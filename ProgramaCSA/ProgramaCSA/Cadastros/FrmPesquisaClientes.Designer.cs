namespace ProgramaCSA.Cadastros
{
    partial class FrmPesquisaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisaClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtIdClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomeClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCnpjClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEnderecoClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumeroClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtComplClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBairroClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMunicipioClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEstadoClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCepClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTel1Clientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTel2Clientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmailClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.mtxtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1041, 30);
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
            this.btMin.Location = new System.Drawing.Point(961, 0);
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
            this.btX.Location = new System.Drawing.Point(1001, 0);
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
            this.panel2.Size = new System.Drawing.Size(3, 453);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1038, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 453);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 480);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1035, 3);
            this.panel4.TabIndex = 8;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdClientes,
            this.txtNomeClientes,
            this.txtCnpjClientes,
            this.txtEnderecoClientes,
            this.txtNumeroClientes,
            this.txtComplClientes,
            this.txtBairroClientes,
            this.txtMunicipioClientes,
            this.txtEstadoClientes,
            this.txtCepClientes,
            this.txtTel1Clientes,
            this.txtTel2Clientes,
            this.txtEmailClientes});
            this.dgvClientes.Location = new System.Drawing.Point(9, 36);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(1023, 361);
            this.dgvClientes.TabIndex = 9;
            this.dgvClientes.DoubleClick += new System.EventHandler(this.dgvClientes_DoubleClick);
            // 
            // txtIdClientes
            // 
            this.txtIdClientes.DataPropertyName = "idClientes";
            dataGridViewCellStyle1.Format = "(11) ";
            dataGridViewCellStyle1.NullValue = null;
            this.txtIdClientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.txtIdClientes.HeaderText = "ID";
            this.txtIdClientes.Name = "txtIdClientes";
            this.txtIdClientes.Visible = false;
            // 
            // txtNomeClientes
            // 
            this.txtNomeClientes.DataPropertyName = "nomeClientes";
            this.txtNomeClientes.HeaderText = "Nome";
            this.txtNomeClientes.Name = "txtNomeClientes";
            this.txtNomeClientes.ReadOnly = true;
            this.txtNomeClientes.Width = 60;
            // 
            // txtCnpjClientes
            // 
            this.txtCnpjClientes.DataPropertyName = "cnpjClientes";
            dataGridViewCellStyle2.Format = "##,###,###/####-##";
            dataGridViewCellStyle2.NullValue = null;
            this.txtCnpjClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.txtCnpjClientes.HeaderText = "CNPJ/CPF";
            this.txtCnpjClientes.Name = "txtCnpjClientes";
            this.txtCnpjClientes.ReadOnly = true;
            this.txtCnpjClientes.Width = 84;
            // 
            // txtEnderecoClientes
            // 
            this.txtEnderecoClientes.DataPropertyName = "enderecoClientes";
            this.txtEnderecoClientes.HeaderText = "Endereço";
            this.txtEnderecoClientes.Name = "txtEnderecoClientes";
            this.txtEnderecoClientes.ReadOnly = true;
            this.txtEnderecoClientes.Width = 78;
            // 
            // txtNumeroClientes
            // 
            this.txtNumeroClientes.DataPropertyName = "numeroClientes";
            this.txtNumeroClientes.HeaderText = "Número";
            this.txtNumeroClientes.Name = "txtNumeroClientes";
            this.txtNumeroClientes.ReadOnly = true;
            this.txtNumeroClientes.Width = 69;
            // 
            // txtComplClientes
            // 
            this.txtComplClientes.DataPropertyName = "complClientes";
            this.txtComplClientes.HeaderText = "Complemento";
            this.txtComplClientes.Name = "txtComplClientes";
            this.txtComplClientes.ReadOnly = true;
            this.txtComplClientes.Width = 96;
            // 
            // txtBairroClientes
            // 
            this.txtBairroClientes.DataPropertyName = "bairroClientes";
            this.txtBairroClientes.HeaderText = "Bairro";
            this.txtBairroClientes.Name = "txtBairroClientes";
            this.txtBairroClientes.ReadOnly = true;
            this.txtBairroClientes.Width = 59;
            // 
            // txtMunicipioClientes
            // 
            this.txtMunicipioClientes.DataPropertyName = "municipioClientes";
            this.txtMunicipioClientes.HeaderText = "Município";
            this.txtMunicipioClientes.Name = "txtMunicipioClientes";
            this.txtMunicipioClientes.ReadOnly = true;
            this.txtMunicipioClientes.Width = 79;
            // 
            // txtEstadoClientes
            // 
            this.txtEstadoClientes.DataPropertyName = "estadoClientes";
            this.txtEstadoClientes.HeaderText = "Estado";
            this.txtEstadoClientes.Name = "txtEstadoClientes";
            this.txtEstadoClientes.ReadOnly = true;
            this.txtEstadoClientes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtEstadoClientes.Width = 65;
            // 
            // txtCepClientes
            // 
            this.txtCepClientes.DataPropertyName = "cepClientes";
            this.txtCepClientes.HeaderText = "CEP";
            this.txtCepClientes.Name = "txtCepClientes";
            this.txtCepClientes.ReadOnly = true;
            this.txtCepClientes.Width = 53;
            // 
            // txtTel1Clientes
            // 
            this.txtTel1Clientes.DataPropertyName = "tel1Clientes";
            this.txtTel1Clientes.HeaderText = "Telefone 1";
            this.txtTel1Clientes.Name = "txtTel1Clientes";
            this.txtTel1Clientes.Visible = false;
            // 
            // txtTel2Clientes
            // 
            this.txtTel2Clientes.DataPropertyName = "tel2Clientes";
            this.txtTel2Clientes.HeaderText = "Telefone 2";
            this.txtTel2Clientes.Name = "txtTel2Clientes";
            this.txtTel2Clientes.Visible = false;
            // 
            // txtEmailClientes
            // 
            this.txtEmailClientes.DataPropertyName = "emailClientes";
            this.txtEmailClientes.HeaderText = "E-mail";
            this.txtEmailClientes.Name = "txtEmailClientes";
            this.txtEmailClientes.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCnpj);
            this.groupBox1.Controls.Add(this.mtxtCnpj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(9, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 71);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(6, 48);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(62, 13);
            this.lblCnpj.TabIndex = 5;
            this.lblCnpj.Text = "CNPJ/CPF:";
            // 
            // mtxtCnpj
            // 
            this.mtxtCnpj.Location = new System.Drawing.Point(74, 45);
            this.mtxtCnpj.Mask = "00,000,000/0000-00";
            this.mtxtCnpj.Name = "mtxtCnpj";
            this.mtxtCnpj.Size = new System.Drawing.Size(105, 20);
            this.mtxtCnpj.TabIndex = 4;
            this.mtxtCnpj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxtCnpj_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(74, 19);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(427, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // FrmPesquisaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1041, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPesquisaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.FrmPesquisaClientes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNomeClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCnpjClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEnderecoClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNumeroClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtComplClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBairroClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMunicipioClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEstadoClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCepClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTel1Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTel2Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmailClientes;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.MaskedTextBox mtxtCnpj;
    }
}