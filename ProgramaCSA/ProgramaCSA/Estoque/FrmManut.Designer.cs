namespace ProgramaCSA.Estoque
{
    partial class FrmManut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManut));
            this.dgvManut = new System.Windows.Forms.DataGridView();
            this.txtIdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLoteProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValidadeProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLocalProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSalvar = new System.Windows.Forms.Button();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.txtFiltro2 = new System.Windows.Forms.TextBox();
            this.txtFiltro1 = new System.Windows.Forms.TextBox();
            this.lblFiltro2 = new System.Windows.Forms.Label();
            this.lblFiltro1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManut)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvManut
            // 
            this.dgvManut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdEstoque,
            this.txtCodigoID,
            this.txtNomeProduto,
            this.txtQt,
            this.txtQtMin,
            this.txtLoteProd,
            this.txtValidadeProd,
            this.txtLocalProd});
            this.dgvManut.Location = new System.Drawing.Point(9, 88);
            this.dgvManut.Name = "dgvManut";
            this.dgvManut.Size = new System.Drawing.Size(954, 399);
            this.dgvManut.TabIndex = 0;
            // 
            // txtIdEstoque
            // 
            this.txtIdEstoque.DataPropertyName = "idEstoque";
            this.txtIdEstoque.HeaderText = "ID";
            this.txtIdEstoque.Name = "txtIdEstoque";
            this.txtIdEstoque.Visible = false;
            // 
            // txtCodigoID
            // 
            this.txtCodigoID.DataPropertyName = "idProdutos";
            this.txtCodigoID.HeaderText = "Código";
            this.txtCodigoID.Name = "txtCodigoID";
            this.txtCodigoID.ReadOnly = true;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.DataPropertyName = "nomeProdutos";
            this.txtNomeProduto.HeaderText = "Produto";
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.ReadOnly = true;
            // 
            // txtQt
            // 
            this.txtQt.DataPropertyName = "qtEstoque";
            this.txtQt.HeaderText = "Quantidade";
            this.txtQt.Name = "txtQt";
            this.txtQt.ReadOnly = true;
            // 
            // txtQtMin
            // 
            this.txtQtMin.DataPropertyName = "qtminProdutos";
            this.txtQtMin.HeaderText = "Qt. Mínima";
            this.txtQtMin.Name = "txtQtMin";
            this.txtQtMin.ReadOnly = true;
            // 
            // txtLoteProd
            // 
            this.txtLoteProd.DataPropertyName = "loteEstoque";
            this.txtLoteProd.HeaderText = "Lote";
            this.txtLoteProd.Name = "txtLoteProd";
            // 
            // txtValidadeProd
            // 
            this.txtValidadeProd.DataPropertyName = "validadeEstoque";
            this.txtValidadeProd.HeaderText = "Validade";
            this.txtValidadeProd.Name = "txtValidadeProd";
            // 
            // txtLocalProd
            // 
            this.txtLocalProd.DataPropertyName = "localEstoque";
            this.txtLocalProd.HeaderText = "Local";
            this.txtLocalProd.Name = "txtLocalProd";
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(9, 493);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 2;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.txtFiltro2);
            this.gbFiltro.Controls.Add(this.txtFiltro1);
            this.gbFiltro.Controls.Add(this.lblFiltro2);
            this.gbFiltro.Controls.Add(this.lblFiltro1);
            this.gbFiltro.Location = new System.Drawing.Point(9, 37);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(208, 45);
            this.gbFiltro.TabIndex = 0;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // txtFiltro2
            // 
            this.txtFiltro2.Location = new System.Drawing.Point(155, 19);
            this.txtFiltro2.MaxLength = 4;
            this.txtFiltro2.Name = "txtFiltro2";
            this.txtFiltro2.Size = new System.Drawing.Size(47, 20);
            this.txtFiltro2.TabIndex = 4;
            this.txtFiltro2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            this.txtFiltro2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Filtro_KeyUp);
            // 
            // txtFiltro1
            // 
            this.txtFiltro1.Location = new System.Drawing.Point(70, 19);
            this.txtFiltro1.MaxLength = 4;
            this.txtFiltro1.Name = "txtFiltro1";
            this.txtFiltro1.Size = new System.Drawing.Size(47, 20);
            this.txtFiltro1.TabIndex = 3;
            this.txtFiltro1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            this.txtFiltro1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Filtro_KeyUp);
            // 
            // lblFiltro2
            // 
            this.lblFiltro2.AutoSize = true;
            this.lblFiltro2.Location = new System.Drawing.Point(123, 22);
            this.lblFiltro2.Name = "lblFiltro2";
            this.lblFiltro2.Size = new System.Drawing.Size(26, 13);
            this.lblFiltro2.TabIndex = 2;
            this.lblFiltro2.Text = "Até:";
            // 
            // lblFiltro1
            // 
            this.lblFiltro1.AutoSize = true;
            this.lblFiltro1.Location = new System.Drawing.Point(6, 22);
            this.lblFiltro1.Name = "lblFiltro1";
            this.lblFiltro1.Size = new System.Drawing.Size(58, 13);
            this.lblFiltro1.TabIndex = 1;
            this.lblFiltro1.Text = "Código de:";
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
            this.panel1.Size = new System.Drawing.Size(972, 30);
            this.panel1.TabIndex = 6;
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
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dados de Estoque";
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
            this.btMin.Location = new System.Drawing.Point(892, 0);
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
            this.btX.Location = new System.Drawing.Point(932, 0);
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
            this.panel2.Size = new System.Drawing.Size(3, 495);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(969, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 495);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 522);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(966, 3);
            this.panel4.TabIndex = 9;
            // 
            // FrmManut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(972, 525);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.dgvManut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Estoque";
            this.Load += new System.EventHandler(this.FrmManut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManut)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManut;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.Label lblFiltro2;
        private System.Windows.Forms.Label lblFiltro1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtFiltro2;
        private System.Windows.Forms.TextBox txtFiltro1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodigoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQt;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQtMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLoteProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtValidadeProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLocalProd;
    }
}