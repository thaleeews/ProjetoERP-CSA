namespace ProgramaCSA.Financeiro
{
    partial class FrmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorio));
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.lblFim = new System.Windows.Forms.Label();
            this.lblComeco = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpComeco = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dgvRelat = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btImprimir = new System.Windows.Forms.Button();
            this.gbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelat)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.lblFim);
            this.gbFiltro.Controls.Add(this.lblComeco);
            this.gbFiltro.Controls.Add(this.dtpFim);
            this.gbFiltro.Controls.Add(this.dtpComeco);
            this.gbFiltro.Controls.Add(this.lblStatus);
            this.gbFiltro.Controls.Add(this.cbStatus);
            this.gbFiltro.Location = new System.Drawing.Point(12, 12);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(332, 72);
            this.gbFiltro.TabIndex = 11;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Location = new System.Drawing.Point(199, 49);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(26, 13);
            this.lblFim.TabIndex = 16;
            this.lblFim.Text = "Até:";
            // 
            // lblComeco
            // 
            this.lblComeco.AutoSize = true;
            this.lblComeco.Location = new System.Drawing.Point(6, 49);
            this.lblComeco.Name = "lblComeco";
            this.lblComeco.Size = new System.Drawing.Size(86, 13);
            this.lblComeco.TabIndex = 15;
            this.lblComeco.Text = "Vencimentos de:";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(231, 46);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(95, 20);
            this.dtpFim.TabIndex = 14;
            this.dtpFim.ValueChanged += new System.EventHandler(this.dtpFim_ValueChanged);
            // 
            // dtpComeco
            // 
            this.dtpComeco.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpComeco.Location = new System.Drawing.Point(98, 46);
            this.dtpComeco.Name = "dtpComeco";
            this.dtpComeco.Size = new System.Drawing.Size(95, 20);
            this.dtpComeco.TabIndex = 13;
            this.dtpComeco.ValueChanged += new System.EventHandler(this.dtpComeco_ValueChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 22);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "EM ABERTO",
            "FECHADO",
            ""});
            this.cbStatus.Location = new System.Drawing.Point(52, 19);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 0;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // dgvRelat
            // 
            this.dgvRelat.AllowUserToAddRows = false;
            this.dgvRelat.AllowUserToDeleteRows = false;
            this.dgvRelat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvRelat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtDescricao,
            this.txtDocumento,
            this.txtValor,
            this.txtVencimento,
            this.txtStatus,
            this.txtPagamento,
            this.txtBanco});
            this.dgvRelat.Location = new System.Drawing.Point(12, 90);
            this.dgvRelat.Name = "dgvRelat";
            this.dgvRelat.Size = new System.Drawing.Size(999, 428);
            this.dgvRelat.TabIndex = 12;
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
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Width = 62;
            // 
            // txtPagamento
            // 
            this.txtPagamento.DataPropertyName = "pagamentoContas";
            this.txtPagamento.HeaderText = "Pagamento";
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Width = 86;
            // 
            // txtBanco
            // 
            this.txtBanco.DataPropertyName = "bancoContas";
            this.txtBanco.HeaderText = "Banco";
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Width = 63;
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImprimir.Location = new System.Drawing.Point(936, 524);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(75, 23);
            this.btImprimir.TabIndex = 13;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1023, 559);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.dgvRelat);
            this.Controls.Add(this.gbFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Contas";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dtpComeco;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Label lblComeco;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DataGridView dgvRelat;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBanco;
    }
}