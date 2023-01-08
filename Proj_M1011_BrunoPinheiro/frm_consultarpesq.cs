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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Proj_M1011_BrunoPinheiro
{
    public partial class frm_consultarpesq : Form
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
        public frm_consultarpesq()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        string nome, nomelow, codigo, tamanho, preco, quantidade;
        float preconum;
        bool precoproc, nomeproc, tamanhoproc;

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

        private void btn_procurar_MouseLeave(object sender, EventArgs e)
        {
            btn_procurar.BackColor = Color.White;
            btn_procurar.ForeColor = Color.Black;
            this.btn_procurar.Image = ((System.Drawing.Image)(Properties.Resources.search__4_));
        }

        private void btn_procurar_MouseMove(object sender, MouseEventArgs e)
        {
            btn_procurar.BackColor = Color.Black;
            btn_procurar.ForeColor = Color.White;
            this.btn_procurar.Image = ((System.Drawing.Image)(Properties.Resources.search__5_));
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

        private void cbo_tamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_tamanho.SelectedIndex != 0)
            {
                tamanhoproc = true;
            }
            else
            {
                tamanhoproc = false;
            }
            dgv_produtos.Rows.Clear();
            XmlTextReader ler = new XmlTextReader("Produtos.xml");
            while (ler.Read())
            {
                if (ler.NodeType == XmlNodeType.Element)
                {
                    if (ler.Name == "Nome")
                    {
                        ler.Read();
                        nome = ler.Value;
                    }
                    if (ler.Name == "Codigo")
                    {
                        ler.Read();
                        codigo = ler.Value;
                    }
                    if (ler.Name == "Tamanho")
                    {
                        ler.Read();
                        tamanho = ler.Value;
                    }
                    if (ler.Name == "Preco")
                    {
                        ler.Read();
                        preco = ler.Value;
                    }
                    if (ler.Name == "Quantidade")
                    {
                        ler.Read();
                        quantidade = ler.Value;
                        if (precoproc == true)
                        {
                            preconum = float.Parse(preco);
                            if (preconum >= tb_precomin.Value && preconum <= tb_precomax.Value)
                            {
                                if (nomeproc == true)
                                {
                                    if (nomelow.Contains(txt_nome.Text.ToLower()))
                                    {
                                        if (tamanho == cbo_tamanho.Text && cbo_tamanho.SelectedIndex != 0)
                                        {
                                            dgv_produtos.Rows.Add(nome, codigo, tamanho, quantidade, preco);
                                        }
                                    }
                                }
                                else
                                {
                                    if (tamanho == cbo_tamanho.Text && cbo_tamanho.SelectedIndex != 0)
                                    {
                                        dgv_produtos.Rows.Add(nome, codigo, tamanho, quantidade, preco);
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (tamanho == cbo_tamanho.Text && cbo_tamanho.SelectedIndex != 0)
                            {
                                dgv_produtos.Rows.Add(nome, codigo, tamanho, quantidade, preco);
                            }
                        }
                    }
                }
            }
            ler.Close();
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            precoproc = true;
            dgv_produtos.Rows.Clear();
            XmlTextReader ler = new XmlTextReader("Produtos.xml");
            while (ler.Read())
            {
                if (ler.NodeType == XmlNodeType.Element)
                {
                    if (ler.Name == "Nome")
                    {
                        ler.Read();
                        nome = ler.Value;
                    }
                    if (ler.Name == "Codigo")
                    {
                        ler.Read();
                        codigo = ler.Value;
                    }
                    if (ler.Name == "Tamanho")
                    {
                        ler.Read();
                        tamanho = ler.Value;
                    }
                    if (ler.Name == "Preco")
                    {
                        ler.Read();
                        preco = ler.Value;
                    }
                    if (ler.Name == "Quantidade")
                    {
                        ler.Read();
                        quantidade = ler.Value;
                        if (nomeproc == true)
                        {
                            if (nomelow.Contains(txt_nome.Text.ToLower()))
                            {
                                if(tamanhoproc == true)
                                {
                                    if (tamanho == cbo_tamanho.Text && cbo_tamanho.SelectedIndex != 0)
                                    {
                                        preconum = float.Parse(preco);
                                        if (preconum >= tb_precomin.Value && preconum <= tb_precomax.Value)
                                        {
                                            dgv_produtos.Rows.Add(nome, codigo, tamanho, quantidade, preco);
                                        }
                                    }
                                }
                                else
                                {
                                    preconum = float.Parse(preco);
                                    if (preconum >= tb_precomin.Value && preconum <= tb_precomax.Value)
                                    {
                                        dgv_produtos.Rows.Add(nome, codigo, tamanho, quantidade, preco);
                                    }
                                }
                            }
                        }
                        else
                        {
                            preconum = float.Parse(preco);
                            if (preconum >= tb_precomin.Value && preconum <= tb_precomax.Value)
                            {
                                dgv_produtos.Rows.Add(nome, codigo, tamanho, quantidade, preco);
                            }
                        }
                    }
                }
            }
            ler.Close();
        }

        private void tb_precomax_Scroll(object sender, EventArgs e)
        {
            tb_precomin.Maximum = tb_precomax.Value;
            lbl_nummin.Text = "" + tb_precomin.Value + "€";
            lbl_nummax.Text = "" + tb_precomax.Value + "€";
        }

        private void tb_precomin_Scroll(object sender, EventArgs e)
        {
            tb_precomax.Minimum = tb_precomin.Value;
            lbl_nummin.Text = "" + tb_precomin.Value + "€";
            lbl_nummax.Text = "" + tb_precomax.Value + "€";
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            if (txt_nome.Text.Length <= 0)
            {
                nomeproc = false;
            }
            else
            {
                nomeproc = true;
            }
            dgv_produtos.Rows.Clear();
            XmlTextReader ler = new XmlTextReader("Produtos.xml");
            while (ler.Read())
            {
                if (ler.NodeType == XmlNodeType.Element)
                {
                    if (ler.Name == "Nome")
                    {
                        ler.Read();
                        nome = ler.Value;
                    }
                    if (ler.Name == "Codigo")
                    {
                        ler.Read();
                        codigo = ler.Value;
                    }
                    if (ler.Name == "Tamanho")
                    {
                        ler.Read();
                        tamanho = ler.Value;
                    }
                    if (ler.Name == "Preco")
                    {
                        ler.Read();
                        preco = ler.Value;
                    }
                    if (ler.Name == "Quantidade")
                    {
                        ler.Read();
                        quantidade = ler.Value;
                        if (tamanhoproc == true)
                        {
                            nomelow = nome.ToLower();
                            if (tamanho == cbo_tamanho.Text && cbo_tamanho.SelectedIndex != 0)
                            {
                                if(precoproc == true)
                                {
                                    nomelow = nome.ToLower();
                                    if (preconum >= tb_precomin.Value && preconum <= tb_precomax.Value)
                                    {
                                        if (nomelow.Contains(txt_nome.Text.ToLower()))
                                        {
                                            if (precoproc == true)
                                            {
                                                nomelow = nome.ToLower();
                                                btn_procurar.PerformClick();
                                            }
                                            dgv_produtos.Rows.Add(nome, codigo, tamanho, quantidade, preco);
                                        }
                                    }
                                }
                                else
                                {
                                    nomelow = nome.ToLower();
                                    if (nomelow.Contains(txt_nome.Text.ToLower()))
                                    {
                                        dgv_produtos.Rows.Add(nome, codigo, tamanho, quantidade, preco);
                                    }
                                }
                            }
                        }
                        else
                        {
                            nomelow = nome.ToLower();
                            if (nomelow.Contains(txt_nome.Text.ToLower()))
                            {
                                dgv_produtos.Rows.Add(nome, codigo, tamanho, quantidade, preco);
                            }
                        }
                    }
                }
            }
            ler.Close();
        }

        private void frm_consultarpesq_Load(object sender, EventArgs e)
        {
            lbl_nummin.Text = "" + tb_precomin.Value + "€";
            lbl_nummax.Text = "" + tb_precomax.Value + "€";
            cbo_tamanho.SelectedIndex = 0;
            dgv_produtos.Rows.Clear();
            XmlTextReader ler = new XmlTextReader("Produtos.xml");
            while (ler.Read())
            {
                if (ler.NodeType == XmlNodeType.Element)
                {
                    if (ler.Name == "Nome")
                    {
                        ler.Read();
                        nome = ler.Value;
                    }

                    if (ler.Name == "Codigo")
                    {
                        ler.Read();
                        codigo = ler.Value;
                    }

                    if (ler.Name == "Tamanho")
                    {
                        ler.Read();
                        tamanho = ler.Value;
                    }
                    if (ler.Name == "Preco")
                    {
                        ler.Read();
                        preco = ler.Value;
                    }

                    if (ler.Name == "Quantidade")
                    {
                        ler.Read();
                        quantidade = ler.Value;
                        dgv_produtos.Rows.Add(nome, codigo, tamanho, quantidade, preco);
                    }
                }
            }
            ler.Close();
        }
    }
}
