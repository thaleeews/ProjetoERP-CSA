namespace ProgramaCSA
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.pGeral = new System.Windows.Forms.Panel();
            this.pFinanceiro = new System.Windows.Forms.Panel();
            this.btContasAPagar = new System.Windows.Forms.Button();
            this.btBoletos = new System.Windows.Forms.Button();
            this.btPFinanceiro = new System.Windows.Forms.Button();
            this.pPedidos = new System.Windows.Forms.Panel();
            this.btConsultarPedido = new System.Windows.Forms.Button();
            this.btPedidosGerais = new System.Windows.Forms.Button();
            this.btFaturamento = new System.Windows.Forms.Button();
            this.btPendentes = new System.Windows.Forms.Button();
            this.btRegistro = new System.Windows.Forms.Button();
            this.btPPedidos = new System.Windows.Forms.Button();
            this.pEstoque = new System.Windows.Forms.Panel();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btManutencao = new System.Windows.Forms.Button();
            this.btSaida = new System.Windows.Forms.Button();
            this.btEntrada = new System.Windows.Forms.Button();
            this.btPEstoque = new System.Windows.Forms.Button();
            this.pCadastros = new System.Windows.Forms.Panel();
            this.btFiscal = new System.Windows.Forms.Button();
            this.btProdutos = new System.Windows.Forms.Button();
            this.btTransportadora = new System.Windows.Forms.Button();
            this.btRepresentante = new System.Windows.Forms.Button();
            this.btFornecedor = new System.Windows.Forms.Button();
            this.btClientes = new System.Windows.Forms.Button();
            this.btPCadastros = new System.Windows.Forms.Button();
            this.pLogo = new System.Windows.Forms.Panel();
            this.picMiniLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pGeral.SuspendLayout();
            this.pFinanceiro.SuspendLayout();
            this.pPedidos.SuspendLayout();
            this.pEstoque.SuspendLayout();
            this.pCadastros.SuspendLayout();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMiniLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btMin);
            this.panel1.Controls.Add(this.btX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 30);
            this.panel1.TabIndex = 2;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(100, 30);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Menu";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btMin
            // 
            this.btMin.BackColor = System.Drawing.Color.Transparent;
            this.btMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(89)))));
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.ForeColor = System.Drawing.Color.White;
            this.btMin.Location = new System.Drawing.Point(1189, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(40, 30);
            this.btMin.TabIndex = 7;
            this.btMin.Text = "_";
            this.btMin.UseVisualStyleBackColor = false;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // btX
            // 
            this.btX.BackColor = System.Drawing.Color.Transparent;
            this.btX.Dock = System.Windows.Forms.DockStyle.Right;
            this.btX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(86)))), ((int)(((byte)(107)))));
            this.btX.FlatAppearance.BorderSize = 0;
            this.btX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(22)))));
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.ForeColor = System.Drawing.Color.White;
            this.btX.Location = new System.Drawing.Point(1229, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(40, 30);
            this.btX.TabIndex = 6;
            this.btX.Text = "X";
            this.btX.UseVisualStyleBackColor = false;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // pGeral
            // 
            this.pGeral.AutoScroll = true;
            this.pGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.pGeral.Controls.Add(this.pFinanceiro);
            this.pGeral.Controls.Add(this.btPFinanceiro);
            this.pGeral.Controls.Add(this.pPedidos);
            this.pGeral.Controls.Add(this.btPPedidos);
            this.pGeral.Controls.Add(this.pEstoque);
            this.pGeral.Controls.Add(this.btPEstoque);
            this.pGeral.Controls.Add(this.pCadastros);
            this.pGeral.Controls.Add(this.btPCadastros);
            this.pGeral.Controls.Add(this.pLogo);
            this.pGeral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pGeral.Location = new System.Drawing.Point(0, 30);
            this.pGeral.Name = "pGeral";
            this.pGeral.Size = new System.Drawing.Size(200, 603);
            this.pGeral.TabIndex = 3;
            // 
            // pFinanceiro
            // 
            this.pFinanceiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(61)))));
            this.pFinanceiro.Controls.Add(this.btContasAPagar);
            this.pFinanceiro.Controls.Add(this.btBoletos);
            this.pFinanceiro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pFinanceiro.Location = new System.Drawing.Point(0, 561);
            this.pFinanceiro.Name = "pFinanceiro";
            this.pFinanceiro.Size = new System.Drawing.Size(200, 1);
            this.pFinanceiro.TabIndex = 8;
            this.pFinanceiro.Visible = false;
            // 
            // btContasAPagar
            // 
            this.btContasAPagar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btContasAPagar.FlatAppearance.BorderSize = 0;
            this.btContasAPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btContasAPagar.ForeColor = System.Drawing.Color.White;
            this.btContasAPagar.Location = new System.Drawing.Point(0, 40);
            this.btContasAPagar.Name = "btContasAPagar";
            this.btContasAPagar.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btContasAPagar.Size = new System.Drawing.Size(200, 40);
            this.btContasAPagar.TabIndex = 2;
            this.btContasAPagar.Text = "Contas a Pagar";
            this.btContasAPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btContasAPagar.UseVisualStyleBackColor = true;
            this.btContasAPagar.Click += new System.EventHandler(this.btContasAPagar_Click);
            // 
            // btBoletos
            // 
            this.btBoletos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btBoletos.FlatAppearance.BorderSize = 0;
            this.btBoletos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBoletos.ForeColor = System.Drawing.Color.White;
            this.btBoletos.Location = new System.Drawing.Point(0, 0);
            this.btBoletos.Name = "btBoletos";
            this.btBoletos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btBoletos.Size = new System.Drawing.Size(200, 40);
            this.btBoletos.TabIndex = 1;
            this.btBoletos.Text = "Boletos";
            this.btBoletos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBoletos.UseVisualStyleBackColor = true;
            this.btBoletos.Click += new System.EventHandler(this.btBoletos_Click);
            // 
            // btPFinanceiro
            // 
            this.btPFinanceiro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPFinanceiro.FlatAppearance.BorderSize = 0;
            this.btPFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btPFinanceiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(66)))));
            this.btPFinanceiro.Location = new System.Drawing.Point(0, 516);
            this.btPFinanceiro.Name = "btPFinanceiro";
            this.btPFinanceiro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btPFinanceiro.Size = new System.Drawing.Size(200, 45);
            this.btPFinanceiro.TabIndex = 7;
            this.btPFinanceiro.Text = "Financeiro";
            this.btPFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPFinanceiro.UseVisualStyleBackColor = true;
            this.btPFinanceiro.Click += new System.EventHandler(this.btPFinanceiro_Click);
            // 
            // pPedidos
            // 
            this.pPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(61)))));
            this.pPedidos.Controls.Add(this.btConsultarPedido);
            this.pPedidos.Controls.Add(this.btPedidosGerais);
            this.pPedidos.Controls.Add(this.btFaturamento);
            this.pPedidos.Controls.Add(this.btPendentes);
            this.pPedidos.Controls.Add(this.btRegistro);
            this.pPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPedidos.Location = new System.Drawing.Point(0, 515);
            this.pPedidos.Name = "pPedidos";
            this.pPedidos.Size = new System.Drawing.Size(200, 1);
            this.pPedidos.TabIndex = 6;
            this.pPedidos.Visible = false;
            // 
            // btConsultarPedido
            // 
            this.btConsultarPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btConsultarPedido.FlatAppearance.BorderSize = 0;
            this.btConsultarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultarPedido.ForeColor = System.Drawing.Color.White;
            this.btConsultarPedido.Location = new System.Drawing.Point(0, 160);
            this.btConsultarPedido.Name = "btConsultarPedido";
            this.btConsultarPedido.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btConsultarPedido.Size = new System.Drawing.Size(200, 40);
            this.btConsultarPedido.TabIndex = 5;
            this.btConsultarPedido.Text = "Consultar Pedidos";
            this.btConsultarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsultarPedido.UseVisualStyleBackColor = true;
            this.btConsultarPedido.Click += new System.EventHandler(this.btConsultarPedido_Click);
            // 
            // btPedidosGerais
            // 
            this.btPedidosGerais.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPedidosGerais.FlatAppearance.BorderSize = 0;
            this.btPedidosGerais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPedidosGerais.ForeColor = System.Drawing.Color.White;
            this.btPedidosGerais.Location = new System.Drawing.Point(0, 120);
            this.btPedidosGerais.Name = "btPedidosGerais";
            this.btPedidosGerais.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btPedidosGerais.Size = new System.Drawing.Size(200, 40);
            this.btPedidosGerais.TabIndex = 4;
            this.btPedidosGerais.Text = "Pedidos Gerais";
            this.btPedidosGerais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPedidosGerais.UseVisualStyleBackColor = true;
            this.btPedidosGerais.Click += new System.EventHandler(this.btPedidosGerais_Click);
            // 
            // btFaturamento
            // 
            this.btFaturamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFaturamento.FlatAppearance.BorderSize = 0;
            this.btFaturamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFaturamento.ForeColor = System.Drawing.Color.White;
            this.btFaturamento.Location = new System.Drawing.Point(0, 80);
            this.btFaturamento.Name = "btFaturamento";
            this.btFaturamento.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btFaturamento.Size = new System.Drawing.Size(200, 40);
            this.btFaturamento.TabIndex = 3;
            this.btFaturamento.Text = "Faturamento";
            this.btFaturamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFaturamento.UseVisualStyleBackColor = true;
            this.btFaturamento.Click += new System.EventHandler(this.btFaturamento_Click);
            // 
            // btPendentes
            // 
            this.btPendentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPendentes.FlatAppearance.BorderSize = 0;
            this.btPendentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPendentes.ForeColor = System.Drawing.Color.White;
            this.btPendentes.Location = new System.Drawing.Point(0, 40);
            this.btPendentes.Name = "btPendentes";
            this.btPendentes.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btPendentes.Size = new System.Drawing.Size(200, 40);
            this.btPendentes.TabIndex = 2;
            this.btPendentes.Text = "Pendentes";
            this.btPendentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPendentes.UseVisualStyleBackColor = true;
            this.btPendentes.Click += new System.EventHandler(this.btPendentes_Click);
            // 
            // btRegistro
            // 
            this.btRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btRegistro.FlatAppearance.BorderSize = 0;
            this.btRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegistro.ForeColor = System.Drawing.Color.White;
            this.btRegistro.Location = new System.Drawing.Point(0, 0);
            this.btRegistro.Name = "btRegistro";
            this.btRegistro.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btRegistro.Size = new System.Drawing.Size(200, 40);
            this.btRegistro.TabIndex = 1;
            this.btRegistro.Text = "Registro";
            this.btRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRegistro.UseVisualStyleBackColor = true;
            this.btRegistro.Click += new System.EventHandler(this.btRegistro_Click);
            // 
            // btPPedidos
            // 
            this.btPPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPPedidos.FlatAppearance.BorderSize = 0;
            this.btPPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btPPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(66)))));
            this.btPPedidos.Location = new System.Drawing.Point(0, 470);
            this.btPPedidos.Name = "btPPedidos";
            this.btPPedidos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btPPedidos.Size = new System.Drawing.Size(200, 45);
            this.btPPedidos.TabIndex = 5;
            this.btPPedidos.Text = "Pedidos";
            this.btPPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPPedidos.UseVisualStyleBackColor = true;
            this.btPPedidos.Click += new System.EventHandler(this.btPPedidos_Click);
            // 
            // pEstoque
            // 
            this.pEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(61)))));
            this.pEstoque.Controls.Add(this.btRelatorio);
            this.pEstoque.Controls.Add(this.btManutencao);
            this.pEstoque.Controls.Add(this.btSaida);
            this.pEstoque.Controls.Add(this.btEntrada);
            this.pEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.pEstoque.Location = new System.Drawing.Point(0, 469);
            this.pEstoque.Name = "pEstoque";
            this.pEstoque.Size = new System.Drawing.Size(200, 1);
            this.pEstoque.TabIndex = 4;
            this.pEstoque.Visible = false;
            // 
            // btRelatorio
            // 
            this.btRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btRelatorio.FlatAppearance.BorderSize = 0;
            this.btRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelatorio.ForeColor = System.Drawing.Color.White;
            this.btRelatorio.Location = new System.Drawing.Point(0, 120);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btRelatorio.Size = new System.Drawing.Size(200, 40);
            this.btRelatorio.TabIndex = 4;
            this.btRelatorio.Text = "Relatório";
            this.btRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRelatorio.UseVisualStyleBackColor = true;
            this.btRelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
            // 
            // btManutencao
            // 
            this.btManutencao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btManutencao.FlatAppearance.BorderSize = 0;
            this.btManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btManutencao.ForeColor = System.Drawing.Color.White;
            this.btManutencao.Location = new System.Drawing.Point(0, 80);
            this.btManutencao.Name = "btManutencao";
            this.btManutencao.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btManutencao.Size = new System.Drawing.Size(200, 40);
            this.btManutencao.TabIndex = 3;
            this.btManutencao.Text = "Manutenção";
            this.btManutencao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btManutencao.UseVisualStyleBackColor = true;
            this.btManutencao.Click += new System.EventHandler(this.btManutencao_Click);
            // 
            // btSaida
            // 
            this.btSaida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSaida.FlatAppearance.BorderSize = 0;
            this.btSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaida.ForeColor = System.Drawing.Color.White;
            this.btSaida.Location = new System.Drawing.Point(0, 40);
            this.btSaida.Name = "btSaida";
            this.btSaida.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btSaida.Size = new System.Drawing.Size(200, 40);
            this.btSaida.TabIndex = 2;
            this.btSaida.Text = "Saída";
            this.btSaida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSaida.UseVisualStyleBackColor = true;
            this.btSaida.Click += new System.EventHandler(this.btSaida_Click);
            // 
            // btEntrada
            // 
            this.btEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEntrada.FlatAppearance.BorderSize = 0;
            this.btEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEntrada.ForeColor = System.Drawing.Color.White;
            this.btEntrada.Location = new System.Drawing.Point(0, 0);
            this.btEntrada.Name = "btEntrada";
            this.btEntrada.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btEntrada.Size = new System.Drawing.Size(200, 40);
            this.btEntrada.TabIndex = 1;
            this.btEntrada.Text = "Entrada";
            this.btEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEntrada.UseVisualStyleBackColor = true;
            this.btEntrada.Click += new System.EventHandler(this.btEntrada_Click);
            // 
            // btPEstoque
            // 
            this.btPEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPEstoque.FlatAppearance.BorderSize = 0;
            this.btPEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btPEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(66)))));
            this.btPEstoque.Location = new System.Drawing.Point(0, 424);
            this.btPEstoque.Name = "btPEstoque";
            this.btPEstoque.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btPEstoque.Size = new System.Drawing.Size(200, 45);
            this.btPEstoque.TabIndex = 3;
            this.btPEstoque.Text = "Estoque";
            this.btPEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPEstoque.UseVisualStyleBackColor = true;
            this.btPEstoque.Click += new System.EventHandler(this.btPEstoque_Click);
            // 
            // pCadastros
            // 
            this.pCadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(61)))));
            this.pCadastros.Controls.Add(this.btFiscal);
            this.pCadastros.Controls.Add(this.btProdutos);
            this.pCadastros.Controls.Add(this.btTransportadora);
            this.pCadastros.Controls.Add(this.btRepresentante);
            this.pCadastros.Controls.Add(this.btFornecedor);
            this.pCadastros.Controls.Add(this.btClientes);
            this.pCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCadastros.Location = new System.Drawing.Point(0, 157);
            this.pCadastros.Name = "pCadastros";
            this.pCadastros.Size = new System.Drawing.Size(200, 267);
            this.pCadastros.TabIndex = 2;
            this.pCadastros.Visible = false;
            // 
            // btFiscal
            // 
            this.btFiscal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFiscal.FlatAppearance.BorderSize = 0;
            this.btFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFiscal.ForeColor = System.Drawing.Color.White;
            this.btFiscal.Location = new System.Drawing.Point(0, 200);
            this.btFiscal.Name = "btFiscal";
            this.btFiscal.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btFiscal.Size = new System.Drawing.Size(200, 40);
            this.btFiscal.TabIndex = 5;
            this.btFiscal.Text = "Fiscal";
            this.btFiscal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFiscal.UseVisualStyleBackColor = true;
            this.btFiscal.Click += new System.EventHandler(this.btFiscal_Click);
            // 
            // btProdutos
            // 
            this.btProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btProdutos.FlatAppearance.BorderSize = 0;
            this.btProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProdutos.ForeColor = System.Drawing.Color.White;
            this.btProdutos.Location = new System.Drawing.Point(0, 160);
            this.btProdutos.Name = "btProdutos";
            this.btProdutos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btProdutos.Size = new System.Drawing.Size(200, 40);
            this.btProdutos.TabIndex = 4;
            this.btProdutos.Text = "Produtos";
            this.btProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProdutos.UseVisualStyleBackColor = true;
            this.btProdutos.Click += new System.EventHandler(this.btProdutos_Click);
            // 
            // btTransportadora
            // 
            this.btTransportadora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btTransportadora.FlatAppearance.BorderSize = 0;
            this.btTransportadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTransportadora.ForeColor = System.Drawing.Color.White;
            this.btTransportadora.Location = new System.Drawing.Point(0, 120);
            this.btTransportadora.Name = "btTransportadora";
            this.btTransportadora.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btTransportadora.Size = new System.Drawing.Size(200, 40);
            this.btTransportadora.TabIndex = 3;
            this.btTransportadora.Text = "Transportadora";
            this.btTransportadora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTransportadora.UseVisualStyleBackColor = true;
            this.btTransportadora.Click += new System.EventHandler(this.btTransportadora_Click);
            // 
            // btRepresentante
            // 
            this.btRepresentante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btRepresentante.FlatAppearance.BorderSize = 0;
            this.btRepresentante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRepresentante.ForeColor = System.Drawing.Color.White;
            this.btRepresentante.Location = new System.Drawing.Point(0, 80);
            this.btRepresentante.Name = "btRepresentante";
            this.btRepresentante.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btRepresentante.Size = new System.Drawing.Size(200, 40);
            this.btRepresentante.TabIndex = 2;
            this.btRepresentante.Text = "Representante";
            this.btRepresentante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRepresentante.UseVisualStyleBackColor = true;
            this.btRepresentante.Click += new System.EventHandler(this.btRepresentante_Click);
            // 
            // btFornecedor
            // 
            this.btFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFornecedor.FlatAppearance.BorderSize = 0;
            this.btFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFornecedor.ForeColor = System.Drawing.Color.White;
            this.btFornecedor.Location = new System.Drawing.Point(0, 40);
            this.btFornecedor.Name = "btFornecedor";
            this.btFornecedor.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btFornecedor.Size = new System.Drawing.Size(200, 40);
            this.btFornecedor.TabIndex = 1;
            this.btFornecedor.Text = "Fornecedor";
            this.btFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFornecedor.UseVisualStyleBackColor = true;
            this.btFornecedor.Click += new System.EventHandler(this.btFornecedor_Click);
            // 
            // btClientes
            // 
            this.btClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btClientes.FlatAppearance.BorderSize = 0;
            this.btClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClientes.ForeColor = System.Drawing.Color.White;
            this.btClientes.Location = new System.Drawing.Point(0, 0);
            this.btClientes.Name = "btClientes";
            this.btClientes.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btClientes.Size = new System.Drawing.Size(200, 40);
            this.btClientes.TabIndex = 0;
            this.btClientes.Text = "Clientes";
            this.btClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClientes.UseVisualStyleBackColor = true;
            this.btClientes.Click += new System.EventHandler(this.btClientes_Click);
            // 
            // btPCadastros
            // 
            this.btPCadastros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPCadastros.FlatAppearance.BorderSize = 0;
            this.btPCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btPCadastros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(66)))));
            this.btPCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPCadastros.Location = new System.Drawing.Point(0, 112);
            this.btPCadastros.Name = "btPCadastros";
            this.btPCadastros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btPCadastros.Size = new System.Drawing.Size(200, 45);
            this.btPCadastros.TabIndex = 1;
            this.btPCadastros.Text = "Cadastros";
            this.btPCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPCadastros.UseVisualStyleBackColor = true;
            this.btPCadastros.Click += new System.EventHandler(this.btPCadastros_Click);
            // 
            // pLogo
            // 
            this.pLogo.Controls.Add(this.picMiniLogo);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(200, 112);
            this.pLogo.TabIndex = 0;
            // 
            // picMiniLogo
            // 
            this.picMiniLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMiniLogo.Image = global::ProgramaCSA.Properties.Resources.minilogo;
            this.picMiniLogo.Location = new System.Drawing.Point(0, 0);
            this.picMiniLogo.Name = "picMiniLogo";
            this.picMiniLogo.Size = new System.Drawing.Size(200, 112);
            this.picMiniLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMiniLogo.TabIndex = 0;
            this.picMiniLogo.TabStop = false;
            this.picMiniLogo.Click += new System.EventHandler(this.picMiniLogo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1266, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 603);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(200, 630);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1066, 3);
            this.panel4.TabIndex = 5;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = global::ProgramaCSA.Properties.Resources.logoprojekt;
            this.picLogo.Location = new System.Drawing.Point(200, 30);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(1066, 600);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1269, 633);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pGeral);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekt phoenix";
            this.panel1.ResumeLayout(false);
            this.pGeral.ResumeLayout(false);
            this.pFinanceiro.ResumeLayout(false);
            this.pPedidos.ResumeLayout(false);
            this.pEstoque.ResumeLayout(false);
            this.pCadastros.ResumeLayout(false);
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMiniLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Panel pGeral;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btPCadastros;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Panel pCadastros;
        private System.Windows.Forms.Button btFiscal;
        private System.Windows.Forms.Button btProdutos;
        private System.Windows.Forms.Button btTransportadora;
        private System.Windows.Forms.Button btRepresentante;
        private System.Windows.Forms.Button btFornecedor;
        private System.Windows.Forms.Button btClientes;
        private System.Windows.Forms.Panel pEstoque;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btManutencao;
        private System.Windows.Forms.Button btSaida;
        private System.Windows.Forms.Button btEntrada;
        private System.Windows.Forms.Button btPEstoque;
        private System.Windows.Forms.Panel pFinanceiro;
        private System.Windows.Forms.Button btPFinanceiro;
        private System.Windows.Forms.Panel pPedidos;
        private System.Windows.Forms.Button btConsultarPedido;
        private System.Windows.Forms.Button btPedidosGerais;
        private System.Windows.Forms.Button btFaturamento;
        private System.Windows.Forms.Button btPendentes;
        private System.Windows.Forms.Button btRegistro;
        private System.Windows.Forms.Button btPPedidos;
        private System.Windows.Forms.Button btContasAPagar;
        private System.Windows.Forms.Button btBoletos;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picMiniLogo;
    }
}

