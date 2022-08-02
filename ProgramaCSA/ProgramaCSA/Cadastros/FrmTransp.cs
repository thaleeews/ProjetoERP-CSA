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
    public partial class FrmTransp : Form
    {
        public FrmTransp()
        {
            InitializeComponent();
        }

        #region configurações primárias
        private void mtxt_Click(object sender, EventArgs e)
        {
            MaskedTextBox mascara = sender as MaskedTextBox;
            mascara.SelectionStart = 0;
        }

        private void txtInsc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar != '-'))
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
            if(!string.IsNullOrWhiteSpace(txtRazao.Text) && mtxtCNPJ.MaskFull && !string.IsNullOrWhiteSpace(txtInsc.Text) && !string.IsNullOrWhiteSpace(txtEndereco.Text)
                && !string.IsNullOrWhiteSpace(txtNumero.Text) && !string.IsNullOrWhiteSpace(txtBairro.Text) && !string.IsNullOrWhiteSpace(txtMunicipio.Text)
                && !string.IsNullOrWhiteSpace(cbEstado.Text) && mtxtCEP.MaskFull)
            {
                if (idpesquisa > 0) 
                {
                    UpdateTransp();
                }
                else
                {
                    AdicionarTransp();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados de cadastro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (idpesquisa > 0)
            {
                ExcluirTransp();
            }
            else
            {
                MessageBox.Show("Cadastro inexistente para exclusão.\nPor favor escolha um cadastro válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            pesquisa = "";
            idpesquisa = 0;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisaTransp transp = new FrmPesquisaTransp();
            transp.ShowDialog();

            if (idpesquisa > 0)
            {
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
                OleDbConnection dbConnection = new OleDbConnection(strConnection);
                OleDbCommand cmdQry = dbConnection.CreateCommand();

                // Definir a instrução SQL com Parâmetros
                cmdQry.CommandText = "SELECT * FROM tblTransp WHERE idTransp=@id;";

                cmdQry.Parameters.AddWithValue("@id", idpesquisa);

                try
                {
                    dbConnection.Open();

                    OleDbDataReader dr = cmdQry.ExecuteReader();

                    if (dr.Read())
                    {
                        txtRazao.Text = dr["nomeTransp"].ToString();
                        mtxtCNPJ.Text = dr["cnpjTransp"].ToString();
                        txtInsc.Text = dr["inscTransp"].ToString();
                        txtEndereco.Text = dr["endTransp"].ToString();
                        txtNumero.Text = dr["numeroTransp"].ToString();
                        txtCompl.Text = dr["complTransp"].ToString();
                        txtBairro.Text = dr["bairroTransp"].ToString();
                        txtMunicipio.Text = dr["municipioTransp"].ToString();
                        cbEstado.Text = dr["estadoTransp"].ToString();
                        mtxtCEP.Text = dr["cepTransp"].ToString();
                        mtxtTel1.Text = dr["tel1Transp"].ToString();
                        mtxtTel2.Text = dr["tel2Transp"].ToString();
                        txtEmail.Text = dr["emailTransp"].ToString();
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

        private async void AdicionarTransp()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "INSERT INTO tblTransp (nomeTransp, cnpjTransp, inscTransp, endTransp, numeroTransp, complTransp, bairroTransp, municipioTransp, estadoTransp, cepTransp, tel1Transp, tel2Transp, emailTransp)"
                + "VALUES (@nome, @cnpj, @insc, @end, @numero, @compl, @bairro, @municipio, @estado, @cep, @tel1, @tel2, @email)";

            string nome = txtRazao.Text;
            string cnpj = mtxtCNPJ.Text;
            string insc = txtInsc.Text;
            string end = txtEndereco.Text;
            string numero = txtNumero.Text;
            string compl = txtCompl.Text;
            string bairro = txtBairro.Text;
            string municipio = txtMunicipio.Text;
            string estado = cbEstado.Text;
            string cep = mtxtCEP.Text;
            string tel1 = mtxtTel1.Text;
            string tel2 = mtxtTel2.Text;
            string email = txtEmail.Text;

            cmdQry.Parameters.AddWithValue("@nome", nome);
            cmdQry.Parameters.AddWithValue("@cnpj", cnpj);
            cmdQry.Parameters.AddWithValue("@insc", insc);
            cmdQry.Parameters.AddWithValue("@end", end);
            cmdQry.Parameters.AddWithValue("@numero", numero);
            cmdQry.Parameters.AddWithValue("@compl", compl);
            cmdQry.Parameters.AddWithValue("@bairro", bairro);
            cmdQry.Parameters.AddWithValue("@municipio", municipio);
            cmdQry.Parameters.AddWithValue("@estado", estado);
            cmdQry.Parameters.AddWithValue("@cep", cep);
            cmdQry.Parameters.AddWithValue("@tel1", tel1);
            cmdQry.Parameters.AddWithValue("@tel2", tel2);
            cmdQry.Parameters.AddWithValue("@email", email);

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

        private async void ExcluirTransp()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "DELETE FROM tblTransp WHERE idTransp=@id";

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

        private async void UpdateTransp()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "UPDATE tblTransp SET nomeTransp=@nome, cnpjTransp=@cpf, inscTransp=@rg, endTransp=@regiao, " +
                "numeroTransp=@end, complTransp=@numero, bairroTransp=@compl, municipioTransp=@bairro, estadoTransp=@municipio, " +
                "cepTransp=@uf, tel1Transp=@cep, tel2Transp=@tel1, emailTransp=@tel2 WHERE idTransp=@id";

            string nome = txtRazao.Text;
            string cnpj = mtxtCNPJ.Text;
            string insc = txtInsc.Text;
            string end = txtEndereco.Text;
            string numero = txtNumero.Text;
            string compl = txtCompl.Text;
            string bairro = txtBairro.Text;
            string municipio = txtMunicipio.Text;
            string estado = cbEstado.Text;
            string cep = mtxtCEP.Text;
            string tel1 = mtxtTel1.Text;
            string tel2 = mtxtTel2.Text;
            string email = txtEmail.Text;

            cmdQry.Parameters.AddWithValue("@nome", nome);
            cmdQry.Parameters.AddWithValue("@cnpj", cnpj);
            cmdQry.Parameters.AddWithValue("@insc", insc);
            cmdQry.Parameters.AddWithValue("@end", end);
            cmdQry.Parameters.AddWithValue("@numero", numero);
            cmdQry.Parameters.AddWithValue("@compl", compl);
            cmdQry.Parameters.AddWithValue("@bairro", bairro);
            cmdQry.Parameters.AddWithValue("@municipio", municipio);
            cmdQry.Parameters.AddWithValue("@estado", estado);
            cmdQry.Parameters.AddWithValue("@cep", cep);
            cmdQry.Parameters.AddWithValue("@tel1", tel1);
            cmdQry.Parameters.AddWithValue("@tel2", tel2);
            cmdQry.Parameters.AddWithValue("@email", email);

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
        #endregion
    }
}
