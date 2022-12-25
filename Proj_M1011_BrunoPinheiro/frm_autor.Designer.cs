namespace Proj_M1011_BrunoPinheiro
{
    partial class frm_autor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_autor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_github = new System.Windows.Forms.PictureBox();
            this.btn_creditos = new System.Windows.Forms.Button();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_github)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Akira Expanded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "AUTOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Akira Expanded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(3, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bruno Pinheiro";
            // 
            // pic_github
            // 
            this.pic_github.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.github_mark;
            this.pic_github.Location = new System.Drawing.Point(165, 122);
            this.pic_github.Name = "pic_github";
            this.pic_github.Size = new System.Drawing.Size(62, 52);
            this.pic_github.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_github.TabIndex = 10;
            this.pic_github.TabStop = false;
            // 
            // btn_creditos
            // 
            this.btn_creditos.FlatAppearance.BorderSize = 0;
            this.btn_creditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_creditos.Font = new System.Drawing.Font("Futura-Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creditos.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.rsz_584292c4a6515b1e0ad75aca;
            this.btn_creditos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_creditos.Location = new System.Drawing.Point(139, 213);
            this.btn_creditos.Name = "btn_creditos";
            this.btn_creditos.Size = new System.Drawing.Size(114, 100);
            this.btn_creditos.TabIndex = 7;
            this.btn_creditos.Text = "Créditos";
            this.btn_creditos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_creditos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_creditos.UseVisualStyleBackColor = true;
            this.btn_creditos.Click += new System.EventHandler(this.btn_creditos_Click);
            // 
            // pic_close
            // 
            this.pic_close.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.close;
            this.pic_close.Location = new System.Drawing.Point(12, 12);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(24, 24);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 5;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources._89bb09f2_001c_4dd1_a9cd_010eab46d781;
            this.pictureBox1.Location = new System.Drawing.Point(400, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_autor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(593, 335);
            this.Controls.Add(this.pic_github);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_creditos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_autor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jordan - Autor";
            ((System.ComponentModel.ISupportInitialize)(this.pic_github)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_creditos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_github;
    }
}