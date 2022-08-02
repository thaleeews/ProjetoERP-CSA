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

namespace ProgramaCSA.Pedidos
{
    public partial class FrmPendentes : Form
    {
        public FrmPendentes()
        {
            InitializeComponent();
        }

        private OleDbDataAdapter adapt = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private OleDbCommandBuilder construtor = null;

        bool selected = false;

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

        private void btAguardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem certeza de que deseja aguardar os itens faltantes chegarem à empresa?", "Confirme a ação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem certeza de que deseja excluir os itens faltantes do pedido?", "Confirme a ação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem certeza de que deseja cancelar o pedido?", "Confirme a ação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void dgvPedidos_SelectionChanged(object sender, EventArgs e)
        {
            if (selected == true)
            {
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
                OleDbConnection dbConnection = new OleDbConnection(strConnection);
                OleDbCommand cmdQry = dbConnection.CreateCommand();

                // Definir a instrução SQL com Parâmetros
                int id = 0;

                cmdQry.CommandText = "SELECT b.nomeProdutos, a.quantidadeItens, a.valorItens, a.subtotalItens FROM tblItensPedido AS a LEFT JOIN tblProdutos AS b ON a.idProdutos=b.idProdutos WHERE a.idPedido=@id";

                try
                {
                    dbConnection.Open();
                    adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                    construtor = new OleDbCommandBuilder(adapt);
                    DataGridViewRow linha = dgvPedidos.CurrentCell.OwningRow;
                    id = Convert.ToInt32(linha.Cells["txtId"].Value);
                    adapt.SelectCommand.Parameters.AddWithValue("@id", id);

                    dataTable = new DataTable();
                    adapt.Fill(dataTable);
                    bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dgvItens.DataSource = bindingSource;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dbConnection.Close();
                }

                cmdQry.CommandText = "SELECT obsPedido FROM tblPedido WHERE idPedido=@id";
                cmdQry.Parameters.Clear();
                cmdQry.Parameters.AddWithValue("@id", id);

                try
                {
                    dbConnection.Open();

                    object resp = cmdQry.ExecuteScalar();

                    if(!resp.Equals(DBNull.Value))
                    {
                        string obs = resp.ToString();
                        txtObs.Text = obs;
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

        private void FrmPendentes_Load(object sender, EventArgs e)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            // Definir a instrução SQL com Parâmetros
            cmdQry.CommandText = "SELECT a.idPedido, b.nomeClientes, c.nomeRepres, a.subtotalPedido, a.tipoPedido, a.dataPedido, a.prazoPedido FROM (tblPedido AS a INNER JOIN tblClientes AS b ON a.idClientes=b.idClientes) " +
                "INNER JOIN tblRepres AS c ON a.idRepres=c.idRepres WHERE a.setorPedido=@setor";

            try
            {
                dbConnection.Open();
                adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                construtor = new OleDbCommandBuilder(adapt);
                adapt.SelectCommand.Parameters.AddWithValue("@setor", "COMERCIAL");

                dataTable = new DataTable();
                adapt.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dgvPedidos.DataSource = bindingSource;
                selected = true;
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
