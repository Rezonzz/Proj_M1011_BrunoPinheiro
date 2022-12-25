using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_M1011_BrunoPinheiro
{
    public partial class frm_autor : Form
    {
        public frm_autor()
        {
            InitializeComponent();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_creditos_Click(object sender, EventArgs e)
        {
            frm_creditos frm_creditos = new frm_creditos();
            frm_creditos.Show();
        }
    }
}
