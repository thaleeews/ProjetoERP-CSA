using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.IO;
using ProgramaCSA.Cadastros;

namespace ProgramaCSA.Pedidos
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        public static string cnpj;
        public static int idcliente;
        public static int idrepr;
        public static int idpedido;
        public static int iditem;
        public static int verificacao;
        public static bool falta;
        StringBuilder sb = new StringBuilder();

        #region configurações primárias
        private void txtPrazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        private void mtxtCNPJ_Enter(object sender, EventArgs e)
        {
            mtxtCNPJ.Mask = "00,000,000/0000-00";
        }

        private void mtxt_Click(object sender, EventArgs e)
        {
            MaskedTextBox mascara = sender as MaskedTextBox;
            mascara.SelectionStart = 0;
        }

        private void txtCobranca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != 'A')
                && (e.KeyChar != 'B')
                && (e.KeyChar != 'C')
                && (e.KeyChar != 'a')
                && (e.KeyChar != 'b')
                && (e.KeyChar != 'c'))
            {
                e.Handled = true;
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btX_Click(object sender, EventArgs e)
        {
            cnpj = "";
            Close();
        }
        private void btMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region botões
        private void btImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openf = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Selecione a Planilha Excel.",

                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "Planilha do Excel|*.xlsx",
                FilterIndex = 2,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openf.ShowDialog() == DialogResult.OK)
            {
                var fileName = Path.GetFileName(openf.FileName);
                FileInfo info = new FileInfo(fileName);
                OleDbConnection MyConnection;
                DataSet DtSet;
                OleDbDataAdapter MyCommand;
                MyConnection = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + info + "';Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\";");
                MyCommand = new OleDbDataAdapter("select * from [Exportar$]", MyConnection);
                MyCommand.TableMappings.Add("Table", "Net-informations.com");
                DtSet = new System.Data.DataSet();
                MyCommand.Fill(DtSet);
                dgvItens.Columns.Clear();
                dgvItens.DataSource = DtSet.Tables[0];
                //dgvItens.Columns[0].Visible = false;
                MyConnection.Close();

                dgvItens.Columns["TOTAL"].DefaultCellStyle.Format = "N2";
                dgvItens.Columns["VALOR UNIT"].DefaultCellStyle.Format = "N2";
                dgvItens.Columns["QUANTIDADE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                for (int v = 0; v < dgvItens.Rows.Count; v++)
                {
                    
                    if (dgvItens.Rows[v].Cells["QUANTIDADE"].Value.ToString() == "0")
                    {
                        dgvItens.Rows.RemoveAt(v);
                        v--;
                    }
                }

                double total = 0;
                for (int i = 0; i < dgvItens.Rows.Count; i++)
                {
                    total += Convert.ToDouble(dgvItens.Rows[i].Cells["TOTAL"].Value);
                }
                txtTotal.Text = total.ToString("N2");
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (mtxtCNPJ.MaskFull && !string.IsNullOrEmpty(txtCliente.Text) && !string.IsNullOrWhiteSpace(cbRepres.Text) && !string.IsNullOrWhiteSpace(txtPrazo.Text)
                && !string.IsNullOrWhiteSpace(cbFat.Text) && !string.IsNullOrWhiteSpace(cbTipo.Text) && !string.IsNullOrWhiteSpace(txtCobranca.Text) && dgvItens.Rows.Count > 0)
            {
                VerificaItens();
                if (falta == true)
                {
                    var mensagem = MessageBox.Show("Os seguintes itens estão em falta:\n" + sb.ToString() + "Deseja continuar mesmo assim?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(mensagem == DialogResult.Yes)
                    {
                        RetrieveRepr();
                        SalvarPedido();
                        SalvarItensPedido();
                    }
                }
                else
                {
                    RetrieveRepr();
                    SalvarPedido();
                    SalvarItensPedido();
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os dados.\nPedido não registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
                foreach (Control control in controls)
                    if (control is ComboBox)
                        (control as ComboBox).Text = "";
                    else
                        func(control.Controls);
                foreach (Control control in controls)
                    if (control is MaskedTextBox)
                        (control as MaskedTextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
            txtData.Text = DateTime.Now.ToString("dd/MM/yyy");
            mtxtCNPJ.Mask = "00,000,000/0000-00";
            lblPendencias.Text = "NÃO HÁ PENDÊNCIAS DO CLIENTE";
            lblPendencias.ForeColor = Color.Green;
            dgvItens.Columns.Clear();
        }
        #endregion

        #region ações com o banco de dados
        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToString("dd/MM/yyy");

            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            // Definir a instrução SQL com Parâmetros
            cmdQry.CommandText = "SELECT nomeRepres FROM tblRepres";

            try
            {
                dbConnection.Open();

                OleDbDataReader dr = cmdQry.ExecuteReader();

                if (dr.Read())
                {
                    cbRepres.Items.Add(dr["nomeRepres"].ToString());
                }
                dr.Close();

                cbRepres.Items.Add("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void mtxtCNPJ_Leave(object sender, EventArgs e)
        {
            if (!mtxtCNPJ.MaskFull)
            {
                mtxtCNPJ.Mask = "000,000,000-00";
                if (mtxtCNPJ.MaskFull)
                {
                    ProcuraCliente();
                }
            }
            else
            {
                ProcuraCliente();
            }
        }

        private void ProcuraCliente()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            // Definir a instrução SQL com Parâmetros
            cmdQry.CommandText = "SELECT * FROM tblClientes WHERE cnpjClientes=@cnpj;";

            cmdQry.Parameters.Add("@id", OleDbType.VarChar, 18);
            cmdQry.Parameters["@id"].Value = mtxtCNPJ.Text;

            try
            {
                dbConnection.Open();

                OleDbDataReader dr = cmdQry.ExecuteReader();

                if (dr.Read())
                {
                    idcliente = Convert.ToInt32(dr["idClientes"]);
                    txtCliente.Text = dr["nomeClientes"].ToString();
                    txtEndereco.Text = dr["enderecoClientes"].ToString();
                    txtNumero.Text = dr["numeroClientes"].ToString();
                    txtComplemento.Text = dr["complClientes"].ToString();
                    txtBairro.Text = dr["bairroClientes"].ToString();
                    txtMunicipio.Text = dr["municipioClientes"].ToString();
                    txtEstado.Text = dr["estadoClientes"].ToString();
                    txtCEP.Text = dr["cepClientes"].ToString();
                    bool divida = Convert.ToBoolean(dr["dividaClientes"]);

                    if(divida == true)
                    {
                        lblPendencias.Text = "HÁ DÍVIDAS DO CLIENTE";
                        lblPendencias.ForeColor = Color.Red;

                        var dialogo = MessageBox.Show("O cliente está endividado, deseja continuar mesmo assim?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogo == DialogResult.No)
                        {
                            Action<Control.ControlCollection> func = null;

                            func = (controls) =>
                            {
                                foreach (Control control in controls)
                                    if (control is TextBox)
                                        (control as TextBox).Clear();
                                    else
                                        func(control.Controls);
                                foreach (Control control in controls)
                                    if (control is ComboBox)
                                        (control as ComboBox).Text = "";
                                    else
                                        func(control.Controls);
                                foreach (Control control in controls)
                                    if (control is MaskedTextBox)
                                        (control as MaskedTextBox).Clear();
                                    else
                                        func(control.Controls);
                            };

                            func(Controls);
                            txtData.Text = DateTime.Now.ToString("dd/MM/yyy");
                            mtxtCNPJ.Mask = "00,000,000/0000-00";
                            lblPendencias.Text = "NÃO HÁ PENDÊNCIAS DO CLIENTE";
                            lblPendencias.ForeColor = Color.Green;
                            dgvItens.Columns.Clear();
                        }
                    }
                }
                else
                {
                    var dialogo = MessageBox.Show("Cliente inexistente, deseja cadastrá-lo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogo == DialogResult.Yes)
                    {
                        cnpj = mtxtCNPJ.Text;
                        FrmClientes cliente = new FrmClientes();
                        cliente.ShowDialog();
                        mtxtCNPJ.Clear();
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void SalvarItensPedido()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            try
            {
                dbConnection.Open();
                for (int i = 0; i < dgvItens.Rows.Count; i++)
                {
                    cmdQry.CommandText = "INSERT INTO tblItensPedido (idPedido, idProdutos, quantidadeItens, valorItens, subtotalItens) VALUES ([@idpedido], [@idprodutos], [@qt], [@valor], [@subtotal]);";

                    cmdQry.Parameters.Clear();

                    cmdQry.Parameters.AddWithValue("@idpedido", idpedido);
                    cmdQry.Parameters.AddWithValue("@idprodutos", Convert.ToInt32(dgvItens.Rows[i].Cells["CODIGO"].Value));
                    cmdQry.Parameters.AddWithValue("@qt", dgvItens.Rows[i].Cells["QUANTIDADE"].Value);
                    cmdQry.Parameters.AddWithValue("@valor", dgvItens.Rows[i].Cells["VALOR UNIT"].Value);
                    cmdQry.Parameters.AddWithValue("@subtotal", dgvItens.Rows[i].Cells["TOTAL"].Value);

                    cmdQry.ExecuteNonQuery();
                }

                Action<Control.ControlCollection> func = null;

                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).Clear();
                        else
                            func(control.Controls);
                    foreach (Control control in controls)
                        if (control is ComboBox)
                            (control as ComboBox).Text = "";
                        else
                            func(control.Controls);
                    foreach (Control control in controls)
                        if (control is MaskedTextBox)
                            (control as MaskedTextBox).Clear();
                        else
                            func(control.Controls);
                };

                func(Controls);
                txtData.Text = DateTime.Now.ToString("dd/MM/yyy");
                mtxtCNPJ.Mask = "00,000,000/0000-00";
                lblPendencias.Text = "NÃO HÁ PENDÊNCIAS DO CLIENTE";
                lblPendencias.ForeColor = Color.Green;
                dgvItens.Columns.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.Close();
                falta = false;
            }
        }

        private void SalvarPedido()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            // Definir a instrução SQL com Parâmetros
            cmdQry.CommandText = "INSERT INTO tblPedido (idClientes, idRepres, prazoPedido, empresaPedido, cobrancaPedido, tipoPedido, obsPedido, subtotalPedido, dataPedido, lumiPedido, maxiPedido)" +
                "VALUES (@idclientes, @idrepr, @prazo, @empresa, @cobranca, @tipo, @obs, @total, @data, @lumi, @maxi);";

            cmdQry.Parameters.AddWithValue("@idclientes", idcliente);
            cmdQry.Parameters.AddWithValue("@idrepr", idrepr);
            cmdQry.Parameters.AddWithValue("@prazo", txtPrazo.Text);
            cmdQry.Parameters.AddWithValue("@empresa", cbFat.Text);
            cmdQry.Parameters.AddWithValue("@cobranca", txtCobranca.Text);
            cmdQry.Parameters.AddWithValue("@tipo", cbTipo.Text);
            cmdQry.Parameters.AddWithValue("@obs", txtObs.Text);
            cmdQry.Parameters.AddWithValue("@total", txtTotal.Text);
            cmdQry.Parameters.AddWithValue("@data", txtData.Text);

            double lumi = 0;
            double maxi = 0;

            for (int v = 0; v < dgvItens.Rows.Count; v++)
            {
                if (dgvItens.Rows[v].Cells["LINHA"].Value.ToString() == "LUMINOSITTA")
                {
                    lumi += Convert.ToDouble(dgvItens.Rows[v].Cells["TOTAL"].Value);
                }
                else if (dgvItens.Rows[v].Cells["LINHA"].Value.ToString() == "MAXILLURING")
                {
                    maxi += Convert.ToDouble(dgvItens.Rows[v].Cells["TOTAL"].Value);
                }
            }

            cmdQry.Parameters.AddWithValue("@lumi", lumi);
            cmdQry.Parameters.AddWithValue("@maxi", maxi);

            try
            {
                dbConnection.Open();

                cmdQry.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.Close();
                falta = false;
            }

            cmdQry.CommandText = "SELECT MAX(idPedido) FROM tblPedido;";

            cmdQry.Parameters.Clear();

            try
            {
                dbConnection.Open();

                idpedido = Convert.ToInt32(cmdQry.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.Close();
                falta = false;
            }
        }

        private void RetrieveRepr()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "SELECT idRepres FROM tblRepres WHERE nomeRepres=@nome;";

            cmdQry.Parameters.AddWithValue("@nome", cbRepres.Text);

            try
            {
                dbConnection.Open();

                idrepr = Convert.ToInt32(cmdQry.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void VerificaItens()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "SELECT SUM(qtEstoque) FROM tblEstoque WHERE idProdutos=@id;";

            cmdQry.Parameters.AddWithValue("@id", iditem);

            try
            {
                dbConnection.Open();

                sb.Clear(); 

                for (int i = 0; i < dgvItens.Rows.Count; i++)
                {
                    cmdQry.CommandText = "SELECT SUM(qtEstoque) FROM tblEstoque WHERE idProdutos=@id;";
                    cmdQry.Parameters.Clear();
                    cmdQry.Parameters.AddWithValue("@id", Convert.ToInt32(dgvItens.Rows[i].Cells["CODIGO"].Value));
                    object ver = cmdQry.ExecuteScalar();

                    if (!ver.Equals(DBNull.Value))
                    {
                        verificacao = Convert.ToInt32(ver);

                        if (Convert.ToInt32(dgvItens.Rows[i].Cells["QUANTIDADE"].Value) > verificacao)
                        {
                            int conta = Convert.ToInt32(dgvItens.Rows[i].Cells[2].Value) - verificacao;
                            sb.AppendLine(dgvItens.Rows[i].Cells[1].Value.ToString() + ", " + conta.ToString() + " unidades faltantes.");
                            falta = true;
                        }
                    }
                    else
                    {
                        verificacao = 0;
                        int conta = Convert.ToInt32(dgvItens.Rows[i].Cells["QUANTIDADE"].Value) - verificacao;
                        sb.AppendLine(dgvItens.Rows[i].Cells["PRODUTO"].Value.ToString() + ", " + conta.ToString() + " unidades faltantes.");
                        falta = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void ReservarItens()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();


        }
        #endregion
    }
}
