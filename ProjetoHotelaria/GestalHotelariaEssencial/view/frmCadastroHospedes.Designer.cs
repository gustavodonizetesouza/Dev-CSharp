namespace GestalHotelariaEssencial.view
{
    partial class frmCadastroHospedes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroHospedes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLista = new System.Windows.Forms.TabPage();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.txtPesquidaDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.ckbDataNascimento = new System.Windows.Forms.CheckBox();
            this.txtPesquisaCPF = new System.Windows.Forms.MaskedTextBox();
            this.ckDescricao = new System.Windows.Forms.CheckBox();
            this.ckbCpf = new System.Windows.Forms.CheckBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneSecundario = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefonePrincipal = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gbSituacao = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.cbUf = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.tabMovimento = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabLista.SuspendLayout();
            this.gbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.tabInfo.SuspendLayout();
            this.gbSituacao.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabMovimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label23);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 57);
            this.panel1.TabIndex = 41;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(6, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(385, 39);
            this.label23.TabIndex = 46;
            this.label23.Text = "Cadastro de Hospedes";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabLista);
            this.tabControl.Controls.Add(this.tabInfo);
            this.tabControl.Controls.Add(this.tabMovimento);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(3, 71);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(990, 426);
            this.tabControl.TabIndex = 42;
            // 
            // tabLista
            // 
            this.tabLista.BackColor = System.Drawing.SystemColors.Control;
            this.tabLista.Controls.Add(this.gbPesquisa);
            this.tabLista.Controls.Add(this.grid);
            this.tabLista.Location = new System.Drawing.Point(4, 24);
            this.tabLista.Name = "tabLista";
            this.tabLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabLista.Size = new System.Drawing.Size(982, 398);
            this.tabLista.TabIndex = 0;
            this.tabLista.Text = "Lista de Hospedes";
            // 
            // gbPesquisa
            // 
            this.gbPesquisa.Controls.Add(this.txtPesquidaDataNascimento);
            this.gbPesquisa.Controls.Add(this.ckbDataNascimento);
            this.gbPesquisa.Controls.Add(this.txtPesquisaCPF);
            this.gbPesquisa.Controls.Add(this.ckDescricao);
            this.gbPesquisa.Controls.Add(this.ckbCpf);
            this.gbPesquisa.Controls.Add(this.btnPesquisar);
            this.gbPesquisa.Controls.Add(this.txtPesquisa);
            this.gbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPesquisa.Location = new System.Drawing.Point(6, 6);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Size = new System.Drawing.Size(967, 83);
            this.gbPesquisa.TabIndex = 38;
            this.gbPesquisa.TabStop = false;
            this.gbPesquisa.Text = "Pesquisar";
            // 
            // txtPesquidaDataNascimento
            // 
            this.txtPesquidaDataNascimento.Enabled = false;
            this.txtPesquidaDataNascimento.Location = new System.Drawing.Point(754, 53);
            this.txtPesquidaDataNascimento.Mask = "00/00/0000";
            this.txtPesquidaDataNascimento.Name = "txtPesquidaDataNascimento";
            this.txtPesquidaDataNascimento.Size = new System.Drawing.Size(133, 21);
            this.txtPesquidaDataNascimento.TabIndex = 118;
            this.txtPesquidaDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // ckbDataNascimento
            // 
            this.ckbDataNascimento.AutoSize = true;
            this.ckbDataNascimento.Location = new System.Drawing.Point(754, 33);
            this.ckbDataNascimento.Name = "ckbDataNascimento";
            this.ckbDataNascimento.Size = new System.Drawing.Size(136, 19);
            this.ckbDataNascimento.TabIndex = 117;
            this.ckbDataNascimento.Text = "Data Nascimento";
            this.ckbDataNascimento.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaCPF
            // 
            this.txtPesquisaCPF.Enabled = false;
            this.txtPesquisaCPF.Location = new System.Drawing.Point(626, 53);
            this.txtPesquisaCPF.Mask = "999,999,999-99";
            this.txtPesquisaCPF.Name = "txtPesquisaCPF";
            this.txtPesquisaCPF.Size = new System.Drawing.Size(117, 21);
            this.txtPesquisaCPF.TabIndex = 116;
            // 
            // ckDescricao
            // 
            this.ckDescricao.AutoSize = true;
            this.ckDescricao.Location = new System.Drawing.Point(6, 33);
            this.ckDescricao.Name = "ckDescricao";
            this.ckDescricao.Size = new System.Drawing.Size(90, 19);
            this.ckDescricao.TabIndex = 114;
            this.ckDescricao.Text = "Por Nome";
            this.ckDescricao.UseVisualStyleBackColor = true;
            // 
            // ckbCpf
            // 
            this.ckbCpf.AutoSize = true;
            this.ckbCpf.Location = new System.Drawing.Point(626, 33);
            this.ckbCpf.Name = "ckbCpf";
            this.ckbCpf.Size = new System.Drawing.Size(52, 19);
            this.ckbCpf.TabIndex = 112;
            this.ckbCpf.Text = "CPF";
            this.ckbCpf.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(893, 22);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(68, 53);
            this.btnPesquisar.TabIndex = 39;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(4, 53);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(616, 21);
            this.txtPesquisa.TabIndex = 35;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(4, 95);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidth = 62;
            this.grid.Size = new System.Drawing.Size(970, 300);
            this.grid.TabIndex = 0;
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tabInfo.Controls.Add(this.txtCep);
            this.tabInfo.Controls.Add(this.txtTelefoneSecundario);
            this.tabInfo.Controls.Add(this.txtTelefonePrincipal);
            this.tabInfo.Controls.Add(this.label20);
            this.tabInfo.Controls.Add(this.txtObservacao);
            this.tabInfo.Controls.Add(this.txtCodigo);
            this.tabInfo.Controls.Add(this.label22);
            this.tabInfo.Controls.Add(this.txtDataNascimento);
            this.tabInfo.Controls.Add(this.label21);
            this.tabInfo.Controls.Add(this.cbEstadoCivil);
            this.tabInfo.Controls.Add(this.label12);
            this.tabInfo.Controls.Add(this.gbSituacao);
            this.tabInfo.Controls.Add(this.cbUf);
            this.tabInfo.Controls.Add(this.label19);
            this.tabInfo.Controls.Add(this.txtEmail);
            this.tabInfo.Controls.Add(this.groupBox2);
            this.tabInfo.Controls.Add(this.label11);
            this.tabInfo.Controls.Add(this.label7);
            this.tabInfo.Controls.Add(this.label8);
            this.tabInfo.Controls.Add(this.label9);
            this.tabInfo.Controls.Add(this.label10);
            this.tabInfo.Controls.Add(this.txtCidade);
            this.tabInfo.Controls.Add(this.label6);
            this.tabInfo.Controls.Add(this.txtComplemento);
            this.tabInfo.Controls.Add(this.label5);
            this.tabInfo.Controls.Add(this.txtBairro);
            this.tabInfo.Controls.Add(this.label3);
            this.tabInfo.Controls.Add(this.txtNumero);
            this.tabInfo.Controls.Add(this.label4);
            this.tabInfo.Controls.Add(this.txtEndereco);
            this.tabInfo.Controls.Add(this.label2);
            this.tabInfo.Controls.Add(this.txtNomeSocial);
            this.tabInfo.Controls.Add(this.label1);
            this.tabInfo.Controls.Add(this.txtNomeCliente);
            this.tabInfo.Location = new System.Drawing.Point(4, 24);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(982, 398);
            this.tabInfo.TabIndex = 1;
            this.tabInfo.Text = "Dados Hospedes";
            // 
            // txtCep
            // 
            this.txtCep.Enabled = false;
            this.txtCep.Location = new System.Drawing.Point(4, 82);
            this.txtCep.Mask = "99999-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(83, 21);
            this.txtCep.TabIndex = 6;
            // 
            // txtTelefoneSecundario
            // 
            this.txtTelefoneSecundario.Enabled = false;
            this.txtTelefoneSecundario.Location = new System.Drawing.Point(875, 137);
            this.txtTelefoneSecundario.Mask = "(99)99999-9999";
            this.txtTelefoneSecundario.Name = "txtTelefoneSecundario";
            this.txtTelefoneSecundario.Size = new System.Drawing.Size(100, 21);
            this.txtTelefoneSecundario.TabIndex = 16;
            // 
            // txtTelefonePrincipal
            // 
            this.txtTelefonePrincipal.Enabled = false;
            this.txtTelefonePrincipal.Location = new System.Drawing.Point(769, 137);
            this.txtTelefonePrincipal.Mask = "(99)99999-9999";
            this.txtTelefonePrincipal.Name = "txtTelefonePrincipal";
            this.txtTelefonePrincipal.Size = new System.Drawing.Size(100, 21);
            this.txtTelefonePrincipal.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(523, 169);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 15);
            this.label20.TabIndex = 45;
            this.label20.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Enabled = false;
            this.txtObservacao.Location = new System.Drawing.Point(523, 187);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(452, 21);
            this.txtObservacao.TabIndex = 18;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(6, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(81, 21);
            this.txtCodigo.TabIndex = 42;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 11);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 15);
            this.label22.TabIndex = 43;
            this.label22.Text = "Código";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Enabled = false;
            this.txtDataNascimento.Location = new System.Drawing.Point(663, 137);
            this.txtDataNascimento.Mask = "99/99/9999";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(100, 21);
            this.txtDataNascimento.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(660, 121);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 15);
            this.label21.TabIndex = 37;
            this.label21.Text = "Data Nascimento";
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.Enabled = false;
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "SOLTEIRO",
            "CASADO",
            "UNIAL ESTAVEL",
            "SEPERADO",
            "DIVORCIADO",
            "VIUVO",
            "NÃO INFORMADO"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(538, 135);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(119, 23);
            this.cbEstadoCivil.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(539, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 15);
            this.label12.TabIndex = 35;
            this.label12.Text = "Estado Civil";
            // 
            // gbSituacao
            // 
            this.gbSituacao.Controls.Add(this.rbInativo);
            this.gbSituacao.Controls.Add(this.rbAtivo);
            this.gbSituacao.Enabled = false;
            this.gbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSituacao.Location = new System.Drawing.Point(818, 3);
            this.gbSituacao.Name = "gbSituacao";
            this.gbSituacao.Size = new System.Drawing.Size(158, 50);
            this.gbSituacao.TabIndex = 3;
            this.gbSituacao.TabStop = false;
            this.gbSituacao.Text = "Situação";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(79, 22);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(67, 19);
            this.rbInativo.TabIndex = 5;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(9, 22);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(55, 19);
            this.rbAtivo.TabIndex = 4;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // cbUf
            // 
            this.cbUf.Enabled = false;
            this.cbUf.FormattingEnabled = true;
            this.cbUf.Items.AddRange(new object[] {
            "ACRE",
            "ALAGOAS",
            "AMAPA",
            "AMAZONAS",
            "BAHIA",
            "CEARA",
            "DISTRITO FEDERAL",
            "ESPIRITO SANTO",
            "GOIAS",
            "MARANHAO",
            "MATO GROSSO",
            "MATO GROSSO DO SUL",
            "MINAS GERAIS",
            "PARANA",
            "PARAIBA",
            "PERNAMBUCO",
            "PIAU",
            "RIO DE JANEIRO",
            "RIO GRANDE DO NORTE",
            "RIO GRANDE DO SUL",
            "RONDONIA",
            "RORAIMA",
            "SANTA CATARIA",
            "SANO PAULO",
            "SERGIPE",
            "TOCANTIS"});
            this.cbUf.Location = new System.Drawing.Point(384, 80);
            this.cbUf.Name = "cbUf";
            this.cbUf.Size = new System.Drawing.Size(101, 23);
            this.cbUf.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 169);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 15);
            this.label19.TabIndex = 31;
            this.label19.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(3, 187);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(514, 21);
            this.txtEmail.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcpf);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtRg);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 65);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // txtcpf
            // 
            this.txtcpf.Enabled = false;
            this.txtcpf.Location = new System.Drawing.Point(6, 38);
            this.txtcpf.Mask = "999,999,999-99";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(117, 21);
            this.txtcpf.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(134, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 15);
            this.label17.TabIndex = 41;
            this.label17.Text = "RG";
            // 
            // txtRg
            // 
            this.txtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRg.Enabled = false;
            this.txtRg.Location = new System.Drawing.Point(131, 38);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(128, 21);
            this.txtRg.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 15);
            this.label18.TabIndex = 39;
            this.label18.Text = "CPF";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(872, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Telefone 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(766, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Telefone Principal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "CEP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Estado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(93, 82);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(286, 21);
            this.txtCidade.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(716, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(713, 82);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(263, 21);
            this.txtComplemento.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(491, 82);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(213, 21);
            this.txtBairro.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nº";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(438, 135);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(94, 21);
            this.txtNumero.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(3, 135);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(426, 21);
            this.txtEndereco.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome Social";
            // 
            // txtNomeSocial
            // 
            this.txtNomeSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeSocial.Enabled = false;
            this.txtNomeSocial.Location = new System.Drawing.Point(521, 29);
            this.txtNomeSocial.Name = "txtNomeSocial";
            this.txtNomeSocial.Size = new System.Drawing.Size(291, 21);
            this.txtNomeSocial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome Hospede";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(93, 29);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(423, 21);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // tabMovimento
            // 
            this.tabMovimento.BackColor = System.Drawing.SystemColors.Control;
            this.tabMovimento.Controls.Add(this.dataGridView1);
            this.tabMovimento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabMovimento.Location = new System.Drawing.Point(4, 24);
            this.tabMovimento.Name = "tabMovimento";
            this.tabMovimento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovimento.Size = new System.Drawing.Size(982, 398);
            this.tabMovimento.TabIndex = 2;
            this.tabMovimento.Text = "Hospedagens";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(970, 389);
            this.dataGridView1.TabIndex = 1;
            // 
            // frmCadastroHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 568);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCadastroHospedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Hospedes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabLista.ResumeLayout(false);
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.gbSituacao.ResumeLayout(false);
            this.gbSituacao.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabMovimento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLista;
        private System.Windows.Forms.GroupBox gbPesquisa;
        private System.Windows.Forms.MaskedTextBox txtPesquidaDataNascimento;
        private System.Windows.Forms.CheckBox ckbDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtPesquisaCPF;
        private System.Windows.Forms.CheckBox ckDescricao;
        private System.Windows.Forms.CheckBox ckbCpf;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtTelefoneSecundario;
        private System.Windows.Forms.MaskedTextBox txtTelefonePrincipal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbSituacao;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.ComboBox cbUf;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TabPage tabMovimento;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}