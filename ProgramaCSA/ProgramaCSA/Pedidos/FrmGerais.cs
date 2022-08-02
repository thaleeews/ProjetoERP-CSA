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
    public partial class FrmGerais : Form
    {
        public FrmGerais()
        {
            InitializeComponent();
        }

        double totallumi = 0;
        double totalmaxi = 0;
        int idrepres = 0;
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

        private void FrmGerais_Load(object sender, EventArgs e)
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            cmdQry.CommandText = "SELECT nomeRepres FROM tblRepres;";

            try
            {
                dbConnection.Open();

                OleDbDataReader dr = cmdQry.ExecuteReader();

                if (dr.Read())
                {
                    cbRepres.Items.Add(dr["nomeRepres"].ToString());
                }
                dr.Close();

                cbRepres.Items.Add("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.Close();
            }


            cmdQry.CommandText = "SELECT tblRepres.nomeRepres, tblPedido.subtotalPedido FROM tblRepres INNER JOIN tblPedido ON tblRepres.idRepres=tblPedido.idRepres";

            try
            {
                dbConnection.Open();

                OleDbDataReader dr = cmdQry.ExecuteReader();

                while (dr.Read())
                {
                    var input = dr["nomeRepres"].ToString();
                    var firstWord = input.IndexOf(" ") > -1
                          ? input.Substring(0, input.IndexOf(" "))
                          : input;
                    grafFat.Series[0].Points.AddXY(firstWord.ToString(), dr["subtotalPedido"]);
                }
                dr.Close();
                grafFat.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                grafFat.Series[0].Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Ascending);
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

        private void cbRepres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(cbRepres.Text))
            {
                if (!string.IsNullOrWhiteSpace(cbMesRepres.Text))
                {
                    ReprMes();
                    Clientes();
                }
                ReprAno();
                ClientesMes();
            }
        }

        private void ReprMes()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            totallumi = 0;
            totalmaxi = 0;

            RetrieveRepres();

            cmdQry.CommandText = "SELECT SUM(lumiPedido) FROM tblPedido WHERE idRepres=@id AND MONTH(dataPedido)=@mes AND YEAR(dataPedido)=@ano";

            try
            {
                dbConnection.Open();

                cmdQry.Parameters.AddWithValue("@id", idrepres);
                cmdQry.Parameters.AddWithValue("@mes", cbMesRepres.SelectedIndex + 1);
                cmdQry.Parameters.AddWithValue("@ano", dtpRepres.Value.Year);

                object soma = cmdQry.ExecuteScalar();

                if(soma.Equals(DBNull.Value))
                {
                    totallumi = 0;
                }
                else
                {
                    totallumi = Convert.ToDouble(soma);
                }

                txtLumiMes.Text = totallumi.ToString("N2");
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
            cmdQry.CommandText = "SELECT SUM(maxiPedido) FROM tblPedido WHERE idRepres=@id AND MONTH(dataPedido)=@mes AND YEAR(dataPedido)=@ano";

            try
            {
                dbConnection.Open();

                cmdQry.Parameters.AddWithValue("@id", idrepres);
                cmdQry.Parameters.AddWithValue("@mes", cbMesRepres.SelectedIndex + 1);
                cmdQry.Parameters.AddWithValue("@ano", dtpRepres.Value.Year);

                object soma = cmdQry.ExecuteScalar();

                if (soma.Equals(DBNull.Value))
                {
                    totalmaxi = 0;
                }
                else
                {
                    totalmaxi = Convert.ToDouble(soma);
                }

                txtMaxiMes.Text = totalmaxi.ToString("N2");
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

        private void ReprAno()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            totallumi = 0;
            totalmaxi = 0;

            cmdQry.CommandText = "SELECT idRepres FROM tblRepres WHERE nomeRepres=@nome";

            cmdQry.Parameters.AddWithValue("@nome", cbRepres.Text);

            try
            {
                dbConnection.Open();

                object retorno = cmdQry.ExecuteScalar();

                if (!retorno.Equals(DBNull.Value))
                {
                    idrepres = Convert.ToInt32(retorno);
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

            cmdQry.Parameters.Clear();
            cmdQry.CommandText = "SELECT SUM(lumiPedido) FROM tblPedido WHERE idRepres=@id AND YEAR(dataPedido)=@ano";

            try
            {
                dbConnection.Open();

                cmdQry.Parameters.AddWithValue("@id", idrepres);
                cmdQry.Parameters.AddWithValue("@ano", dtpRepres.Value.Year);

                object soma = cmdQry.ExecuteScalar();

                if (soma.Equals(DBNull.Value))
                {
                    totallumi = 0;
                }
                else
                {
                    totallumi = Convert.ToDouble(soma);
                }

                txtLumiAno.Text = totallumi.ToString("N2");
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
            cmdQry.CommandText = "SELECT SUM(maxiPedido) FROM tblPedido WHERE idRepres=@id AND YEAR(dataPedido)=@ano";

            try
            {
                dbConnection.Open();

                cmdQry.Parameters.AddWithValue("@id", idrepres);
                cmdQry.Parameters.AddWithValue("@ano", dtpRepres.Value.Year);

                object soma = cmdQry.ExecuteScalar();

                if (soma.Equals(DBNull.Value))
                {
                    totalmaxi = 0;
                }
                else
                {
                    totalmaxi = Convert.ToDouble(soma);
                }

                txtMaxiAno.Text = totalmaxi.ToString("N2");
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

        private void Clientes()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            RetrieveRepres();

            cmdQry.CommandText = "SELECT tblPedido.subtotalPedido, tblPedido.dataPedido, tblClientes.nomeClientes FROM tblPedido LEFT JOIN tblClientes ON tblPedido.idClientes=tblClientes.idClientes WHERE MONTH(tblPedido.dataPedido)=@mes AND YEAR(tblPedido.dataPedido)=@ano AND tblPedido.idRepres=@id";


            try
            {
                dbConnection.Open();

                adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                construtor = new OleDbCommandBuilder(adapt);
                adapt.SelectCommand.Parameters.AddWithValue("@mes", cbMesRepres.SelectedIndex + 1);
                adapt.SelectCommand.Parameters.AddWithValue("@ano", dtpRepres.Value.Year);
                adapt.SelectCommand.Parameters.AddWithValue("@id", idrepres);

                dataTable = new DataTable();
                adapt.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dgvVendasMes.DataSource = bindingSource;
                if (dgvVendasMes.Rows.Count > 1)
                {
                    dgvVendasMes.Sort(dgvVendasMes.Columns["txtValorVendido"], ListSortDirection.Descending);
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

        private void ClientesMes()
        {
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            OleDbCommand cmdQry = dbConnection.CreateCommand();

            RetrieveRepres();

            cmdQry.CommandText = "SELECT tblClientes.nomeClientes, SUM(tblPedido.subtotalPedido) as subtotal FROM tblPedido INNER JOIN tblClientes ON tblPedido.idClientes=tblClientes.idClientes WHERE idRepres=@id GROUP BY nomeClientes";

            try
            {
                dbConnection.Open();

                adapt = new OleDbDataAdapter(cmdQry.CommandText, dbConnection);
                construtor = new OleDbCommandBuilder(adapt);
                adapt.SelectCommand.Parameters.AddWithValue("@id", idrepres);

                dataTable = new DataTable();
                adapt.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dgvTopClientes.DataSource = bindingSource;
                if (dgvTopClientes.Rows.Count > 1)
                {
                    dgvTopClientes.Sort(dgvTopClientes.Columns["txtValor"], ListSortDirection.Descending);
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

        private void RetrieveRepres()
        {
            if (!string.IsNullOrWhiteSpace(cbRepres.Text))
            {
                string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\dbProjectA.mdb";
                OleDbConnection dbConnection = new OleDbConnection(strConnection);
                OleDbCommand cmdQry = dbConnection.CreateCommand();

                idrepres = 0;

                cmdQry.CommandText = "SELECT idRepres FROM tblRepres WHERE nomeRepres=@nome";

                cmdQry.Parameters.AddWithValue("@nome", cbRepres.Text);

                try
                {
                    dbConnection.Open();

                    idrepres = Convert.ToInt32(cmdQry.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dbConnection.Close();
                    cmdQry.Parameters.Clear();
                }
            }
            else
            {
                MessageBox.Show("Por favor escolha um representante para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
