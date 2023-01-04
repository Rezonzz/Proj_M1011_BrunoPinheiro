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
    public partial class frm_consultarmenu : Form
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
        public frm_consultarmenu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
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

        private void btn_voltar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_voltar.Image = ((System.Drawing.Image)(Properties.Resources.jordan11));
        }

        private void btn_voltar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_voltar.Image = ((System.Drawing.Image)(Properties.Resources.jordan12));
        }
        string FromXML_passeAdm;
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            if (UserInfo.PasseAdm_user == "y")
            {
                frm_menu frm_menu = new frm_menu();
                frm_menu.Show();
                this.Close();
            }
            else
            {
                frm_menu2 frm_menu2 = new frm_menu2();
                frm_menu2.Show();
                this.Close();
            }
        }

        private void btn_artigos_Click(object sender, EventArgs e)
        {
            frm_consultarartigos frm_consultarartigos = new frm_consultarartigos();
            frm_consultarartigos.Show();
            this.Close();
        }
    }
}
