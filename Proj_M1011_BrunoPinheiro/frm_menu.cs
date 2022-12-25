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
    public partial class frm_menu : Form
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
        public frm_menu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        private void btn_artigos_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_artigos.Image = ((System.Drawing.Image)(Properties.Resources.jordan2));
        }

        private void btn_artigos_MouseLeave(object sender, EventArgs e)
        {
            this.btn_artigos.Image = ((System.Drawing.Image)(Properties.Resources.jordan1));
        }

        private void btn_consultar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_consultar.Image = ((System.Drawing.Image)(Properties.Resources.jordan4));
        }

        private void btn_consultar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_consultar.Image = ((System.Drawing.Image)(Properties.Resources.jordan3));
        }

        private void btn_autor_MouseLeave(object sender, EventArgs e)
        {
            this.btn_autor.Image = ((System.Drawing.Image)(Properties.Resources.jordan51));
        }

        private void btn_autor_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_autor.Image = ((System.Drawing.Image)(Properties.Resources.jordan61));
        }

        private void btn_sair_MouseLeave(object sender, EventArgs e)
        {
            this.btn_sair.Image = ((System.Drawing.Image)(Properties.Resources.jordan7));
        }

        private void btn_sair_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_sair.Image = ((System.Drawing.Image)(Properties.Resources.jordan8));
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_autor_Click(object sender, EventArgs e)
        {
            frm_autor frm_autor = new frm_autor();
            frm_autor.Show();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
