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
    public partial class FrmRepres : Form
    {
        public FrmRepres()
        {
            InitializeComponent();
        }

        #region configurações primarias
        private void mtxt_Click(object sender, EventArgs e)
        {
            MaskedTextBox mascara = sender as MaskedTextBox;
            mascara.SelectionStart = 0;
        }

        private void mtxtTelefones_Leave(object sender, EventArgs e)
        {
            MaskedTextBox mascara = sender as MaskedTextBox;
            if (!mascara.MaskFull)
            {
                mascara.Mask = "(00) 0000-0000";
            }
        }

        private void mtxtTelefones_Enter(object sender, EventArgs e)
        {
            MaskedTextBox mascara = sender as MaskedTextBox;
            mascara.Mask = "(00) 0,0000-0000";
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
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
            if (!string.IsNullOrWhiteSpace(txtNome.Text) && mtxtCPF.MaskFull && mtxtRG.MaskFull && !string.IsNullOrWhiteSpace(txtEndereco.Text)
                && !string.IsNullOrWhiteSpace(txtNumero.Text) && !string.IsNullOrWhiteSpace(txtBairro.Text) && !string.IsNullOrWhiteSpace(txtMunicipio.Text)
                && !string.IsNullOrWhiteSpace(cbEstado.Text) && mtxtCEP.MaskFull)
            {
                if (idpesquisa > 0)
                {
                    UpdateRepres();
                }
                else
                {
                    AdicionarRepres();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados de cadastro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if(idpesquisa > 0)
            {
                ExcluirRepres();
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

            mtxtTel3.Mask = "(00) 0,0000-0000";
            mtxtTel1.Mask = "(00) 0,0000-0000";
            mtxtTel2.Mask = "(00) 0,0000-0000";

            pesquisa = "";
            idpesquisa = 0;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisaRepres repres = new FrmPesquisaRepres();
            repres.ShowDialog();

            if(idpesquisa > 0)
            {
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
                OleDbConnection dbConnection = new OleDbConnection(strConnection);
                OleDbCommand cmdQry = dbConnection.CreateCommand();

                // Definir a instrução SQL com Parâmetros
                cmdQry.CommandText = "SELECT * FROM tblRepres WHERE idRepres=@id;";

                cmdQry.Parameters.AddWithValue("@id", idpesquisa);

                try
                {
                    dbConnection.Open();

                    OleDbDataReader dr = cmdQry.ExecuteReader();

                    if (dr.Read())
                    {
                        txtNome.Text = dr["nomeRepres"].ToString();
                        mtxtCPF.Text = dr["cpfRepres"].ToString();
                        mtxtRG.Text = dr["rgRepres"].ToString();
                        cbRegiao.Text = dr["regiaoRepres"].ToString();
                        txtEndereco.Text = dr["endRepres"].ToString();
                        txtNumero.Text = dr["numeroRepres"].ToString();
                        txtCompl.Text = dr["complRepres"].ToString();
                        txtBairro.Text = dr["bairroRepres"].ToString();
                        txtMunicipio.Text = dr["municipioRepres"].ToString();
                        cbEstado.Text = dr["ufRepres"].ToString();
                        mtxtCEP.Text = dr["cepRepres"].ToString();
                        mtxtTel1.Text = dr["tel1Repres"].ToString();
                        mtxtTel2.Text = dr["tel2Repres"].ToString();
                        mtxtTel3.Text = dr["tel3Repres"].ToString();
                        txtEmail.Text = dr["emailRepres"].ToString();
                        txtFavorecido.Text = dr["favorecidoRepres"].ToString();
                        txtAgencia.Text = dr["agenciaRepres"].ToString();
                        txtConta.Text = dr["contaRepres"].ToString();
                        cbBanco.Text = dr["bancoRepres"].ToString();
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
                    if (!mtxtTel3.MaskFull)
                    {
                        mtxtTel3.Mask = "000,000,000-00";
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
        public static string pesquisa = "";
        public static int idpesquisa = 0;

        public async void AdicionarRepres()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "INSERT INTO tblRepres (nomeRepres, cpfRepres, rgRepres, regiaoRepres, endRepres, numeroRepres, complRepres, bairroRepres, municipioRepres, ufRepres, cepRepres, tel1Repres, tel2Repres, tel3Repres, emailRepres, favorecidoRepres, agenciaRepres, contaRepres, bancoRepres)"
                + "VALUES (@nome, @cpf, @rg, @regiao, @end, @numero, @compl, @bairro, @municipio, @uf, @cep, @tel1, @tel2, @tel3, @email, @favorecido, @agencia, @conta, @banco)";

            string nome = txtNome.Text;
            string cpf = mtxtCPF.Text;
            string rg = mtxtRG.Text;
            string regiao = cbRegiao.Text;
            string endereco = txtEndereco.Text;
            string numero = txtNumero.Text;
            string compl = txtCompl.Text;
            string bairro = txtBairro.Text;
            string municipio = txtMunicipio.Text;
            string estado = cbEstado.Text;
            string cep = mtxtCEP.Text;
            string tel1 = mtxtTel1.Text;
            string tel2 = mtxtTel2.Text;
            string tel3 = mtxtTel3.Text;
            string email = txtEmail.Text;
            string favorecido = txtFavorecido.Text;
            string agencia = txtAgencia.Text;
            string conta = txtConta.Text;
            string banco = cbBanco.Text;

            cmdQry.Parameters.AddWithValue("@nome", nome);
            cmdQry.Parameters.AddWithValue("@cpf", cpf);
            cmdQry.Parameters.AddWithValue("@rg", rg);
            cmdQry.Parameters.AddWithValue("@regiao", regiao);
            cmdQry.Parameters.AddWithValue("@end", endereco);
            cmdQry.Parameters.AddWithValue("@numero", numero);
            cmdQry.Parameters.AddWithValue("@compl", compl);
            cmdQry.Parameters.AddWithValue("@bairro", bairro);
            cmdQry.Parameters.AddWithValue("@municipio", municipio);
            cmdQry.Parameters.AddWithValue("@uf", estado);
            cmdQry.Parameters.AddWithValue("@cep", cep);
            cmdQry.Parameters.AddWithValue("@tel1", tel1);
            cmdQry.Parameters.AddWithValue("@tel2", tel2);
            cmdQry.Parameters.AddWithValue("@tel3", tel3);
            cmdQry.Parameters.AddWithValue("@email", email);
            cmdQry.Parameters.AddWithValue("@favorecido", favorecido);
            cmdQry.Parameters.AddWithValue("@agencia", agencia);
            cmdQry.Parameters.AddWithValue("@conta", conta);
            cmdQry.Parameters.AddWithValue("@banco", banco);

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

                mtxtTel3.Mask = "(00) 0,0000-0000";
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

        public async void ExcluirRepres()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "DELETE FROM tblRepres WHERE idRepres=@id";

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

                mtxtTel3.Mask = "(00) 0,0000-0000";
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

        public async void UpdateRepres()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "UPDATE tblRepres SET nomeRepres=@nome, cpfRepres=@cpf, rgRepres=@rg, regiaoRepres=@regiao, " +
                "endRepres=@end, numeroRepres=@numero, complRepres=@compl, bairroRepres=@bairro, municipioRepres=@municipio, " +
                "ufRepres=@uf, cepRepres=@cep, tel1Repres=@tel1, tel2Repres=@tel2, tel3Repres=@tel3," +
                "emailRepres=@email, favorecidoRepres=@favorecido, agenciaRepres=@agencia, contaRepres=@conta, " +
                "bancoRepres=@banco WHERE idRepres=@id";

            string nome = txtNome.Text;
            string cpf = mtxtCPF.Text;
            string rg = mtxtRG.Text;
            string regiao = cbRegiao.Text;
            string endereco = txtEndereco.Text;
            string numero = txtNumero.Text;
            string compl = txtCompl.Text;
            string bairro = txtBairro.Text;
            string municipio = txtMunicipio.Text;
            string estado = cbEstado.Text;
            string cep = mtxtCEP.Text;
            string tel1 = mtxtTel1.Text;
            string tel2 = mtxtTel2.Text;
            string tel3 = mtxtTel3.Text;
            string email = txtEmail.Text;
            string favorecido = txtFavorecido.Text;
            string agencia = txtAgencia.Text;
            string conta = txtConta.Text;
            string banco = cbBanco.Text;

            cmdQry.Parameters.AddWithValue("@nome", nome);
            cmdQry.Parameters.AddWithValue("@cpf", cpf);
            cmdQry.Parameters.AddWithValue("@rg", rg);
            cmdQry.Parameters.AddWithValue("@regiao", regiao);
            cmdQry.Parameters.AddWithValue("@end", endereco);
            cmdQry.Parameters.AddWithValue("@numero", numero);
            cmdQry.Parameters.AddWithValue("@compl", compl);
            cmdQry.Parameters.AddWithValue("@bairro", bairro);
            cmdQry.Parameters.AddWithValue("@municipio", municipio);
            cmdQry.Parameters.AddWithValue("@uf", estado);
            cmdQry.Parameters.AddWithValue("@cep", cep);
            cmdQry.Parameters.AddWithValue("@tel1", tel1);
            cmdQry.Parameters.AddWithValue("@tel2", tel2);
            cmdQry.Parameters.AddWithValue("@tel3", tel3);
            cmdQry.Parameters.AddWithValue("@email", email);
            cmdQry.Parameters.AddWithValue("@favorecido", favorecido);
            cmdQry.Parameters.AddWithValue("@agencia", agencia);
            cmdQry.Parameters.AddWithValue("@conta", conta);
            cmdQry.Parameters.AddWithValue("@banco", banco);

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

                mtxtTel3.Mask = "(00) 0,0000-0000";
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
