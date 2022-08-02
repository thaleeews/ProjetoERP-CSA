namespace ProgramaCSA.Cadastros
{
    partial class FrmFiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiscal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.gbAliquotas = new System.Windows.Forms.GroupBox();
            this.mtxtST = new System.Windows.Forms.MaskedTextBox();
            this.lblST = new System.Windows.Forms.Label();
            this.mtxtEstadual = new System.Windows.Forms.MaskedTextBox();
            this.lblEstadual = new System.Windows.Forms.Label();
            this.lblMVA = new System.Windows.Forms.Label();
            this.mtxtMVA = new System.Windows.Forms.MaskedTextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.gbAliquotas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Location = new System.Drawing.Point(9, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "ACRE",
            "ALAGOAS",
            "AMAPÁ",
            "AMAZONAS",
            "BAHIA",
            "CEARÁ",
            "DISTRITO FEDERAL",
            "ESPÍRITO SANTO",
            "GOIÁS",
            "MARANHÃO",
            "MATO GROSSO",
            "MATO GROSSO DO SUL",
            "MINAS GERAIS",
            "PARÁ",
            "PARAÍBA",
            "PARANÁ",
            "PERNAMBUCO",
            "PIAUÍ",
            "RIO DE JANEIRO",
            "RIO GRANDE DO NORTE",
            "RIO GRANDE DO SUL",
            "RONDÔNIA",
            "RORAIMA",
            "SANTA CATARINA",
            "SÃO PAULO",
            "SERGIPE",
            "TOCANTINS",
            ""});
            this.cbEstado.Location = new System.Drawing.Point(55, 15);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(172, 21);
            this.cbEstado.TabIndex = 0;
            // 
            // gbAliquotas
            // 
            this.gbAliquotas.Controls.Add(this.mtxtST);
            this.gbAliquotas.Controls.Add(this.lblST);
            this.gbAliquotas.Controls.Add(this.mtxtEstadual);
            this.gbAliquotas.Controls.Add(this.lblEstadual);
            this.gbAliquotas.Controls.Add(this.lblMVA);
            this.gbAliquotas.Controls.Add(this.mtxtMVA);
            this.gbAliquotas.Controls.Add(this.lblTipo);
            this.gbAliquotas.Controls.Add(this.cbTipo);
            this.gbAliquotas.Location = new System.Drawing.Point(9, 88);
            this.gbAliquotas.Name = "gbAliquotas";
            this.gbAliquotas.Size = new System.Drawing.Size(319, 73);
            this.gbAliquotas.TabIndex = 1;
            this.gbAliquotas.TabStop = false;
            this.gbAliquotas.Text = "Alíquotas";
            // 
            // mtxtST
            // 
            this.mtxtST.Location = new System.Drawing.Point(186, 46);
            this.mtxtST.Mask = "00%";
            this.mtxtST.Name = "mtxtST";
            this.mtxtST.Size = new System.Drawing.Size(29, 20);
            this.mtxtST.TabIndex = 2;
            this.mtxtST.Click += new System.EventHandler(this.mtxt_Click);
            // 
            // lblST
            // 
            this.lblST.AutoSize = true;
            this.lblST.Location = new System.Drawing.Point(127, 49);
            this.lblST.Name = "lblST";
            this.lblST.Size = new System.Drawing.Size(53, 13);
            this.lblST.TabIndex = 7;
            this.lblST.Text = "ICMS ST:";
            // 
            // mtxtEstadual
            // 
            this.mtxtEstadual.Location = new System.Drawing.Point(92, 46);
            this.mtxtEstadual.Mask = "00%";
            this.mtxtEstadual.Name = "mtxtEstadual";
            this.mtxtEstadual.Size = new System.Drawing.Size(29, 20);
            this.mtxtEstadual.TabIndex = 1;
            this.mtxtEstadual.Click += new System.EventHandler(this.mtxt_Click);
            // 
            // lblEstadual
            // 
            this.lblEstadual.AutoSize = true;
            this.lblEstadual.Location = new System.Drawing.Point(6, 49);
            this.lblEstadual.Name = "lblEstadual";
            this.lblEstadual.Size = new System.Drawing.Size(80, 13);
            this.lblEstadual.TabIndex = 5;
            this.lblEstadual.Text = "ICMS Estadual:";
            // 
            // lblMVA
            // 
            this.lblMVA.AutoSize = true;
            this.lblMVA.Location = new System.Drawing.Point(221, 49);
            this.lblMVA.Name = "lblMVA";
            this.lblMVA.Size = new System.Drawing.Size(33, 13);
            this.lblMVA.TabIndex = 4;
            this.lblMVA.Text = "MVA:";
            // 
            // mtxtMVA
            // 
            this.mtxtMVA.Location = new System.Drawing.Point(260, 46);
            this.mtxtMVA.Mask = "00,00%";
            this.mtxtMVA.Name = "mtxtMVA";
            this.mtxtMVA.Size = new System.Drawing.Size(45, 20);
            this.mtxtMVA.TabIndex = 3;
            this.mtxtMVA.Click += new System.EventHandler(this.mtxt_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 22);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(69, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo de Item:";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Shampoo",
            "Oxigenada (+500mL)",
            "Oxigenada (-500mL)",
            "Tintura",
            "Outros"});
            this.cbTipo.Location = new System.Drawing.Point(92, 19);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(213, 21);
            this.cbTipo.TabIndex = 0;
            // 
            // btSalvar
            // 
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(9, 167);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 2;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btMin);
            this.panel1.Controls.Add(this.btX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 30);
            this.panel1.TabIndex = 5;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cadastro de Clientes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btMin
            // 
            this.btMin.BackColor = System.Drawing.Color.Transparent;
            this.btMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(89)))));
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.ForeColor = System.Drawing.Color.White;
            this.btMin.Location = new System.Drawing.Point(257, 0);
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
            this.btX.Location = new System.Drawing.Point(297, 0);
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
            this.panel2.Size = new System.Drawing.Size(3, 169);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(334, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 169);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 196);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(331, 3);
            this.panel4.TabIndex = 8;
            // 
            // FrmFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(337, 199);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.gbAliquotas);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Fiscal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAliquotas.ResumeLayout(false);
            this.gbAliquotas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.GroupBox gbAliquotas;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblST;
        private System.Windows.Forms.MaskedTextBox mtxtEstadual;
        private System.Windows.Forms.Label lblEstadual;
        private System.Windows.Forms.Label lblMVA;
        private System.Windows.Forms.MaskedTextBox mtxtMVA;
        private System.Windows.Forms.MaskedTextBox mtxtST;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}