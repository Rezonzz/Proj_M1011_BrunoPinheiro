namespace Proj_M1011_BrunoPinheiro
{
    partial class frm_consultarmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_consultarmenu));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_autor = new System.Windows.Forms.Button();
            this.btn_artigos = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.pic_minimize = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
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
            this.pnl_top.TabIndex = 12;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Akira Expanded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "MENU";
            // 
            // lbl_username
            // 
            this.lbl_username.Font = new System.Drawing.Font("Akira Expanded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_username.Location = new System.Drawing.Point(194, 106);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(166, 19);
            this.lbl_username.TabIndex = 17;
            this.lbl_username.Text = "Consultar";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_autor.TabIndex = 15;
            this.btn_autor.Text = "Stock";
            this.btn_autor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_autor.UseVisualStyleBackColor = true;
            // 
            // btn_artigos
            // 
            this.btn_artigos.FlatAppearance.BorderSize = 0;
            this.btn_artigos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_artigos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_artigos.Font = new System.Drawing.Font("Futura-Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artigos.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.jordan3;
            this.btn_artigos.Location = new System.Drawing.Point(163, 109);
            this.btn_artigos.Name = "btn_artigos";
            this.btn_artigos.Size = new System.Drawing.Size(110, 128);
            this.btn_artigos.TabIndex = 14;
            this.btn_artigos.Text = "Artigos";
            this.btn_artigos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_artigos.UseVisualStyleBackColor = true;
            this.btn_artigos.Click += new System.EventHandler(this.btn_artigos_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.jordan11;
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_voltar.Location = new System.Drawing.Point(464, 264);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(84, 67);
            this.btn_voltar.TabIndex = 13;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            this.btn_voltar.MouseLeave += new System.EventHandler(this.btn_voltar_MouseLeave);
            this.btn_voltar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_voltar_MouseMove);
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
            // frm_consultarmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(548, 331);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_autor);
            this.Controls.Add(this.btn_artigos);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_consultarmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jordan - Menu Consultar";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.PictureBox pic_minimize;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_autor;
        private System.Windows.Forms.Button btn_artigos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_username;
    }
}