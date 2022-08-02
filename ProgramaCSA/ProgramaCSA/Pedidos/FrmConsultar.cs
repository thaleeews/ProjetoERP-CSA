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

namespace ProgramaCSA.Pedidos
{
    public partial class FrmConsultar : Form
    {
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private OleDbDataAdapter adapt = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private OleDbCommandBuilder construtor = null;
        bool select = false;

        #region configurações básicas
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

        private void txtPedido_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPedido.Text))
            {
                select = false;
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
                OleDbConnection dbConnection = new OleDbConnection(strConnection);
                OleDbCommand cmdQry = dbConnection.CreateCommand();

                cmdQry.CommandText = "SELECT a.idPedido, b.nomeClientes, c.nomeRepres, a.subtotalPedido, a.tipoPedido, a.dataPedido, a.prazoPedido FROM (tblPedido AS a INNER JOIN tblClientes AS b ON a.idClientes=b.idClientes) " +
                    "INNER JOIN tblRepres AS c ON a.idRepres=c.idRepres WHERE a.idPedido=@pedido";

                try
                {
                    dbConnection.Open();
                    adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                    construtor = new OleDbCommandBuilder(adapt);
                    int pedido = Convert.ToInt32(txtPedido.Text);
                    adapt.SelectCommand.Parameters.AddWithValue("@pedido", pedido);

                    dataTable = new DataTable();
                    adapt.Fill(dataTable);
                    bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dgvPedido.DataSource = bindingSource;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dbConnection.Close();
                    select = true;
                }
            }
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "SELECT a.idPedido, b.nomeClientes, c.nomeRepres, a.subtotalPedido, a.tipoPedido, a.dataPedido, a.prazoPedido FROM (tblPedido AS a INNER JOIN tblClientes AS b ON a.idClientes=b.idClientes) " +
                "INNER JOIN tblRepres AS c ON a.idRepres=c.idRepres";

            try
            {
                dbConnection.Open();
                adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                construtor = new OleDbCommandBuilder(adapt);

                dataTable = new DataTable();
                adapt.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dgvPedido.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.Close();
                select = true;
            }
        }

        private void dgvPedido_SelectionChanged(object sender, EventArgs e)
        {
            if(select == true)
            {

            }
        }
    }
}
