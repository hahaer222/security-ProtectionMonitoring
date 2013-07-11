using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OuterCavity.InfoSearch
{
    public partial class FrmSearchInfo : frmBase
    {

        Form frm = null;
        public FrmSearchInfo()
        {
            InitializeComponent();
        }

        private void btn_BaseInfo_Click(object sender, EventArgs e)
        {

        }

        private void btn_Manage_Click(object sender, EventArgs e)
        {

        }

        private void btn_Account_Click(object sender, EventArgs e)
        {

        }

        private void btn_Notice_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmSearchInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 48)
            {
                frmMain frm = this.MdiParent as frmMain;
                
                frm.btn_Home_Click(null,null);
                this.Close();
            }
            else if(e.KeyChar == 49)//个人信息
            {
                ShowTabForm(btn_BaseInfo.Text);
            }
            else if(e.KeyChar == 50)//替身管教
            {
                ShowTabForm(btn_Manage.Text);
            }
            else if(e.KeyChar == 51)//账户
            {
                ShowTabForm(btn_Account.Text);
            }
            else if(e.KeyChar == 52)//监规
            {
                ShowTabForm(btn_Notice.Text);
            }
        }


        private void ShowTabForm(string text)
        {
            try
            {
                if (text == btn_BaseInfo.Text)
                {
                    frm = new frmBaseInfo();
                }
                if (text == btn_Account.Text)
                {
                    frm = new frmAccount();
                }
                if (text == btn_Manage.Text)
                {
                    frm = new frmDeliver();
                }
                if (text == btn_Notice.Text)
                {
                    frm = new frmNotice();
                }
                frm.TopLevel = false;
                TabPage tp = new TabPage();
                tp.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                this.tabControl1.TabPages.Add(tp);
                tabControl1.SelectedTab = tp;
                tp.Show();

                frm.Show();
            }
            catch
            {
            }
        }
    }
}
