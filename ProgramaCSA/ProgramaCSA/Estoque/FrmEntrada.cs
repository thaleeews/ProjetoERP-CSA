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

namespace ProgramaCSA.Estoque
{
    public partial class FrmEntrada : Form
    {
        public FrmEntrada()
        {
            InitializeComponent();
        }

        private OleDbDataAdapter adapt = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private OleDbCommandBuilder construtor = null;
        bool pesquisa = true;

        #region configurações primárias
        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
            Close();
        }
        private void btMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void dtpEntrada_ValueChanged(object sender, EventArgs e)
        {
            if (pesquisa == true)
            {
                btSalvar.Enabled = false;
                btFiltro.Enabled = true;
                btImprimir.Enabled = true;
                dgvEntrada.AllowUserToAddRows = false;
                dgvEntrada.AllowUserToDeleteRows = false;

                dgvEntrada.Columns.Clear();

                dgvEntrada.Columns.Add("txtId", "ID");
                dgvEntrada.Columns[0].Visible = false;
                dgvEntrada.Columns.Add("txtCodigo", "Código");
                dgvEntrada.Columns.Add("txtQuantidade", "Quantidade");
                dgvEntrada.Columns.Add("txtLote", "Lote");
                dgvEntrada.Columns.Add("txtValidade", "Validade");
                dgvEntrada.Columns.Add("txtData", "Data");

                dgvEntrada.Columns[0].DataPropertyName = "idEntradas";
                dgvEntrada.Columns[1].DataPropertyName = "idProdutos";
                dgvEntrada.Columns[2].DataPropertyName = "qtEntradas";
                dgvEntrada.Columns[3].DataPropertyName = "loteEntradas";
                dgvEntrada.Columns[4].DataPropertyName = "validadeEntradas";
                dgvEntrada.Columns[5].DataPropertyName = "dataEntradas";

                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
                OleDbConnection dbConnection = new OleDbConnection(strConnection);
                OleDbCommand cmdQry = dbConnection.CreateCommand();

                // Definir a instrução SQL com Parâmetros
                cmdQry.CommandText = "SELECT * FROM [tblEntradas] WHERE [dataEntradas] LIKE @data;";

                try
                {
                    dbConnection.Open();
                    adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                    construtor = new OleDbCommandBuilder(adapt);
                    string param = dtpEntrada.Text.ToString();
                    adapt.SelectCommand.Parameters.AddWithValue("@data", "%" + param + "%");

                    dataTable = new DataTable();
                    adapt.Fill(dataTable);
                    bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dgvEntrada.DataSource = bindingSource;

                    // to hide Identity column
                    dgvEntrada.Columns[0].Visible = false;
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

        private void btFiltro_Click(object sender, EventArgs e)
        {
            pesquisa = false;
            dtpEntrada.Text = DateTime.Now.ToString();
            dgvEntrada.Columns.Clear();
            btImprimir.Enabled = false;
            btFiltro.Enabled = false;
            btSalvar.Enabled = true;

            dgvEntrada.Columns.Add("txtId", "ID");
            dgvEntrada.Columns[0].Visible = false;
            dgvEntrada.Columns.Add("txtCodigo", "Código");
            dgvEntrada.Columns.Add("txtQuantidade", "Quantidade");
            dgvEntrada.Columns.Add("txtLote", "Lote");
            dgvEntrada.Columns.Add("txtValidade", "Validade");

            dgvEntrada.AllowUserToAddRows = true;
            dgvEntrada.AllowUserToDeleteRows = true;
            pesquisa = true;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            try
            {
                dbConnection.Open();
                for (int i = 0; i < dgvEntrada.Rows.Count; i++)
                {
                    cmdQry.CommandText = "INSERT INTO tblEntradas (idProdutos, qtEntradas, loteEntradas, validadeEntradas, dataEntradas) VALUES " +
                    "([@id], [@qt], [@lote], [@validade], [@data]);";

                    cmdQry.Parameters.Clear();

                    cmdQry.Parameters.AddWithValue("@id", dgvEntrada.Rows[i].Cells[1].Value);
                    cmdQry.Parameters.AddWithValue("@qt", dgvEntrada.Rows[i].Cells[2].Value);
                    cmdQry.Parameters.AddWithValue("@lote", dgvEntrada.Rows[i].Cells[3].Value);
                    cmdQry.Parameters.AddWithValue("@validade", dgvEntrada.Rows[i].Cells[4].Value);
                    cmdQry.Parameters.AddWithValue("@data", dtpEntrada.Text);

                    cmdQry.ExecuteNonQuery();
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

        private void btLimpar_Click(object sender, EventArgs e)
        {
            btSalvar.Enabled = true;
            btImprimir.Enabled = false;
            btFiltro.Enabled = false;
            
            dgvEntrada.Columns.Clear();
        }
    }
}
