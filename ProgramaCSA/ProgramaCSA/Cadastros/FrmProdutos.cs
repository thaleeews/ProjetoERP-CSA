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

namespace ProgramaCSA.Cadastros
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        public static int idpesquisa;

        #region configurações primárias
        private void mtxtCodigo_Click(object sender, EventArgs e)
        {
            mtxtCodigo.SelectionStart = 0;
        }

        private void txtBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void mtxtNCM_Click(object sender, EventArgs e)
        {
            mtxtNCM.SelectionStart = 0; 
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
            Close();
        }
        private void btMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region botões
        private void btPesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisaProd pesq = new FrmPesquisaProd();
            pesq.ShowDialog();

            if(idpesquisa>0)
            {
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
                OleDbConnection dbConnection = new OleDbConnection(strConnection);
                OleDbCommand cmdQry = dbConnection.CreateCommand();

                // Definir a instrução SQL com Parâmetros
                cmdQry.CommandText = "SELECT * FROM tblProdutos WHERE idProdutos=@id;";

                cmdQry.Parameters.AddWithValue("@id", idpesquisa);

                try
                {
                    dbConnection.Open();

                    OleDbDataReader dr = cmdQry.ExecuteReader();

                    if (dr.Read())
                    {
                        txtProduto.Text = dr["nomeProdutos"].ToString();
                        cbLinha.Text = dr["linhaProdutos"].ToString();
                        mtxtCodigo.Text = dr["codigoProdutos"].ToString();
                        mtxtNCM.Text = dr["ncmProdutos"].ToString();
                        txtValor.Text = dr["valorProdutos"].ToString();
                        txtBarras.Text = dr["codbarrasProdutos"].ToString();
                        cbTipo.Text = dr["tipoProdutos"].ToString();
                        txtQtMin.Text = dr["qtminProdutos"].ToString();
                        txtQtIdeal.Text = dr["qtidealProdutos"].ToString();
                        txtQtAtual.Text = dr["qtatualProdutos"].ToString();
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
            idpesquisa = 0;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProduto.Text) || string.IsNullOrWhiteSpace(cbLinha.Text) || !mtxtCodigo.MaskFull)
            {
                MessageBox.Show("Preencha todos os dados de cadastro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (idpesquisa > 0)
                {
                    UpdateProduto();
                }
                else
                {
                    AdicionarProduto();
                }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (idpesquisa > 0)
            {
                ExcluirProduto();
            }
            else
            {
                MessageBox.Show("Produto não cadastrado.\nPor favor exclua um registro válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region relações com o banco de dados
        private async void AdicionarProduto()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "INSERT INTO tblProdutos (nomeProdutos, linhaProdutos, codigoProdutos, ncmProdutos, valorProdutos, codbarrasProdutos, tipoProdutos, qtminProdutos, qtidealProdutos, qtatualProdutos)"
                + "VALUES (@nome, @linha, @codigo, @ncm, @valor, @codbarras, @tipo, @qtmin, @qtideal, @qtatual)";


            cmdQry.Parameters.Add("@nome", OleDbType.VarChar, 60);
            cmdQry.Parameters.Add("@linha", OleDbType.VarChar, 11);
            cmdQry.Parameters.Add("@codigo", OleDbType.VarChar, 7);
            cmdQry.Parameters.Add("@ncm", OleDbType.VarChar, 10);
            cmdQry.Parameters.Add("@valor", OleDbType.VarChar, 7);
            cmdQry.Parameters.Add("@codbarras", OleDbType.VarChar, 40);
            cmdQry.Parameters.Add("@tipo", OleDbType.VarChar, 35);
            cmdQry.Parameters.Add("@qtmin", OleDbType.VarChar, 2);
            cmdQry.Parameters.Add("@qtideal", OleDbType.VarChar, 9);
            cmdQry.Parameters.Add("@qtatual", OleDbType.VarChar, 16);
            cmdQry.Parameters.Add("@id", OleDbType.Integer);

            string nome = txtProduto.Text;
            string linha = cbLinha.Text;
            string codigo = mtxtCodigo.Text;
            string ncm = mtxtNCM.Text;
            string valor = txtValor.Text;
            string codbarras = txtBarras.Text;
            string tipo = cbTipo.Text;
            string qtmin = txtQtMin.Text;
            string qtideal = txtQtIdeal.Text;
            string qtatual = txtQtAtual.Text;

            cmdQry.Parameters["@nome"].Value = nome;
            cmdQry.Parameters["@linha"].Value = linha;
            cmdQry.Parameters["@codigo"].Value = codigo;
            cmdQry.Parameters["@ncm"].Value = ncm;
            cmdQry.Parameters["@valor"].Value = valor;
            cmdQry.Parameters["@codbarras"].Value = codbarras;
            cmdQry.Parameters["@tipo"].Value = tipo;
            cmdQry.Parameters["@qtmin"].Value = qtmin;
            cmdQry.Parameters["@qtideal"].Value = qtideal;
            cmdQry.Parameters["@qtatual"].Value = qtatual;
            cmdQry.Parameters["@id"].Value = idpesquisa;

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

        private async void ExcluirProduto()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "DELETE FROM tblProdutos WHERE idProdutos=@id";

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

        private async void UpdateProduto()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "UPDATE tblProdutos SET nomeProdutos=@nome, linhaProdutos=@linha, codigoProdutos=@codigo, ncmProdutos=@ncm, " +
                "valorProdutos=@valor, codbarrasProdutos=@codbarras, tipoProdutos=@tipo, qtminProdutos=@qtmin, qtidealProdutos=@qtideal, " +
                "qtatualProdutos=@qtatual WHERE idProdutos=@id";

            cmdQry.Parameters.Add("@nome", OleDbType.VarChar, 60);
            cmdQry.Parameters.Add("@linha", OleDbType.VarChar, 11);
            cmdQry.Parameters.Add("@codigo", OleDbType.VarChar, 7);
            cmdQry.Parameters.Add("@ncm", OleDbType.VarChar, 10);
            cmdQry.Parameters.Add("@valor", OleDbType.VarChar, 7);
            cmdQry.Parameters.Add("@codbarras", OleDbType.VarChar, 40);
            cmdQry.Parameters.Add("@tipo", OleDbType.VarChar, 35);
            cmdQry.Parameters.Add("@qtmin", OleDbType.VarChar, 2);
            cmdQry.Parameters.Add("@qtideal", OleDbType.VarChar, 9);
            cmdQry.Parameters.Add("@qtatual", OleDbType.VarChar, 16);
            cmdQry.Parameters.Add("@id", OleDbType.Integer);

            string nome = txtProduto.Text;
            string linha = cbLinha.Text;
            string codigo = mtxtCodigo.Text;
            string ncm = mtxtNCM.Text;
            string valor = txtValor.Text;
            string codbarras = txtBarras.Text;
            string tipo = cbTipo.Text;
            string qtmin = txtQtMin.Text;
            string qtideal = txtQtIdeal.Text;
            string qtatual = txtQtAtual.Text;

            cmdQry.Parameters["@nome"].Value = nome;
            cmdQry.Parameters["@linha"].Value = linha;
            cmdQry.Parameters["@codigo"].Value = codigo;
            cmdQry.Parameters["@ncm"].Value = ncm;
            cmdQry.Parameters["@valor"].Value = valor;
            cmdQry.Parameters["@codbarras"].Value = codbarras;
            cmdQry.Parameters["@tipo"].Value = tipo;
            cmdQry.Parameters["@qtmin"].Value = qtmin;
            cmdQry.Parameters["@qtideal"].Value = qtideal;
            cmdQry.Parameters["@qtatual"].Value = qtatual;
            cmdQry.Parameters["@id"].Value = idpesquisa;

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
        #endregion
    }
}
