namespace ProgramaCSA.Cadastros
{
    partial class FrmPesquisaForn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisaForn));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.dgvForn = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInscr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.mtxtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 452);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 3);
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
            this.panel4.Size = new System.Drawing.Size(800, 30);
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
            this.btMin.Location = new System.Drawing.Point(720, 0);
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
            this.btX.Location = new System.Drawing.Point(760, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(40, 30);
            this.btX.TabIndex = 0;
            this.btX.Text = "X";
            this.btX.UseVisualStyleBackColor = false;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // dgvForn
            // 
            this.dgvForn.AllowUserToAddRows = false;
            this.dgvForn.AllowUserToDeleteRows = false;
            this.dgvForn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtNome,
            this.txtCnpj,
            this.txtInscr,
            this.txtEndereco,
            this.txtNumero,
            this.txtCompl,
            this.txtBairro,
            this.txtMunicipio,
            this.txtEstado,
            this.txtCep,
            this.txtTel1,
            this.txtTel2,
            this.txtTel3,
            this.txtEmail});
            this.dgvForn.Location = new System.Drawing.Point(9, 36);
            this.dgvForn.Name = "dgvForn";
            this.dgvForn.Size = new System.Drawing.Size(782, 333);
            this.dgvForn.TabIndex = 10;
            this.dgvForn.DoubleClick += new System.EventHandler(this.dgvForn_DoubleClick);
            // 
            // txtId
            // 
            this.txtId.DataPropertyName = "idForn";
            this.txtId.HeaderText = "ID";
            this.txtId.Name = "txtId";
            this.txtId.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.DataPropertyName = "nomeForn";
            this.txtNome.HeaderText = "Razão Social";
            this.txtNome.Name = "txtNome";
            this.txtNome.Width = 95;
            // 
            // txtCnpj
            // 
            this.txtCnpj.DataPropertyName = "cnpjForn";
            this.txtCnpj.HeaderText = "CNPJ";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Width = 59;
            // 
            // txtInscr
            // 
            this.txtInscr.DataPropertyName = "inscrForn";
            this.txtInscr.HeaderText = "Inscrição";
            this.txtInscr.Name = "txtInscr";
            this.txtInscr.Width = 75;
            // 
            // txtEndereco
            // 
            this.txtEndereco.DataPropertyName = "endForn";
            this.txtEndereco.HeaderText = "Endereço";
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Width = 78;
            // 
            // txtNumero
            // 
            this.txtNumero.DataPropertyName = "numeroForn";
            this.txtNumero.HeaderText = "Número";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Width = 69;
            // 
            // txtCompl
            // 
            this.txtCompl.DataPropertyName = "complForn";
            this.txtCompl.HeaderText = "Complemento";
            this.txtCompl.Name = "txtCompl";
            this.txtCompl.Width = 96;
            // 
            // txtBairro
            // 
            this.txtBairro.DataPropertyName = "bairroForn";
            this.txtBairro.HeaderText = "Bairro";
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Width = 59;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.DataPropertyName = "municipioForn";
            this.txtMunicipio.HeaderText = "Município";
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Width = 79;
            // 
            // txtEstado
            // 
            this.txtEstado.DataPropertyName = "estadoForn";
            this.txtEstado.HeaderText = "Estado";
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Width = 65;
            // 
            // txtCep
            // 
            this.txtCep.DataPropertyName = "cepForn";
            this.txtCep.HeaderText = "CEP";
            this.txtCep.Name = "txtCep";
            this.txtCep.Width = 53;
            // 
            // txtTel1
            // 
            this.txtTel1.DataPropertyName = "tel1Forn";
            this.txtTel1.HeaderText = "Telefone 1";
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Visible = false;
            // 
            // txtTel2
            // 
            this.txtTel2.DataPropertyName = "tel2Forn";
            this.txtTel2.HeaderText = "Telefone 2";
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Visible = false;
            // 
            // txtTel3
            // 
            this.txtTel3.DataPropertyName = "tel3Forn";
            this.txtTel3.HeaderText = "Telefone 3";
            this.txtTel3.Name = "txtTel3";
            this.txtTel3.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.DataPropertyName = "emailForn";
            this.txtEmail.HeaderText = "E-mail";
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Visible = false;
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.mtxtCnpj);
            this.gbFiltro.Controls.Add(this.txtRazao);
            this.gbFiltro.Controls.Add(this.lblNome);
            this.gbFiltro.Controls.Add(this.lblCnpj);
            this.gbFiltro.Location = new System.Drawing.Point(9, 375);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(461, 71);
            this.gbFiltro.TabIndex = 11;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // mtxtCnpj
            // 
            this.mtxtCnpj.Location = new System.Drawing.Point(85, 45);
            this.mtxtCnpj.Mask = "00,000,000/0000-00";
            this.mtxtCnpj.Name = "mtxtCnpj";
            this.mtxtCnpj.Size = new System.Drawing.Size(105, 20);
            this.mtxtCnpj.TabIndex = 3;
            this.mtxtCnpj.Click += new System.EventHandler(this.mtxt_Click);
            this.mtxtCnpj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxtCnpj_KeyUp);
            // 
            // txtRazao
            // 
            this.txtRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazao.Location = new System.Drawing.Point(85, 19);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(370, 20);
            this.txtRazao.TabIndex = 2;
            this.txtRazao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRazao_KeyUp);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(73, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Razão Social:";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(6, 48);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(62, 13);
            this.lblCnpj.TabIndex = 0;
            this.lblCnpj.Text = "CNPJ/CPF:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 422);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(797, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 422);
            this.panel2.TabIndex = 13;
            // 
            // FrmPesquisaForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.dgvForn);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPesquisaForn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.FrmPesquisaForn_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvForn;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtInscr;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEndereco;
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
        private System.Windows.Forms.MaskedTextBox mtxtCnpj;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}