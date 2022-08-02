using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProgramaCSA.Pedidos;

namespace ProgramaCSA.Cadastros
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        #region configurações primárias
        private void mtxtTelefones_Leave(object sender, EventArgs e)
        {
            MaskedTextBox mask = sender as MaskedTextBox;
            if (!mask.MaskFull)
            {
                mask.Mask = "(00) 0000-0000";
            }
        }

        private void mtxtTelefones_Enter(object sender, EventArgs e)
        {
            MaskedTextBox mask = sender as MaskedTextBox;
            mask.Mask = "(00) 0,0000-0000";
        }

        private void mtxt_Click(object sender, EventArgs e)
        {
            MaskedTextBox mascara = sender as MaskedTextBox;
            mascara.SelectionStart = 0;
        }

        private void mtxtCNPJ_Enter(object sender, EventArgs e)
        {
            mtxtCNPJ.Mask = "00,000,000/0000-00";
        }

        private void mtxtCNPJ_Leave(object sender, EventArgs e)
        {
            if(!mtxtCNPJ.MaskFull)
            {
                mtxtCNPJ.Mask = "000,000,000-00";
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
            idpesquisa = 0;
            pesquisa = "";
            Close();
        }
        private void btMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region botões
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (mtxtCNPJ.MaskFull && !string.IsNullOrWhiteSpace(txtCliente.Text) && !string.IsNullOrWhiteSpace(txtEndereco.Text) && !string.IsNullOrWhiteSpace(txtBairro.Text)
                && !string.IsNullOrWhiteSpace(txtNumero.Text) && !string.IsNullOrWhiteSpace(txtMunicipio.Text) && !string.IsNullOrWhiteSpace(cbEstado.Text)
                && mtxtCep.MaskFull)
            {
                int verificacao = VerificaNome(txtCliente.Text);

                if (verificacao == 0)
                {
                    if (idpesquisa > 0)
                    {
                        UpdateCliente();
                    }

                    else
                    {
                        AdicionarCliente();
                    }
                }
                else
                {
                    MessageBox.Show("O cliente " + txtCliente.Text + " já possui registro. \nPesquise-o clicando no botão PESQUISAR abaixo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados de cadastro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if(idpesquisa==0)
            {
                MessageBox.Show("Cadastro inexistente para exclusão.\nPor favor escolha um cadastro válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ExcluirCliente();
            }
        }

        private void btPesquisa_Click(object sender, EventArgs e)
        {
            FrmPesquisaClientes pesq = new FrmPesquisaClientes();
            pesq.ShowDialog();

            if (idpesquisa > 0)
            {
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
                OleDbConnection dbConnection = new OleDbConnection(strConnection);
                OleDbCommand cmdQry = dbConnection.CreateCommand();

                // Definir a instrução SQL com Parâmetros
                cmdQry.CommandText = "SELECT * FROM tblClientes WHERE idClientes=@id;";

                cmdQry.Parameters.AddWithValue("@id", idpesquisa);

                try
                {
                    dbConnection.Open();

                    OleDbDataReader dr = cmdQry.ExecuteReader();

                    if (dr.Read())
                    {
                        txtCliente.Text = dr["nomeClientes"].ToString();
                        mtxtCNPJ.Text = dr["cnpjClientes"].ToString();
                        txtEndereco.Text = dr["enderecoClientes"].ToString();
                        txtNumero.Text = dr["numeroClientes"].ToString();
                        txtCompl.Text = dr["complClientes"].ToString();
                        txtBairro.Text = dr["bairroClientes"].ToString();
                        txtMunicipio.Text = dr["municipioClientes"].ToString();
                        cbEstado.Text = dr["estadoClientes"].ToString();
                        mtxtCep.Text = dr["cepClientes"].ToString();
                        mtxtTel1.Text = dr["tel1Clientes"].ToString();
                        mtxtTel2.Text = dr["tel2Clientes"].ToString();
                        txtEmail.Text = dr["emailClientes"].ToString();
                    }
                    dr.Close();

                    if (!mtxtTel1.MaskFull)
                    {
                        mtxtTel1.Mask = "(00) 0000-0000";
                    }
                    if (!mtxtTel2.MaskFull)
                    {
                        mtxtTel2.Mask = "(00) 0000-0000";
                    }
                    if (!mtxtCNPJ.MaskFull)
                    {
                        mtxtCNPJ.Mask = "000,000,000-00";
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

            mtxtCNPJ.Mask = "00,000,000/0000-00";
            mtxtTel1.Mask = "(00) 0,0000-0000";
            mtxtTel2.Mask = "(00) 0,0000-0000";

            pesquisa = "";
            idpesquisa = 0;
        }
        #endregion

        #region ações com o banco de dados
        public static string pesquisa;
        public static int idpesquisa;

        private async void AdicionarCliente()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "INSERT INTO tblClientes (nomeClientes, cnpjClientes, enderecoClientes, numeroClientes, complClientes, bairroClientes, municipioClientes, estadoClientes, cepClientes, tel1Clientes, tel2Clientes, emailClientes)"
                + "VALUES (@nome, @cnpj, @endereco, @numero, @compl, @bairro, @municipio, @estado, @cep, @tel1, @tel2, @email)";


            cmdQry.Parameters.Add("@nome", OleDbType.VarChar, 60);
            cmdQry.Parameters.Add("@cnpj", OleDbType.VarChar, 18);
            cmdQry.Parameters.Add("@endereco", OleDbType.VarChar, 60);
            cmdQry.Parameters.Add("@numero", OleDbType.VarChar, 15);
            cmdQry.Parameters.Add("@compl", OleDbType.VarChar, 60);
            cmdQry.Parameters.Add("@bairro", OleDbType.VarChar, 40);
            cmdQry.Parameters.Add("@municipio", OleDbType.VarChar, 35);
            cmdQry.Parameters.Add("@estado", OleDbType.VarChar, 2);
            cmdQry.Parameters.Add("@cep", OleDbType.VarChar, 9);
            cmdQry.Parameters.Add("@tel1", OleDbType.VarChar, 16);
            cmdQry.Parameters.Add("@tel2", OleDbType.VarChar, 16);
            cmdQry.Parameters.Add("@email", OleDbType.VarChar, 50);

            string nome = txtCliente.Text;
            string cnpj = mtxtCNPJ.Text;
            string endereco = txtEndereco.Text;
            string numero = txtNumero.Text;
            string compl = txtCompl.Text;
            string bairro = txtBairro.Text;
            string municipio = txtMunicipio.Text;
            string estado = cbEstado.Text;
            string cep = mtxtCep.Text;
            string tel1 = mtxtTel1.Text;
            string tel2 = mtxtTel2.Text;
            string email = txtEmail.Text;

            cmdQry.Parameters["@nome"].Value = nome;
            cmdQry.Parameters["@cnpj"].Value = cnpj;
            cmdQry.Parameters["@endereco"].Value = endereco;
            cmdQry.Parameters["@numero"].Value = numero;
            cmdQry.Parameters["@compl"].Value = compl;
            cmdQry.Parameters["@bairro"].Value = bairro;
            cmdQry.Parameters["@municipio"].Value = municipio;
            cmdQry.Parameters["@estado"].Value = estado;
            cmdQry.Parameters["@cep"].Value = cep;
            cmdQry.Parameters["@tel1"].Value = tel1;
            cmdQry.Parameters["@tel2"].Value = tel2;
            cmdQry.Parameters["@email"].Value = email;

            try
            {
                dbConnection.Open();
                cmdQry.ExecuteNonQuery();

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

                mtxtCNPJ.Mask = "00,000,000/0000-00";
                mtxtTel1.Mask = "(00) 0,0000-0000";
                mtxtTel2.Mask = "(00) 0,0000-0000";

                pesquisa = "";
                idpesquisa = 0;

                lblSalvo.Visible = true;
                await Task.Delay(3000);
                lblSalvo.Visible = false;
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

        private async void ExcluirCliente()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "DELETE FROM tblClientes WHERE idClientes=@id";

            cmdQry.Parameters.Add("@id", OleDbType.Integer);

            int id = idpesquisa;

            cmdQry.Parameters["@id"].Value = id;

            try
            {
                dbConnection.Open();
                cmdQry.ExecuteNonQuery();

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

                mtxtCNPJ.Mask = "00,000,000/0000-00";
                mtxtTel1.Mask = "(00) 0,0000-0000";
                mtxtTel2.Mask = "(00) 0,0000-0000";

                pesquisa = "";
                idpesquisa = 0;

                lblSalvo.Visible = true;
                await Task.Delay(3000);
                lblSalvo.Visible = false;
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

        private async void UpdateCliente()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "UPDATE tblClientes SET nomeClientes=@nome, cnpjClientes=@cnpj, enderecoClientes=@endereco, numeroClientes=@numero, " +
                "complClientes=@compl, bairroClientes=@bairro, municipioClientes=@municipio, estadoClientes=@estado, cepClientes=@cep, " +
                "tel1Clientes=@tel1, tel2Clientes=@tel2, emailClientes=@email WHERE idClientes=@id";

            cmdQry.Parameters.Add("@nome", OleDbType.VarChar, 60);
            cmdQry.Parameters.Add("@cnpj", OleDbType.VarChar, 18);
            cmdQry.Parameters.Add("@endereco", OleDbType.VarChar, 60);
            cmdQry.Parameters.Add("@numero", OleDbType.VarChar, 15);
            cmdQry.Parameters.Add("@compl", OleDbType.VarChar, 60);
            cmdQry.Parameters.Add("@bairro", OleDbType.VarChar, 40);
            cmdQry.Parameters.Add("@municipio", OleDbType.VarChar, 35);
            cmdQry.Parameters.Add("@estado", OleDbType.VarChar, 2);
            cmdQry.Parameters.Add("@cep", OleDbType.VarChar, 9);
            cmdQry.Parameters.Add("@tel1", OleDbType.VarChar, 16);
            cmdQry.Parameters.Add("@tel2", OleDbType.VarChar, 16);
            cmdQry.Parameters.Add("@email", OleDbType.VarChar, 50);
            cmdQry.Parameters.Add("@id", OleDbType.Integer);

            string nome = txtCliente.Text;
            string cnpj = mtxtCNPJ.Text;
            string endereco = txtEndereco.Text;
            string numero = txtNumero.Text;
            string compl = txtCompl.Text;
            string bairro = txtBairro.Text;
            string municipio = txtMunicipio.Text;
            string estado = cbEstado.Text;
            string cep = mtxtCep.Text;
            string tel1 = mtxtTel1.Text;
            string tel2 = mtxtTel2.Text;
            string email = txtEmail.Text;
            int id = idpesquisa;

            cmdQry.Parameters["@nome"].Value = nome;
            cmdQry.Parameters["@cnpj"].Value = cnpj;
            cmdQry.Parameters["@endereco"].Value = endereco;
            cmdQry.Parameters["@numero"].Value = numero;
            cmdQry.Parameters["@compl"].Value = compl;
            cmdQry.Parameters["@bairro"].Value = bairro;
            cmdQry.Parameters["@municipio"].Value = municipio;
            cmdQry.Parameters["@estado"].Value = estado;
            cmdQry.Parameters["@cep"].Value = cep;
            cmdQry.Parameters["@tel1"].Value = tel1;
            cmdQry.Parameters["@tel2"].Value = tel2;
            cmdQry.Parameters["@email"].Value = email;
            cmdQry.Parameters["@id"].Value = id;

            try
            {
                dbConnection.Open();
                cmdQry.ExecuteNonQuery();

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

                mtxtCNPJ.Mask = "00,000,000/0000-00";
                mtxtTel1.Mask = "(00) 0,0000-0000";
                mtxtTel2.Mask = "(00) 0,0000-0000";

                pesquisa = "";
                idpesquisa = 0;

                lblSalvo.Visible = true;
                await Task.Delay(3000);
                lblSalvo.Visible = false;
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

        private static int VerificaNome(string nome)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "SELECT nomeClientes FROM tblClientes WHERE nomeClientes=@nome;";

            cmdQry.Parameters.AddWithValue("@nome", nome);
            int verifica = 0;

            try
            {
                dbConnection.Open();

                verifica = Convert.ToInt32(cmdQry.ExecuteScalar());
                return verifica;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return verifica;
            }
            finally
            {
                dbConnection.Close();
            }
        }
        #endregion

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FrmRegistro.cnpj))
            {
                mtxtCNPJ.Text = FrmRegistro.cnpj;
            }
        }
    }
}
