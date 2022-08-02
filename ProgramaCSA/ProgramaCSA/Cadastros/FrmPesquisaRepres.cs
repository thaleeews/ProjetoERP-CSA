using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaCSA.Cadastros
{
    public partial class FrmPesquisaRepres : Form
    {
        public FrmPesquisaRepres()
        {
            InitializeComponent();
        }

        private OleDbDataAdapter adapt = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private OleDbCommandBuilder construtor = null;

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
            FrmRepres.idpesquisa = 0;
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

        #endregion

        private void FrmPesquisaRepres_Load(object sender, EventArgs e)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            // Definir a instrução SQL com Parâmetros
            cmdQry.CommandText = "SELECT * FROM tblRepres";

            try
            {
                dbConnection.Open();
                adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                construtor = new OleDbCommandBuilder(adapt);

                dataTable = new DataTable();
                adapt.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dgvRepres.DataSource = bindingSource;

                // to hide Identity column
                dgvRepres.Columns[0].Visible = false;
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

        private void dgvRepres_DoubleClick(object sender, EventArgs e)
        {
            if (dgvRepres.SelectedRows.Count == 1 || dgvRepres.SelectedCells.Count == 1)
            {
                var message = MessageBox.Show("Deseja visualizar o representante " + dgvRepres.CurrentRow.Cells[1].Value.ToString() + "?", "Confirme a ação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    FrmRepres.pesquisa = dgvRepres.CurrentRow.Cells[1].Value.ToString();
                    FrmRepres.idpesquisa = Convert.ToInt32(dgvRepres.CurrentRow.Cells[0].Value);
                    Close();
                }
            }
        }

        private void txtRepres_KeyUp(object sender, KeyEventArgs e)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            // Definir a instrução SQL com Parâmetros
            cmdQry.CommandText = "SELECT * FROM [tblRepres] WHERE [nomeRepres] LIKE @nome;";

            try
            {
                dbConnection.Open();
                adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                construtor = new OleDbCommandBuilder(adapt);
                string param = txtRepres.Text.ToString();
                adapt.SelectCommand.Parameters.AddWithValue("@nome", "%" + param + "%");

                dataTable = new DataTable();
                adapt.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dgvRepres.DataSource = bindingSource;

                // to hide Identity column
                dgvRepres.Columns[0].Visible = false;
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

        private void mtxtCpf_KeyUp(object sender, KeyEventArgs e)
        {
            if(mtxtCpf.MaskFull)
            {
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
                OleDbConnection dbConnection = new OleDbConnection(strConnection);
                OleDbCommand cmdQry = dbConnection.CreateCommand();

                // Definir a instrução SQL com Parâmetros
                cmdQry.CommandText = "SELECT * FROM [tblRepres] WHERE [cpfRepres] LIKE @cpf;";

                try
                {
                    dbConnection.Open();
                    adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                    construtor = new OleDbCommandBuilder(adapt);
                    string param = mtxtCpf.Text.ToString();
                    adapt.SelectCommand.Parameters.AddWithValue("@cpf", "%" + param + "%");

                    dataTable = new DataTable();
                    adapt.Fill(dataTable);
                    bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dgvRepres.DataSource = bindingSource;

                    // to hide Identity column
                    dgvRepres.Columns[0].Visible = false;
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
            else
            {
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
                OleDbConnection dbConnection = new OleDbConnection(strConnection);
                OleDbCommand cmdQry = dbConnection.CreateCommand();

                // Definir a instrução SQL com Parâmetros
                cmdQry.CommandText = "SELECT * FROM tblRepres";

                try
                {
                    dbConnection.Open();
                    adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                    construtor = new OleDbCommandBuilder(adapt);

                    dataTable = new DataTable();
                    adapt.Fill(dataTable);
                    bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dgvRepres.DataSource = bindingSource;

                    // to hide Identity column
                    dgvRepres.Columns[0].Visible = false;
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

        private void cbRegiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            // Definir a instrução SQL com Parâmetros
            cmdQry.CommandText = "SELECT * FROM [tblRepres] WHERE [regiaoRepres] LIKE @regiao;";

            try
            {
                dbConnection.Open();
                adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                construtor = new OleDbCommandBuilder(adapt);
                string param = cbRegiao.Text.ToString();
                adapt.SelectCommand.Parameters.AddWithValue("@regiao", "%" + param + "%");

                dataTable = new DataTable();
                adapt.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dgvRepres.DataSource = bindingSource;

                // to hide Identity column
                dgvRepres.Columns[0].Visible = false;
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
