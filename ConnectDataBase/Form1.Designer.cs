namespace ConnectDataBase
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_sid = new System.Windows.Forms.TextBox();
            this.textBox_sname = new System.Windows.Forms.TextBox();
            this.textBox_sbirth = new System.Windows.Forms.TextBox();
            this.textBox_ssex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_select = new System.Windows.Forms.Button();
            this.checkBox_sname = new System.Windows.Forms.CheckBox();
            this.checkBox_sbirth = new System.Windows.Forms.CheckBox();
            this.checkBox_ssex = new System.Windows.Forms.CheckBox();
            this.checkBox_sid = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "连接数据库";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(683, 214);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox_sid
            // 
            this.textBox_sid.Location = new System.Drawing.Point(97, 314);
            this.textBox_sid.Name = "textBox_sid";
            this.textBox_sid.Size = new System.Drawing.Size(100, 25);
            this.textBox_sid.TabIndex = 3;
            // 
            // textBox_sname
            // 
            this.textBox_sname.Location = new System.Drawing.Point(282, 314);
            this.textBox_sname.Name = "textBox_sname";
            this.textBox_sname.Size = new System.Drawing.Size(100, 25);
            this.textBox_sname.TabIndex = 4;
            // 
            // textBox_sbirth
            // 
            this.textBox_sbirth.Location = new System.Drawing.Point(466, 314);
            this.textBox_sbirth.Name = "textBox_sbirth";
            this.textBox_sbirth.Size = new System.Drawing.Size(100, 25);
            this.textBox_sbirth.TabIndex = 5;
            // 
            // textBox_ssex
            // 
            this.textBox_ssex.Location = new System.Drawing.Point(653, 314);
            this.textBox_ssex.Name = "textBox_ssex";
            this.textBox_ssex.Size = new System.Drawing.Size(100, 25);
            this.textBox_ssex.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "s_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "s_name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "s_birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "s_sex";
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(139, 400);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(75, 35);
            this.button_insert.TabIndex = 11;
            this.button_insert.Text = "插入";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(282, 403);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 35);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "删除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(420, 403);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 35);
            this.button_update.TabIndex = 13;
            this.button_update.Text = "修改";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(556, 403);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(75, 35);
            this.button_select.TabIndex = 14;
            this.button_select.Text = "查询";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // checkBox_sname
            // 
            this.checkBox_sname.AutoSize = true;
            this.checkBox_sname.Location = new System.Drawing.Point(282, 345);
            this.checkBox_sname.Name = "checkBox_sname";
            this.checkBox_sname.Size = new System.Drawing.Size(77, 19);
            this.checkBox_sname.TabIndex = 15;
            this.checkBox_sname.Text = "s_name";
            this.checkBox_sname.UseVisualStyleBackColor = true;
            // 
            // checkBox_sbirth
            // 
            this.checkBox_sbirth.AutoSize = true;
            this.checkBox_sbirth.Location = new System.Drawing.Point(466, 345);
            this.checkBox_sbirth.Name = "checkBox_sbirth";
            this.checkBox_sbirth.Size = new System.Drawing.Size(85, 19);
            this.checkBox_sbirth.TabIndex = 16;
            this.checkBox_sbirth.Text = "s_birth";
            this.checkBox_sbirth.UseVisualStyleBackColor = true;
            // 
            // checkBox_ssex
            // 
            this.checkBox_ssex.AutoSize = true;
            this.checkBox_ssex.Location = new System.Drawing.Point(653, 345);
            this.checkBox_ssex.Name = "checkBox_ssex";
            this.checkBox_ssex.Size = new System.Drawing.Size(69, 19);
            this.checkBox_ssex.TabIndex = 17;
            this.checkBox_ssex.Text = "s_sex";
            this.checkBox_ssex.UseVisualStyleBackColor = true;
            // 
            // checkBox_sid
            // 
            this.checkBox_sid.AutoSize = true;
            this.checkBox_sid.Location = new System.Drawing.Point(97, 345);
            this.checkBox_sid.Name = "checkBox_sid";
            this.checkBox_sid.Size = new System.Drawing.Size(61, 19);
            this.checkBox_sid.TabIndex = 23;
            this.checkBox_sid.Text = "s_id";
            this.checkBox_sid.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 42);
            this.button2.TabIndex = 24;
            this.button2.Text = "说明";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox_sid);
            this.Controls.Add(this.checkBox_ssex);
            this.Controls.Add(this.checkBox_sbirth);
            this.Controls.Add(this.checkBox_sname);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ssex);
            this.Controls.Add(this.textBox_sbirth);
            this.Controls.Add(this.textBox_sname);
            this.Controls.Add(this.textBox_sid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_sid;
        private System.Windows.Forms.TextBox textBox_sname;
        private System.Windows.Forms.TextBox textBox_sbirth;
        private System.Windows.Forms.TextBox textBox_ssex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.CheckBox checkBox_sname;
        private System.Windows.Forms.CheckBox checkBox_sbirth;
        private System.Windows.Forms.CheckBox checkBox_ssex;
        private System.Windows.Forms.CheckBox checkBox_sid;
        private System.Windows.Forms.Button button2;
    }
}

