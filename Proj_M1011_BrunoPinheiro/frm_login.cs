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
using System.IO;
using System.Runtime.ConstrainedExecution;

namespace Proj_M1011_BrunoPinheiro
{
    public partial class frm_login : Form
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
        public frm_login()
        {
            InitializeComponent();
        }

        public string FromXML_user;
        public string FromXML_password;
        public string FromXML_passeAdm;

        private void pnl_top_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void pnl_top_MouseLeave(object sender, EventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void lbl_name_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void lbl_name_MouseLeave(object sender, EventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void pic_logo_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void pic_logo_MouseLeave(object sender, EventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btn_close_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void btn_minimize_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void btn_minimize_MouseLeave(object sender, EventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btn_close_MouseLeave(object sender, EventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.pic_username.Image = ((System.Drawing.Image)(Properties.Resources.account__1_));
            this.pic_password.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
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
            pnl_top.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void btn_login_MouseMove(object sender, MouseEventArgs e)
        {
            btn_login.BackColor = Color.Black;
            btn_login.ForeColor = Color.White;
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.White;
            btn_login.ForeColor = Color.Black;
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

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            frm_sair frm_sair = new frm_sair();
            frm_sair.Show();
        }

        private void lbl_registrar_Click(object sender, EventArgs e)
        {
            frm_signup frm_signin = new frm_signup();
            frm_signin.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.pic_username.Image = ((System.Drawing.Image)(Properties.Resources.account__1_));
            this.pic_password.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
            XDocument doc = XDocument.Load(Application.StartupPath.ToString() + @"\users.xml");
            var selected_user = from x in doc.Descendants("users").Where 
                                (x => (string)x.Element("username") == txt_username.Text)
                                select new
                                {
                                    XMLuser = x.Element("username").Value,
                                    XMLpassword = x.Element("password").Value,
                                    XMLpasseAdm = x.Element("passeAdm").Value
                                };
            foreach (var x in selected_user)
            {
                FromXML_user = x.XMLuser;
                FromXML_password = x.XMLpassword;
                FromXML_passeAdm = x.XMLpasseAdm;
            }
            if (txt_username.Text != "" || txt_username.Text != "Username")
            {
                if (txt_password.Text != "" || txt_password.Text != "Password")
                {
                    if (txt_username.Text == FromXML_user)
                    {
                        if (txt_password.Text == FromXML_password)
                        {
                            UserInfo.Username_user = FromXML_user;
                            UserInfo.Password_user = FromXML_password;
                            UserInfo.PasseAdm_user = FromXML_passeAdm;
                            frm_menu frm_menu = new frm_menu();
                            frm_menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("pass errada");
                        }
                    }
                    else
                    {
                        MessageBox.Show("user errado");
                    }
                }
                else
                {
                    MessageBox.Show("user vazio");
                }
            }
            else
            {
                MessageBox.Show("password vazia");
            }
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

        private void lbl_limpar_Click(object sender, EventArgs e)
        {
            this.pic_username.Image = ((System.Drawing.Image)(Properties.Resources.account__2_));
            this.pic_password.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
            txt_username.Clear();
            txt_password.Clear();
            txt_username.ResetText();
            txt_password.ResetText();
            txt_username.Focus();
            txt_password.Text = "Password";
            txt_password.UseSystemPasswordChar = true;
            pic_ocultado.Enabled = false;
            pic_ocultado.Visible = false;
            pic_mostrar.Enabled = true;
            pic_mostrar.Visible = true;
            lbl_limpar.Visible = false;
            lbl_limpar.Enabled = false;
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
            if (txt_username.Text == "Username")
            {
                txt_username.ResetText();
                txt_username.Focus();
            }
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            this.pic_password.Image = ((System.Drawing.Image)(Properties.Resources.padlock__2_));
            this.pic_username.Image = ((System.Drawing.Image)(Properties.Resources.account__1_));
            if (txt_password.Text == "Password")
            {
                txt_password.UseSystemPasswordChar = false;
                txt_password.ResetText();
                txt_password.Focus();
            }
        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
                }
                e.SuppressKeyPress = true;
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
                e.SuppressKeyPress = true;
                this.pic_username.Image = ((System.Drawing.Image)(Properties.Resources.account__1_));
                this.pic_password.Image = ((System.Drawing.Image)(Properties.Resources.padlock__1_));
            }
        }
    }
}
