namespace Proj_M1011_BrunoPinheiro
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pic_minimize = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_autor = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_artigos = new System.Windows.Forms.Button();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Akira Expanded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "MENU";
            // 
            // lbl_username
            // 
            this.lbl_username.Font = new System.Drawing.Font("Akira Expanded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_username.Location = new System.Drawing.Point(12, 106);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(524, 19);
            this.lbl_username.TabIndex = 9;
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_top
            // 
            this.pnl_top.Controls.Add(this.pic_minimize);
            this.pnl_top.Controls.Add(this.pic_close);
            this.pnl_top.Controls.Add(this.lbl_name);
            this.pnl_top.Controls.Add(this.pic_logo);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(548, 51);
            this.pnl_top.TabIndex = 11;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
            // 
            // pic_minimize
            // 
            this.pic_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_minimize.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.minus_sign;
            this.pic_minimize.Location = new System.Drawing.Point(478, 15);
            this.pic_minimize.Name = "pic_minimize";
            this.pic_minimize.Size = new System.Drawing.Size(20, 20);
            this.pic_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_minimize.TabIndex = 6;
            this.pic_minimize.TabStop = false;
            this.pic_minimize.Click += new System.EventHandler(this.pic_minimize_Click);
            // 
            // pic_close
            // 
            this.pic_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_close.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.close;
            this.pic_close.Location = new System.Drawing.Point(514, 15);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(20, 20);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 4;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Akira Expanded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(48, 15);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(116, 20);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "JORDAN";
            this.lbl_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_name_MouseDown);
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources._584292c4a6515b1e0ad75aca1;
            this.pic_logo.Location = new System.Drawing.Point(10, 9);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(32, 32);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 8;
            this.pic_logo.TabStop = false;
            this.pic_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_logo_MouseDown);
            // 
            // btn_logout
            // 
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.joordan9;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_logout.Location = new System.Drawing.Point(464, 264);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(84, 67);
            this.btn_logout.TabIndex = 10;
            this.btn_logout.Text = "Log out";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.button1_Click);
            this.btn_logout.MouseLeave += new System.EventHandler(this.btn_logout_MouseLeave);
            this.btn_logout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_logout_MouseMove);
            // 
            // btn_sair
            // 
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Futura-Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.jordan7;
            this.btn_sair.Location = new System.Drawing.Point(383, 109);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(110, 128);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            this.btn_sair.MouseLeave += new System.EventHandler(this.btn_sair_MouseLeave);
            this.btn_sair.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_sair_MouseMove);
            // 
            // btn_autor
            // 
            this.btn_autor.FlatAppearance.BorderSize = 0;
            this.btn_autor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_autor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autor.Font = new System.Drawing.Font("Futura-Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_autor.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.jordan51;
            this.btn_autor.Location = new System.Drawing.Point(273, 109);
            this.btn_autor.Name = "btn_autor";
            this.btn_autor.Size = new System.Drawing.Size(110, 128);
            this.btn_autor.TabIndex = 2;
            this.btn_autor.Text = "Autor";
            this.btn_autor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_autor.UseVisualStyleBackColor = true;
            this.btn_autor.Click += new System.EventHandler(this.btn_autor_Click);
            this.btn_autor.MouseLeave += new System.EventHandler(this.btn_autor_MouseLeave);
            this.btn_autor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_autor_MouseMove);
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar.Font = new System.Drawing.Font("Futura-Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.jordan3;
            this.btn_consultar.Location = new System.Drawing.Point(163, 109);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(110, 128);
            this.btn_consultar.TabIndex = 1;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            this.btn_consultar.MouseLeave += new System.EventHandler(this.btn_consultar_MouseLeave);
            this.btn_consultar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_consultar_MouseMove);
            // 
            // btn_artigos
            // 
            this.btn_artigos.FlatAppearance.BorderSize = 0;
            this.btn_artigos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_artigos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_artigos.Font = new System.Drawing.Font("Futura-Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artigos.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.jordan1;
            this.btn_artigos.Location = new System.Drawing.Point(53, 109);
            this.btn_artigos.Name = "btn_artigos";
            this.btn_artigos.Size = new System.Drawing.Size(110, 128);
            this.btn_artigos.TabIndex = 0;
            this.btn_artigos.Text = "Artigos";
            this.btn_artigos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_artigos.UseVisualStyleBackColor = true;
            this.btn_artigos.Click += new System.EventHandler(this.btn_artigos_Click);
            this.btn_artigos.MouseLeave += new System.EventHandler(this.btn_artigos_MouseLeave);
            this.btn_artigos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_artigos_MouseMove);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(548, 331);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_autor);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_artigos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jordan - Menu";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_artigos;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_autor;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.PictureBox pic_minimize;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pic_logo;
    }
}