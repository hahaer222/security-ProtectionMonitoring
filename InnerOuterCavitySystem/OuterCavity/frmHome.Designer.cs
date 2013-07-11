namespace OuterCavity
{
    partial class frmHome
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Education = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Law = new System.Windows.Forms.Button();
            this.btn_Shop = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 549);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Education, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Law, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Shop, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Search, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 549);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_Education
            // 
            this.btn_Education.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Education.Location = new System.Drawing.Point(117, 385);
            this.btn_Education.Name = "btn_Education";
            this.btn_Education.Size = new System.Drawing.Size(130, 53);
            this.btn_Education.TabIndex = 0;
            this.btn_Education.Text = "教育学习(3)";
            this.btn_Education.UseVisualStyleBackColor = true;
            this.btn_Education.Click += new System.EventHandler(this.btn_Education_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.Location = new System.Drawing.Point(117, 110);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(130, 53);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "信息查询(1)";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Law
            // 
            this.btn_Law.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Law.Location = new System.Drawing.Point(482, 385);
            this.btn_Law.Name = "btn_Law";
            this.btn_Law.Size = new System.Drawing.Size(130, 53);
            this.btn_Law.TabIndex = 0;
            this.btn_Law.Text = "法律法规(4)";
            this.btn_Law.UseVisualStyleBackColor = true;
            this.btn_Law.Click += new System.EventHandler(this.btn_Law_Click);
            // 
            // btn_Shop
            // 
            this.btn_Shop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Shop.Location = new System.Drawing.Point(482, 110);
            this.btn_Shop.Name = "btn_Shop";
            this.btn_Shop.Size = new System.Drawing.Size(130, 53);
            this.btn_Shop.TabIndex = 0;
            this.btn_Shop.Text = "预约购物(2)";
            this.btn_Shop.UseVisualStyleBackColor = true;
            this.btn_Shop.Click += new System.EventHandler(this.btn_Shop_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 549);
            this.Controls.Add(this.panel2);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHome_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmHome_KeyPress);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Law;
        private System.Windows.Forms.Button btn_Education;
        private System.Windows.Forms.Button btn_Shop;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}