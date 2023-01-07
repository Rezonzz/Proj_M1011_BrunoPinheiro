namespace Proj_M1011_BrunoPinheiro
{
    partial class frm_consultarpesq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_consultarpesq));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_minimize = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_ntas = new System.Windows.Forms.Label();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_precomin = new System.Windows.Forms.TrackBar();
            this.tb_precomax = new System.Windows.Forms.TrackBar();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_precomin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_precomax)).BeginInit();
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
            this.pnl_top.TabIndex = 31;
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
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Futura-Heavy", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(6, 340);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(234, 24);
            this.txt_nome.TabIndex = 32;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // lbl_ntas
            // 
            this.lbl_ntas.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ntas.Location = new System.Drawing.Point(6, 313);
            this.lbl_ntas.Name = "lbl_ntas";
            this.lbl_ntas.Size = new System.Drawing.Size(234, 24);
            this.lbl_ntas.TabIndex = 39;
            this.lbl_ntas.Text = "Nome";
            this.lbl_ntas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ntas.Visible = false;
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
            this.Codigo,
            this.Tamanho,
            this.Quantidade,
            this.Preco});
            this.dgv_produtos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_produtos.Location = new System.Drawing.Point(10, 58);
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.Size = new System.Drawing.Size(646, 202);
            this.dgv_produtos.TabIndex = 40;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 60;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 65;
            // 
            // Tamanho
            // 
            this.Tamanho.HeaderText = "Tamanho";
            this.Tamanho.Name = "Tamanho";
            this.Tamanho.ReadOnly = true;
            this.Tamanho.Width = 77;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 87;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 60;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Futura-Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Preço";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // tb_precomin
            // 
            this.tb_precomin.AutoSize = false;
            this.tb_precomin.Location = new System.Drawing.Point(315, 348);
            this.tb_precomin.Maximum = 1000;
            this.tb_precomin.Name = "tb_precomin";
            this.tb_precomin.Size = new System.Drawing.Size(140, 35);
            this.tb_precomin.TabIndex = 43;
            // 
            // tb_precomax
            // 
            this.tb_precomax.AutoSize = false;
            this.tb_precomax.Location = new System.Drawing.Point(315, 393);
            this.tb_precomax.Maximum = 1000;
            this.tb_precomax.Name = "tb_precomax";
            this.tb_precomax.Size = new System.Drawing.Size(140, 35);
            this.tb_precomax.TabIndex = 44;
            // 
            // frm_consultarpesq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(668, 438);
            this.Controls.Add(this.tb_precomax);
            this.Controls.Add(this.tb_precomin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_produtos);
            this.Controls.Add(this.lbl_ntas);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_consultarpesq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jordan - Consultar Pesquisa";
            this.Load += new System.EventHandler(this.frm_consultarpesq_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_precomin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_precomax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.PictureBox pic_minimize;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_ntas;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tb_precomin;
        private System.Windows.Forms.TrackBar tb_precomax;
    }
}