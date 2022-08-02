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

namespace ProgramaCSA.Financeiro
{
    public partial class FrmBaixaTit : Form
    {
        public FrmBaixaTit()
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
        }
        private void btMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void FrmBaixaTit_Load(object sender, EventArgs e)
        {
            var firstDay = new DateTime(DateTime.Now.Year, 1, 1);
            dtpComeco.Text = firstDay.ToString();

            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            // Definir a instrução SQL com Parâmetros
            cmdQry.CommandText = "SELECT * FROM tblContasPagar WHERE statusContas=@status AND vencimentoContas BETWEEN @data1 AND @data2";

            try
            {
                dbConnection.Open();
                adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                construtor = new OleDbCommandBuilder(adapt);
                string statusContas = "EM ABERTO";
                string data1 = dtpComeco.Text.ToString();
                string data2 = dtpFim.Text.ToString();
                adapt.SelectCommand.Parameters.AddWithValue("@status", statusContas);
                adapt.SelectCommand.Parameters.AddWithValue("@data1", data1);
                adapt.SelectCommand.Parameters.AddWithValue("@data2", data2);

                dataTable = new DataTable();
                adapt.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dgvBaixa.DataSource = bindingSource;
                adapt.SelectCommand.Parameters.Clear();
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

        private void dtpComeco_ValueChanged(object sender, EventArgs e)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            // Definir a instrução SQL com Parâmetros
            cmdQry.CommandText = "SELECT * FROM tblContasPagar WHERE statusContas=@status AND vencimentoContas BETWEEN @data1 AND @data2";

            try
            {
                dbConnection.Open();
                adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                construtor = new OleDbCommandBuilder(adapt);
                string statusContas = "EM ABERTO";
                string data1 = dtpComeco.Text.ToString();
                string data2 = dtpFim.Text.ToString();
                adapt.SelectCommand.Parameters.AddWithValue("@status", statusContas);
                adapt.SelectCommand.Parameters.AddWithValue("@data1", data1);
                adapt.SelectCommand.Parameters.AddWithValue("@data2", data2);

                dataTable = new DataTable();
                adapt.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dgvBaixa.DataSource = bindingSource;
                adapt.SelectCommand.Parameters.Clear();
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

        private void dtpFim_ValueChanged(object sender, EventArgs e)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            // Definir a instrução SQL com Parâmetros
            cmdQry.CommandText = "SELECT * FROM tblContasPagar WHERE statusContas=@status AND vencimentoContas BETWEEN @data1 AND @data2";

            try
            {
                dbConnection.Open();
                adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                construtor = new OleDbCommandBuilder(adapt);
                string statusContas = "EM ABERTO";
                string data1 = dtpComeco.Text.ToString();
                string data2 = dtpFim.Text.ToString();
                adapt.SelectCommand.Parameters.AddWithValue("@status", statusContas);
                adapt.SelectCommand.Parameters.AddWithValue("@data1", data1);
                adapt.SelectCommand.Parameters.AddWithValue("@data2", data2);

                dataTable = new DataTable();
                adapt.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dgvBaixa.DataSource = bindingSource;
                adapt.SelectCommand.Parameters.Clear();
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

        private void btSalvar_Click(object sender, EventArgs e)
        { 
            var message = MessageBox.Show("Tem certeza de que deseja dar baixa nos registros?", "Confirme a ação.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
                OleDbConnection dbConnection = new OleDbConnection(strConnection);

                try
                {
                    dbConnection.Open();
                    adapt.Update(dataTable);
                    adapt.SelectCommand.Parameters.Clear();
                    MessageBox.Show("Baixas registradas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
