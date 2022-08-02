namespace ProgramaCSA.Estoque
{
    partial class FrmFiltro
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
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.lblPeriodo2 = new System.Windows.Forms.Label();
            this.mtxtData2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtData1 = new System.Windows.Forms.MaskedTextBox();
            this.lblPeriodo1 = new System.Windows.Forms.Label();
            this.gbProduto = new System.Windows.Forms.GroupBox();
            this.lblProduto2 = new System.Windows.Forms.Label();
            this.mtxtProduto1 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtProduto2 = new System.Windows.Forms.MaskedTextBox();
            this.lblProduto1 = new System.Windows.Forms.Label();
            this.gbLancamento = new System.Windows.Forms.GroupBox();
            this.rbSaidas = new System.Windows.Forms.RadioButton();
            this.rbEntradas = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.gbCNPJ = new System.Windows.Forms.GroupBox();
            this.mtxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbFiltro.SuspendLayout();
            this.gbProduto.SuspendLayout();
            this.gbLancamento.SuspendLayout();
            this.gbCNPJ.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.lblPeriodo2);
            this.gbFiltro.Controls.Add(this.mtxtData2);
            this.gbFiltro.Controls.Add(this.mtxtData1);
            this.gbFiltro.Controls.Add(this.lblPeriodo1);
            this.gbFiltro.Location = new System.Drawing.Point(12, 31);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(212, 44);
            this.gbFiltro.TabIndex = 0;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Período";
            // 
            // lblPeriodo2
            // 
            this.lblPeriodo2.AutoSize = true;
            this.lblPeriodo2.Location = new System.Drawing.Point(108, 22);
            this.lblPeriodo2.Name = "lblPeriodo2";
            this.lblPeriodo2.Size = new System.Drawing.Size(26, 13);
            this.lblPeriodo2.TabIndex = 5;
            this.lblPeriodo2.Text = "Até:";
            // 
            // mtxtData2
            // 
            this.mtxtData2.Location = new System.Drawing.Point(140, 19);
            this.mtxtData2.Mask = "00/00/0000";
            this.mtxtData2.Name = "mtxtData2";
            this.mtxtData2.Size = new System.Drawing.Size(66, 20);
            this.mtxtData2.TabIndex = 4;
            this.mtxtData2.Click += new System.EventHandler(this.mtxt_Click);
            // 
            // mtxtData1
            // 
            this.mtxtData1.Location = new System.Drawing.Point(36, 19);
            this.mtxtData1.Mask = "00/00/0000";
            this.mtxtData1.Name = "mtxtData1";
            this.mtxtData1.Size = new System.Drawing.Size(66, 20);
            this.mtxtData1.TabIndex = 3;
            this.mtxtData1.Click += new System.EventHandler(this.mtxt_Click);
            // 
            // lblPeriodo1
            // 
            this.lblPeriodo1.AutoSize = true;
            this.lblPeriodo1.Location = new System.Drawing.Point(6, 22);
            this.lblPeriodo1.Name = "lblPeriodo1";
            this.lblPeriodo1.Size = new System.Drawing.Size(24, 13);
            this.lblPeriodo1.TabIndex = 2;
            this.lblPeriodo1.Text = "De:";
            // 
            // gbProduto
            // 
            this.gbProduto.Controls.Add(this.lblProduto2);
            this.gbProduto.Controls.Add(this.mtxtProduto1);
            this.gbProduto.Controls.Add(this.mtxtProduto2);
            this.gbProduto.Controls.Add(this.lblProduto1);
            this.gbProduto.Location = new System.Drawing.Point(12, 81);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Size = new System.Drawing.Size(212, 44);
            this.gbProduto.TabIndex = 1;
            this.gbProduto.TabStop = false;
            this.gbProduto.Text = "Produto";
            // 
            // lblProduto2
            // 
            this.lblProduto2.AutoSize = true;
            this.lblProduto2.Location = new System.Drawing.Point(89, 22);
            this.lblProduto2.Name = "lblProduto2";
            this.lblProduto2.Size = new System.Drawing.Size(26, 13);
            this.lblProduto2.TabIndex = 9;
            this.lblProduto2.Text = "Até:";
            // 
            // mtxtProduto1
            // 
            this.mtxtProduto1.Location = new System.Drawing.Point(36, 19);
            this.mtxtProduto1.Mask = "000,000";
            this.mtxtProduto1.Name = "mtxtProduto1";
            this.mtxtProduto1.Size = new System.Drawing.Size(47, 20);
            this.mtxtProduto1.TabIndex = 7;
            this.mtxtProduto1.Click += new System.EventHandler(this.mtxt_Click);
            // 
            // mtxtProduto2
            // 
            this.mtxtProduto2.Location = new System.Drawing.Point(121, 19);
            this.mtxtProduto2.Mask = "000,000";
            this.mtxtProduto2.Name = "mtxtProduto2";
            this.mtxtProduto2.Size = new System.Drawing.Size(47, 20);
            this.mtxtProduto2.TabIndex = 8;
            this.mtxtProduto2.Click += new System.EventHandler(this.mtxt_Click);
            // 
            // lblProduto1
            // 
            this.lblProduto1.AutoSize = true;
            this.lblProduto1.Location = new System.Drawing.Point(6, 22);
            this.lblProduto1.Name = "lblProduto1";
            this.lblProduto1.Size = new System.Drawing.Size(24, 13);
            this.lblProduto1.TabIndex = 6;
            this.lblProduto1.Text = "De:";
            // 
            // gbLancamento
            // 
            this.gbLancamento.Controls.Add(this.rbSaidas);
            this.gbLancamento.Controls.Add(this.rbEntradas);
            this.gbLancamento.Controls.Add(this.rbTodos);
            this.gbLancamento.Location = new System.Drawing.Point(12, 131);
            this.gbLancamento.Name = "gbLancamento";
            this.gbLancamento.Size = new System.Drawing.Size(212, 44);
            this.gbLancamento.TabIndex = 10;
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
            // gbCNPJ
            // 
            this.gbCNPJ.Controls.Add(this.mtxtCNPJ);
            this.gbCNPJ.Location = new System.Drawing.Point(12, 181);
            this.gbCNPJ.Name = "gbCNPJ";
            this.gbCNPJ.Size = new System.Drawing.Size(212, 44);
            this.gbCNPJ.TabIndex = 11;
            this.gbCNPJ.TabStop = false;
            this.gbCNPJ.Text = "CNPJ/CPF do Cliente";
            // 
            // mtxtCNPJ
            // 
            this.mtxtCNPJ.Location = new System.Drawing.Point(6, 19);
            this.mtxtCNPJ.Mask = "00,000,000/0000-00";
            this.mtxtCNPJ.Name = "mtxtCNPJ";
            this.mtxtCNPJ.Size = new System.Drawing.Size(109, 20);
            this.mtxtCNPJ.TabIndex = 0;
            this.mtxtCNPJ.Click += new System.EventHandler(this.mtxt_Click);
            this.mtxtCNPJ.Enter += new System.EventHandler(this.mtxtCNPJ_Enter);
            this.mtxtCNPJ.Leave += new System.EventHandler(this.mtxtCNPJ_Leave);
            // 
            // btFiltrar
            // 
            this.btFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFiltrar.Location = new System.Drawing.Point(12, 231);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btFiltrar.TabIndex = 12;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(86)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btMin);
            this.panel1.Controls.Add(this.btX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 25);
            this.panel1.TabIndex = 13;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro";
            // 
            // btMin
            // 
            this.btMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(86)))), ((int)(((byte)(107)))));
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.ForeColor = System.Drawing.Color.White;
            this.btMin.Location = new System.Drawing.Point(183, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(25, 25);
            this.btMin.TabIndex = 1;
            this.btMin.Text = "_";
            this.btMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMin.UseVisualStyleBackColor = true;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // btX
            // 
            this.btX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(86)))), ((int)(((byte)(107)))));
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.ForeColor = System.Drawing.Color.White;
            this.btX.Location = new System.Drawing.Point(209, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(25, 25);
            this.btX.TabIndex = 0;
            this.btX.Text = "X";
            this.btX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btX.UseVisualStyleBackColor = true;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(86)))), ((int)(((byte)(107)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(231, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 241);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(86)))), ((int)(((byte)(107)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 241);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(86)))), ((int)(((byte)(107)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 263);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 3);
            this.panel4.TabIndex = 16;
            // 
            // FrmFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(234, 266);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.gbCNPJ);
            this.Controls.Add(this.gbLancamento);
            this.Controls.Add(this.gbProduto);
            this.Controls.Add(this.gbFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFiltro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro";
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.gbProduto.ResumeLayout(false);
            this.gbProduto.PerformLayout();
            this.gbLancamento.ResumeLayout(false);
            this.gbLancamento.PerformLayout();
            this.gbCNPJ.ResumeLayout(false);
            this.gbCNPJ.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.Label lblPeriodo2;
        private System.Windows.Forms.MaskedTextBox mtxtData2;
        private System.Windows.Forms.MaskedTextBox mtxtData1;
        private System.Windows.Forms.Label lblPeriodo1;
        private System.Windows.Forms.GroupBox gbProduto;
        private System.Windows.Forms.Label lblProduto2;
        private System.Windows.Forms.MaskedTextBox mtxtProduto1;
        private System.Windows.Forms.MaskedTextBox mtxtProduto2;
        private System.Windows.Forms.Label lblProduto1;
        private System.Windows.Forms.GroupBox gbLancamento;
        private System.Windows.Forms.RadioButton rbSaidas;
        private System.Windows.Forms.RadioButton rbEntradas;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.GroupBox gbCNPJ;
        private System.Windows.Forms.MaskedTextBox mtxtCNPJ;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}