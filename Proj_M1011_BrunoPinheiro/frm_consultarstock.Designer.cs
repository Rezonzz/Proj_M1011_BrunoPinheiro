namespace Proj_M1011_BrunoPinheiro
{
    partial class frm_consultarstock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_consultarstock));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_stock = new System.Windows.Forms.Button();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_minimize = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_numstock = new System.Windows.Forms.Label();
            this.lbl_ntas = new System.Windows.Forms.Label();
            this.lbl_valorstock = new System.Windows.Forms.Label();
            this.lbl_vts = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
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
            this.pnl_top.TabIndex = 30;
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
            this.Quantidade,
            this.Preço,
            this.ValorStock});
            this.dgv_produtos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_produtos.Location = new System.Drawing.Point(10, 58);
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.Size = new System.Drawing.Size(646, 202);
            this.dgv_produtos.TabIndex = 31;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 60;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 87;
            // 
            // Preço
            // 
            this.Preço.HeaderText = "Preço €";
            this.Preço.Name = "Preço";
            this.Preço.ReadOnly = true;
            this.Preço.Width = 69;
            // 
            // ValorStock
            // 
            this.ValorStock.HeaderText = "Valor em Stock";
            this.ValorStock.Name = "ValorStock";
            this.ValorStock.ReadOnly = true;
            this.ValorStock.Width = 96;
            // 
            // btn_stock
            // 
            this.btn_stock.FlatAppearance.BorderSize = 0;
            this.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.Image = global::Proj_M1011_BrunoPinheiro.Properties.Resources.information;
            this.btn_stock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_stock.Location = new System.Drawing.Point(235, 279);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(198, 67);
            this.btn_stock.TabIndex = 32;
            this.btn_stock.Text = "Valor Total em Stock";
            this.btn_stock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            this.btn_stock.MouseLeave += new System.EventHandler(this.btn_stock_MouseLeave);
            this.btn_stock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_stock_MouseMove);
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
            // lbl_numstock
            // 
            this.lbl_numstock.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numstock.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_numstock.Location = new System.Drawing.Point(17, 395);
            this.lbl_numstock.Name = "lbl_numstock";
            this.lbl_numstock.Size = new System.Drawing.Size(312, 24);
            this.lbl_numstock.TabIndex = 39;
            this.lbl_numstock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ntas
            // 
            this.lbl_ntas.AutoSize = true;
            this.lbl_ntas.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ntas.Location = new System.Drawing.Point(31, 365);
            this.lbl_ntas.Name = "lbl_ntas";
            this.lbl_ntas.Size = new System.Drawing.Size(281, 24);
            this.lbl_ntas.TabIndex = 38;
            this.lbl_ntas.Text = "Número total de artigos em stock";
            this.lbl_ntas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ntas.Visible = false;
            // 
            // lbl_valorstock
            // 
            this.lbl_valorstock.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorstock.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_valorstock.Location = new System.Drawing.Point(335, 395);
            this.lbl_valorstock.Name = "lbl_valorstock";
            this.lbl_valorstock.Size = new System.Drawing.Size(312, 24);
            this.lbl_valorstock.TabIndex = 41;
            this.lbl_valorstock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_vts
            // 
            this.lbl_vts.AutoSize = true;
            this.lbl_vts.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vts.Location = new System.Drawing.Point(410, 365);
            this.lbl_vts.Name = "lbl_vts";
            this.lbl_vts.Size = new System.Drawing.Size(168, 24);
            this.lbl_vts.TabIndex = 40;
            this.lbl_vts.Text = "Valor total do stock";
            this.lbl_vts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_vts.Visible = false;
            // 
            // frm_consultarstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(668, 438);
            this.Controls.Add(this.lbl_valorstock);
            this.Controls.Add(this.lbl_vts);
            this.Controls.Add(this.lbl_numstock);
            this.Controls.Add(this.lbl_ntas);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.dgv_produtos);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_consultarstock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jordan - Consultar Stock";
            this.Load += new System.EventHandler(this.frm_consultarstock_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.PictureBox pic_minimize;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorStock;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Label lbl_numstock;
        private System.Windows.Forms.Label lbl_ntas;
        private System.Windows.Forms.Label lbl_valorstock;
        private System.Windows.Forms.Label lbl_vts;
    }
}