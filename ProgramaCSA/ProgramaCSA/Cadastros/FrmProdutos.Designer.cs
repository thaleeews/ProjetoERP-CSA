namespace ProgramaCSA.Cadastros
{
    partial class FrmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            this.btSalvar = new System.Windows.Forms.Button();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.mtxtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.lblLinha = new System.Windows.Forms.Label();
            this.cbLinha = new System.Windows.Forms.ComboBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.gbFiscal = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.txtBarras = new System.Windows.Forms.TextBox();
            this.lblBarras = new System.Windows.Forms.Label();
            this.lblNCM = new System.Windows.Forms.Label();
            this.mtxtNCM = new System.Windows.Forms.MaskedTextBox();
            this.gbEstoque = new System.Windows.Forms.GroupBox();
            this.txtQtAtual = new System.Windows.Forms.TextBox();
            this.lblQtAtual = new System.Windows.Forms.Label();
            this.txtQtIdeal = new System.Windows.Forms.TextBox();
            this.lblQtIdeal = new System.Windows.Forms.Label();
            this.lblQtMin = new System.Windows.Forms.Label();
            this.txtQtMin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.lblSalvo = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.gbDados.SuspendLayout();
            this.gbFiscal.SuspendLayout();
            this.gbEstoque.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(9, 269);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 3;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.lblCodigo);
            this.gbDados.Controls.Add(this.mtxtCodigo);
            this.gbDados.Controls.Add(this.lblLinha);
            this.gbDados.Controls.Add(this.cbLinha);
            this.gbDados.Controls.Add(this.txtProduto);
            this.gbDados.Controls.Add(this.lblProduto);
            this.gbDados.Location = new System.Drawing.Point(9, 36);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(508, 98);
            this.gbDados.TabIndex = 0;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 75);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "Código:";
            // 
            // mtxtCodigo
            // 
            this.mtxtCodigo.Location = new System.Drawing.Point(76, 72);
            this.mtxtCodigo.Mask = "000,000";
            this.mtxtCodigo.Name = "mtxtCodigo";
            this.mtxtCodigo.Size = new System.Drawing.Size(47, 20);
            this.mtxtCodigo.TabIndex = 2;
            this.mtxtCodigo.Click += new System.EventHandler(this.mtxtCodigo_Click);
            // 
            // lblLinha
            // 
            this.lblLinha.AutoSize = true;
            this.lblLinha.Location = new System.Drawing.Point(6, 48);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(36, 13);
            this.lblLinha.TabIndex = 4;
            this.lblLinha.Text = "Linha:";
            // 
            // cbLinha
            // 
            this.cbLinha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLinha.FormattingEnabled = true;
            this.cbLinha.Items.AddRange(new object[] {
            "LUMINOSITTÀ",
            "MAXILLURING",
            ""});
            this.cbLinha.Location = new System.Drawing.Point(76, 45);
            this.cbLinha.Name = "cbLinha";
            this.cbLinha.Size = new System.Drawing.Size(121, 21);
            this.cbLinha.TabIndex = 1;
            // 
            // txtProduto
            // 
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Location = new System.Drawing.Point(76, 19);
            this.txtProduto.MaxLength = 60;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(426, 20);
            this.txtProduto.TabIndex = 0;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(6, 22);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 2;
            this.lblProduto.Text = "Produto:";
            // 
            // gbFiscal
            // 
            this.gbFiscal.Controls.Add(this.txtValor);
            this.gbFiscal.Controls.Add(this.lblValor);
            this.gbFiscal.Controls.Add(this.lblTipo);
            this.gbFiscal.Controls.Add(this.cbTipo);
            this.gbFiscal.Controls.Add(this.txtBarras);
            this.gbFiscal.Controls.Add(this.lblBarras);
            this.gbFiscal.Controls.Add(this.lblNCM);
            this.gbFiscal.Controls.Add(this.mtxtNCM);
            this.gbFiscal.Location = new System.Drawing.Point(9, 140);
            this.gbFiscal.Name = "gbFiscal";
            this.gbFiscal.Size = new System.Drawing.Size(508, 72);
            this.gbFiscal.TabIndex = 1;
            this.gbFiscal.TabStop = false;
            this.gbFiscal.Text = "Fiscal";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(210, 19);
            this.txtValor.MaxLength = 7;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(75, 20);
            this.txtValor.TabIndex = 1;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(115, 22);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(89, 13);
            this.lblValor.TabIndex = 10;
            this.lblValor.Text = "Valor do Produto:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 48);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "ÁGUA OXIGENADA (INFERIOR A 500ML)",
            "ÁGUA OXIGENADA (SUPERIOR A 500ML)",
            "CONDICIONADOR",
            "SHAMPOO",
            "TINTURA",
            ""});
            this.cbTipo.Location = new System.Drawing.Point(46, 45);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(239, 21);
            this.cbTipo.TabIndex = 3;
            // 
            // txtBarras
            // 
            this.txtBarras.Location = new System.Drawing.Point(388, 19);
            this.txtBarras.MaxLength = 13;
            this.txtBarras.Name = "txtBarras";
            this.txtBarras.Size = new System.Drawing.Size(114, 20);
            this.txtBarras.TabIndex = 2;
            this.txtBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarras_KeyPress);
            // 
            // lblBarras
            // 
            this.lblBarras.AutoSize = true;
            this.lblBarras.Location = new System.Drawing.Point(291, 22);
            this.lblBarras.Name = "lblBarras";
            this.lblBarras.Size = new System.Drawing.Size(91, 13);
            this.lblBarras.TabIndex = 6;
            this.lblBarras.Text = "Código de Barras:";
            // 
            // lblNCM
            // 
            this.lblNCM.AutoSize = true;
            this.lblNCM.Location = new System.Drawing.Point(6, 22);
            this.lblNCM.Name = "lblNCM";
            this.lblNCM.Size = new System.Drawing.Size(34, 13);
            this.lblNCM.TabIndex = 7;
            this.lblNCM.Text = "NCM:";
            // 
            // mtxtNCM
            // 
            this.mtxtNCM.Location = new System.Drawing.Point(46, 19);
            this.mtxtNCM.Mask = "0000,00,00";
            this.mtxtNCM.Name = "mtxtNCM";
            this.mtxtNCM.Size = new System.Drawing.Size(63, 20);
            this.mtxtNCM.TabIndex = 0;
            this.mtxtNCM.Click += new System.EventHandler(this.mtxtNCM_Click);
            // 
            // gbEstoque
            // 
            this.gbEstoque.Controls.Add(this.txtQtAtual);
            this.gbEstoque.Controls.Add(this.lblQtAtual);
            this.gbEstoque.Controls.Add(this.txtQtIdeal);
            this.gbEstoque.Controls.Add(this.lblQtIdeal);
            this.gbEstoque.Controls.Add(this.lblQtMin);
            this.gbEstoque.Controls.Add(this.txtQtMin);
            this.gbEstoque.Location = new System.Drawing.Point(9, 218);
            this.gbEstoque.Name = "gbEstoque";
            this.gbEstoque.Size = new System.Drawing.Size(508, 45);
            this.gbEstoque.TabIndex = 2;
            this.gbEstoque.TabStop = false;
            this.gbEstoque.Text = "Quantidades";
            // 
            // txtQtAtual
            // 
            this.txtQtAtual.Location = new System.Drawing.Point(312, 19);
            this.txtQtAtual.MaxLength = 5;
            this.txtQtAtual.Name = "txtQtAtual";
            this.txtQtAtual.Size = new System.Drawing.Size(82, 20);
            this.txtQtAtual.TabIndex = 2;
            this.txtQtAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarras_KeyPress);
            // 
            // lblQtAtual
            // 
            this.lblQtAtual.AutoSize = true;
            this.lblQtAtual.Location = new System.Drawing.Point(272, 22);
            this.lblQtAtual.Name = "lblQtAtual";
            this.lblQtAtual.Size = new System.Drawing.Size(34, 13);
            this.lblQtAtual.TabIndex = 4;
            this.lblQtAtual.Text = "Atual:";
            // 
            // txtQtIdeal
            // 
            this.txtQtIdeal.Location = new System.Drawing.Point(184, 19);
            this.txtQtIdeal.MaxLength = 5;
            this.txtQtIdeal.Name = "txtQtIdeal";
            this.txtQtIdeal.Size = new System.Drawing.Size(82, 20);
            this.txtQtIdeal.TabIndex = 1;
            this.txtQtIdeal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarras_KeyPress);
            // 
            // lblQtIdeal
            // 
            this.lblQtIdeal.AutoSize = true;
            this.lblQtIdeal.Location = new System.Drawing.Point(145, 22);
            this.lblQtIdeal.Name = "lblQtIdeal";
            this.lblQtIdeal.Size = new System.Drawing.Size(33, 13);
            this.lblQtIdeal.TabIndex = 2;
            this.lblQtIdeal.Text = "Ideal:";
            // 
            // lblQtMin
            // 
            this.lblQtMin.AutoSize = true;
            this.lblQtMin.Location = new System.Drawing.Point(6, 22);
            this.lblQtMin.Name = "lblQtMin";
            this.lblQtMin.Size = new System.Drawing.Size(45, 13);
            this.lblQtMin.TabIndex = 1;
            this.lblQtMin.Text = "Mínima:";
            // 
            // txtQtMin
            // 
            this.txtQtMin.Location = new System.Drawing.Point(57, 19);
            this.txtQtMin.MaxLength = 5;
            this.txtQtMin.Name = "txtQtMin";
            this.txtQtMin.Size = new System.Drawing.Size(82, 20);
            this.txtQtMin.TabIndex = 0;
            this.txtQtMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarras_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btMin);
            this.panel1.Controls.Add(this.btX);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 30);
            this.panel1.TabIndex = 4;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btMin
            // 
            this.btMin.BackColor = System.Drawing.Color.Transparent;
            this.btMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(89)))));
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.ForeColor = System.Drawing.Color.White;
            this.btMin.Location = new System.Drawing.Point(446, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(40, 30);
            this.btMin.TabIndex = 9;
            this.btMin.Text = "_";
            this.btMin.UseVisualStyleBackColor = false;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // btX
            // 
            this.btX.BackColor = System.Drawing.Color.Transparent;
            this.btX.Dock = System.Windows.Forms.DockStyle.Right;
            this.btX.FlatAppearance.BorderSize = 0;
            this.btX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(22)))));
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.ForeColor = System.Drawing.Color.White;
            this.btX.Location = new System.Drawing.Point(486, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(40, 30);
            this.btX.TabIndex = 8;
            this.btX.Text = "X";
            this.btX.UseVisualStyleBackColor = false;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(150, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cadastro de Produtos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 3);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(523, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 268);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 268);
            this.panel4.TabIndex = 7;
            // 
            // btLimpar
            // 
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Location = new System.Drawing.Point(361, 269);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar Tela";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Location = new System.Drawing.Point(442, 269);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 9;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // lblSalvo
            // 
            this.lblSalvo.AutoSize = true;
            this.lblSalvo.ForeColor = System.Drawing.Color.Green;
            this.lblSalvo.Location = new System.Drawing.Point(171, 274);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(73, 13);
            this.lblSalvo.TabIndex = 21;
            this.lblSalvo.Text = "Dados Salvos";
            this.lblSalvo.Visible = false;
            // 
            // btExcluir
            // 
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Location = new System.Drawing.Point(90, 269);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 22;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(526, 301);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.lblSalvo);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbEstoque);
            this.Controls.Add(this.gbFiscal);
            this.Controls.Add(this.gbDados);
            this.Controls.Add(this.btSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.gbFiscal.ResumeLayout(false);
            this.gbFiscal.PerformLayout();
            this.gbEstoque.ResumeLayout(false);
            this.gbEstoque.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.ComboBox cbLinha;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.MaskedTextBox mtxtCodigo;
        private System.Windows.Forms.GroupBox gbFiscal;
        private System.Windows.Forms.Label lblNCM;
        private System.Windows.Forms.MaskedTextBox mtxtNCM;
        private System.Windows.Forms.TextBox txtBarras;
        private System.Windows.Forms.Label lblBarras;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox gbEstoque;
        private System.Windows.Forms.TextBox txtQtAtual;
        private System.Windows.Forms.Label lblQtAtual;
        private System.Windows.Forms.TextBox txtQtIdeal;
        private System.Windows.Forms.Label lblQtIdeal;
        private System.Windows.Forms.Label lblQtMin;
        private System.Windows.Forms.TextBox txtQtMin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Label lblSalvo;
        private System.Windows.Forms.Button btExcluir;
    }
}