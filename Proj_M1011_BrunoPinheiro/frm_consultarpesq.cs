using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public frm_consultarpesq()
        {
            InitializeComponent();
        }

        string nome, nomelow, codigo, tamanho, preco, quantidade;
        float preconum;
        bool precoproc;

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
                        preconum = float.Parse(preco);
                        if (preconum >= tb_precomin.Value && preconum <= tb_precomax.Value)
                        {
                            dgv_produtos.Rows.Add(nome, codigo, tamanho, quantidade, preco);
                        }
                    }
                }
            }
            ler.Close();
        }

        private void tb_precomax_Scroll(object sender, EventArgs e)
        {
            tb_precomin.Maximum = tb_precomax.Value;
            lbl_nummax.Text = "" + tb_precomax.Value;
            lbl_nummin.Text = "" + tb_precomin.Value;
        }

        private void tb_precomin_Scroll(object sender, EventArgs e)
        {
            tb_precomax.Minimum = tb_precomin.Value;
            lbl_nummin.Text = "" + tb_precomin.Value;
            lbl_nummax.Text = "" + tb_precomax.Value;
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
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
                        nomelow = nome.ToLower();
                        if (precoproc == true)
                        {
                            preconum = float.Parse(preco);
                            if (preconum >= tb_precomin.Value && preconum <= tb_precomax.Value)
                            {
                                if (nomelow.Contains(txt_nome.Text.ToLower()))
                                {
                                    dgv_produtos.Rows.Add(nome, codigo, tamanho, quantidade, preco);
                                }
                            }
                        }
                        else
                        {
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
