namespace ProgramaCSA.Cadastros
{
    partial class FrmRepres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepres));
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.cbRegiao = new System.Windows.Forms.ComboBox();
            this.lblRegiao = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.mtxtRG = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbLogradouro = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCompl = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCompl = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTel3 = new System.Windows.Forms.Label();
            this.mtxtTel3 = new System.Windows.Forms.MaskedTextBox();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.mtxtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.mtxtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.gbDadosBancarios = new System.Windows.Forms.GroupBox();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.lblFavorecido = new System.Windows.Forms.Label();
            this.txtFavorecido = new System.Windows.Forms.TextBox();
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
            this.lblSalvo = new System.Windows.Forms.Label();
            this.gbDados.SuspendLayout();
            this.gbLogradouro.SuspendLayout();
            this.gbContato.SuspendLayout();
            this.gbDadosBancarios.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.cbRegiao);
            this.gbDados.Controls.Add(this.lblRegiao);
            this.gbDados.Controls.Add(this.lblRG);
            this.gbDados.Controls.Add(this.mtxtRG);
            this.gbDados.Controls.Add(this.lblCPF);
            this.gbDados.Controls.Add(this.mtxtCPF);
            this.gbDados.Controls.Add(this.lblNome);
            this.gbDados.Controls.Add(this.txtNome);
            this.gbDados.Location = new System.Drawing.Point(9, 36);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(522, 73);
            this.gbDados.TabIndex = 0;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // cbRegiao
            // 
            this.cbRegiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegiao.FormattingEnabled = true;
            this.cbRegiao.Location = new System.Drawing.Point(307, 45);
            this.cbRegiao.Name = "cbRegiao";
            this.cbRegiao.Size = new System.Drawing.Size(209, 21);
            this.cbRegiao.TabIndex = 3;
            // 
            // lblRegiao
            // 
            this.lblRegiao.AutoSize = true;
            this.lblRegiao.Location = new System.Drawing.Point(257, 49);
            this.lblRegiao.Name = "lblRegiao";
            this.lblRegiao.Size = new System.Drawing.Size(44, 13);
            this.lblRegiao.TabIndex = 7;
            this.lblRegiao.Text = "Região:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(141, 48);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 6;
            this.lblRG.Text = "RG:";
            // 
            // mtxtRG
            // 
            this.mtxtRG.Location = new System.Drawing.Point(173, 46);
            this.mtxtRG.Mask = "00,000,000-A";
            this.mtxtRG.Name = "mtxtRG";
            this.mtxtRG.Size = new System.Drawing.Size(74, 20);
            this.mtxtRG.TabIndex = 2;
            this.mtxtRG.Click += new System.EventHandler(this.mtxt_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(6, 48);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF:";
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(50, 45);
            this.mtxtCPF.Mask = "000,000,000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(85, 20);
            this.mtxtCPF.TabIndex = 1;
            this.mtxtCPF.Click += new System.EventHandler(this.mtxt_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(50, 19);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(466, 20);
            this.txtNome.TabIndex = 0;
            // 
            // gbLogradouro
            // 
            this.gbLogradouro.Controls.Add(this.txtNumero);
            this.gbLogradouro.Controls.Add(this.lblNumero);
            this.gbLogradouro.Controls.Add(this.mtxtCEP);
            this.gbLogradouro.Controls.Add(this.lblCEP);
            this.gbLogradouro.Controls.Add(this.lblEstado);
            this.gbLogradouro.Controls.Add(this.cbEstado);
            this.gbLogradouro.Controls.Add(this.lblMunicipio);
            this.gbLogradouro.Controls.Add(this.txtMunicipio);
            this.gbLogradouro.Controls.Add(this.txtBairro);
            this.gbLogradouro.Controls.Add(this.txtCompl);
            this.gbLogradouro.Controls.Add(this.lblEndereco);
            this.gbLogradouro.Controls.Add(this.lblCompl);
            this.gbLogradouro.Controls.Add(this.lblBairro);
            this.gbLogradouro.Controls.Add(this.txtEndereco);
            this.gbLogradouro.Location = new System.Drawing.Point(9, 115);
            this.gbLogradouro.Name = "gbLogradouro";
            this.gbLogradouro.Size = new System.Drawing.Size(522, 175);
            this.gbLogradouro.TabIndex = 1;
            this.gbLogradouro.TabStop = false;
            this.gbLogradouro.Text = "Logradouro";
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(86, 45);
            this.txtNumero.MaxLength = 15;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(84, 20);
            this.txtNumero.TabIndex = 21;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 48);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 20;
            this.lblNumero.Text = "Número:";
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.Location = new System.Drawing.Point(173, 149);
            this.mtxtCEP.Mask = "00000-000";
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(64, 20);
            this.mtxtCEP.TabIndex = 5;
            this.mtxtCEP.Click += new System.EventHandler(this.mtxt_Click);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(136, 152);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 19;
            this.lblCEP.Text = "CEP:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(6, 152);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado:";
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
            this.cbEstado.Location = new System.Drawing.Point(86, 149);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(44, 21);
            this.cbEstado.TabIndex = 4;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(6, 126);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(57, 13);
            this.lblMunicipio.TabIndex = 16;
            this.lblMunicipio.Text = "Município:";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMunicipio.Location = new System.Drawing.Point(86, 123);
            this.txtMunicipio.MaxLength = 35;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(215, 20);
            this.txtMunicipio.TabIndex = 3;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(86, 97);
            this.txtBairro.MaxLength = 40;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(288, 20);
            this.txtBairro.TabIndex = 2;
            // 
            // txtCompl
            // 
            this.txtCompl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCompl.Location = new System.Drawing.Point(86, 71);
            this.txtCompl.MaxLength = 40;
            this.txtCompl.Name = "txtCompl";
            this.txtCompl.Size = new System.Drawing.Size(405, 20);
            this.txtCompl.TabIndex = 1;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(6, 22);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 10;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblCompl
            // 
            this.lblCompl.AutoSize = true;
            this.lblCompl.Location = new System.Drawing.Point(6, 74);
            this.lblCompl.Name = "lblCompl";
            this.lblCompl.Size = new System.Drawing.Size(74, 13);
            this.lblCompl.TabIndex = 11;
            this.lblCompl.Text = "Complemento:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(6, 100);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 12;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(86, 19);
            this.txtEndereco.MaxLength = 60;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(430, 20);
            this.txtEndereco.TabIndex = 0;
            // 
            // gbContato
            // 
            this.gbContato.Controls.Add(this.lblEmail);
            this.gbContato.Controls.Add(this.txtEmail);
            this.gbContato.Controls.Add(this.lblTel3);
            this.gbContato.Controls.Add(this.mtxtTel3);
            this.gbContato.Controls.Add(this.lblTel2);
            this.gbContato.Controls.Add(this.mtxtTel2);
            this.gbContato.Controls.Add(this.lblTel1);
            this.gbContato.Controls.Add(this.mtxtTel1);
            this.gbContato.Location = new System.Drawing.Point(9, 296);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(522, 75);
            this.gbContato.TabIndex = 2;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Contato";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 48);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(73, 45);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(443, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblTel3
            // 
            this.lblTel3.AutoSize = true;
            this.lblTel3.Location = new System.Drawing.Point(332, 22);
            this.lblTel3.Name = "lblTel3";
            this.lblTel3.Size = new System.Drawing.Size(61, 13);
            this.lblTel3.TabIndex = 23;
            this.lblTel3.Text = "Telefone 3:";
            // 
            // mtxtTel3
            // 
            this.mtxtTel3.Location = new System.Drawing.Point(399, 19);
            this.mtxtTel3.Mask = "(00) 0,0000-0000";
            this.mtxtTel3.Name = "mtxtTel3";
            this.mtxtTel3.Size = new System.Drawing.Size(90, 20);
            this.mtxtTel3.TabIndex = 2;
            this.mtxtTel3.Click += new System.EventHandler(this.mtxt_Click);
            this.mtxtTel3.Enter += new System.EventHandler(this.mtxtTelefones_Enter);
            this.mtxtTel3.Leave += new System.EventHandler(this.mtxtTelefones_Leave);
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.Location = new System.Drawing.Point(169, 22);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(61, 13);
            this.lblTel2.TabIndex = 22;
            this.lblTel2.Text = "Telefone 2:";
            // 
            // mtxtTel2
            // 
            this.mtxtTel2.Location = new System.Drawing.Point(236, 19);
            this.mtxtTel2.Mask = "(00) 0,0000-0000";
            this.mtxtTel2.Name = "mtxtTel2";
            this.mtxtTel2.Size = new System.Drawing.Size(90, 20);
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
            this.lblTel1.TabIndex = 21;
            this.lblTel1.Text = "Telefone 1:";
            // 
            // mtxtTel1
            // 
            this.mtxtTel1.Location = new System.Drawing.Point(73, 19);
            this.mtxtTel1.Mask = "(00) 0,0000-0000";
            this.mtxtTel1.Name = "mtxtTel1";
            this.mtxtTel1.Size = new System.Drawing.Size(90, 20);
            this.mtxtTel1.TabIndex = 0;
            this.mtxtTel1.Click += new System.EventHandler(this.mtxt_Click);
            this.mtxtTel1.Enter += new System.EventHandler(this.mtxtTelefones_Enter);
            this.mtxtTel1.Leave += new System.EventHandler(this.mtxtTelefones_Leave);
            // 
            // gbDadosBancarios
            // 
            this.gbDadosBancarios.Controls.Add(this.cbBanco);
            this.gbDadosBancarios.Controls.Add(this.lblBanco);
            this.gbDadosBancarios.Controls.Add(this.txtConta);
            this.gbDadosBancarios.Controls.Add(this.lblConta);
            this.gbDadosBancarios.Controls.Add(this.lblAgencia);
            this.gbDadosBancarios.Controls.Add(this.txtAgencia);
            this.gbDadosBancarios.Controls.Add(this.lblFavorecido);
            this.gbDadosBancarios.Controls.Add(this.txtFavorecido);
            this.gbDadosBancarios.Location = new System.Drawing.Point(9, 377);
            this.gbDadosBancarios.Name = "gbDadosBancarios";
            this.gbDadosBancarios.Size = new System.Drawing.Size(522, 72);
            this.gbDadosBancarios.TabIndex = 3;
            this.gbDadosBancarios.TabStop = false;
            this.gbDadosBancarios.Text = "Dados Bancários";
            // 
            // cbBanco
            // 
            this.cbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Items.AddRange(new object[] {
            "BANCO DO BRASIL",
            "ITAÚ",
            "CAIXA ECONÔMICA FEDERAL",
            "BRADESCO",
            "BNDES",
            "SANTANDER",
            "HSBC",
            "BANCO SAFRA",
            "BTG PACTUAL",
            "VOTORAANTIM",
            "CITIBANK",
            "BANRISUL",
            "JP MORGAN CHASE",
            "CREDIT SUISSE",
            "BANCO DO NORDESTE DO BRASIL",
            "DEUTSCHE",
            "BMG",
            "BANCO VOLKSVAGEM",
            "BANCO COOPERATIVO SICREDI",
            "PANAMERICANO"});
            this.cbBanco.Location = new System.Drawing.Point(303, 45);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(213, 21);
            this.cbBanco.TabIndex = 3;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(256, 48);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(41, 13);
            this.lblBanco.TabIndex = 6;
            this.lblBanco.Text = "Banco:";
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(180, 45);
            this.txtConta.MaxLength = 10;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(70, 20);
            this.txtConta.TabIndex = 2;
            this.txtConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(136, 48);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(38, 13);
            this.lblConta.TabIndex = 4;
            this.lblConta.Text = "Conta:";
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(6, 48);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(49, 13);
            this.lblAgencia.TabIndex = 3;
            this.lblAgencia.Text = "Agência:";
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(75, 45);
            this.txtAgencia.MaxLength = 8;
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(55, 20);
            this.txtAgencia.TabIndex = 1;
            this.txtAgencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblFavorecido
            // 
            this.lblFavorecido.AutoSize = true;
            this.lblFavorecido.Location = new System.Drawing.Point(6, 22);
            this.lblFavorecido.Name = "lblFavorecido";
            this.lblFavorecido.Size = new System.Drawing.Size(63, 13);
            this.lblFavorecido.TabIndex = 1;
            this.lblFavorecido.Text = "Favorecido:";
            // 
            // txtFavorecido
            // 
            this.txtFavorecido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFavorecido.Location = new System.Drawing.Point(75, 19);
            this.txtFavorecido.MaxLength = 60;
            this.txtFavorecido.Name = "txtFavorecido";
            this.txtFavorecido.Size = new System.Drawing.Size(441, 20);
            this.txtFavorecido.TabIndex = 0;
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(9, 455);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 4;
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
            this.panel1.Size = new System.Drawing.Size(540, 30);
            this.panel1.TabIndex = 5;
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
            this.btMin.Location = new System.Drawing.Point(460, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(40, 30);
            this.btMin.TabIndex = 2;
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
            this.btX.Location = new System.Drawing.Point(500, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(40, 30);
            this.btX.TabIndex = 1;
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
            this.label1.Text = "Cadastro de Representantes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(537, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 457);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 484);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 3);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 454);
            this.panel4.TabIndex = 8;
            // 
            // btExcluir
            // 
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Location = new System.Drawing.Point(90, 455);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 9;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Location = new System.Drawing.Point(456, 455);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 10;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Location = new System.Drawing.Point(375, 455);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 11;
            this.btLimpar.Text = "Limpar Tela";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lblSalvo
            // 
            this.lblSalvo.AutoSize = true;
            this.lblSalvo.ForeColor = System.Drawing.Color.Green;
            this.lblSalvo.Location = new System.Drawing.Point(171, 460);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(73, 13);
            this.lblSalvo.TabIndex = 21;
            this.lblSalvo.Text = "Dados Salvos";
            this.lblSalvo.Visible = false;
            // 
            // FrmRepres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(540, 487);
            this.Controls.Add(this.lblSalvo);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.gbDadosBancarios);
            this.Controls.Add(this.gbContato);
            this.Controls.Add(this.gbLogradouro);
            this.Controls.Add(this.gbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRepres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Representantes";
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.gbLogradouro.ResumeLayout(false);
            this.gbLogradouro.PerformLayout();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.gbDadosBancarios.ResumeLayout(false);
            this.gbDadosBancarios.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbLogradouro;
        private System.Windows.Forms.MaskedTextBox mtxtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCompl;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCompl;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox mtxtRG;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTel3;
        private System.Windows.Forms.MaskedTextBox mtxtTel3;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.MaskedTextBox mtxtTel2;
        private System.Windows.Forms.Label lblTel1;
        private System.Windows.Forms.MaskedTextBox mtxtTel1;
        private System.Windows.Forms.GroupBox gbDadosBancarios;
        private System.Windows.Forms.Label lblFavorecido;
        private System.Windows.Forms.TextBox txtFavorecido;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.ComboBox cbBanco;
        private System.Windows.Forms.ComboBox cbRegiao;
        private System.Windows.Forms.Label lblRegiao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lblSalvo;
    }
}