namespace OuterCavity.InfoSearch
{
    partial class frmDeliver
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Col_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Time,
            this.Col_Type,
            this.col_person,
            this.Col_remark});
            this.dataGridView1.Location = new System.Drawing.Point(30, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(475, 428);
            this.dataGridView1.TabIndex = 0;
            // 
            // Col_Time
            // 
            this.Col_Time.HeaderText = "时间";
            this.Col_Time.Name = "Col_Time";
            this.Col_Time.Width = 130;
            // 
            // Col_Type
            // 
            this.Col_Type.HeaderText = "活动类型";
            this.Col_Type.Name = "Col_Type";
            // 
            // col_person
            // 
            this.col_person.HeaderText = "经办人";
            this.col_person.Name = "col_person";
            // 
            // Col_remark
            // 
            this.Col_remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_remark.HeaderText = "备注";
            this.Col_remark.Name = "Col_remark";
            // 
            // frmDeliver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(550, 567);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmDeliver";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_person;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_remark;
    }
}
