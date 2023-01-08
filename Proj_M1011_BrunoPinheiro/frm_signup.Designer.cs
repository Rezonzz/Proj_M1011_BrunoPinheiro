namespace Proj_M1011_BrunoPinheiro
{
    partial class frm_signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_signup));
            this.lbl_invalido = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_limpar = new System.Windows.Forms.Label();
            this.lbl_sair = new System.Windows.Forms.Label();
            this.btn_signup = new System.Windows.Forms.Button();
            this.lbl_login = new System.Windows.Forms.Label();
            this.pnl_2 = new System.Windows.Forms.Panel();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.txt_confirmar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_vazio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rad_sim = new System.Windows.Forms.RadioButton();
            this.rad_nao = new System.Windows.Forms.RadioButton();
            this.txt_passe = new System.Windows.Forms.TextBox();
            this.pnl_passe = new System.Windows.Forms.Panel();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pic_minimize = new System.Windows.Forms.PictureBox();
            this.pic_confirmar = new System.Windows.Forms.PictureBox();
            this.pic_passe = new System.Windows.Forms.PictureBox();
            this.pic_mostrar2 = new System.Windows.Forms.PictureBox();
            this.pic_ocultado2 = new System.Windows.Forms.PictureBox();
            this.pic_mostrar = new System.Windows.Forms.PictureBox();
            this.pic_ocultado = new System.Windows.Forms.PictureBox();
            this.pic_password = new System.Windows.Forms.PictureBox();
            this.pic_username = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_confirmar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_passe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mostrar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ocultado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ocultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_invalido
            // 
            this.lbl_invalido.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invalido.ForeColor = System.Drawing.Color.Red;
            this.lbl_invalido.Location = new System.Drawing.Point(49, 467);
            this.lbl_invalido.Name = "lbl_invalido";
            this.lbl_invalido.Size = new System.Drawing.Size(236, 32);
            this.lbl_invalido.TabIndex = 73;
            this.lbl_invalido.Text = "Username ou Password Inválidos";
            this.lbl_invalido.Visible = false;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.Location = new System.Drawing.Point(95, 316);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(154, 27);
            this.txt_password.TabIndex = 72;
            this.txt_password.Text = "Password";
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.Click += new System.EventHandler(this.txt_password_Click);
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.Location = new System.Drawing.Point(95, 238);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(191, 27);
            this.txt_username.TabIndex = 71;
            this.txt_username.Text = "Username";
            this.txt_username.Click += new System.EventHandler(this.txt_username_Click);
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            this.txt_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_username_KeyDown);
            // 
            // lbl_limpar
            // 
            this.lbl_limpar.AutoSize = true;
            this.lbl_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_limpar.Enabled = false;
            this.lbl_limpar.Font = new System.Drawing.Font("Futura-Heavy", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_limpar.ForeColor = System.Drawing.Color.Black;
            this.lbl_limpar.Location = new System.Drawing.Point(238, 511);
            this.lbl_limpar.Name = "lbl_limpar";
            this.lbl_limpar.Size = new System.Drawing.Size(44, 16);
            this.lbl_limpar.TabIndex = 70;
            this.lbl_limpar.Text = "Limpar";
            this.lbl_limpar.Visible = false;
            this.lbl_limpar.Click += new System.EventHandler(this.lbl_limpar_Click);
            // 
            // lbl_sair
            // 
            this.lbl_sair.AutoSize = true;
            this.lbl_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_sair.Font = new System.Drawing.Font("Futura-Heavy", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sair.ForeColor = System.Drawing.Color.Black;
            this.lbl_sair.Location = new System.Drawing.Point(139, 544);
            this.lbl_sair.Name = "lbl_sair";
            this.lbl_sair.Size = new System.Drawing.Size(41, 16);
            this.lbl_sair.TabIndex = 69;
            this.lbl_sair.Text = "Voltar";
            this.lbl_sair.Click += new System.EventHandler(this.lbl_sair_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.White;
            this.btn_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.Font = new System.Drawing.Font("Akira Expanded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.Color.Black;
            this.btn_signup.Location = new System.Drawing.Point(92, 504);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(140, 37);
            this.btn_signup.TabIndex = 68;
            this.btn_signup.Text = "SIGN UP";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_signup.MouseLeave += new System.EventHandler(this.btn_login_MouseLeave);
            this.btn_signup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_login_MouseMove);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Akira Expanded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_login.Location = new System.Drawing.Point(73, 179);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(195, 34);
            this.lbl_login.TabIndex = 67;
            this.lbl_login.Text = "SIGN UP";
            // 
            // pnl_2
            // 
            this.pnl_2.BackColor = System.Drawing.SystemColors.ControlText;
            this.pnl_2.Location = new System.Drawing.Point(52, 353);
            this.pnl_2.Name = "pnl_2";
            this.pnl_2.Size = new System.Drawing.Size(236, 1);
            this.pnl_2.TabIndex = 66;
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pnl_1.Location = new System.Drawing.Point(52, 276);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(236, 1);
            this.pnl_1.TabIndex = 65;
            // 
            // txt_confirmar
            // 
            this.txt_confirmar.BackColor = System.Drawing.Color.White;
            this.txt_confirmar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirmar.Font = new System.Drawing.Font("Futura-Heavy", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmar.ForeColor = System.Drawing.Color.Black;
            this.txt_confirmar.Location = new System.Drawing.Point(94, 392);
            this.txt_confirmar.Multiline = true;
            this.txt_confirmar.Name = "txt_confirmar";
            this.txt_confirmar.PasswordChar = '*';
            this.txt_confirmar.Size = new System.Drawing.Size(163, 27);
            this.txt_confirmar.TabIndex = 79;
            this.txt_confirmar.Text = "Confirmar Password";
            this.txt_confirmar.UseSystemPasswordChar = true;
            this.txt_confirmar.Click += new System.EventHandler(this.txt_confirmar_Click);
            this.txt_confirmar.TextChanged += new System.EventHandler(this.txt_confirmar_TextChanged);
            this.txt_confirmar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_confirmar_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(52, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 78;
            // 
            // lbl_vazio
            // 
            this.lbl_vazio.ForeColor = System.Drawing.Color.Red;
            this.lbl_vazio.Location = new System.Drawing.Point(49, 467);
            this.lbl_vazio.Name = "lbl_vazio";
            this.lbl_vazio.Size = new System.Drawing.Size(260, 19);
            this.lbl_vazio.TabIndex = 82;
            this.lbl_vazio.Text = "As caixas do Username ou/e Password estão vazios";
            this.lbl_vazio.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Tem passe de gestor?";
            // 
            // rad_sim
            // 
            this.rad_sim.AutoSize = true;
            this.rad_sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad_sim.Location = new System.Drawing.Point(175, 441);
            this.rad_sim.Name = "rad_sim";
            this.rad_sim.Size = new System.Drawing.Size(41, 17);
            this.rad_sim.TabIndex = 84;
            this.rad_sim.TabStop = true;
            this.rad_sim.Text = "Sim";
            this.rad_sim.UseVisualStyleBackColor = true;
            this.rad_sim.CheckedChanged += new System.EventHandler(this.rad_sim_CheckedChanged);
            // 
            // rad_nao
            // 
            this.rad_nao.AutoSize = true;
            this.rad_nao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad_nao.Location = new System.Drawing.Point(235, 441);
            this.rad_nao.Name = "rad_nao";
            this.rad_nao.Size = new System.Drawing.Size(44, 17);
            this.rad_nao.TabIndex = 85;
            this.rad_nao.TabStop = true;
            this.rad_nao.Text = "Não";
            this.rad_nao.UseVisualStyleBackColor = true;
            this.rad_nao.CheckedChanged += new System.EventHandler(this.rad_nao_CheckedChanged);
            // 
            // txt_passe
            // 
            this.txt_passe.BackColor = System.Drawing.Color.White;
            this.txt_passe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_passe.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passe.ForeColor = System.Drawing.Color.Black;
            this.txt_passe.Location = new System.Drawing.Point(95, 483);
            this.txt_passe.Multiline = true;
            this.txt_passe.Name = "txt_passe";
            this.txt_passe.PasswordChar = '*';
            this.txt_passe.Size = new System.Drawing.Size(194, 27);
            this.txt_passe.TabIndex = 88;
            this.txt_passe.Text = "Passe de Gestor";
            this.txt_passe.UseSystemPasswordChar = true;
            this.txt_passe.Visible = false;
            this.txt_passe.Click += new System.EventHandler(this.txt_passe_Click);
            this.txt_passe.TextChanged += new System.EventHandler(this.txt_passe_TextChanged);
            // 
            // pnl_passe
            // 
            this.pnl_passe.BackColor = System.Drawing.SystemColors.ControlText;
            this.pnl_passe.Location = new System.Drawing.Point(52, 519);
            this.pnl_passe.Name = "pnl_passe";
            this.pnl_passe.Size = new System.Drawing.Size(236, 1);
            this.pnl_passe.TabIndex = 87;
            this.pnl_passe.Visible = false;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_top.Controls.Add(this.lbl_name);
            this.pnl_top.Controls.Add(this.pic_close);
            this.pnl_top.Controls.Add(this.pic_logo);
            this.pnl_top.Controls.Add(this.pic_minimize);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(337, 51);
            this.pnl_top.TabIndex = 89;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Akira Expanded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(50, 15);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(116, 20);
            this.lbl_name.TabIndex = 101;
            this.lbl_name.Text = "JORDAN";
            this.lbl_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_name_MouseDown);
            // 
            // pic_close
            // 
            this.pic_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_close.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.close;
            this.pic_close.Location = new System.Drawing.Point(304, 17);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(18, 18);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 99;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources._584292c4a6515b1e0ad75aca1;
            this.pic_logo.Location = new System.Drawing.Point(12, 9);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(32, 32);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 102;
            this.pic_logo.TabStop = false;
            this.pic_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_logo_MouseDown);
            // 
            // pic_minimize
            // 
            this.pic_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_minimize.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.minus_sign;
            this.pic_minimize.Location = new System.Drawing.Point(269, 17);
            this.pic_minimize.Name = "pic_minimize";
            this.pic_minimize.Size = new System.Drawing.Size(18, 18);
            this.pic_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_minimize.TabIndex = 100;
            this.pic_minimize.TabStop = false;
            this.pic_minimize.Click += new System.EventHandler(this.pic_minimize_Click);
            // 
            // pic_confirmar
            // 
            this.pic_confirmar.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.padlock__1_;
            this.pic_confirmar.Location = new System.Drawing.Point(52, 384);
            this.pic_confirmar.Name = "pic_confirmar";
            this.pic_confirmar.Size = new System.Drawing.Size(37, 36);
            this.pic_confirmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_confirmar.TabIndex = 77;
            this.pic_confirmar.TabStop = false;
            // 
            // pic_passe
            // 
            this.pic_passe.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.id_card;
            this.pic_passe.Location = new System.Drawing.Point(52, 477);
            this.pic_passe.Name = "pic_passe";
            this.pic_passe.Size = new System.Drawing.Size(37, 36);
            this.pic_passe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_passe.TabIndex = 86;
            this.pic_passe.TabStop = false;
            this.pic_passe.Visible = false;
            // 
            // pic_mostrar2
            // 
            this.pic_mostrar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_mostrar2.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.view;
            this.pic_mostrar2.Location = new System.Drawing.Point(259, 388);
            this.pic_mostrar2.Name = "pic_mostrar2";
            this.pic_mostrar2.Size = new System.Drawing.Size(30, 30);
            this.pic_mostrar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_mostrar2.TabIndex = 81;
            this.pic_mostrar2.TabStop = false;
            this.pic_mostrar2.Click += new System.EventHandler(this.pic_mostrar2_Click);
            // 
            // pic_ocultado2
            // 
            this.pic_ocultado2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_ocultado2.Enabled = false;
            this.pic_ocultado2.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.hide__1_;
            this.pic_ocultado2.Location = new System.Drawing.Point(259, 388);
            this.pic_ocultado2.Name = "pic_ocultado2";
            this.pic_ocultado2.Size = new System.Drawing.Size(30, 30);
            this.pic_ocultado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ocultado2.TabIndex = 80;
            this.pic_ocultado2.TabStop = false;
            this.pic_ocultado2.Visible = false;
            this.pic_ocultado2.Click += new System.EventHandler(this.pic_ocultado2_Click);
            // 
            // pic_mostrar
            // 
            this.pic_mostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_mostrar.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.view;
            this.pic_mostrar.Location = new System.Drawing.Point(259, 315);
            this.pic_mostrar.Name = "pic_mostrar";
            this.pic_mostrar.Size = new System.Drawing.Size(30, 30);
            this.pic_mostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_mostrar.TabIndex = 76;
            this.pic_mostrar.TabStop = false;
            this.pic_mostrar.Click += new System.EventHandler(this.pic_mostrar_Click);
            // 
            // pic_ocultado
            // 
            this.pic_ocultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_ocultado.Enabled = false;
            this.pic_ocultado.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.hide__1_;
            this.pic_ocultado.Location = new System.Drawing.Point(259, 315);
            this.pic_ocultado.Name = "pic_ocultado";
            this.pic_ocultado.Size = new System.Drawing.Size(30, 30);
            this.pic_ocultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ocultado.TabIndex = 75;
            this.pic_ocultado.TabStop = false;
            this.pic_ocultado.Visible = false;
            this.pic_ocultado.Click += new System.EventHandler(this.pic_ocultado_Click);
            // 
            // pic_password
            // 
            this.pic_password.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.padlock__1_;
            this.pic_password.Location = new System.Drawing.Point(52, 311);
            this.pic_password.Name = "pic_password";
            this.pic_password.Size = new System.Drawing.Size(37, 36);
            this.pic_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_password.TabIndex = 64;
            this.pic_password.TabStop = false;
            // 
            // pic_username
            // 
            this.pic_username.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.account__1_;
            this.pic_username.Location = new System.Drawing.Point(52, 234);
            this.pic_username.Name = "pic_username";
            this.pic_username.Size = new System.Drawing.Size(37, 36);
            this.pic_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_username.TabIndex = 63;
            this.pic_username.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources._9c8286a9ddb18ecc7709a490b5084c2a_removebg_preview__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-21, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Futura-Heavy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(91, 222);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(75, 19);
            this.lbl_username.TabIndex = 90;
            this.lbl_username.Text = "Username";
            this.lbl_username.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura-Heavy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 91;
            this.label2.Text = "Password";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Futura-Heavy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 19);
            this.label3.TabIndex = 92;
            this.label3.Text = "Confirmar Password";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Futura-Heavy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 93;
            this.label4.Text = "Passe de Gestor";
            this.label4.Visible = false;
            // 
            // frm_signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(337, 576);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pic_confirmar);
            this.Controls.Add(this.pic_passe);
            this.Controls.Add(this.txt_passe);
            this.Controls.Add(this.pnl_passe);
            this.Controls.Add(this.rad_nao);
            this.Controls.Add(this.rad_sim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_vazio);
            this.Controls.Add(this.pic_mostrar2);
            this.Controls.Add(this.pic_ocultado2);
            this.Controls.Add(this.txt_confirmar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_mostrar);
            this.Controls.Add(this.pic_ocultado);
            this.Controls.Add(this.lbl_invalido);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_limpar);
            this.Controls.Add(this.lbl_sair);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.pnl_2);
            this.Controls.Add(this.pnl_1);
            this.Controls.Add(this.pic_password);
            this.Controls.Add(this.pic_username);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jordan - Sign In";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_confirmar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_passe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mostrar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ocultado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ocultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_mostrar;
        private System.Windows.Forms.PictureBox pic_ocultado;
        private System.Windows.Forms.Label lbl_invalido;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_limpar;
        private System.Windows.Forms.Label lbl_sair;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Panel pnl_2;
        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.PictureBox pic_password;
        private System.Windows.Forms.PictureBox pic_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_mostrar2;
        private System.Windows.Forms.PictureBox pic_ocultado2;
        private System.Windows.Forms.TextBox txt_confirmar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_confirmar;
        private System.Windows.Forms.Label lbl_vazio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rad_sim;
        private System.Windows.Forms.RadioButton rad_nao;
        private System.Windows.Forms.TextBox txt_passe;
        private System.Windows.Forms.Panel pnl_passe;
        private System.Windows.Forms.PictureBox pic_passe;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.PictureBox pic_minimize;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}