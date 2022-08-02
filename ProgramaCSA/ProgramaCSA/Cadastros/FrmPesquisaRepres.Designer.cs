namespace ProgramaCSA.Cadastros
{
    partial class FrmPesquisaRepres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisaRepres));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRepres = new System.Windows.Forms.DataGridView();
            this.txtIdRepres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRegiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCompl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTel3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFavorecido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAgencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.lblRegiao = new System.Windows.Forms.Label();
            this.cbRegiao = new System.Windows.Forms.ComboBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRepres = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepres)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 482);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 3);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btMin);
            this.panel4.Controls.Add(this.btX);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(984, 30);
            this.panel4.TabIndex = 9;
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btMin
            // 
            this.btMin.BackColor = System.Drawing.Color.Transparent;
            this.btMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(89)))));
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.ForeColor = System.Drawing.Color.White;
            this.btMin.Location = new System.Drawing.Point(904, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(40, 30);
            this.btMin.TabIndex = 1;
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
            this.btX.Location = new System.Drawing.Point(944, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(40, 30);
            this.btX.TabIndex = 0;
            this.btX.Text = "X";
            this.btX.UseVisualStyleBackColor = false;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 452);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(981, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 452);
            this.panel1.TabIndex = 11;
            // 
            // dgvRepres
            // 
            this.dgvRepres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRepres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdRepres,
            this.txtNome,
            this.txtCpf,
            this.txtRg,
            this.txtRegiao,
            this.txtEnd,
            this.txtNumero,
            this.txtCompl,
            this.txtBairro,
            this.txtMunicipio,
            this.txtEstado,
            this.txtCep,
            this.txtTel1,
            this.txtTel2,
            this.txtTel3,
            this.txtEmail,
            this.txtFavorecido,
            this.txtAgencia,
            this.txtConta,
            this.txtBanco});
            this.dgvRepres.Location = new System.Drawing.Point(9, 36);
            this.dgvRepres.Name = "dgvRepres";
            this.dgvRepres.Size = new System.Drawing.Size(966, 333);
            this.dgvRepres.TabIndex = 12;
            this.dgvRepres.DoubleClick += new System.EventHandler(this.dgvRepres_DoubleClick);
            // 
            // txtIdRepres
            // 
            this.txtIdRepres.DataPropertyName = "idRepres";
            this.txtIdRepres.HeaderText = "ID";
            this.txtIdRepres.Name = "txtIdRepres";
            this.txtIdRepres.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.DataPropertyName = "nomeRepres";
            this.txtNome.HeaderText = "Nome";
            this.txtNome.Name = "txtNome";
            // 
            // txtCpf
            // 
            this.txtCpf.DataPropertyName = "cpfRepres";
            this.txtCpf.HeaderText = "CPF";
            this.txtCpf.Name = "txtCpf";
            // 
            // txtRg
            // 
            this.txtRg.DataPropertyName = "rgRepres";
            this.txtRg.HeaderText = "RG";
            this.txtRg.Name = "txtRg";
            // 
            // txtRegiao
            // 
            this.txtRegiao.DataPropertyName = "regiaoRepres";
            this.txtRegiao.HeaderText = "Região";
            this.txtRegiao.Name = "txtRegiao";
            // 
            // txtEnd
            // 
            this.txtEnd.DataPropertyName = "endRepres";
            this.txtEnd.HeaderText = "Endereço";
            this.txtEnd.Name = "txtEnd";
            // 
            // txtNumero
            // 
            this.txtNumero.DataPropertyName = "numeroRepres";
            this.txtNumero.HeaderText = "Número";
            this.txtNumero.Name = "txtNumero";
            // 
            // txtCompl
            // 
            this.txtCompl.DataPropertyName = "complRepres";
            this.txtCompl.HeaderText = "Complemento";
            this.txtCompl.Name = "txtCompl";
            // 
            // txtBairro
            // 
            this.txtBairro.DataPropertyName = "bairroRepres";
            this.txtBairro.HeaderText = "Bairro";
            this.txtBairro.Name = "txtBairro";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.DataPropertyName = "municipioRepres";
            this.txtMunicipio.HeaderText = "Município";
            this.txtMunicipio.Name = "txtMunicipio";
            // 
            // txtEstado
            // 
            this.txtEstado.DataPropertyName = "ufRepres";
            this.txtEstado.HeaderText = "Estado";
            this.txtEstado.Name = "txtEstado";
            // 
            // txtCep
            // 
            this.txtCep.DataPropertyName = "cepRepres";
            this.txtCep.HeaderText = "CEP";
            this.txtCep.Name = "txtCep";
            // 
            // txtTel1
            // 
            this.txtTel1.DataPropertyName = "tel1Repres";
            this.txtTel1.HeaderText = "Telefone 1";
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Visible = false;
            // 
            // txtTel2
            // 
            this.txtTel2.DataPropertyName = "tel2Repres";
            this.txtTel2.HeaderText = "Telefone 2";
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Visible = false;
            // 
            // txtTel3
            // 
            this.txtTel3.DataPropertyName = "tel3Repres";
            this.txtTel3.HeaderText = "Telefone 3";
            this.txtTel3.Name = "txtTel3";
            this.txtTel3.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.DataPropertyName = "emailRepres";
            this.txtEmail.HeaderText = "E-mail";
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Visible = false;
            // 
            // txtFavorecido
            // 
            this.txtFavorecido.DataPropertyName = "favorecidoRepres";
            this.txtFavorecido.HeaderText = "Favorecido";
            this.txtFavorecido.Name = "txtFavorecido";
            this.txtFavorecido.Visible = false;
            // 
            // txtAgencia
            // 
            this.txtAgencia.DataPropertyName = "agenciaRepres";
            this.txtAgencia.HeaderText = "Agência";
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Visible = false;
            // 
            // txtConta
            // 
            this.txtConta.DataPropertyName = "contaRepres";
            this.txtConta.HeaderText = "Conta";
            this.txtConta.Name = "txtConta";
            this.txtConta.Visible = false;
            // 
            // txtBanco
            // 
            this.txtBanco.DataPropertyName = "bancoRepres";
            this.txtBanco.HeaderText = "Banco";
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Visible = false;
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.lblRegiao);
            this.gbFiltro.Controls.Add(this.cbRegiao);
            this.gbFiltro.Controls.Add(this.lblCpf);
            this.gbFiltro.Controls.Add(this.mtxtCpf);
            this.gbFiltro.Controls.Add(this.label2);
            this.gbFiltro.Controls.Add(this.txtRepres);
            this.gbFiltro.Location = new System.Drawing.Point(9, 375);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(491, 98);
            this.gbFiltro.TabIndex = 13;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // lblRegiao
            // 
            this.lblRegiao.AutoSize = true;
            this.lblRegiao.Location = new System.Drawing.Point(6, 74);
            this.lblRegiao.Name = "lblRegiao";
            this.lblRegiao.Size = new System.Drawing.Size(44, 13);
            this.lblRegiao.TabIndex = 5;
            this.lblRegiao.Text = "Região:";
            // 
            // cbRegiao
            // 
            this.cbRegiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegiao.FormattingEnabled = true;
            this.cbRegiao.Location = new System.Drawing.Point(56, 71);
            this.cbRegiao.Name = "cbRegiao";
            this.cbRegiao.Size = new System.Drawing.Size(121, 21);
            this.cbRegiao.TabIndex = 4;
            this.cbRegiao.SelectedIndexChanged += new System.EventHandler(this.cbRegiao_SelectedIndexChanged);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(6, 48);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = "CPF:";
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.Location = new System.Drawing.Point(56, 45);
            this.mtxtCpf.Mask = "000,000,000-00";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(82, 20);
            this.mtxtCpf.TabIndex = 2;
            this.mtxtCpf.Click += new System.EventHandler(this.mtxt_Click);
            this.mtxtCpf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxtCpf_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // txtRepres
            // 
            this.txtRepres.Location = new System.Drawing.Point(56, 19);
            this.txtRepres.Name = "txtRepres";
            this.txtRepres.Size = new System.Drawing.Size(429, 20);
            this.txtRepres.TabIndex = 0;
            this.txtRepres.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRepres_KeyUp);
            // 
            // FrmPesquisaRepres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(984, 485);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.dgvRepres);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPesquisaRepres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.FrmPesquisaRepres_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepres)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRepres;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.Label lblRegiao;
        private System.Windows.Forms.ComboBox cbRegiao;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mtxtCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRepres;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdRepres;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRegiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCompl;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFavorecido;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAgencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBanco;
    }
}