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
    public partial class frm_creditos : Form
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
        public frm_creditos()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        private void tmr_creditos_Tick(object sender, EventArgs e)
        {
            lbl_dp.Location = new Point(lbl_dp.Location.X, lbl_dp.Location.Y - 2);
            lbl_nome1.Location = new Point(lbl_nome1.Location.X, lbl_nome1.Location.Y - 2);
            lbl_ap.Location = new Point(lbl_ap.Location.X, lbl_ap.Location.Y - 2);
            lbl_nome2.Location = new Point(lbl_nome2.Location.X, lbl_nome2.Location.Y - 2);
            lbl_ts.Location = new Point(lbl_ts.Location.X, lbl_ts.Location.Y - 2);
            lbl_nome3.Location = new Point(lbl_nome3.Location.X, lbl_nome3.Location.Y - 2);
            lbl_d.Location = new Point(lbl_d.Location.X, lbl_d.Location.Y - 2);
            lbl_nome4.Location = new Point(lbl_nome4.Location.X, lbl_nome4.Location.Y - 2);
            lbl_p.Location = new Point(lbl_p.Location.X, lbl_p.Location.Y - 2);
            lbl_nome5.Location = new Point(lbl_nome5.Location.X, lbl_nome5.Location.Y - 2);
            lbl_dep.Location = new Point(lbl_dep.Location.X, lbl_dep.Location.Y - 2);
            lbl_nome6.Location = new Point(lbl_nome6.Location.X, lbl_nome6.Location.Y - 2);

            if (lbl_nome6.Location.Y <= 100)
            {
                lbl_dp.Location = new Point(54, 557);
                lbl_nome1.Location = new Point(92, 589);
                lbl_ap.Location = new Point(38, 632);
                lbl_nome2.Location = new Point(92, 661);
                lbl_ts.Location = new Point(76, 703);
                lbl_nome3.Location = new Point(92, 733);
                lbl_d.Location = new Point(121, 778);
                lbl_nome4.Location = new Point(92, 808);
                lbl_p.Location = new Point(112, 846);
                lbl_nome5.Location = new Point(92, 882);
                lbl_dep.Location = new Point(78, 921);
                lbl_nome6.Location = new Point(92, 955);
            }
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
