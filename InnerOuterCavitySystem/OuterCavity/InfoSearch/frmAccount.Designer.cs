namespace OuterCavity.InfoSearch
{
    partial class frmAccount
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Money_Amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Account_No = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Col_Detail_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Moddify_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gray;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(117, 37);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(300, 2);
            this.textBox2.TabIndex = 184;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 185;
            this.label1.Text = "账户基本信息";
            // 
            // txt_Money_Amount
            // 
            this.txt_Money_Amount.Enabled = false;
            this.txt_Money_Amount.Location = new System.Drawing.Point(100, 86);
            this.txt_Money_Amount.Name = "txt_Money_Amount";
            this.txt_Money_Amount.Size = new System.Drawing.Size(204, 20);
            this.txt_Money_Amount.TabIndex = 190;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 186;
            this.label2.Text = "余额";
            // 
            // txt_Account_No
            // 
            this.txt_Account_No.Enabled = false;
            this.txt_Account_No.Location = new System.Drawing.Point(100, 60);
            this.txt_Account_No.Name = "txt_Account_No";
            this.txt_Account_No.Size = new System.Drawing.Size(204, 20);
            this.txt_Account_No.TabIndex = 191;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 187;
            this.label3.Text = "账户";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(117, 130);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(300, 2);
            this.textBox1.TabIndex = 184;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(25, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 185;
            this.label4.Text = "账户明细";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Detail_Type,
            this.Col_Category,
            this.Col_Money,
            this.Col_Moddify_Time});
            this.dataGridView1.Location = new System.Drawing.Point(44, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(447, 309);
            this.dataGridView1.TabIndex = 192;
            // 
            // Col_Detail_Type
            // 
            this.Col_Detail_Type.HeaderText = "收入/支出";
            this.Col_Detail_Type.Name = "Col_Detail_Type";
            // 
            // Col_Category
            // 
            this.Col_Category.HeaderText = "类别";
            this.Col_Category.Name = "Col_Category";
            // 
            // Col_Money
            // 
            this.Col_Money.HeaderText = "金额(元)";
            this.Col_Money.Name = "Col_Money";
            // 
            // Col_Moddify_Time
            // 
            this.Col_Moddify_Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_Moddify_Time.HeaderText = "时间";
            this.Col_Moddify_Time.Name = "Col_Moddify_Time";
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Money_Amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Account_No);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmAccount";
            this.Text = "账户信息";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Detail_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Moddify_Time;
        private System.Windows.Forms.TextBox txt_Money_Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Account_No;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;

    }
}