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

namespace ProgramaCSA.Financeiro
{
    public partial class FrmLancamentos : Form
    {
        public FrmLancamentos()
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
            Close();
        }
        private void btMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        private async void btSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbForn.Text) && !string.IsNullOrEmpty(txtValor.Text))
            {
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
                OleDbConnection dbConnection = new OleDbConnection(strConnection);
                OleDbCommand cmdQry = dbConnection.CreateCommand();

                int idforn = 0;

                cmdQry.CommandText = "SELECT idForn FROM tblFornecedores WHERE nomeForn=@nome";

                cmdQry.Parameters.AddWithValue("@nome", cbForn.Text);

                try
                {
                    dbConnection.Open();

                    idforn = Convert.ToInt32(cmdQry.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dbConnection.Close();
                }

                cmdQry.Parameters.Clear();
                cmdQry.CommandText = "INSERT INTO tblContasPagar (idForn, descrContas, documContas, valorContas, vencimentoContas, statusContas) VALUES (@idForn, @descr, @docum, @valor, @vencimento, @status)";

                string nome = cbForn.Text;
                string descr = txtDesc.Text;
                string docum = txtDocum.Text;
                string valor = txtValor.Text;
                string vencimento = dtpVenc.Text;
                string status = "EM ABERTO";

                cmdQry.Parameters.AddWithValue("@id", idforn);
                cmdQry.Parameters.AddWithValue("@descr", descr);
                cmdQry.Parameters.AddWithValue("@docum", docum);
                cmdQry.Parameters.AddWithValue("@valor", valor);
                cmdQry.Parameters.AddWithValue("@vencimento", vencimento);
                cmdQry.Parameters.AddWithValue("@status", status);

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

                    dtpVenc.Text = DateTime.Now.ToString();
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

            dtpVenc.Text = DateTime.Now.ToString();
        }

        private void FrmLancamentos_Load(object sender, EventArgs e)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            // Definir a instrução SQL com Parâmetros
            cmdQry.CommandText = "SELECT nomeForn FROM tblFornecedores";

            try
            {
                dbConnection.Open();

                OleDbDataReader dr = cmdQry.ExecuteReader();

                if (dr.Read())
                {
                    cbForn.Items.Add(dr["nomeForn"].ToString());
                }
                dr.Close();

                cbForn.Items.Add("");
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

        private void mtxtCnpj_Leave(object sender, EventArgs e)
        {
            if (mtxtCnpj.MaskFull)
            {
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
                OleDbConnection dbConnection = new OleDbConnection(strConnection);
                OleDbCommand cmdQry = dbConnection.CreateCommand();

                // Definir a instrução SQL com Parâmetros
                cmdQry.CommandText = "SELECT nomeForn FROM tblFornecedores WHERE cnpjForn=@cnpj";

                string cnpj = mtxtCnpj.Text;
                cmdQry.Parameters.AddWithValue("@cnpj", cnpj);

                try
                {
                    dbConnection.Open();

                    cbForn.Text = Convert.ToString(cmdQry.ExecuteScalar());
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

        private void cbForn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(cbForn.Text))
            {
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
                OleDbConnection dbConnection = new OleDbConnection(strConnection);
                OleDbCommand cmdQry = dbConnection.CreateCommand();

                cmdQry.CommandText = "SELECT cnpjForn FROM tblFornecedores WHERE nomeForn=@nome";

                cmdQry.Parameters.AddWithValue("@nome", cbForn.Text);

                try
                {
                    dbConnection.Open();

                    OleDbDataReader dr = cmdQry.ExecuteReader();

                    if(dr.Read())
                    {
                        mtxtCnpj.Text = dr["cnpjForn"].ToString();
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

        private void mtxtCnpj_KeyUp(object sender, KeyEventArgs e)
        {
            if(mtxtCnpj.MaskFull)
            {
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
                OleDbConnection dbConnection = new OleDbConnection(strConnection);
                OleDbCommand cmdQry = dbConnection.CreateCommand();

                cmdQry.CommandText = "SELECT nomeForn FROM tblFornecedores WHERE cnpjForn=@cnpj";

                cmdQry.Parameters.AddWithValue("@cnpj", mtxtCnpj.Text);

                try
                {
                    dbConnection.Open();

                    OleDbDataReader dr = cmdQry.ExecuteReader();

                    if (dr.Read())
                    {
                        cbForn.Text = dr["nomeForn"].ToString();
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
    }
}
