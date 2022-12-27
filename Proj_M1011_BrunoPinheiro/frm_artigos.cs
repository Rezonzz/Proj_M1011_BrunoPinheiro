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

namespace Proj_M1011_BrunoPinheiro
{
    public partial class frm_artigos : Form
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
        public frm_artigos()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
            this.Close();
        }

        private void pic_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void CarregaDadosXML()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("Produtos.xml");
            dgv_produtos.DataSource = ds;
            dgv_produtos.DataMember = "Artigos";
        }

        private void frm_artigos_Load(object sender, EventArgs e)
        {
            CarregaDadosXML();
            cbo_tamanho.SelectedIndex = 0;
        }

        private void btn_adicionar_MouseMove(object sender, MouseEventArgs e)
        {
            btn_adicionar.BackColor = Color.Black;
            btn_adicionar.ForeColor = Color.White;
            this.btn_adicionar.Image = ((System.Drawing.Image)(Properties.Resources.add__5_));
        }

        private void btn_adicionar_MouseLeave(object sender, EventArgs e)
        {
            btn_adicionar.BackColor = Color.White;
            btn_adicionar.ForeColor = Color.Black;
            this.btn_adicionar.Image = ((System.Drawing.Image)(Properties.Resources.add__2_));
        }

        private void btn_alterar_MouseMove(object sender, MouseEventArgs e)
        {
            btn_alterar.BackColor = Color.Black;
            btn_alterar.ForeColor = Color.White;
            this.btn_alterar.Image = ((System.Drawing.Image)(Properties.Resources.refresh__1_));
        }

        private void btn_alterar_MouseLeave(object sender, EventArgs e)
        {
            btn_alterar.BackColor = Color.White;
            btn_alterar.ForeColor = Color.Black;
            this.btn_alterar.Image = ((System.Drawing.Image)(Properties.Resources.refresh));
        }

        private void btn_eliminar_MouseMove(object sender, MouseEventArgs e)
        {
            btn_eliminar.BackColor = Color.Black;
            btn_eliminar.ForeColor = Color.White;
            this.btn_eliminar.Image = ((System.Drawing.Image)(Properties.Resources.remove__1_));
        }

        private void btn_eliminar_MouseLeave(object sender, EventArgs e)
        {
            btn_eliminar.BackColor = Color.White;
            btn_eliminar.ForeColor = Color.Black;
            this.btn_eliminar.Image = ((System.Drawing.Image)(Properties.Resources.remove));
        }

        int indice;
        private void dgv_produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgv_produtos.CurrentRow.Index;

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("Produtos.xml");

            XmlNodeList xmlnodelist = xmldoc.DocumentElement.ChildNodes;
            XmlNode xmlnode = xmlnodelist.Item(indice);

            txt_codigo.Text = xmlnode["Codigo"].InnerText;
            txt_nome.Text = xmlnode["Nome"].InnerText;
            txt_preco.Text = xmlnode["Preco"].InnerText;
            txt_quantidade.Text = xmlnode["Quantidade"].InnerText;
            cbo_tamanho.Text = xmlnode["Tamanho"].InnerText;
        }

        public void Limpar()
        {
            txt_codigo.ResetText();
            txt_nome.ResetText();
            txt_preco.ResetText();
            txt_quantidade.ResetText();
            cbo_tamanho.SelectedIndex = 0;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == null)
            {
                MessageBox.Show("Selecione um Código!");
                txt_codigo.Focus();
            }
            else
            {
                if (txt_nome.Text == null || (System.Text.RegularExpressions.Regex.IsMatch(txt_nome.Text, "[^a-zA-Z]+$")))
                {
                    MessageBox.Show("Selecione um Nome ou Digite só letras!");
                }
                else
                {
                    if (cbo_tamanho.SelectedIndex == 0)
                    {
                        MessageBox.Show("Selecione um Tamanho!");
                    }
                    else
                    {
                        if (txt_quantidade.Text == null || (System.Text.RegularExpressions.Regex.IsMatch(txt_quantidade.Text, "[^0-9]")))
                        {
                            MessageBox.Show("Selecione a quantidade ou Digite só Números!");
                        }
                        else
                        {
                            if (txt_preco.Text == null || (System.Text.RegularExpressions.Regex.IsMatch(txt_preco.Text, "[^0-9]")))
                            {
                                MessageBox.Show("Selecione o preço ou Digite só Números!");
                            }
                            else
                            {
                                XmlDocument xmlDoc = new XmlDocument();
                                xmlDoc.Load("Produtos.xml");
                                XmlElement novoelemento = xmlDoc.CreateElement("Artigos");
                                XmlElement xmlCodigo = xmlDoc.CreateElement("Codigo");
                                XmlElement xmlNome = xmlDoc.CreateElement("Nome");
                                XmlElement xmlTamanho = xmlDoc.CreateElement("Tamanho");
                                XmlElement xmlPreco = xmlDoc.CreateElement("Preco");
                                XmlElement xmlQuantidade = xmlDoc.CreateElement("Quantidade");
                                xmlCodigo.InnerText = txt_codigo.Text;
                                xmlNome.InnerText = txt_nome.Text;
                                xmlTamanho.InnerText = cbo_tamanho.Text;
                                xmlPreco.InnerText = txt_preco.Text;
                                xmlQuantidade.InnerText = txt_quantidade.Text;
                                novoelemento.AppendChild(xmlCodigo);
                                novoelemento.AppendChild(xmlNome);
                                novoelemento.AppendChild(xmlTamanho);
                                novoelemento.AppendChild(xmlPreco);
                                novoelemento.AppendChild(xmlQuantidade);
                                xmlDoc.DocumentElement.AppendChild(novoelemento);
                                xmlDoc.Save("Produtos.xml");
                                CarregaDadosXML();
                                Limpar();
                            }
                        }
                    }
                }
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == null)
            {
                MessageBox.Show("Selecione um Código!");
                txt_codigo.Focus();
            }
            else
            {
                if (txt_nome.Text == null || (System.Text.RegularExpressions.Regex.IsMatch(txt_nome.Text, "[^a-zA-Z]+$")))
                {
                    MessageBox.Show("Selecione um Nome ou Digite só letras!");
                }
                else
                {
                    if (cbo_tamanho.SelectedIndex == 0)
                    {
                        MessageBox.Show("Selecione um Tamanho!");
                    }
                    else
                    {
                        if (txt_quantidade.Text == null || (System.Text.RegularExpressions.Regex.IsMatch(txt_quantidade.Text, "[^0-9]")))
                        {
                            MessageBox.Show("Selecione a quantidade ou Digite só Números!");
                        }
                        else
                        {
                            if (txt_preco.Text == null || (System.Text.RegularExpressions.Regex.IsMatch(txt_preco.Text, "[^0-9]")))
                            {
                                MessageBox.Show("Selecione o preço ou Digite só Números!");
                            }
                            else
                            {
                                XmlDocument xmldoc = new XmlDocument();
                                xmldoc.Load("Produtos.xml");
                                XmlNode xmlnode = xmldoc.DocumentElement.ChildNodes.Item(indice);

                                xmlnode["Codigo"].InnerText = txt_codigo.Text;
                                xmlnode["Nome"].InnerText = txt_nome.Text;
                                xmlnode["Tamanho"].InnerText = cbo_tamanho.Text;
                                xmlnode["Preco"].InnerText = txt_preco.Text;
                                xmlnode["Quantidade"].InnerText = txt_quantidade.Text;

                                xmldoc.Save("Produtos.xml");
                                CarregaDadosXML();
                            }
                        }
                    }
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a Eliminação do Artigo " + txt_nome.Text + " ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load("Produtos.xml");

                XmlNode xmlnode = xmldoc.DocumentElement.ChildNodes.Item(indice);
                xmlnode.ParentNode.RemoveChild(xmlnode);

                xmldoc.Save("Produtos.xml");

                CarregaDadosXML();
                Limpar();
            }
        }

        private void btn_eliminartudo_MouseMove(object sender, MouseEventArgs e)
        {
            btn_eliminartudo.BackColor = Color.Black;
            btn_eliminartudo.ForeColor = Color.White;
            this.btn_eliminartudo.Image = ((System.Drawing.Image)(Properties.Resources.bin__1_));
        }

        private void btn_eliminartudo_MouseLeave(object sender, EventArgs e)
        {
            btn_eliminartudo.BackColor = Color.White;
            btn_eliminartudo.ForeColor = Color.Black;
            this.btn_eliminartudo.Image = ((System.Drawing.Image)(Properties.Resources.bin));
        }

        private void btn_eliminartudo_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("Produtos.xml");

            XmlElement root = xmldoc.DocumentElement;
            root.RemoveAll();
        }
    }
}
