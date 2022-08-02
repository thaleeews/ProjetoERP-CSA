namespace ProgramaCSA.Pedidos
{
    partial class FrmFaturamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturamento));
            this.btConfirmar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblItens = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRepres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.txtProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // btConfirmar
            // 
            this.btConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmar.Location = new System.Drawing.Point(9, 430);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btConfirmar.TabIndex = 2;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
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
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 5;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pedidos a Faturar";
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
            this.btMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btX.ForeColor = System.Drawing.Color.White;
            this.btX.Location = new System.Drawing.Point(760, 0);
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 3);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(797, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 429);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 429);
            this.panel4.TabIndex = 8;
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Location = new System.Drawing.Point(6, 33);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(45, 13);
            this.lblPedidos.TabIndex = 10;
            this.lblPedidos.Text = "Pedidos";
            // 
            // lblItens
            // 
            this.lblItens.AutoSize = true;
            this.lblItens.Location = new System.Drawing.Point(6, 230);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(30, 13);
            this.lblItens.TabIndex = 11;
            this.lblItens.Text = "Itens";
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
            this.dgvPedidos.Location = new System.Drawing.Point(9, 49);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(782, 178);
            this.dgvPedidos.TabIndex = 12;
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
            this.dgvItens.Location = new System.Drawing.Point(9, 246);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.Size = new System.Drawing.Size(782, 178);
            this.dgvItens.TabIndex = 13;
            this.dgvItens.SelectionChanged += new System.EventHandler(this.dgvItens_SelectionChanged);
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
            // FrmFaturamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.lblItens);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFaturamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos a Faturar";
            this.Load += new System.EventHandler(this.FrmFaturamento_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblItens;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRepres;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtData;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrazo;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuant;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSubt;
    }
}