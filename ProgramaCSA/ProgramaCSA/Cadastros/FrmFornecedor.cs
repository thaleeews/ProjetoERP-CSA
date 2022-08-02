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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        #region configurações primárias
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

        private void mtxt_Click(object sender, EventArgs e)
        {
            MaskedTextBox mascara = sender as MaskedTextBox;
            mascara.SelectionStart = 0;
        }

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

        private void mtxtCNPJ_Enter(object sender, EventArgs e)
        {
            mtxtCNPJ.Mask = "00,000,000/0000-00";
        }

        private void mtxtCNPJ_Leave(object sender, EventArgs e)
        {
            if (!mtxtCNPJ.MaskFull)
            {
                mtxtCNPJ.Mask = "000,000,000-00";
            }
        }

        private void txtInsc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar !='-'))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region botões
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtRazao.Text) && !mtxtCNPJ.MaskFull && string.IsNullOrWhiteSpace(txtEndereco.Text) && string.IsNullOrWhiteSpace(txtNumero.Text)
                && string.IsNullOrWhiteSpace(txtBairro.Text) && string.IsNullOrWhiteSpace(txtMunicipio.Text) && !mtxtCep.MaskFull && string.IsNullOrWhiteSpace(cbUF.Text))
            {
                MessageBox.Show("Por favor preencha todos os dados do cadastro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(idpesquisa>0)
                {
                    UpdateFornecedor();
                }
                else
                {
                    AdicionarFornecedor();
                }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (idpesquisa == 0)
            {
                MessageBox.Show("Cadastro inexistente para exclusão.\nPor favor escolha um cadastro válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ExcluirFornecedor();
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

            mtxtTel1.Mask = "(00) 0,0000-0000";
            mtxtTel2.Mask = "(00) 0,0000-0000";
            mtxtTel3.Mask = "(00) 0,0000-0000";
            mtxtCNPJ.Mask = "00,000,000/0000-00";

            idpesquisa = 0;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisaForn fornp = new FrmPesquisaForn();
            fornp.ShowDialog();

            if(idpesquisa > 0)
            {
                mtxtCNPJ.Mask = "00,000,000/0000-00";
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
                OleDbConnection dbConnection = new OleDbConnection(strConnection);
                OleDbCommand cmdQry = dbConnection.CreateCommand();

                // Definir a instrução SQL com Parâmetros
                cmdQry.CommandText = "SELECT * FROM tblFornecedores WHERE idForn=@id;";

                cmdQry.Parameters.AddWithValue("@id", idpesquisa);

                try
                {
                    dbConnection.Open();

                    OleDbDataReader dr = cmdQry.ExecuteReader();

                    if (dr.Read())
                    {
                        txtRazao.Text = dr["nomeForn"].ToString();
                        mtxtCNPJ.Text = dr["cnpjForn"].ToString();
                        txtInsc.Text = dr["inscrForn"].ToString();
                        txtEndereco.Text = dr["endForn"].ToString();
                        txtNumero.Text = dr["numeroForn"].ToString();
                        txtCompl.Text = dr["complForn"].ToString();
                        txtBairro.Text = dr["bairroForn"].ToString();
                        txtMunicipio.Text = dr["municipioForn"].ToString();
                        cbUF.Text = dr["estadoForn"].ToString();
                        mtxtCep.Text = dr["cepForn"].ToString();
                        mtxtTel1.Text = dr["tel1Forn"].ToString();
                        mtxtTel2.Text = dr["tel2Forn"].ToString();
                        mtxtTel3.Text = dr["tel3Forn"].ToString();
                        txtEmail.Text = dr["emailForn"].ToString();
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
                    if(!mtxtTel3.MaskFull)
                    {
                        mtxtTel3.Mask = "(00) 0000-0000";
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
        #endregion

        #region ações com o banco de dados
        public static string pesquisa;
        public static int idpesquisa;

        private async void AdicionarFornecedor()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "INSERT INTO tblFornecedores (nomeForn, cnpjForn, inscrForn, endForn, numeroForn, complForn, bairroForn, municipioForn, estadoForn, cepForn, tel1Forn, tel2Forn, tel3Forn, emailForn)"
                + "VALUES (@nome, @cnpj, @inscr, @endereco, @numero, @compl, @bairro, @municipio, @estado, @cep, @tel1, @tel2, @tel3, @email)";


            cmdQry.Parameters.Add("@nome", OleDbType.VarChar, 60);
            cmdQry.Parameters.Add("@cnpj", OleDbType.VarChar, 18);
            cmdQry.Parameters.Add("@inscr", OleDbType.VarChar, 12);
            cmdQry.Parameters.Add("@endereco", OleDbType.VarChar, 60);
            cmdQry.Parameters.Add("@numero", OleDbType.VarChar, 15);
            cmdQry.Parameters.Add("@compl", OleDbType.VarChar, 60);
            cmdQry.Parameters.Add("@bairro", OleDbType.VarChar, 40);
            cmdQry.Parameters.Add("@municipio", OleDbType.VarChar, 35);
            cmdQry.Parameters.Add("@estado", OleDbType.VarChar, 2);
            cmdQry.Parameters.Add("@cep", OleDbType.VarChar, 9);
            cmdQry.Parameters.Add("@tel1", OleDbType.VarChar, 16);
            cmdQry.Parameters.Add("@tel2", OleDbType.VarChar, 16);
            cmdQry.Parameters.Add("@tel3", OleDbType.VarChar, 16);
            cmdQry.Parameters.Add("@email", OleDbType.VarChar, 50);

            string nome = txtRazao.Text;
            string cnpj = mtxtCNPJ.Text;
            string inscricao = txtInsc.Text;
            string endereco = txtEndereco.Text;
            string numero = txtNumero.Text;
            string compl = txtCompl.Text;
            string bairro = txtBairro.Text;
            string municipio = txtMunicipio.Text;
            string estado = cbUF.Text;
            string cep = mtxtCep.Text;
            string tel1 = mtxtTel1.Text;
            string tel2 = mtxtTel2.Text;
            string tel3 = mtxtTel3.Text;
            string email = txtEmail.Text;

            cmdQry.Parameters["@nome"].Value = nome;
            cmdQry.Parameters["@inscr"].Value = inscricao;
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
            cmdQry.Parameters["@tel3"].Value = tel3;
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
                mtxtTel3.Mask = "(00) 0,0000-0000";

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

        private async void ExcluirFornecedor()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "DELETE FROM tblFornecedores WHERE idForn=@id";

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
                mtxtTel3.Mask = "(00) 0,0000-0000";

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

        private async void UpdateFornecedor()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "UPDATE tblFornecedores SET nomeForn=@nome, cnpjForn=@cnpj, inscrForn=@inscr, endForn=@endereco, numeroForn=@numero, " +
                "complForn=@compl, bairroForn=@bairro, municipioForn=@municipio, estadoForn=@estado, cepForn=@cep, " +
                "tel1Forn=@tel1, tel2Forn=@tel2, tel3Forn=@tel3, emailForn=@email WHERE idForn=@id";

            cmdQry.Parameters.Add("@nome", OleDbType.VarChar, 60);
            cmdQry.Parameters.Add("@cnpj", OleDbType.VarChar, 18);
            cmdQry.Parameters.Add("@inscr", OleDbType.VarChar, 12);
            cmdQry.Parameters.Add("@endereco", OleDbType.VarChar, 60);
            cmdQry.Parameters.Add("@numero", OleDbType.VarChar, 15);
            cmdQry.Parameters.Add("@compl", OleDbType.VarChar, 60);
            cmdQry.Parameters.Add("@bairro", OleDbType.VarChar, 40);
            cmdQry.Parameters.Add("@municipio", OleDbType.VarChar, 35);
            cmdQry.Parameters.Add("@estado", OleDbType.VarChar, 2);
            cmdQry.Parameters.Add("@cep", OleDbType.VarChar, 9);
            cmdQry.Parameters.Add("@tel1", OleDbType.VarChar, 16);
            cmdQry.Parameters.Add("@tel2", OleDbType.VarChar, 16);
            cmdQry.Parameters.Add("@tel3", OleDbType.VarChar, 16);
            cmdQry.Parameters.Add("@email", OleDbType.VarChar, 50);

            string nome = txtRazao.Text;
            string cnpj = mtxtCNPJ.Text;
            string inscricao = txtInsc.Text;
            string endereco = txtEndereco.Text;
            string numero = txtNumero.Text;
            string compl = txtCompl.Text;
            string bairro = txtBairro.Text;
            string municipio = txtMunicipio.Text;
            string estado = cbUF.Text;
            string cep = mtxtCep.Text;
            string tel1 = mtxtTel1.Text;
            string tel2 = mtxtTel2.Text;
            string tel3 = mtxtTel3.Text;
            string email = txtEmail.Text;

            cmdQry.Parameters["@nome"].Value = nome;
            cmdQry.Parameters["@inscr"].Value = inscricao;
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
            cmdQry.Parameters["@tel3"].Value = tel3;
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
                mtxtTel3.Mask = "(00) 0,0000-0000";

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
        #endregion
    }
}
