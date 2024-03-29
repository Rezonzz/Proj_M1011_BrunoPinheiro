﻿using System;
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
    public partial class frm_menu2 : Form
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
        public frm_menu2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login frm_login = new frm_login();
            frm_login.Show();
            this.Close();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            frm_sair frm_sair = new frm_sair();
            frm_sair.Show();
        }

        private void btn_autor_Click(object sender, EventArgs e)
        {
            frm_autor frm_autor = new frm_autor();
            frm_autor.Show();
        }

        private void btn_stock_MouseLeave(object sender, EventArgs e)
        {
            this.btn_stock.Image = ((System.Drawing.Image)(Properties.Resources.jordan3));
        }

        private void btn_stock_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_stock.Image = ((System.Drawing.Image)(Properties.Resources.jordan4));
        }

        private void btn_autor_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_autor.Image = ((System.Drawing.Image)(Properties.Resources.jordan61));
        }

        private void btn_autor_MouseLeave(object sender, EventArgs e)
        {
            this.btn_autor.Image = ((System.Drawing.Image)(Properties.Resources.jordan51));
        }

        private void btn_sair_MouseLeave(object sender, EventArgs e)
        {
            this.btn_sair.Image = ((System.Drawing.Image)(Properties.Resources.jordan7));
        }

        private void btn_sair_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_sair.Image = ((System.Drawing.Image)(Properties.Resources.jordan8));
        }

        private void frm_menu2_Load(object sender, EventArgs e)
        {
            lbl_username.Text = UserInfo.Username_user + " - Cliente";
        }

        private void btn_logout_MouseLeave(object sender, EventArgs e)
        {
            this.btn_logout.Image = ((System.Drawing.Image)(Properties.Resources.joordan9));
        }

        private void btn_logout_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_logout.Image = ((System.Drawing.Image)(Properties.Resources.jordan10));
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

        private void btn_stock_Click(object sender, EventArgs e)
        {
            frm_consultarmenu2 frm_consultarmenu2 = new frm_consultarmenu2();
            frm_consultarmenu2.Show();
            this.Close();
        }
    }
}
