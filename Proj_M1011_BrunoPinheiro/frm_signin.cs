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
    public partial class frm_signin : Form
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
        public frm_signin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        private void rad_sim_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(337, 640);
            this.CenterToScreen();
            btn_login.Location = new Point(92, 556);
            lbl_limpar.Location = new Point(238, 563);
            lbl_sair.Location = new Point(139, 596);
            lbl_vazio.Location = new Point(49, 529);
            lbl_invalido.Location = new Point(49, 529);
            pic_passe.Visible = true;
            txt_passe.Visible = true;
            pnl_passe.Visible = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            frm_login frm_login = new frm_login();
            frm_login.Show();
            this.Close();
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

        private void rad_nao_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(337, 576);
            this.CenterToScreen();
            btn_login.Location = new Point(92, 504);
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
            btn_login.BackColor = Color.Black;
            btn_login.ForeColor = Color.White;
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.White;
            btn_login.ForeColor = Color.Black;
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

        private void pic_logo_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void btn_minimize_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void btn_close_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void btn_close_MouseLeave(object sender, EventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btn_minimize_MouseLeave(object sender, EventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void lbl_name_MouseLeave(object sender, EventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void pic_logo_MouseLeave(object sender, EventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}
