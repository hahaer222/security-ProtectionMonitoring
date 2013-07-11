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
    public partial class frmHome : frmBase
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btn_Shop_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void btn_Education_Click(object sender, EventArgs e)
        {

        }

        private void btn_Law_Click(object sender, EventArgs e)
        {

        }

        private void frmHome_KeyDown(object sender, KeyEventArgs e)
        {

        }
        /// <summary>
        /// 键盘事件
        /// 0  48 H  72 
        ///1 49 I  73 
        ///2 50 J  74 
        ///3  51 K  75 
        ///4  52 L  76 
        ///5 53 M  77 
        ///6  54 N  78 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 48)
            { 
                frmMain frm = this.MdiParent as frmMain;
                frm.btn_Home_Click(null,null);
            }
            else if(e.KeyChar == 49)//信息查询
            {
                frmMain frm = this.MdiParent as frmMain;
                InfoSearch.FrmSearchInfo info = new InfoSearch.FrmSearchInfo();
                info.MdiParent = frm;
                info.Show();
                this.Close();
            }
            else if(e.KeyChar == 50)//预约购物
            {
                
            }
            else if(e.KeyChar == 51)//教育学习
            {
                
            }
            else if(e.KeyChar == 52)//法律法规
            {
                
            }
        }
    }
}
