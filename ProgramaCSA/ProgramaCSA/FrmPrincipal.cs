using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramaCSA.Cadastros;
using ProgramaCSA.Pedidos;
using ProgramaCSA.Financeiro;
using ProgramaCSA.Estoque;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProgramaCSA
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region configurações basicas
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
            FrmSair sair = new FrmSair();
            sair.ShowDialog();
        }
        private void btMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
#endregion

        private void EsconderSubs()
        {
            if (pCadastros.Visible == true)
                pCadastros.Visible = false;
            if (pEstoque.Visible == true)
                pEstoque.Visible = false;
            if (pPedidos.Visible == true)
                pPedidos.Visible = false;
            if (pFinanceiro.Visible == true)
                pFinanceiro.Visible = false;
        }

        private void MostrarSub(Panel sub)
        {
            if(sub.Visible == false)
            {
                EsconderSubs();
                sub.Size = new Size(250, (sub.Controls.Count * 40));
                sub.Visible = true;
            }
            else
            {
                sub.Visible = false;
            }
        }

        #region SEÇÃO CADASTROS
        private void btPCadastros_Click(object sender, EventArgs e)
        {
            MostrarSub(pCadastros);
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            Hide();
            FrmClientes t = new FrmClientes();
            t.ShowDialog();
            Show();
        }
        private void btFornecedor_Click(object sender, EventArgs e)
        {
            Hide();
            FrmFornecedor fornecedor = new FrmFornecedor();
            fornecedor.ShowDialog();
            Show();
        }
        private void btRepresentante_Click(object sender, EventArgs e)
        {
            Hide();
            FrmRepres repr = new FrmRepres();
            repr.ShowDialog();
            Show();
        }
        private void btTransportadora_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTransp transp = new FrmTransp();
            transp.ShowDialog();
            Show();
        }
        private void btProdutos_Click(object sender, EventArgs e)
        {
            Hide();
            FrmProdutos r = new FrmProdutos();
            r.ShowDialog();
            Show();
        }
        private void btFiscal_Click(object sender, EventArgs e)
        {
            Hide();
            FrmFiscal fisco = new FrmFiscal();
            fisco.ShowDialog();
            Show();
        }
        #endregion

        #region SEÇÃO ESTOQUE
        private void btPEstoque_Click(object sender, EventArgs e)
        {
            MostrarSub(pEstoque);
        }

        private void btEntrada_Click(object sender, EventArgs e)
        {
            Hide();
            FrmEntrada entrada = new FrmEntrada();
            entrada.ShowDialog();
            Show();
        }
        private void btSaida_Click(object sender, EventArgs e)
        {
            Hide();
            FrmSaida saida = new FrmSaida();
            saida.ShowDialog();
            Show();
        }
        private void btManutencao_Click(object sender, EventArgs e)
        {
            Hide();
            FrmManut manu = new FrmManut();
            manu.ShowDialog();
            Show();
        }
        private void btRelatorio_Click(object sender, EventArgs e)
        {
            Hide();
            Estoque.FrmRelatorio relat = new Estoque.FrmRelatorio();
            relat.ShowDialog();
            Show();
        }
        #endregion

        #region SEÇÃO PEDIDOS
        private void btPPedidos_Click(object sender, EventArgs e)
        {
            MostrarSub(pPedidos);
        }

        private void btRegistro_Click(object sender, EventArgs e)
        {
            Hide();
            FrmRegistro reg = new FrmRegistro();
            reg.ShowDialog();
            Show();
        }
        private void btPendentes_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPendentes pendente = new FrmPendentes();
            pendente.ShowDialog();
            Show();
        }
        private void btFaturamento_Click(object sender, EventArgs e)
        {
            Hide();
            FrmFaturamento fatura = new FrmFaturamento();
            fatura.ShowDialog();
            Show();
        }
        private void btPedidosGerais_Click(object sender, EventArgs e)
        {
            Hide();
            FrmGerais ger = new FrmGerais();
            ger.ShowDialog();
            Show();
        }
        private void btConsultarPedido_Click(object sender, EventArgs e)
        {
            Hide();
            FrmConsultar consultar = new FrmConsultar();
            consultar.ShowDialog();
            Show();
        }
        #endregion

        #region SEÇÃO FINANCEIRO
        private void btPFinanceiro_Click(object sender, EventArgs e)
        {
            MostrarSub(pFinanceiro);
        }

        private void btBoletos_Click(object sender, EventArgs e)
        {
            Hide();
            FrmBoletos boletos = new FrmBoletos();
            boletos.ShowDialog();
            Show();
        }
        private void btContasAPagar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmContasPagar contas = new FrmContasPagar();
            contas.ShowDialog();
            Show();
        }
        #endregion

        private void picMiniLogo_Click(object sender, EventArgs e)
        {
            EsconderSubs();
        }
    }
}
