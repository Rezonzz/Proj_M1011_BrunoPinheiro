namespace Proj_M1011_BrunoPinheiro
{
    partial class frm_consultarartigos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_consultarartigos));
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pc = new System.Windows.Forms.Label();
            this.lbl_pb = new System.Windows.Forms.Label();
            this.lbl_npsm = new System.Windows.Forms.Label();
            this.lbl_produtobarato = new System.Windows.Forms.Label();
            this.lbl_produtocaro = new System.Windows.Forms.Label();
            this.lbl_produtobaratop = new System.Windows.Forms.Label();
            this.lbl_produtocarop = new System.Windows.Forms.Label();
            this.lbl_média = new System.Windows.Forms.Label();
            this.lbl_median = new System.Windows.Forms.Label();
            this.lbl_numpsm = new System.Windows.Forms.Label();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_minimize = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.AllowUserToAddRows = false;
            this.dgv_produtos.AllowUserToDeleteRows = false;
            this.dgv_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_produtos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_produtos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_produtos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_produtos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Preço});
            this.dgv_produtos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_produtos.Location = new System.Drawing.Point(10, 58);
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.Size = new System.Drawing.Size(646, 177);
            this.dgv_produtos.TabIndex = 24;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 60;
            // 
            // Preço
            // 
            this.Preço.HeaderText = "Preço €";
            this.Preço.Name = "Preço";
            this.Preço.ReadOnly = true;
            this.Preço.Width = 69;
            // 
            // pnl_top
            // 
            this.pnl_top.Controls.Add(this.lbl_name);
            this.pnl_top.Controls.Add(this.pic_close);
            this.pnl_top.Controls.Add(this.pic_minimize);
            this.pnl_top.Controls.Add(this.pic_logo);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(668, 52);
            this.pnl_top.TabIndex = 29;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Akira Expanded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(48, 14);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(116, 20);
            this.lbl_name.TabIndex = 11;
            this.lbl_name.Text = "JORDAN";
            this.lbl_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_name_MouseDown);
            // 
            // lbl_pc
            // 
            this.lbl_pc.AutoSize = true;
            this.lbl_pc.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pc.Location = new System.Drawing.Point(89, 348);
            this.lbl_pc.Name = "lbl_pc";
            this.lbl_pc.Size = new System.Drawing.Size(158, 24);
            this.lbl_pc.TabIndex = 31;
            this.lbl_pc.Text = "Produto mais caro";
            // 
            // lbl_pb
            // 
            this.lbl_pb.AutoSize = true;
            this.lbl_pb.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pb.Location = new System.Drawing.Point(414, 348);
            this.lbl_pb.Name = "lbl_pb";
            this.lbl_pb.Size = new System.Drawing.Size(177, 24);
            this.lbl_pb.TabIndex = 32;
            this.lbl_pb.Text = "Produto mais barato";
            // 
            // lbl_npsm
            // 
            this.lbl_npsm.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_npsm.Location = new System.Drawing.Point(405, 258);
            this.lbl_npsm.Name = "lbl_npsm";
            this.lbl_npsm.Size = new System.Drawing.Size(203, 49);
            this.lbl_npsm.TabIndex = 34;
            this.lbl_npsm.Text = "Número de Produtos superior à média";
            this.lbl_npsm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_produtobarato
            // 
            this.lbl_produtobarato.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produtobarato.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_produtobarato.Location = new System.Drawing.Point(349, 378);
            this.lbl_produtobarato.Name = "lbl_produtobarato";
            this.lbl_produtobarato.Size = new System.Drawing.Size(307, 24);
            this.lbl_produtobarato.TabIndex = 36;
            this.lbl_produtobarato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_produtocaro
            // 
            this.lbl_produtocaro.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produtocaro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_produtocaro.Location = new System.Drawing.Point(12, 378);
            this.lbl_produtocaro.Name = "lbl_produtocaro";
            this.lbl_produtocaro.Size = new System.Drawing.Size(312, 24);
            this.lbl_produtocaro.TabIndex = 37;
            this.lbl_produtocaro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_produtobaratop
            // 
            this.lbl_produtobaratop.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produtobaratop.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_produtobaratop.Location = new System.Drawing.Point(349, 403);
            this.lbl_produtobaratop.Name = "lbl_produtobaratop";
            this.lbl_produtobaratop.Size = new System.Drawing.Size(307, 24);
            this.lbl_produtobaratop.TabIndex = 38;
            this.lbl_produtobaratop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_produtocarop
            // 
            this.lbl_produtocarop.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produtocarop.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_produtocarop.Location = new System.Drawing.Point(12, 404);
            this.lbl_produtocarop.Name = "lbl_produtocarop";
            this.lbl_produtocarop.Size = new System.Drawing.Size(312, 24);
            this.lbl_produtocarop.TabIndex = 39;
            this.lbl_produtocarop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_média
            // 
            this.lbl_média.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_média.Location = new System.Drawing.Point(67, 280);
            this.lbl_média.Name = "lbl_média";
            this.lbl_média.Size = new System.Drawing.Size(203, 27);
            this.lbl_média.TabIndex = 40;
            this.lbl_média.Text = "Média";
            this.lbl_média.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_median
            // 
            this.lbl_median.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_median.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_median.Location = new System.Drawing.Point(52, 309);
            this.lbl_median.Name = "lbl_median";
            this.lbl_median.Size = new System.Drawing.Size(233, 24);
            this.lbl_median.TabIndex = 41;
            this.lbl_median.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_numpsm
            // 
            this.lbl_numpsm.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numpsm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_numpsm.Location = new System.Drawing.Point(390, 311);
            this.lbl_numpsm.Name = "lbl_numpsm";
            this.lbl_numpsm.Size = new System.Drawing.Size(233, 24);
            this.lbl_numpsm.TabIndex = 42;
            this.lbl_numpsm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_close
            // 
            this.pic_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_close.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.close;
            this.pic_close.Location = new System.Drawing.Point(636, 14);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(20, 20);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 9;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // pic_minimize
            // 
            this.pic_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_minimize.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.minus_sign;
            this.pic_minimize.Location = new System.Drawing.Point(600, 14);
            this.pic_minimize.Name = "pic_minimize";
            this.pic_minimize.Size = new System.Drawing.Size(20, 20);
            this.pic_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_minimize.TabIndex = 10;
            this.pic_minimize.TabStop = false;
            this.pic_minimize.Click += new System.EventHandler(this.pic_minimize_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources._584292c4a6515b1e0ad75aca1;
            this.pic_logo.Location = new System.Drawing.Point(10, 8);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(32, 32);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 12;
            this.pic_logo.TabStop = false;
            this.pic_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_logo_MouseDown);
            // 
            // frm_consultarartigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(668, 438);
            this.Controls.Add(this.lbl_numpsm);
            this.Controls.Add(this.lbl_median);
            this.Controls.Add(this.lbl_média);
            this.Controls.Add(this.lbl_produtocarop);
            this.Controls.Add(this.lbl_produtobaratop);
            this.Controls.Add(this.lbl_produtocaro);
            this.Controls.Add(this.lbl_produtobarato);
            this.Controls.Add(this.lbl_npsm);
            this.Controls.Add(this.lbl_pb);
            this.Controls.Add(this.lbl_pc);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.dgv_produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_consultarartigos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jordan - Consultar Artigos";
            this.Load += new System.EventHandler(this.frm_consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.PictureBox pic_minimize;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lbl_pc;
        private System.Windows.Forms.Label lbl_pb;
        private System.Windows.Forms.Label lbl_npsm;
        private System.Windows.Forms.Label lbl_produtobarato;
        private System.Windows.Forms.Label lbl_produtocaro;
        private System.Windows.Forms.Label lbl_produtobaratop;
        private System.Windows.Forms.Label lbl_produtocarop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.Label lbl_média;
        private System.Windows.Forms.Label lbl_median;
        private System.Windows.Forms.Label lbl_numpsm;
    }
}