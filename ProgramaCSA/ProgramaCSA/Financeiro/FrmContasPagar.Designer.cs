namespace ProgramaCSA.Financeiro
{
    partial class FrmContasPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContasPagar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pMenus = new System.Windows.Forms.Panel();
            this.btRelat = new System.Windows.Forms.Button();
            this.btBaixa = new System.Windows.Forms.Button();
            this.btLancamento = new System.Windows.Forms.Button();
            this.pFormRecb = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pMenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 30);
            this.panel1.TabIndex = 3;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(100, 30);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Contas a Pagar";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(89)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1046, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "_";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btMin_Click);
            // 
            // btX
            // 
            this.btX.BackColor = System.Drawing.Color.Transparent;
            this.btX.Dock = System.Windows.Forms.DockStyle.Right;
            this.btX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(86)))), ((int)(((byte)(107)))));
            this.btX.FlatAppearance.BorderSize = 0;
            this.btX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(22)))));
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.ForeColor = System.Drawing.Color.White;
            this.btX.Location = new System.Drawing.Point(1086, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(40, 30);
            this.btX.TabIndex = 6;
            this.btX.Text = "X";
            this.btX.UseVisualStyleBackColor = false;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 562);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1123, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 562);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 589);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1120, 3);
            this.panel4.TabIndex = 7;
            // 
            // pMenus
            // 
            this.pMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.pMenus.Controls.Add(this.btRelat);
            this.pMenus.Controls.Add(this.btBaixa);
            this.pMenus.Controls.Add(this.btLancamento);
            this.pMenus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenus.Location = new System.Drawing.Point(3, 30);
            this.pMenus.Name = "pMenus";
            this.pMenus.Size = new System.Drawing.Size(100, 559);
            this.pMenus.TabIndex = 8;
            // 
            // btRelat
            // 
            this.btRelat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btRelat.FlatAppearance.BorderSize = 0;
            this.btRelat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelat.ForeColor = System.Drawing.Color.White;
            this.btRelat.Location = new System.Drawing.Point(0, 80);
            this.btRelat.Name = "btRelat";
            this.btRelat.Size = new System.Drawing.Size(100, 40);
            this.btRelat.TabIndex = 2;
            this.btRelat.Text = "Relatório";
            this.btRelat.UseVisualStyleBackColor = true;
            this.btRelat.Click += new System.EventHandler(this.btRelat_Click);
            // 
            // btBaixa
            // 
            this.btBaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btBaixa.FlatAppearance.BorderSize = 0;
            this.btBaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaixa.ForeColor = System.Drawing.Color.White;
            this.btBaixa.Location = new System.Drawing.Point(0, 40);
            this.btBaixa.Name = "btBaixa";
            this.btBaixa.Size = new System.Drawing.Size(100, 40);
            this.btBaixa.TabIndex = 1;
            this.btBaixa.Text = "Baixa de Títulos";
            this.btBaixa.UseVisualStyleBackColor = true;
            this.btBaixa.Click += new System.EventHandler(this.btBaixa_Click);
            // 
            // btLancamento
            // 
            this.btLancamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btLancamento.FlatAppearance.BorderSize = 0;
            this.btLancamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLancamento.ForeColor = System.Drawing.Color.White;
            this.btLancamento.Location = new System.Drawing.Point(0, 0);
            this.btLancamento.Name = "btLancamento";
            this.btLancamento.Size = new System.Drawing.Size(100, 40);
            this.btLancamento.TabIndex = 0;
            this.btLancamento.Text = "Lançamento";
            this.btLancamento.UseVisualStyleBackColor = true;
            this.btLancamento.Click += new System.EventHandler(this.btLancamento_Click);
            // 
            // pFormRecb
            // 
            this.pFormRecb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFormRecb.Location = new System.Drawing.Point(103, 30);
            this.pFormRecb.Name = "pFormRecb";
            this.pFormRecb.Size = new System.Drawing.Size(1020, 559);
            this.pFormRecb.TabIndex = 9;
            // 
            // FrmContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1126, 592);
            this.Controls.Add(this.pFormRecb);
            this.Controls.Add(this.pMenus);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmContasPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Pagar";
            this.panel1.ResumeLayout(false);
            this.pMenus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pMenus;
        private System.Windows.Forms.Button btLancamento;
        private System.Windows.Forms.Panel pFormRecb;
        private System.Windows.Forms.Button btBaixa;
        private System.Windows.Forms.Button btRelat;
    }
}