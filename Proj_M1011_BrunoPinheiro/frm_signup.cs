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
using System.Xml.Linq;

namespace Proj_M1011_BrunoPinheiro
{
    public partial class frm_signup : Form
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
        public frm_signup()
        {
            InitializeComponent();
        }

        private void rad_sim_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(337, 640);
            this.CenterToScreen();
            btn_signup.Location = new Point(92, 556);
            lbl_limpar.Location = new Point(238, 563);
            lbl_sair.Location = new Point(139, 596);
            lbl_vazio.Location = new Point(49, 529);
            lbl_invalido.Location = new Point(49, 529);
            pic_passe.Visible = true;
            txt_passe.Visible = true;
            pnl_passe.Visible = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void rad_nao_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(337, 576);
            this.CenterToScreen();
            btn_signup.Location = new Point(92, 504);
            lbl_limpar.Location = new Point(238, 511);
            lbl_sair.Location = new Point(139, 544);
            lbl_vazio.Location = new Point(49, 467);
            lbl_invalido.Location = new Point(49, 467);
            pic_passe.Visible = false;
            txt_passe.Visible = false;
            pnl_passe.Visible = false;
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            frm_login frm_login = new frm_login();
            frm_login.Show();
            this.Close();
        }

        private void btn_login_MouseMove(object sender, MouseEventArgs e)
        {
            btn_signup.BackColor = Color.Black;
            btn_signup.ForeColor = Color.White;
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_signup.BackColor = Color.White;
            btn_signup.ForeColor = Color.Black;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                MessageBox.Show("Username vazio");
                Limpar();
            }
            else
            {
                if (txt_password.Text == "")
                {
                    MessageBox.Show("Password vazia");
                    Limpar();
                }
                else
                {
                    if (txt_confirmar.Text == "")
                    {
                        MessageBox.Show("Confirmar Password vazio");
                        Limpar();
                    }
                    else
                    {
                        if (txt_confirmar.Text != txt_password.Text)
                        {
                            MessageBox.Show("Password nao iguais");
                            Limpar();
                        }
                        else
                        {
                            if (rad_sim.Checked == true && txt_passe.Text != "a8ut54hwf2son")
                            {
                                MessageBox.Show("Passe Errado ou Vazio");
                                Limpar();
                            }
                            else
                            {
                                XmlTextReader ler = new XmlTextReader("users.xml");

                                while (ler.Read())
                                {
                                    if (ler.NodeType == XmlNodeType.Element)
                                    {
                                        if (ler.Name == "username")
                                        {
                                            ler.Read();
                                            if (ler.Value == txt_username.Text)
                                            {
                                                MessageBox.Show("Faça Login! (Conta Já Existente)");
                                                frm_login frm_login = new frm_login();
                                                frm_login.Show();
                                                this.Close();
                                                Limpar();
                                                ler.Close();
                                            }
                                            else if (ler.Value != txt_username.Text)
                                            {
                                                ler.Close();
                                                XmlDocument xmlDoc = new XmlDocument();
                                                xmlDoc.Load("users.xml");
                                                XmlElement novoelemento = xmlDoc.CreateElement("users");
                                                XmlElement xmlUsername = xmlDoc.CreateElement("username");
                                                XmlElement xmlPassword = xmlDoc.CreateElement("password");
                                                XmlElement xmlPasse = xmlDoc.CreateElement("passeAdm");
                                                xmlUsername.InnerText = txt_username.Text;
                                                xmlPassword.InnerText = txt_password.Text;
                                                if (rad_sim.Checked == true)
                                                {
                                                    xmlPasse.InnerText = "y";
                                                }
                                                else
                                                {
                                                    xmlPasse.InnerText = "n";
                                                }
                                                novoelemento.AppendChild(xmlUsername);
                                                novoelemento.AppendChild(xmlPassword);
                                                novoelemento.AppendChild(xmlPasse);
                                                xmlDoc.DocumentElement.AppendChild(novoelemento);
                                                xmlDoc.Save("users.xml");
                                                CarregaDadosXML();
                                                frm_login frm_login = new frm_login();
                                                frm_login.Show();
                                                this.Close();
                                                MessageBox.Show("Faça Login!");
                                            }
                                        }
                                    }
                                }
                                ler.Close();
                            }
                        }
                    }
                }
            }
        }

        public void CarregaDadosXML()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("users.xml");
        }

        private void lbl_limpar_Click(object sender, EventArgs e)
        {
            Limpar();   
        }

        public void Limpar()
        {
            this.pic_username.Image = ((System.Drawing.Image)(Properties.Resources.account__2_));
            this.pic_password.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
            this.pic_confirmar.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
            this.pic_passe.Image = ((System.Drawing.Image)(Properties.Resources.id_card));
            txt_username.Clear();
            txt_password.Clear();
            txt_confirmar.Clear();
            txt_username.ResetText();
            txt_password.ResetText();
            txt_confirmar.ResetText();
            txt_username.Focus();
            txt_password.Text = "Password";
            txt_password.UseSystemPasswordChar = true;
            txt_confirmar.Text = "Confirmar Password";
            txt_confirmar.UseSystemPasswordChar = true;
            txt_passe.ResetText();
            txt_passe.Clear();
            txt_passe.Text = "Passe de Gestor";
            txt_passe.UseSystemPasswordChar = true;
            pic_ocultado.Enabled = false;
            pic_ocultado.Visible = false;
            pic_mostrar.Enabled = true;
            pic_mostrar.Visible = true;
            pic_ocultado2.Enabled = false;
            pic_ocultado2.Visible = false;
            pic_mostrar2.Enabled = true;
            pic_mostrar2.Visible = true;
            lbl_limpar.Visible = false;
            lbl_limpar.Enabled = false;
        }

        private void pic_mostrar_Click(object sender, EventArgs e)
        {
            if (txt_password.Text != "Password")
            {
                txt_password.UseSystemPasswordChar = true;
            }
            pic_ocultado.Enabled = true;
            pic_ocultado.Visible = true;
            pic_mostrar.Enabled = false;
            pic_mostrar.Visible = false;
        }

        private void pic_mostrar2_Click(object sender, EventArgs e)
        {
            if (txt_confirmar.Text != "Confirmar Password")
            {
                txt_confirmar.UseSystemPasswordChar = true;
            }
            pic_ocultado2.Enabled = true;
            pic_ocultado2.Visible = true;
            pic_mostrar2.Enabled = false;
            pic_mostrar2.Visible = false;
        }

        private void pic_ocultado2_Click(object sender, EventArgs e)
        {
            if (txt_confirmar.Text != "Confirmar Password")
            {
                txt_confirmar.UseSystemPasswordChar = false;
            }
            pic_ocultado2.Enabled = false;
            pic_ocultado2.Visible = false;
            pic_mostrar2.Enabled = true;
            pic_mostrar2.Visible = true;
        }

        private void pic_ocultado_Click(object sender, EventArgs e)
        {
            if (txt_password.Text != "Password")
            {
                txt_password.UseSystemPasswordChar = false;
            }
            pic_ocultado.Enabled = false;
            pic_ocultado.Visible = false;
            pic_mostrar.Enabled = true;
            pic_mostrar.Visible = true;
        }

        private void txt_username_Click(object sender, EventArgs e)
        {
            this.pic_username.Image = ((System.Drawing.Image)(Properties.Resources.account__2_));
            this.pic_password.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
            this.pic_confirmar.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
            this.pic_passe.Image = ((System.Drawing.Image)(Properties.Resources.id_card));
            if (txt_username.Text == "Username")
            {
                txt_username.ResetText();
                txt_username.Focus();
            }
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            this.pic_password.Image = ((System.Drawing.Image)(Properties.Resources.padlock__2_));
            this.pic_confirmar.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
            this.pic_username.Image = ((System.Drawing.Image)(Properties.Resources.account__1_));
            this.pic_passe.Image = ((System.Drawing.Image)(Properties.Resources.id_card));
            if (txt_password.Text == "Password")
            {
                txt_password.UseSystemPasswordChar = false;
                txt_password.ResetText();
                txt_password.Focus();
            }
        }

        private void txt_confirmar_Click(object sender, EventArgs e)
        {
            this.pic_confirmar.Image = ((System.Drawing.Image)(Properties.Resources.padlock__2_));
            this.pic_password.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
            this.pic_username.Image = ((System.Drawing.Image)(Properties.Resources.account__1_));
            this.pic_passe.Image = ((System.Drawing.Image)(Properties.Resources.id_card));
            if (txt_confirmar.Text == "Confirmar Password")
            {
                txt_confirmar.UseSystemPasswordChar = false;
                txt_confirmar.ResetText();
                txt_confirmar.Focus();
            }
        }

        private void txt_passe_Click(object sender, EventArgs e)
        {
            this.pic_confirmar.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
            this.pic_password.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
            this.pic_username.Image = ((System.Drawing.Image)(Properties.Resources.account__1_));
            this.pic_passe.Image = ((System.Drawing.Image)(Properties.Resources.id_card__1_));
            if (txt_passe.Text == "Passe de Gestor")
            {
                txt_passe.UseSystemPasswordChar = false;
                txt_passe.ResetText();
                txt_passe.Focus();
            }
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_password.Text == "Password")
                {
                    txt_password.UseSystemPasswordChar = false;
                    txt_password.ResetText();
                    txt_password.Focus();
                    this.pic_username.Image = ((System.Drawing.Image)(Properties.Resources.account__1_));
                    this.pic_password.Image = ((System.Drawing.Image)(Properties.Resources.padlock__2_));
                    this.pic_confirmar.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
                    this.pic_passe.Image = ((System.Drawing.Image)(Properties.Resources.id_card));
                }
                e.SuppressKeyPress = true;
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_confirmar.Text == "Confirmar Password")
                {
                    txt_confirmar.UseSystemPasswordChar = false;
                    txt_confirmar.ResetText();
                    txt_confirmar.Focus();
                    this.pic_username.Image = ((System.Drawing.Image)(Properties.Resources.account__1_));
                    this.pic_password.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
                    this.pic_confirmar.Image = ((System.Drawing.Image)(Properties.Resources.padlock__2_));
                    this.pic_passe.Image = ((System.Drawing.Image)(Properties.Resources.id_card));
                }
                e.SuppressKeyPress = true;
            }
        }

        private void txt_confirmar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_signup.PerformClick();
                e.SuppressKeyPress = true;
                this.pic_username.Image = ((System.Drawing.Image)(Properties.Resources.account__1_));
                this.pic_password.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
                this.pic_confirmar.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
                this.pic_passe.Image = ((System.Drawing.Image)(Properties.Resources.id_card));
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            txt_username.MaxLength = 10;
            if (txt_username.Text != "" && txt_username.Text != "Username")
            {
                lbl_limpar.Visible = true;
                lbl_limpar.Enabled = true;
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.MaxLength = 12;
            if (txt_password.Text != "" && txt_password.Text != "Password")
            {
                lbl_limpar.Visible = true;
                lbl_limpar.Enabled = true;
            }
        }

        private void txt_confirmar_TextChanged(object sender, EventArgs e)
        {
            txt_confirmar.MaxLength = 12;
            if (txt_confirmar.Text != "" && txt_confirmar.Text != "Confirmar Password")
            {
                lbl_limpar.Visible = true;
                lbl_limpar.Enabled = true;
            }
        }

        private void txt_passe_TextChanged(object sender, EventArgs e)
        {
            txt_passe.MaxLength = 13;
            if (txt_passe.Text != "" && txt_passe.Text != "Passe de Gestor")
            {
                lbl_limpar.Visible = true;
                lbl_limpar.Enabled = true;
            }
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            frm_login frm_login = new frm_login();
            frm_login.Show();
            this.Close();
        }

        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pic_minimize_Click(object sender, EventArgs e)
        {
            this.pic_username.Image = ((System.Drawing.Image)(Properties.Resources.account__1_));
            this.pic_password.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
            this.pic_confirmar.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
            this.pic_passe.Image = ((System.Drawing.Image)(Properties.Resources.id_card));
            WindowState = FormWindowState.Minimized;
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
    }
}
