namespace ProgramaCSA.Cadastros
{
    partial class FrmTransp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransp));
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.txtInsc = new System.Windows.Forms.TextBox();
            this.lblInsc = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.mtxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.lblRazao = new System.Windows.Forms.Label();
            this.gbLogradouro = new System.Windows.Forms.GroupBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.txtCompl = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.mtxtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.lblSalvo = new System.Windows.Forms.Label();
            this.gbDados.SuspendLayout();
            this.gbLogradouro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbContato.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.txtInsc);
            this.gbDados.Controls.Add(this.lblInsc);
            this.gbDados.Controls.Add(this.lblCNPJ);
            this.gbDados.Controls.Add(this.mtxtCNPJ);
            this.gbDados.Controls.Add(this.txtRazao);
            this.gbDados.Controls.Add(this.lblRazao);
            this.gbDados.Location = new System.Drawing.Point(9, 36);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(537, 71);
            this.gbDados.TabIndex = 0;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // txtInsc
            // 
            this.txtInsc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInsc.Location = new System.Drawing.Point(307, 45);
            this.txtInsc.MaxLength = 12;
            this.txtInsc.Name = "txtInsc";
            this.txtInsc.Size = new System.Drawing.Size(117, 20);
            this.txtInsc.TabIndex = 3;
            this.txtInsc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsc_KeyPress);
            // 
            // lblInsc
            // 
            this.lblInsc.AutoSize = true;
            this.lblInsc.Location = new System.Drawing.Point(204, 48);
            this.lblInsc.Name = "lblInsc";
            this.lblInsc.Size = new System.Drawing.Size(97, 13);
            this.lblInsc.TabIndex = 2;
            this.lblInsc.Text = "Inscrição Estadual:";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(6, 48);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(37, 13);
            this.lblCNPJ.TabIndex = 1;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // mtxtCNPJ
            // 
            this.mtxtCNPJ.Location = new System.Drawing.Point(86, 45);
            this.mtxtCNPJ.Mask = "00,000,000/0000-00";
            this.mtxtCNPJ.Name = "mtxtCNPJ";
            this.mtxtCNPJ.Size = new System.Drawing.Size(112, 20);
            this.mtxtCNPJ.TabIndex = 1;
            this.mtxtCNPJ.Click += new System.EventHandler(this.mtxt_Click);
            // 
            // txtRazao
            // 
            this.txtRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazao.Location = new System.Drawing.Point(86, 19);
            this.txtRazao.MaxLength = 60;
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(445, 20);
            this.txtRazao.TabIndex = 0;
            // 
            // lblRazao
            // 
            this.lblRazao.AutoSize = true;
            this.lblRazao.Location = new System.Drawing.Point(6, 22);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(73, 13);
            this.lblRazao.TabIndex = 1;
            this.lblRazao.Text = "Razão Social:";
            // 
            // gbLogradouro
            // 
            this.gbLogradouro.Controls.Add(this.lblNumero);
            this.gbLogradouro.Controls.Add(this.txtNumero);
            this.gbLogradouro.Controls.Add(this.mtxtCEP);
            this.gbLogradouro.Controls.Add(this.cbEstado);
            this.gbLogradouro.Controls.Add(this.lblCEP);
            this.gbLogradouro.Controls.Add(this.txtMunicipio);
            this.gbLogradouro.Controls.Add(this.txtBairro);
            this.gbLogradouro.Controls.Add(this.label5);
            this.gbLogradouro.Controls.Add(this.lblBairro);
            this.gbLogradouro.Controls.Add(this.lblComplemento);
            this.gbLogradouro.Controls.Add(this.lblEndereco);
            this.gbLogradouro.Controls.Add(this.lblMunicipio);
            this.gbLogradouro.Controls.Add(this.txtCompl);
            this.gbLogradouro.Controls.Add(this.txtEndereco);
            this.gbLogradouro.Location = new System.Drawing.Point(9, 113);
            this.gbLogradouro.Name = "gbLogradouro";
            this.gbLogradouro.Size = new System.Drawing.Size(537, 176);
            this.gbLogradouro.TabIndex = 1;
            this.gbLogradouro.TabStop = false;
            this.gbLogradouro.Text = "Logradouro";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(405, 48);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(458, 45);
            this.txtNumero.MaxLength = 15;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(73, 20);
            this.txtNumero.TabIndex = 8;
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.Location = new System.Drawing.Point(86, 150);
            this.mtxtCEP.Mask = "00000-000";
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(64, 20);
            this.mtxtCEP.TabIndex = 5;
            this.mtxtCEP.Click += new System.EventHandler(this.mtxt_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA ",
            "CE ",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE ",
            "PI ",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            ""});
            this.cbEstado.Location = new System.Drawing.Point(86, 123);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(43, 21);
            this.cbEstado.TabIndex = 4;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(6, 153);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 7;
            this.lblCEP.Text = "CEP:";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMunicipio.Location = new System.Drawing.Point(86, 97);
            this.txtMunicipio.MaxLength = 35;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(223, 20);
            this.txtMunicipio.TabIndex = 3;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(86, 71);
            this.txtBairro.MaxLength = 40;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(313, 20);
            this.txtBairro.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estado:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(6, 74);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 4;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(6, 48);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 3;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(6, 22);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(6, 100);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(57, 13);
            this.lblMunicipio.TabIndex = 5;
            this.lblMunicipio.Text = "Município:";
            // 
            // txtCompl
            // 
            this.txtCompl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCompl.Location = new System.Drawing.Point(86, 45);
            this.txtCompl.MaxLength = 40;
            this.txtCompl.Name = "txtCompl";
            this.txtCompl.Size = new System.Drawing.Size(313, 20);
            this.txtCompl.TabIndex = 1;
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(86, 19);
            this.txtEndereco.MaxLength = 60;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(445, 20);
            this.txtEndereco.TabIndex = 0;
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(9, 372);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 2;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
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
            this.panel1.Size = new System.Drawing.Size(555, 30);
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
            this.btMin.Location = new System.Drawing.Point(475, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(40, 30);
            this.btMin.TabIndex = 8;
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
            this.btX.Location = new System.Drawing.Point(515, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(40, 30);
            this.btX.TabIndex = 7;
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
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Transportadoras";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(552, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 374);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 374);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 401);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(549, 3);
            this.panel4.TabIndex = 6;
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Location = new System.Drawing.Point(90, 372);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 7;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Location = new System.Drawing.Point(471, 372);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 8;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Location = new System.Drawing.Point(390, 372);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 9;
            this.btLimpar.Text = "Limpar Tela";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // gbContato
            // 
            this.gbContato.Controls.Add(this.mtxtTel2);
            this.gbContato.Controls.Add(this.mtxtTel1);
            this.gbContato.Controls.Add(this.lblEmail);
            this.gbContato.Controls.Add(this.txtEmail);
            this.gbContato.Controls.Add(this.lblTel2);
            this.gbContato.Controls.Add(this.lblTel1);
            this.gbContato.Location = new System.Drawing.Point(9, 295);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(537, 71);
            this.gbContato.TabIndex = 10;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Contato";
            // 
            // mtxtTel2
            // 
            this.mtxtTel2.Location = new System.Drawing.Point(251, 19);
            this.mtxtTel2.Mask = "(00) 0,0000-0000";
            this.mtxtTel2.Name = "mtxtTel2";
            this.mtxtTel2.Size = new System.Drawing.Size(92, 20);
            this.mtxtTel2.TabIndex = 1;
            // 
            // mtxtTel1
            // 
            this.mtxtTel1.Location = new System.Drawing.Point(86, 19);
            this.mtxtTel1.Mask = "(00) 0,0000-0000";
            this.mtxtTel1.Name = "mtxtTel1";
            this.mtxtTel1.Size = new System.Drawing.Size(92, 20);
            this.mtxtTel1.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 48);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(86, 45);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(445, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.Location = new System.Drawing.Point(184, 22);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(61, 13);
            this.lblTel2.TabIndex = 18;
            this.lblTel2.Text = "Telefone 2:";
            // 
            // lblTel1
            // 
            this.lblTel1.AutoSize = true;
            this.lblTel1.Location = new System.Drawing.Point(6, 22);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(61, 13);
            this.lblTel1.TabIndex = 16;
            this.lblTel1.Text = "Telefone 1:";
            // 
            // lblSalvo
            // 
            this.lblSalvo.AutoSize = true;
            this.lblSalvo.ForeColor = System.Drawing.Color.Green;
            this.lblSalvo.Location = new System.Drawing.Point(171, 377);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(73, 13);
            this.lblSalvo.TabIndex = 22;
            this.lblSalvo.Text = "Dados Salvos";
            this.lblSalvo.Visible = false;
            // 
            // FrmTransp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(555, 404);
            this.Controls.Add(this.lblSalvo);
            this.Controls.Add(this.gbContato);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.gbLogradouro);
            this.Controls.Add(this.gbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTransp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Transportadora";
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.gbLogradouro.ResumeLayout(false);
            this.gbLogradouro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.Label lblRazao;
        private System.Windows.Forms.MaskedTextBox mtxtCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.GroupBox gbLogradouro;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txtCompl;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox mtxtCEP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.TextBox txtInsc;
        private System.Windows.Forms.Label lblInsc;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.MaskedTextBox mtxtTel2;
        private System.Windows.Forms.MaskedTextBox mtxtTel1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.Label lblTel1;
        private System.Windows.Forms.Label lblSalvo;
    }
}