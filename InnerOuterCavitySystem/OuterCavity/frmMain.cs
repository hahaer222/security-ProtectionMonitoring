using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OuterCavity
{
    public partial class frmMain : Form
    {
        public  frmHome home = new frmHome();
        public frmMain()
        {
            InitializeComponent();
            if(home == null)
            {
                home = new frmHome();
            }
            home.MdiParent = this;
            home.Show();
            //Cursor.Hide();
            
        }

        public void btn_Home_Click(object sender, EventArgs e)
        {
            if (home == null || home.IsDisposed)
            {
                home = new frmHome();
            }
            
            home.MdiParent = this;
            home.Show();
        }
    }
}
