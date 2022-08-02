namespace ProgramaCSA.Cadastros
{
    partial class FrmPesquisaTransp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisaTransp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvTransp = new System.Windows.Forms.DataGridView();
            this.txtIdTransp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomeTransp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCnpjTransp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInscTransp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEndTransp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumeroTransp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtComplTransp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBairroTransp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMunicipioTransp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEstadoTransp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCepTransp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTel1Transp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTel2Transp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmailTransp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.mtxtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransp)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btMin);
            this.panel1.Controls.Add(this.btX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 30);
            this.panel1.TabIndex = 5;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            this.btMin.Location = new System.Drawing.Point(942, 0);
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
            this.btX.Location = new System.Drawing.Point(982, 0);
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
            this.panel2.Size = new System.Drawing.Size(3, 425);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1019, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 425);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 452);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1016, 3);
            this.panel4.TabIndex = 8;
            // 
            // dgvTransp
            // 
            this.dgvTransp.AllowUserToAddRows = false;
            this.dgvTransp.AllowUserToDeleteRows = false;
            this.dgvTransp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTransp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdTransp,
            this.txtNomeTransp,
            this.txtCnpjTransp,
            this.txtInscTransp,
            this.txtEndTransp,
            this.txtNumeroTransp,
            this.txtComplTransp,
            this.txtBairroTransp,
            this.txtMunicipioTransp,
            this.txtEstadoTransp,
            this.txtCepTransp,
            this.txtTel1Transp,
            this.txtTel2Transp,
            this.txtEmailTransp});
            this.dgvTransp.Location = new System.Drawing.Point(9, 36);
            this.dgvTransp.Name = "dgvTransp";
            this.dgvTransp.Size = new System.Drawing.Size(1004, 333);
            this.dgvTransp.TabIndex = 9;
            this.dgvTransp.DoubleClick += new System.EventHandler(this.dgvTransp_DoubleClick);
            // 
            // txtIdTransp
            // 
            this.txtIdTransp.DataPropertyName = "idTransp";
            this.txtIdTransp.HeaderText = "ID";
            this.txtIdTransp.Name = "txtIdTransp";
            this.txtIdTransp.Visible = false;
            // 
            // txtNomeTransp
            // 
            this.txtNomeTransp.DataPropertyName = "nomeTransp";
            this.txtNomeTransp.HeaderText = "Nome";
            this.txtNomeTransp.Name = "txtNomeTransp";
            // 
            // txtCnpjTransp
            // 
            this.txtCnpjTransp.DataPropertyName = "cnpjTransp";
            this.txtCnpjTransp.HeaderText = "CNPJ";
            this.txtCnpjTransp.Name = "txtCnpjTransp";
            // 
            // txtInscTransp
            // 
            this.txtInscTransp.DataPropertyName = "inscTransp";
            this.txtInscTransp.HeaderText = "Inscrição Estadual";
            this.txtInscTransp.Name = "txtInscTransp";
            // 
            // txtEndTransp
            // 
            this.txtEndTransp.DataPropertyName = "endTransp";
            this.txtEndTransp.HeaderText = "Endereço";
            this.txtEndTransp.Name = "txtEndTransp";
            // 
            // txtNumeroTransp
            // 
            this.txtNumeroTransp.DataPropertyName = "numeroTransp";
            this.txtNumeroTransp.HeaderText = "Número";
            this.txtNumeroTransp.Name = "txtNumeroTransp";
            // 
            // txtComplTransp
            // 
            this.txtComplTransp.DataPropertyName = "complTransp";
            this.txtComplTransp.HeaderText = "Complemento";
            this.txtComplTransp.Name = "txtComplTransp";
            // 
            // txtBairroTransp
            // 
            this.txtBairroTransp.DataPropertyName = "bairroTransp";
            this.txtBairroTransp.HeaderText = "Bairro";
            this.txtBairroTransp.Name = "txtBairroTransp";
            // 
            // txtMunicipioTransp
            // 
            this.txtMunicipioTransp.DataPropertyName = "municipioTransp";
            this.txtMunicipioTransp.HeaderText = "Município";
            this.txtMunicipioTransp.Name = "txtMunicipioTransp";
            // 
            // txtEstadoTransp
            // 
            this.txtEstadoTransp.DataPropertyName = "estadoTransp";
            this.txtEstadoTransp.HeaderText = "Estado";
            this.txtEstadoTransp.Name = "txtEstadoTransp";
            // 
            // txtCepTransp
            // 
            this.txtCepTransp.DataPropertyName = "cepTransp";
            this.txtCepTransp.HeaderText = "CEP";
            this.txtCepTransp.Name = "txtCepTransp";
            // 
            // txtTel1Transp
            // 
            this.txtTel1Transp.DataPropertyName = "tel1Transp";
            this.txtTel1Transp.HeaderText = "Telefone 1";
            this.txtTel1Transp.Name = "txtTel1Transp";
            this.txtTel1Transp.Visible = false;
            // 
            // txtTel2Transp
            // 
            this.txtTel2Transp.DataPropertyName = "tel2Transp";
            this.txtTel2Transp.HeaderText = "Telefone 2";
            this.txtTel2Transp.Name = "txtTel2Transp";
            this.txtTel2Transp.Visible = false;
            // 
            // txtEmailTransp
            // 
            this.txtEmailTransp.DataPropertyName = "emailTransp";
            this.txtEmailTransp.HeaderText = "E-mail";
            this.txtEmailTransp.Name = "txtEmailTransp";
            this.txtEmailTransp.Visible = false;
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.mtxtCnpj);
            this.gbFiltro.Controls.Add(this.lblCnpj);
            this.gbFiltro.Controls.Add(this.txtNome);
            this.gbFiltro.Controls.Add(this.lblNome);
            this.gbFiltro.Location = new System.Drawing.Point(9, 375);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(495, 71);
            this.gbFiltro.TabIndex = 10;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // mtxtCnpj
            // 
            this.mtxtCnpj.Location = new System.Drawing.Point(60, 45);
            this.mtxtCnpj.Mask = "00,000,000/0000-00";
            this.mtxtCnpj.Name = "mtxtCnpj";
            this.mtxtCnpj.Size = new System.Drawing.Size(106, 20);
            this.mtxtCnpj.TabIndex = 3;
            this.mtxtCnpj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxtCnpj_KeyUp);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(6, 48);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(37, 13);
            this.lblCnpj.TabIndex = 2;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(60, 19);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(429, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // FrmPesquisaTransp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1022, 455);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.dgvTransp);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPesquisaTransp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.FrmPesquisaTransp_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransp)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvTransp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdTransp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNomeTransp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCnpjTransp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtInscTransp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEndTransp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNumeroTransp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtComplTransp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBairroTransp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMunicipioTransp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEstadoTransp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCepTransp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTel1Transp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTel2Transp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmailTransp;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.MaskedTextBox mtxtCnpj;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}