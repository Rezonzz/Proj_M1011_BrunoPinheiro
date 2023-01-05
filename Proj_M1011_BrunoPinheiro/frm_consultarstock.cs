using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proj_M1011_BrunoPinheiro
{
    public partial class frm_consultarstock : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );
        public frm_consultarstock()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pic_close_Click(object sender, EventArgs e)
        {
            frm_consultarmenu frm_consultarmenu = new frm_consultarmenu();
            frm_consultarmenu.Show();
            this.Close();
        }

        private void pic_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbl_name_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pic_logo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        int numtotalstock=0;
        float valorstock=0;

        private void frm_consultarstock_Load(object sender, EventArgs e)
        {
            var LerProdutos = System.Xml.Linq.XElement.Load("Produtos.xml");
            int contar = LerProdutos.Descendants().Count(el => el.Name.LocalName == "Artigos");

            int i = 0;
            string[] nome = new string[contar];
            float[] preco = new float[contar];
            int[] quantidade = new int[contar];
            float[] ValorStock = new float[contar];

            dgv_produtos.Rows.Clear();
            XmlTextReader ler = new XmlTextReader("Produtos.xml");
            while (ler.Read())
            {
                if (ler.NodeType == XmlNodeType.Element)
                {
                    if (ler.Name == "Nome")
                    {
                        ler.Read();
                        nome[i] = ler.Value;
                    }

                    if (ler.Name == "Codigo")
                    {
                        ler.Read();
                    }

                    if (ler.Name == "Tamanho")
                    {
                        ler.Read();
                    }
                    if (ler.Name == "Preco")
                    {
                        ler.Read();
                        preco[i] = float.Parse(ler.Value);
                        
                    }

                    if (ler.Name == "Quantidade")
                    {
                        ler.Read();
                        quantidade[i] = int.Parse(ler.Value);
                        ValorStock[i] = preco[i] * quantidade[i];
                        valorstock = valorstock + ValorStock[i];
                        numtotalstock = numtotalstock + quantidade[i];
                        dgv_produtos.Rows.Add(nome[i], quantidade[i], preco[i], ValorStock[i]);
                        i++;
                    }
                }
            }
            ler.Close();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            lbl_ntas.Visible = true;
            lbl_vts.Visible = true;
            lbl_numstock.Text = numtotalstock.ToString();
            lbl_valorstock.Text = valorstock.ToString();
        }

        private void btn_stock_MouseMove(object sender, MouseEventArgs e)
        {
            btn_stock.BackColor = Color.Black;
            btn_stock.ForeColor = Color.White;
            this.btn_stock.Image = ((System.Drawing.Image)(Properties.Resources.information__1_));
        }

        private void btn_stock_MouseLeave(object sender, EventArgs e)
        {
            btn_stock.BackColor = Color.White;
            btn_stock.ForeColor = Color.Black;
            this.btn_stock.Image = ((System.Drawing.Image)(Properties.Resources.information));
        }
    }
}
