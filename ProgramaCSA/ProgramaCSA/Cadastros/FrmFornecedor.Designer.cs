namespace ProgramaCSA.Cadastros
{
    partial class FrmFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFornecedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbFornecedor = new System.Windows.Forms.GroupBox();
            this.lblRazao = new System.Windows.Forms.Label();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.txtInsc = new System.Windows.Forms.TextBox();
            this.lblInsc = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.mtxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.gbLogradouro = new System.Windows.Forms.GroupBox();
            this.mtxtCep = new System.Windows.Forms.MaskedTextBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCompl = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtCompl = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTel3 = new System.Windows.Forms.Label();
            this.mtxtTel3 = new System.Windows.Forms.MaskedTextBox();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.mtxtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.mtxtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lblSalvo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbFornecedor.SuspendLayout();
            this.gbLogradouro.SuspendLayout();
            this.gbContato.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(610, 30);
            this.panel1.TabIndex = 1;
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
            this.btMin.Location = new System.Drawing.Point(530, 0);
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
            this.btX.Location = new System.Drawing.Point(570, 0);
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
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Fornecedores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 321);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(607, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 321);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 348);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(604, 3);
            this.panel4.TabIndex = 4;
            // 
            // gbFornecedor
            // 
            this.gbFornecedor.Controls.Add(this.lblRazao);
            this.gbFornecedor.Controls.Add(this.txtRazao);
            this.gbFornecedor.Controls.Add(this.txtInsc);
            this.gbFornecedor.Controls.Add(this.lblInsc);
            this.gbFornecedor.Controls.Add(this.lblCNPJ);
            this.gbFornecedor.Controls.Add(this.mtxtCNPJ);
            this.gbFornecedor.Location = new System.Drawing.Point(10, 36);
            this.gbFornecedor.Name = "gbFornecedor";
            this.gbFornecedor.Size = new System.Drawing.Size(591, 71);
            this.gbFornecedor.TabIndex = 0;
            this.gbFornecedor.TabStop = false;
            this.gbFornecedor.Text = "Dados do Fornecedor";
            // 
            // lblRazao
            // 
            this.lblRazao.AutoSize = true;
            this.lblRazao.Location = new System.Drawing.Point(6, 48);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(73, 13);
            this.lblRazao.TabIndex = 5;
            this.lblRazao.Text = "Razão Social:";
            // 
            // txtRazao
            // 
            this.txtRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazao.Location = new System.Drawing.Point(86, 45);
            this.txtRazao.MaxLength = 60;
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(499, 20);
            this.txtRazao.TabIndex = 2;
            // 
            // txtInsc
            // 
            this.txtInsc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInsc.Location = new System.Drawing.Point(301, 19);
            this.txtInsc.MaxLength = 12;
            this.txtInsc.Name = "txtInsc";
            this.txtInsc.Size = new System.Drawing.Size(126, 20);
            this.txtInsc.TabIndex = 1;
            this.txtInsc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsc_KeyPress);
            // 
            // lblInsc
            // 
            this.lblInsc.AutoSize = true;
            this.lblInsc.Location = new System.Drawing.Point(198, 22);
            this.lblInsc.Name = "lblInsc";
            this.lblInsc.Size = new System.Drawing.Size(97, 13);
            this.lblInsc.TabIndex = 2;
            this.lblInsc.Text = "Inscrição Estadual:";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(6, 22);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(62, 13);
            this.lblCNPJ.TabIndex = 1;
            this.lblCNPJ.Text = "CNPJ/CPF:";
            // 
            // mtxtCNPJ
            // 
            this.mtxtCNPJ.Location = new System.Drawing.Point(86, 19);
            this.mtxtCNPJ.Mask = "00,000,000/0000-00";
            this.mtxtCNPJ.Name = "mtxtCNPJ";
            this.mtxtCNPJ.Size = new System.Drawing.Size(106, 20);
            this.mtxtCNPJ.TabIndex = 0;
            this.mtxtCNPJ.Click += new System.EventHandler(this.mtxt_Click);
            this.mtxtCNPJ.Enter += new System.EventHandler(this.mtxtCNPJ_Enter);
            this.mtxtCNPJ.Leave += new System.EventHandler(this.mtxtCNPJ_Leave);
            // 
            // gbLogradouro
            // 
            this.gbLogradouro.Controls.Add(this.mtxtCep);
            this.gbLogradouro.Controls.Add(this.cbUF);
            this.gbLogradouro.Controls.Add(this.txtMunicipio);
            this.gbLogradouro.Controls.Add(this.txtBairro);
            this.gbLogradouro.Controls.Add(this.txtNumero);
            this.gbLogradouro.Controls.Add(this.txtEndereco);
            this.gbLogradouro.Controls.Add(this.lblCep);
            this.gbLogradouro.Controls.Add(this.lblUF);
            this.gbLogradouro.Controls.Add(this.lblMunicipio);
            this.gbLogradouro.Controls.Add(this.lblBairro);
            this.gbLogradouro.Controls.Add(this.lblCompl);
            this.gbLogradouro.Controls.Add(this.lblNumero);
            this.gbLogradouro.Controls.Add(this.txtCompl);
            this.gbLogradouro.Controls.Add(this.lblEndereco);
            this.gbLogradouro.Location = new System.Drawing.Point(10, 113);
            this.gbLogradouro.Name = "gbLogradouro";
            this.gbLogradouro.Size = new System.Drawing.Size(591, 123);
            this.gbLogradouro.TabIndex = 1;
            this.gbLogradouro.TabStop = false;
            this.gbLogradouro.Text = "Logradouro";
            // 
            // mtxtCep
            // 
            this.mtxtCep.Location = new System.Drawing.Point(449, 97);
            this.mtxtCep.Mask = "00000-000";
            this.mtxtCep.Name = "mtxtCep";
            this.mtxtCep.Size = new System.Drawing.Size(58, 20);
            this.mtxtCep.TabIndex = 6;
            this.mtxtCep.Click += new System.EventHandler(this.mtxt_Click);
            // 
            // cbUF
            // 
            this.cbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
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
            this.cbUF.Location = new System.Drawing.Point(368, 97);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(38, 21);
            this.cbUF.TabIndex = 5;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMunicipio.Location = new System.Drawing.Point(86, 97);
            this.txtMunicipio.MaxLength = 35;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(246, 20);
            this.txtMunicipio.TabIndex = 4;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(86, 71);
            this.txtBairro.MaxLength = 40;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(223, 20);
            this.txtBairro.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(530, 19);
            this.txtNumero.MaxLength = 15;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(55, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(86, 19);
            this.txtEndereco.MaxLength = 60;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(385, 20);
            this.txtEndereco.TabIndex = 0;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(412, 100);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 7;
            this.lblCep.Text = "CEP:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(338, 100);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 6;
            this.lblUF.Text = "UF:";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(6, 100);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(55, 13);
            this.lblMunicipio.TabIndex = 5;
            this.lblMunicipio.Text = "Municipio:";
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
            // lblCompl
            // 
            this.lblCompl.AutoSize = true;
            this.lblCompl.Location = new System.Drawing.Point(6, 48);
            this.lblCompl.Name = "lblCompl";
            this.lblCompl.Size = new System.Drawing.Size(74, 13);
            this.lblCompl.TabIndex = 3;
            this.lblCompl.Text = "Complemento:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(477, 22);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Número:";
            // 
            // txtCompl
            // 
            this.txtCompl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCompl.Location = new System.Drawing.Point(86, 45);
            this.txtCompl.MaxLength = 40;
            this.txtCompl.Name = "txtCompl";
            this.txtCompl.Size = new System.Drawing.Size(341, 20);
            this.txtCompl.TabIndex = 2;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(6, 22);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "Endereço:";
            // 
            // gbContato
            // 
            this.gbContato.Controls.Add(this.label2);
            this.gbContato.Controls.Add(this.txtEmail);
            this.gbContato.Controls.Add(this.lblTel3);
            this.gbContato.Controls.Add(this.mtxtTel3);
            this.gbContato.Controls.Add(this.lblTel2);
            this.gbContato.Controls.Add(this.mtxtTel2);
            this.gbContato.Controls.Add(this.lblTel1);
            this.gbContato.Controls.Add(this.mtxtTel1);
            this.gbContato.Location = new System.Drawing.Point(10, 242);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(591, 71);
            this.gbContato.TabIndex = 2;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Contato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "E-mails:";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(86, 45);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(499, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblTel3
            // 
            this.lblTel3.AutoSize = true;
            this.lblTel3.Location = new System.Drawing.Point(343, 22);
            this.lblTel3.Name = "lblTel3";
            this.lblTel3.Size = new System.Drawing.Size(61, 13);
            this.lblTel3.TabIndex = 5;
            this.lblTel3.Text = "Telefone 3:";
            // 
            // mtxtTel3
            // 
            this.mtxtTel3.Location = new System.Drawing.Point(410, 19);
            this.mtxtTel3.Mask = "(00) 0,0000-0000";
            this.mtxtTel3.Name = "mtxtTel3";
            this.mtxtTel3.Size = new System.Drawing.Size(89, 20);
            this.mtxtTel3.TabIndex = 2;
            this.mtxtTel3.Click += new System.EventHandler(this.mtxt_Click);
            this.mtxtTel3.Enter += new System.EventHandler(this.mtxtTelefones_Enter);
            this.mtxtTel3.Leave += new System.EventHandler(this.mtxtTelefones_Leave);
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.Location = new System.Drawing.Point(181, 22);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(61, 13);
            this.lblTel2.TabIndex = 3;
            this.lblTel2.Text = "Telefone 2:";
            // 
            // mtxtTel2
            // 
            this.mtxtTel2.Location = new System.Drawing.Point(248, 19);
            this.mtxtTel2.Mask = "(00) 0,0000-0000";
            this.mtxtTel2.Name = "mtxtTel2";
            this.mtxtTel2.Size = new System.Drawing.Size(89, 20);
            this.mtxtTel2.TabIndex = 1;
            this.mtxtTel2.Click += new System.EventHandler(this.mtxt_Click);
            this.mtxtTel2.Enter += new System.EventHandler(this.mtxtTelefones_Enter);
            this.mtxtTel2.Leave += new System.EventHandler(this.mtxtTelefones_Leave);
            // 
            // lblTel1
            // 
            this.lblTel1.AutoSize = true;
            this.lblTel1.Location = new System.Drawing.Point(6, 22);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(61, 13);
            this.lblTel1.TabIndex = 1;
            this.lblTel1.Text = "Telefone 1:";
            // 
            // mtxtTel1
            // 
            this.mtxtTel1.Location = new System.Drawing.Point(86, 19);
            this.mtxtTel1.Mask = "(00) 0,0000-0000";
            this.mtxtTel1.Name = "mtxtTel1";
            this.mtxtTel1.Size = new System.Drawing.Size(89, 20);
            this.mtxtTel1.TabIndex = 0;
            this.mtxtTel1.Click += new System.EventHandler(this.mtxt_Click);
            this.mtxtTel1.Enter += new System.EventHandler(this.mtxtTelefones_Enter);
            this.mtxtTel1.Leave += new System.EventHandler(this.mtxtTelefones_Leave);
            // 
            // btSalvar
            // 
            this.btSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSalvar.Location = new System.Drawing.Point(9, 319);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 3;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btPesquisar.Location = new System.Drawing.Point(526, 319);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 6;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btExcluir.Location = new System.Drawing.Point(90, 319);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 4;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btLimpar.Location = new System.Drawing.Point(445, 319);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 5;
            this.btLimpar.Text = "Limpar Tela";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lblSalvo
            // 
            this.lblSalvo.AutoSize = true;
            this.lblSalvo.ForeColor = System.Drawing.Color.Green;
            this.lblSalvo.Location = new System.Drawing.Point(171, 324);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(73, 13);
            this.lblSalvo.TabIndex = 21;
            this.lblSalvo.Text = "Dados Salvos";
            this.lblSalvo.Visible = false;
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(610, 351);
            this.Controls.Add(this.lblSalvo);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.gbContato);
            this.Controls.Add(this.gbLogradouro);
            this.Controls.Add(this.gbFornecedor);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedores";
            this.panel1.ResumeLayout(false);
            this.gbFornecedor.ResumeLayout(false);
            this.gbFornecedor.PerformLayout();
            this.gbLogradouro.ResumeLayout(false);
            this.gbLogradouro.PerformLayout();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gbFornecedor;
        private System.Windows.Forms.Label lblRazao;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.TextBox txtInsc;
        private System.Windows.Forms.Label lblInsc;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.MaskedTextBox mtxtCNPJ;
        private System.Windows.Forms.GroupBox gbLogradouro;
        private System.Windows.Forms.MaskedTextBox mtxtCep;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCompl;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtCompl;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTel3;
        private System.Windows.Forms.MaskedTextBox mtxtTel3;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.MaskedTextBox mtxtTel2;
        private System.Windows.Forms.Label lblTel1;
        private System.Windows.Forms.MaskedTextBox mtxtTel1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lblSalvo;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
    }
}