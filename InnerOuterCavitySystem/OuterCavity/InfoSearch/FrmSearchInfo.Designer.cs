namespace OuterCavity.InfoSearch
{
    partial class FrmSearchInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Notice = new System.Windows.Forms.Button();
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_Manage = new System.Windows.Forms.Button();
            this.btn_BaseInfo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Notice);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Account);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Manage);
            this.splitContainer1.Panel1.Controls.Add(this.btn_BaseInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(730, 549);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_Notice
            // 
            this.btn_Notice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Notice.Location = new System.Drawing.Point(0, 150);
            this.btn_Notice.Name = "btn_Notice";
            this.btn_Notice.Size = new System.Drawing.Size(243, 50);
            this.btn_Notice.TabIndex = 1;
            this.btn_Notice.Text = "监所须知          (4)";
            this.btn_Notice.UseVisualStyleBackColor = true;
            this.btn_Notice.Click += new System.EventHandler(this.btn_Notice_Click);
            // 
            // btn_Account
            // 
            this.btn_Account.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Account.Location = new System.Drawing.Point(0, 100);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(243, 50);
            this.btn_Account.TabIndex = 0;
            this.btn_Account.Text = "个人账户信息   (3)";
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // btn_Manage
            // 
            this.btn_Manage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Manage.Location = new System.Drawing.Point(0, 50);
            this.btn_Manage.Name = "btn_Manage";
            this.btn_Manage.Size = new System.Drawing.Size(243, 50);
            this.btn_Manage.TabIndex = 0;
            this.btn_Manage.Text = "提审管教信息  (2)";
            this.btn_Manage.UseVisualStyleBackColor = true;
            this.btn_Manage.Click += new System.EventHandler(this.btn_Manage_Click);
            // 
            // btn_BaseInfo
            // 
            this.btn_BaseInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_BaseInfo.Location = new System.Drawing.Point(0, 0);
            this.btn_BaseInfo.Name = "btn_BaseInfo";
            this.btn_BaseInfo.Size = new System.Drawing.Size(243, 50);
            this.btn_BaseInfo.TabIndex = 0;
            this.btn_BaseInfo.Text = "基本信息         (1)";
            this.btn_BaseInfo.UseVisualStyleBackColor = true;
            this.btn_BaseInfo.Click += new System.EventHandler(this.btn_BaseInfo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(483, 549);
            this.tabControl1.TabIndex = 0;
            // 
            // FrmSearchInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 549);
            this.Controls.Add(this.splitContainer1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmSearchInfo";
            this.Text = "FrmSearchInfo";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmSearchInfo_KeyPress);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_Manage;
        private System.Windows.Forms.Button btn_BaseInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_Notice;
    }
}