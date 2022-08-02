namespace ProgramaCSA.Financeiro
{
    partial class FrmLancamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLancamentos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblVenc = new System.Windows.Forms.Label();
            this.dtpVenc = new System.Windows.Forms.DateTimePicker();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.mtxtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblDocum = new System.Windows.Forms.Label();
            this.txtDocum = new System.Windows.Forms.TextBox();
            this.lblForn = new System.Windows.Forms.Label();
            this.cbForn = new System.Windows.Forms.ComboBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lblSalvo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblDesc);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.lblVenc);
            this.groupBox1.Controls.Add(this.dtpVenc);
            this.groupBox1.Controls.Add(this.lblCnpj);
            this.groupBox1.Controls.Add(this.mtxtCnpj);
            this.groupBox1.Controls.Add(this.lblDocum);
            this.groupBox1.Controls.Add(this.txtDocum);
            this.groupBox1.Controls.Add(this.lblForn);
            this.groupBox1.Controls.Add(this.cbForn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(6, 75);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(58, 13);
            this.lblDesc.TabIndex = 11;
            this.lblDesc.Text = "Descrição:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(77, 72);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(450, 20);
            this.txtDesc.TabIndex = 10;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(275, 98);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(78, 20);
            this.txtValor.TabIndex = 9;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(235, 101);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 8;
            this.lblValor.Text = "Valor:";
            // 
            // lblVenc
            // 
            this.lblVenc.AutoSize = true;
            this.lblVenc.Location = new System.Drawing.Point(359, 101);
            this.lblVenc.Name = "lblVenc";
            this.lblVenc.Size = new System.Drawing.Size(66, 13);
            this.lblVenc.TabIndex = 7;
            this.lblVenc.Text = "Vencimento:";
            // 
            // dtpVenc
            // 
            this.dtpVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVenc.Location = new System.Drawing.Point(431, 98);
            this.dtpVenc.Name = "dtpVenc";
            this.dtpVenc.Size = new System.Drawing.Size(96, 20);
            this.dtpVenc.TabIndex = 6;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(6, 49);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(37, 13);
            this.lblCnpj.TabIndex = 5;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // mtxtCnpj
            // 
            this.mtxtCnpj.Location = new System.Drawing.Point(77, 46);
            this.mtxtCnpj.Mask = "00,000,000/0000-00";
            this.mtxtCnpj.Name = "mtxtCnpj";
            this.mtxtCnpj.Size = new System.Drawing.Size(106, 20);
            this.mtxtCnpj.TabIndex = 4;
            this.mtxtCnpj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxtCnpj_KeyUp);
            this.mtxtCnpj.Leave += new System.EventHandler(this.mtxtCnpj_Leave);
            // 
            // lblDocum
            // 
            this.lblDocum.AutoSize = true;
            this.lblDocum.Location = new System.Drawing.Point(6, 101);
            this.lblDocum.Name = "lblDocum";
            this.lblDocum.Size = new System.Drawing.Size(65, 13);
            this.lblDocum.TabIndex = 3;
            this.lblDocum.Text = "Documento:";
            // 
            // txtDocum
            // 
            this.txtDocum.Location = new System.Drawing.Point(77, 98);
            this.txtDocum.Name = "txtDocum";
            this.txtDocum.Size = new System.Drawing.Size(152, 20);
            this.txtDocum.TabIndex = 2;
            // 
            // lblForn
            // 
            this.lblForn.AutoSize = true;
            this.lblForn.Location = new System.Drawing.Point(6, 22);
            this.lblForn.Name = "lblForn";
            this.lblForn.Size = new System.Drawing.Size(64, 13);
            this.lblForn.TabIndex = 1;
            this.lblForn.Text = "Fornecedor:";
            // 
            // cbForn
            // 
            this.cbForn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbForn.FormattingEnabled = true;
            this.cbForn.Location = new System.Drawing.Point(77, 19);
            this.cbForn.Name = "cbForn";
            this.cbForn.Size = new System.Drawing.Size(450, 21);
            this.cbForn.TabIndex = 0;
            this.cbForn.SelectedIndexChanged += new System.EventHandler(this.cbForn_SelectedIndexChanged);
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(12, 142);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 5;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Location = new System.Drawing.Point(470, 142);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 6;
            this.btLimpar.Text = "Limpar Tela";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lblSalvo
            // 
            this.lblSalvo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalvo.AutoSize = true;
            this.lblSalvo.ForeColor = System.Drawing.Color.Green;
            this.lblSalvo.Location = new System.Drawing.Point(93, 147);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(73, 13);
            this.lblSalvo.TabIndex = 21;
            this.lblSalvo.Text = "Dados Salvos";
            this.lblSalvo.Visible = false;
            // 
            // FrmLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(557, 177);
            this.Controls.Add(this.lblSalvo);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLancamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de Títulos";
            this.Load += new System.EventHandler(this.FrmLancamentos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblVenc;
        private System.Windows.Forms.DateTimePicker dtpVenc;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.MaskedTextBox mtxtCnpj;
        private System.Windows.Forms.Label lblDocum;
        private System.Windows.Forms.TextBox txtDocum;
        private System.Windows.Forms.Label lblForn;
        private System.Windows.Forms.ComboBox cbForn;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lblSalvo;
    }
}