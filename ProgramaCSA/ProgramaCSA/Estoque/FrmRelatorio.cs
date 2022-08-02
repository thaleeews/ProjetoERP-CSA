using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramaCSA.Estoque;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace ProgramaCSA.Estoque
{
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
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

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "SELECT a.nomeProdutos, b.qtEstoque, b.loteEstoque, b.validadeEstoque, b.localEstoque FROM tblEstoque AS b INNER JOIN tblProdutos AS a ON b.idProdutos=a.idProdutos";

            try
            {
                dbConnection.Open();

                adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                construtor = new OleDbCommandBuilder(adapt);
                dataTable = new DataTable();
                adapt.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dgvRelat.DataSource = bindingSource;
                if (dgvRelat.Rows.Count > 1)
                {
                    dgvRelat.Sort(dgvRelat.Columns["txtNome"], ListSortDirection.Descending);
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
