namespace 花旗_二
{
    partial class Form4
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPassword2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.textPassword2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textUser, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textPassword, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(281, 70);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.66973F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.6789F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.04587F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(368, 436);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // textPassword
            // 
            this.textPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.textPassword.Location = new System.Drawing.Point(3, 128);
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
            this.button2.Location = new System.Drawing.Point(3, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(362, 66);
            this.button2.TabIndex = 6;
            this.button2.Text = "注册";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textUser
            // 
            this.textUser.ForeColor = System.Drawing.Color.DarkGray;
            this.textUser.Location = new System.Drawing.Point(3, 3);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(362, 35);
            this.textUser.TabIndex = 7;
            this.textUser.Text = "用户名";
            this.textUser.Click += new System.EventHandler(this.textUser_Click);
            this.textUser.Leave += new System.EventHandler(this.textUser_Leave);
            // 
            // textPassword2
            // 
            this.textPassword2.ForeColor = System.Drawing.Color.DarkGray;
            this.textPassword2.Location = new System.Drawing.Point(3, 192);
            this.textPassword2.Name = "textPassword2";
            this.textPassword2.Size = new System.Drawing.Size(362, 35);
            this.textPassword2.TabIndex = 9;
            this.textPassword2.Text = "确认密码";
            this.textPassword2.Enter += new System.EventHandler(this.textPassword2_Enter);
            this.textPassword2.Leave += new System.EventHandler(this.textPassword2_Leave);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 576);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPassword2;
    }
}