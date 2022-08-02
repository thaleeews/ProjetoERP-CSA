namespace ProgramaCSA.Pedidos
{
    partial class FrmPendentes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPendentes));
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRepres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblItens = new System.Windows.Forms.Label();
            this.gbAcoes = new System.Windows.Forms.GroupBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAguardar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.gbObservações = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.txtProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.gbAcoes.SuspendLayout();
            this.gbObservações.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtCliente,
            this.txtRepres,
            this.txtTotal,
            this.txtTipo,
            this.txtData,
            this.txtPrazo});
            this.dgvPedidos.Location = new System.Drawing.Point(9, 52);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(836, 231);
            this.dgvPedidos.TabIndex = 0;
            this.dgvPedidos.SelectionChanged += new System.EventHandler(this.dgvPedidos_SelectionChanged);
            // 
            // txtId
            // 
            this.txtId.DataPropertyName = "idPedido";
            this.txtId.HeaderText = "ID";
            this.txtId.Name = "txtId";
            this.txtId.Visible = false;
            // 
            // txtCliente
            // 
            this.txtCliente.DataPropertyName = "nomeClientes";
            this.txtCliente.HeaderText = "Nome do Cliente";
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Width = 101;
            // 
            // txtRepres
            // 
            this.txtRepres.DataPropertyName = "nomeRepres";
            this.txtRepres.HeaderText = "Representante";
            this.txtRepres.Name = "txtRepres";
            this.txtRepres.Width = 102;
            // 
            // txtTotal
            // 
            this.txtTotal.DataPropertyName = "subtotalPedido";
            dataGridViewCellStyle1.Format = "N2";
            this.txtTotal.DefaultCellStyle = dataGridViewCellStyle1;
            this.txtTotal.HeaderText = "Total";
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Width = 56;
            // 
            // txtTipo
            // 
            this.txtTipo.DataPropertyName = "tipoPedido";
            this.txtTipo.HeaderText = "Tipo";
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Width = 53;
            // 
            // txtData
            // 
            this.txtData.DataPropertyName = "dataPedido";
            this.txtData.HeaderText = "Data";
            this.txtData.Name = "txtData";
            this.txtData.Width = 55;
            // 
            // txtPrazo
            // 
            this.txtPrazo.DataPropertyName = "prazoPedido";
            this.txtPrazo.HeaderText = "Prazo";
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Width = 59;
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Location = new System.Drawing.Point(6, 36);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(45, 13);
            this.lblPedidos.TabIndex = 2;
            this.lblPedidos.Text = "Pedidos";
            // 
            // lblItens
            // 
            this.lblItens.AutoSize = true;
            this.lblItens.Location = new System.Drawing.Point(6, 286);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(30, 13);
            this.lblItens.TabIndex = 3;
            this.lblItens.Text = "Itens";
            // 
            // gbAcoes
            // 
            this.gbAcoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbAcoes.Controls.Add(this.btExcluir);
            this.gbAcoes.Controls.Add(this.btAguardar);
            this.gbAcoes.Controls.Add(this.btCancelar);
            this.gbAcoes.Location = new System.Drawing.Point(9, 628);
            this.gbAcoes.Name = "gbAcoes";
            this.gbAcoes.Size = new System.Drawing.Size(312, 49);
            this.gbAcoes.TabIndex = 5;
            this.gbAcoes.TabStop = false;
            this.gbAcoes.Text = "Ações";
            // 
            // btExcluir
            // 
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Location = new System.Drawing.Point(211, 19);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(95, 23);
            this.btExcluir.TabIndex = 2;
            this.btExcluir.Text = "Excluir Faltas";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAguardar
            // 
            this.btAguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAguardar.Location = new System.Drawing.Point(110, 19);
            this.btAguardar.Name = "btAguardar";
            this.btAguardar.Size = new System.Drawing.Size(95, 23);
            this.btAguardar.TabIndex = 1;
            this.btAguardar.Text = "Aguardar Faltas";
            this.btAguardar.UseVisualStyleBackColor = true;
            this.btAguardar.Click += new System.EventHandler(this.btAguardar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Location = new System.Drawing.Point(9, 19);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(95, 23);
            this.btCancelar.TabIndex = 0;
            this.btCancelar.Text = "Cancelar Pedido";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // gbObservações
            // 
            this.gbObservações.Controls.Add(this.txtObs);
            this.gbObservações.Location = new System.Drawing.Point(9, 527);
            this.gbObservações.Name = "gbObservações";
            this.gbObservações.Size = new System.Drawing.Size(836, 95);
            this.gbObservações.TabIndex = 6;
            this.gbObservações.TabStop = false;
            this.gbObservações.Text = "Observações";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(9, 19);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(821, 70);
            this.txtObs.TabIndex = 0;
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
            this.panel1.Size = new System.Drawing.Size(854, 30);
            this.panel1.TabIndex = 7;
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
            this.label1.Text = "Pedidos Pendentes";
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
            this.btMin.Location = new System.Drawing.Point(774, 0);
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
            this.btX.Location = new System.Drawing.Point(814, 0);
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
            this.panel2.Size = new System.Drawing.Size(3, 656);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(851, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 656);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 683);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(848, 3);
            this.panel4.TabIndex = 10;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtProduto,
            this.txtQuant,
            this.txtValor,
            this.txtSubt});
            this.dgvItens.Location = new System.Drawing.Point(9, 302);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.Size = new System.Drawing.Size(836, 219);
            this.dgvItens.TabIndex = 11;
            // 
            // txtProduto
            // 
            this.txtProduto.DataPropertyName = "nomeProdutos";
            this.txtProduto.HeaderText = "Produto";
            this.txtProduto.Name = "txtProduto";
            // 
            // txtQuant
            // 
            this.txtQuant.DataPropertyName = "quantidadeItens";
            this.txtQuant.HeaderText = "Quantidade";
            this.txtQuant.Name = "txtQuant";
            // 
            // txtValor
            // 
            this.txtValor.DataPropertyName = "valorItens";
            dataGridViewCellStyle2.Format = "N2";
            this.txtValor.DefaultCellStyle = dataGridViewCellStyle2;
            this.txtValor.HeaderText = "Valor";
            this.txtValor.Name = "txtValor";
            // 
            // txtSubt
            // 
            this.txtSubt.DataPropertyName = "subtotalItens";
            dataGridViewCellStyle3.Format = "N2";
            this.txtSubt.DefaultCellStyle = dataGridViewCellStyle3;
            this.txtSubt.HeaderText = "Subtotal";
            this.txtSubt.Name = "txtSubt";
            // 
            // FrmPendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(854, 686);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbObservações);
            this.Controls.Add(this.gbAcoes);
            this.Controls.Add(this.lblItens);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.dgvPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPendentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos Pendentes";
            this.Load += new System.EventHandler(this.FrmPendentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.gbAcoes.ResumeLayout(false);
            this.gbObservações.ResumeLayout(false);
            this.gbObservações.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblItens;
        private System.Windows.Forms.GroupBox gbAcoes;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAguardar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.GroupBox gbObservações;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRepres;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtData;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuant;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSubt;
    }
}