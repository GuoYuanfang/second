namespace 花旗_二
{
    partial class Form2
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.72826F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.27174F));
            this.tableLayoutPanel2.Controls.Add(this.textPassword, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.checkBox2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.checkBox1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textUser, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(245, 95);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(368, 436);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // textPassword
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textPassword, 2);
            this.textPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.textPassword.Location = new System.Drawing.Point(3, 112);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(362, 35);
            this.textPassword.TabIndex = 8;
            this.textPassword.Text = "密码";
            this.textPassword.Click += new System.EventHandler(this.textPassword_Click);
            this.textPassword.Enter += new System.EventHandler(this.textPassword_Enter);
            this.textPassword.Leave += new System.EventHandler(this.textPassword_Leave);
            // 
            // button2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.button2, 2);
            this.button2.Location = new System.Drawing.Point(3, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(362, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "登录";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(185, 221);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(138, 28);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "自动登录";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 221);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 28);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "保存密码";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textUser
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textUser, 2);
            this.textUser.ForeColor = System.Drawing.Color.DarkGray;
            this.textUser.Location = new System.Drawing.Point(3, 3);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(362, 35);
            this.textUser.TabIndex = 7;
            this.textUser.Text = "用户名";
            this.textUser.Click += new System.EventHandler(this.textUser_Click);
            this.textUser.Leave += new System.EventHandler(this.textUser_Leave);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 627);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUser;
    }
}