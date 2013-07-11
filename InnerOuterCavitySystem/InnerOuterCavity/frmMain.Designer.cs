namespace InnerOuterCavity
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Law = new System.Windows.Forms.Button();
            this.btn_Education = new System.Windows.Forms.Button();
            this.btn_Shop = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Law);
            this.panel2.Controls.Add(this.btn_Education);
            this.panel2.Controls.Add(this.btn_Shop);
            this.panel2.Controls.Add(this.btn_Search);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 425);
            this.panel2.TabIndex = 3;
            // 
            // btn_Law
            // 
            this.btn_Law.Location = new System.Drawing.Point(494, 263);
            this.btn_Law.Name = "btn_Law";
            this.btn_Law.Size = new System.Drawing.Size(130, 53);
            this.btn_Law.TabIndex = 0;
            this.btn_Law.Text = "法律法规(4)";
            this.btn_Law.UseVisualStyleBackColor = true;
            // 
            // btn_Education
            // 
            this.btn_Education.Location = new System.Drawing.Point(141, 263);
            this.btn_Education.Name = "btn_Education";
            this.btn_Education.Size = new System.Drawing.Size(130, 53);
            this.btn_Education.TabIndex = 0;
            this.btn_Education.Text = "教育学习(3)";
            this.btn_Education.UseVisualStyleBackColor = true;
            // 
            // btn_Shop
            // 
            this.btn_Shop.Location = new System.Drawing.Point(494, 96);
            this.btn_Shop.Name = "btn_Shop";
            this.btn_Shop.Size = new System.Drawing.Size(130, 53);
            this.btn_Shop.TabIndex = 0;
            this.btn_Shop.Text = "预约购物(2)";
            this.btn_Shop.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(141, 96);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(130, 53);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "信息查询(1)";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 100);
            this.panel1.TabIndex = 2;
            // 
            // btn_Home
            // 
            this.btn_Home.Location = new System.Drawing.Point(598, 26);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(130, 53);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "返回(0)";
            this.btn_Home.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Law;
        private System.Windows.Forms.Button btn_Education;
        private System.Windows.Forms.Button btn_Shop;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Timer timer1;
    }
}

