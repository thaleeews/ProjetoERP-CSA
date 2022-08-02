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
    public partial class FrmPesquisaClientes : Form
    {
        public FrmPesquisaClientes()
        {
            InitializeComponent();
        }

        private OleDbDataAdapter adapt = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private OleDbCommandBuilder construtor = null;

        #region configurações primárias
        private void mtxt_Click(object sender, EventArgs e)
        {
            MaskedTextBox mascara = sender as MaskedTextBox;
            mascara.SelectionStart = 0;
        }

        private void mtxtCNPJ_Enter(object sender, EventArgs e)
        {
            MaskedTextBox mascara = sender as MaskedTextBox;
            mascara.Mask = "00,000,000/0000-00";
        }

        private void mtxtCNPJ_Leave(object sender, EventArgs e)
        {
            MaskedTextBox mascara = sender as MaskedTextBox;
            if (!mascara.MaskFull)
            {
                mascara.Mask = "000,000,000-00";
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
            Close();
        }
        private void btMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void FrmPesquisaClientes_Load(object sender, EventArgs e)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            // Definir a instrução SQL com Parâmetros
            cmdQry.CommandText = "SELECT * FROM tblClientes";

            try
            {
                dbConnection.Open();
                adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                construtor = new OleDbCommandBuilder(adapt);

                dataTable = new DataTable();
                adapt.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dgvClientes.DataSource = bindingSource;

                dgvClientes.Columns[0].Visible = false;
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

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            // Definir a instrução SQL com Parâmetros
            cmdQry.CommandText = "SELECT * FROM [tblClientes] WHERE [nomeClientes] LIKE @nome;";

            try
            {
                dbConnection.Open();
                adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                construtor = new OleDbCommandBuilder(adapt);
                string param = txtNome.Text.ToString();
                adapt.SelectCommand.Parameters.AddWithValue("@nome", "%"+param+"%");

                dataTable = new DataTable();
                adapt.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dgvClientes.DataSource = bindingSource;

                // to hide Identity column
                dgvClientes.Columns[0].Visible = false;
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

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            if(dgvClientes.SelectedRows.Count == 1 || dgvClientes.SelectedCells.Count == 1)
            {
                var message = MessageBox.Show("Deseja visualizar o cliente " + dgvClientes.CurrentRow.Cells[1].Value.ToString() + "?", "Confirme a ação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    FrmClientes.pesquisa = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                    FrmClientes.idpesquisa = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
                    Close();
                }
            }
        }

        private void mtxtCnpj_KeyUp(object sender, KeyEventArgs e)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            // Definir a instrução SQL com Parâmetros
            cmdQry.CommandText = "SELECT * FROM [tblClientes] WHERE [cnpjClientes] LIKE @cnpj;";

            try
            {
                dbConnection.Open();
                adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                construtor = new OleDbCommandBuilder(adapt);
                string param = mtxtCnpj.Text.ToString();
                adapt.SelectCommand.Parameters.AddWithValue("@cnpj", "%" + param + "%");

                dataTable = new DataTable();
                adapt.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dgvClientes.DataSource = bindingSource;

                // to hide Identity column
                dgvClientes.Columns[0].Visible = false;
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
