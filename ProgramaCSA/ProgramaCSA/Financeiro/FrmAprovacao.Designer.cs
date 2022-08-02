namespace ProgramaCSA.Financeiro
{
    partial class FrmAprovacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAprovacao));
            this.dgvBoletos = new System.Windows.Forms.DataGridView();
            this.btAprovar = new System.Windows.Forms.Button();
            this.dgvVenc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBoletos
            // 
            this.dgvBoletos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvBoletos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoletos.Location = new System.Drawing.Point(12, 12);
            this.dgvBoletos.Name = "dgvBoletos";
            this.dgvBoletos.Size = new System.Drawing.Size(906, 253);
            this.dgvBoletos.TabIndex = 2;
            // 
            // btAprovar
            // 
            this.btAprovar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAprovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAprovar.Location = new System.Drawing.Point(12, 517);
            this.btAprovar.Name = "btAprovar";
            this.btAprovar.Size = new System.Drawing.Size(75, 23);
            this.btAprovar.TabIndex = 4;
            this.btAprovar.Text = "Aprovar";
            this.btAprovar.UseVisualStyleBackColor = true;
            // 
            // dgvVenc
            // 
            this.dgvVenc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvVenc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenc.Location = new System.Drawing.Point(12, 271);
            this.dgvVenc.Name = "dgvVenc";
            this.dgvVenc.Size = new System.Drawing.Size(906, 240);
            this.dgvVenc.TabIndex = 5;
            // 
            // FrmAprovacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(930, 552);
            this.Controls.Add(this.dgvVenc);
            this.Controls.Add(this.btAprovar);
            this.Controls.Add(this.dgvBoletos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAprovacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boletos a Emitir";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBoletos;
        private System.Windows.Forms.Button btAprovar;
        private System.Windows.Forms.DataGridView dgvVenc;
    }
}