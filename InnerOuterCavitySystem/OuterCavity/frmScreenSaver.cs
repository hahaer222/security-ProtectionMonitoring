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
    public partial class frmScreenSaver : frmBase
    {
        public frmScreenSaver()
        {
            InitializeComponent();
        }

        private void frmScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.Show();
        }

        protected bool CheckPersonInfo()
        { 
            //获取人员信息并设置PersonInfo

        }
    }
}
