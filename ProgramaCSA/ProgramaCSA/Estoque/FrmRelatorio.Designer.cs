namespace ProgramaCSA.Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorio));
            this.dgvRelat = new System.Windows.Forms.DataGridView();
            this.btImprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbLancamento = new System.Windows.Forms.GroupBox();
            this.rbSaidas = new System.Windows.Forms.RadioButton();
            this.rbEntradas = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.dtpData2 = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodo2 = new System.Windows.Forms.Label();
            this.dtpData1 = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodo1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelat)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbLancamento.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRelat
            // 
            this.dgvRelat.AllowUserToAddRows = false;
            this.dgvRelat.AllowUserToDeleteRows = false;
            this.dgvRelat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRelat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtNome,
            this.txtQt,
            this.txtLote,
            this.txtValidade,
            this.txtLocal});
            this.dgvRelat.Location = new System.Drawing.Point(9, 86);
            this.dgvRelat.Name = "dgvRelat";
            this.dgvRelat.Size = new System.Drawing.Size(782, 358);
            this.dgvRelat.TabIndex = 1;
            // 
            // btImprimir
            // 
            this.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImprimir.Location = new System.Drawing.Point(9, 450);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(75, 23);
            this.btImprimir.TabIndex = 2;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btMin);
            this.panel1.Controls.Add(this.btX);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 3;
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
            this.btMin.Location = new System.Drawing.Point(720, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(40, 30);
            this.btMin.TabIndex = 2;
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
            this.btX.TabIndex = 1;
            this.btX.Text = "X";
            this.btX.UseVisualStyleBackColor = false;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório de Estoque";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 452);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(3, 479);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 3);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(797, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 449);
            this.panel4.TabIndex = 6;
            // 
            // gbLancamento
            // 
            this.gbLancamento.Controls.Add(this.rbSaidas);
            this.gbLancamento.Controls.Add(this.rbEntradas);
            this.gbLancamento.Controls.Add(this.rbTodos);
            this.gbLancamento.Location = new System.Drawing.Point(9, 36);
            this.gbLancamento.Name = "gbLancamento";
            this.gbLancamento.Size = new System.Drawing.Size(212, 44);
            this.gbLancamento.TabIndex = 11;
            this.gbLancamento.TabStop = false;
            this.gbLancamento.Text = "Tipo de Lançamento";
            // 
            // rbSaidas
            // 
            this.rbSaidas.AutoSize = true;
            this.rbSaidas.Location = new System.Drawing.Point(140, 19);
            this.rbSaidas.Name = "rbSaidas";
            this.rbSaidas.Size = new System.Drawing.Size(59, 17);
            this.rbSaidas.TabIndex = 2;
            this.rbSaidas.Text = "Saídas";
            this.rbSaidas.UseVisualStyleBackColor = true;
            // 
            // rbEntradas
            // 
            this.rbEntradas.AutoSize = true;
            this.rbEntradas.Location = new System.Drawing.Point(67, 19);
            this.rbEntradas.Name = "rbEntradas";
            this.rbEntradas.Size = new System.Drawing.Size(67, 17);
            this.rbEntradas.TabIndex = 1;
            this.rbEntradas.Text = "Entradas";
            this.rbEntradas.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(6, 19);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.dtpData2);
            this.gbFiltro.Controls.Add(this.lblPeriodo2);
            this.gbFiltro.Controls.Add(this.dtpData1);
            this.gbFiltro.Controls.Add(this.lblPeriodo1);
            this.gbFiltro.Location = new System.Drawing.Point(227, 36);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(267, 44);
            this.gbFiltro.TabIndex = 12;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Período";
            // 
            // dtpData2
            // 
            this.dtpData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData2.Location = new System.Drawing.Point(165, 19);
            this.dtpData2.Name = "dtpData2";
            this.dtpData2.Size = new System.Drawing.Size(96, 20);
            this.dtpData2.TabIndex = 14;
            // 
            // lblPeriodo2
            // 
            this.lblPeriodo2.AutoSize = true;
            this.lblPeriodo2.Location = new System.Drawing.Point(138, 21);
            this.lblPeriodo2.Name = "lblPeriodo2";
            this.lblPeriodo2.Size = new System.Drawing.Size(26, 13);
            this.lblPeriodo2.TabIndex = 5;
            this.lblPeriodo2.Text = "Até:";
            // 
            // dtpData1
            // 
            this.dtpData1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData1.Location = new System.Drawing.Point(36, 19);
            this.dtpData1.Name = "dtpData1";
            this.dtpData1.Size = new System.Drawing.Size(96, 20);
            this.dtpData1.TabIndex = 13;
            // 
            // lblPeriodo1
            // 
            this.lblPeriodo1.AutoSize = true;
            this.lblPeriodo1.Location = new System.Drawing.Point(6, 21);
            this.lblPeriodo1.Name = "lblPeriodo1";
            this.lblPeriodo1.Size = new System.Drawing.Size(24, 13);
            this.lblPeriodo1.TabIndex = 2;
            this.lblPeriodo1.Text = "De:";
            // 
            // txtNome
            // 
            this.txtNome.DataPropertyName = "nomeProdutos";
            this.txtNome.HeaderText = "Produto";
            this.txtNome.Name = "txtNome";
            // 
            // txtQt
            // 
            this.txtQt.DataPropertyName = "qtEstoque";
            this.txtQt.HeaderText = "Quantidade";
            this.txtQt.Name = "txtQt";
            // 
            // txtLote
            // 
            this.txtLote.DataPropertyName = "loteEstoque";
            this.txtLote.HeaderText = "Lote";
            this.txtLote.Name = "txtLote";
            // 
            // txtValidade
            // 
            this.txtValidade.DataPropertyName = "validadeEstoque";
            this.txtValidade.HeaderText = "Validade";
            this.txtValidade.Name = "txtValidade";
            // 
            // txtLocal
            // 
            this.txtLocal.DataPropertyName = "localEstoque";
            this.txtLocal.HeaderText = "Local";
            this.txtLocal.Name = "txtLocal";
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.gbLancamento);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.dgvRelat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Estoque";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbLancamento.ResumeLayout(false);
            this.gbLancamento.PerformLayout();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRelat;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gbLancamento;
        private System.Windows.Forms.RadioButton rbSaidas;
        private System.Windows.Forms.RadioButton rbEntradas;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.DateTimePicker dtpData2;
        private System.Windows.Forms.Label lblPeriodo2;
        private System.Windows.Forms.DateTimePicker dtpData1;
        private System.Windows.Forms.Label lblPeriodo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQt;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtValidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLocal;
    }
}