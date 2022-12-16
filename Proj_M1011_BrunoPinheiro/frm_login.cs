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
            frm_signin frm_signin = new frm_signin();
            frm_signin.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
        }
    }
}
