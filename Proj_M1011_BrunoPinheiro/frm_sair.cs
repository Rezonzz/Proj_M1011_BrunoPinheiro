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
    public partial class frm_sair : Form
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
        public frm_sair()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        private void pnl_top_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void pnl_top_MouseLeave(object sender, EventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void lbl_name_MouseLeave(object sender, EventArgs e)
        {
            pnl_top.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void lbl_name_MouseMove(object sender, MouseEventArgs e)
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

        private void btn_yes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_yes_MouseMove(object sender, MouseEventArgs e)
        {
            btn_yes.BackColor = Color.Black;
            btn_yes.ForeColor = Color.White;
        }

        private void btn_yes_MouseLeave(object sender, EventArgs e)
        {
            btn_yes.BackColor = Color.White;
            btn_yes.ForeColor = Color.Black;
        }

        private void btn_no_MouseMove(object sender, MouseEventArgs e)
        {
            btn_no.BackColor = Color.Black;
            btn_no.ForeColor = Color.White;
        }

        private void btn_no_MouseLeave(object sender, EventArgs e)
        {
            btn_no.BackColor = Color.White;
            btn_no.ForeColor = Color.Black;
        }

        private void lbl_name_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frm_sair_Load(object sender, EventArgs e)
        {

        }
    }
}
