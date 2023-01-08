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
    public partial class frm_consultarartigos : Form
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
        public frm_consultarartigos()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            if (UserInfo.PasseAdm_user == "y")
            {
                frm_consultarmenu frm_consultarmenu = new frm_consultarmenu();
                frm_consultarmenu.Show();
                this.Close();
            }
            else
            {
                frm_consultarmenu2 frm_consultarmenu2 = new frm_consultarmenu2();
                frm_consultarmenu2.Show();
                this.Close();
            }
        }

        private void pic_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
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

        float caro = 0, barato=999;
        float soma = 0, media;
        string NomeCaro, NomeBarato;

        private void dgv_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int countmedia = 0;
        private void frm_consultar_Load(object sender, EventArgs e)
        {
            var LerProdutos = System.Xml.Linq.XElement.Load("Produtos.xml");
            int contar = LerProdutos.Descendants().Count(el => el.Name.LocalName == "Artigos");

            int i = 0;
            string[] nome = new string[contar];
            float[] preco = new float[contar];

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
                        dgv_produtos.Rows.Add(nome[i], preco[i]);
                    }

                    if (ler.Name == "Quantidade")
                    {
                        ler.Read();

                        i++;
                    }
                }
            }
            ler.Close();

            for (i = 0; i < contar; i++)
            {
                soma = soma + preco[i];

                if (preco[i] > caro)
                {
                    caro = preco[i];
                    NomeCaro = nome[i];
                }
                if (preco[i] < barato)
                {
                    barato = preco[i];
                    NomeBarato = nome[i];
                }
            }
            media = soma / contar;

            for (i = 0; i < contar; i++)
            {
                if (preco[i] > media)
                {
                    countmedia++;
                }
            }
            lbl_produtobarato.Text = NomeBarato;
            lbl_produtocaro.Text = NomeCaro;
            lbl_produtobaratop.Text = barato.ToString() + "€";
            lbl_produtocarop.Text = caro.ToString() + "€";
            lbl_median.Text = media.ToString() + "€";
            lbl_numpsm.Text = countmedia.ToString();
        }
    }
}
