namespace ProgramaCSA.Financeiro
{
    partial class FrmBaixaTit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaixaTit));
            this.btSalvar = new System.Windows.Forms.Button();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpComeco = new System.Windows.Forms.DateTimePicker();
            this.lblFim = new System.Windows.Forms.Label();
            this.lblComeco = new System.Windows.Forms.Label();
            this.dgvBaixa = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(12, 524);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 10;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.dtpFim);
            this.gbFiltro.Controls.Add(this.dtpComeco);
            this.gbFiltro.Controls.Add(this.lblFim);
            this.gbFiltro.Controls.Add(this.lblComeco);
            this.gbFiltro.Location = new System.Drawing.Point(12, 12);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(334, 45);
            this.gbFiltro.TabIndex = 12;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(232, 19);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(96, 20);
            this.dtpFim.TabIndex = 5;
            this.dtpFim.ValueChanged += new System.EventHandler(this.dtpFim_ValueChanged);
            // 
            // dtpComeco
            // 
            this.dtpComeco.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpComeco.Location = new System.Drawing.Point(98, 19);
            this.dtpComeco.Name = "dtpComeco";
            this.dtpComeco.Size = new System.Drawing.Size(96, 20);
            this.dtpComeco.TabIndex = 4;
            this.dtpComeco.ValueChanged += new System.EventHandler(this.dtpComeco_ValueChanged);
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Location = new System.Drawing.Point(200, 22);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(26, 13);
            this.lblFim.TabIndex = 3;
            this.lblFim.Text = "Até:";
            // 
            // lblComeco
            // 
            this.lblComeco.AutoSize = true;
            this.lblComeco.Location = new System.Drawing.Point(6, 22);
            this.lblComeco.Name = "lblComeco";
            this.lblComeco.Size = new System.Drawing.Size(86, 13);
            this.lblComeco.TabIndex = 2;
            this.lblComeco.Text = "Vencimentos de:";
            // 
            // dgvBaixa
            // 
            this.dgvBaixa.AllowUserToAddRows = false;
            this.dgvBaixa.AllowUserToDeleteRows = false;
            this.dgvBaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtDescricao,
            this.txtDocumento,
            this.txtValor,
            this.txtVencimento,
            this.txtStatus,
            this.txtPagamento,
            this.txtBanco});
            this.dgvBaixa.Location = new System.Drawing.Point(12, 63);
            this.dgvBaixa.Name = "dgvBaixa";
            this.dgvBaixa.Size = new System.Drawing.Size(999, 455);
            this.dgvBaixa.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.DataPropertyName = "idContas";
            this.txtId.HeaderText = "ID";
            this.txtId.Name = "txtId";
            this.txtId.Visible = false;
            this.txtId.Width = 43;
            // 
            // txtDescricao
            // 
            this.txtDescricao.DataPropertyName = "descrContas";
            this.txtDescricao.HeaderText = "Descrição";
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Width = 80;
            // 
            // txtDocumento
            // 
            this.txtDocumento.DataPropertyName = "valorContas";
            this.txtDocumento.HeaderText = "Documento";
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Width = 87;
            // 
            // txtValor
            // 
            this.txtValor.DataPropertyName = "valorContas";
            dataGridViewCellStyle1.Format = "N2";
            this.txtValor.DefaultCellStyle = dataGridViewCellStyle1;
            this.txtValor.HeaderText = "Valor";
            this.txtValor.Name = "txtValor";
            this.txtValor.Width = 56;
            // 
            // txtVencimento
            // 
            this.txtVencimento.DataPropertyName = "vencimentoContas";
            this.txtVencimento.HeaderText = "Vencimento";
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Width = 88;
            // 
            // txtStatus
            // 
            this.txtStatus.DataPropertyName = "statusContas";
            this.txtStatus.HeaderText = "Status";
            this.txtStatus.Items.AddRange(new object[] {
            "EM ABERTO",
            "FECHADO",
            ""});
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.txtStatus.Width = 62;
            // 
            // txtPagamento
            // 
            this.txtPagamento.DataPropertyName = "pagamentoContas";
            this.txtPagamento.HeaderText = "Pagamento";
            this.txtPagamento.MaxInputLength = 10;
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Width = 86;
            // 
            // txtBanco
            // 
            this.txtBanco.DataPropertyName = "bancoContas";
            this.txtBanco.HeaderText = "Banco";
            this.txtBanco.MaxInputLength = 50;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Width = 63;
            // 
            // FrmBaixaTit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1023, 559);
            this.Controls.Add(this.dgvBaixa);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.btSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBaixaTit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "/";
            this.Load += new System.EventHandler(this.FrmBaixaTit_Load);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaixa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpComeco;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Label lblComeco;
        private System.Windows.Forms.DataGridView dgvBaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtVencimento;
        private System.Windows.Forms.DataGridViewComboBoxColumn txtStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBanco;
    }
}