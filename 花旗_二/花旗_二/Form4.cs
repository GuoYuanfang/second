using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 花旗_二
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default["user1"].ToString());
            
        }

        private void textUser_Click(object sender, EventArgs e)
        {
            textUser.Text = "";
            textUser.ForeColor = Color.Black;
        }
        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text == "")
            {
                textUser.Text = "用户名";
                textUser.ForeColor = Color.DarkGray;
            }
        }
        private void textPassword_Click(object sender, EventArgs e)
        {
            if (textPassword.Text == "密码")
            {
                textPassword.Text = "";

            }
            textPassword.ForeColor = Color.Black;
            textPassword.UseSystemPasswordChar = true;

        }
        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.UseSystemPasswordChar = false;
                textPassword.Text = "密码";
                textPassword.ForeColor = Color.DarkGray;

            }
        }
        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.Text == "密码")
            {
                textPassword.Text = "";

            }
            textPassword.ForeColor = Color.Black;
            textPassword.UseSystemPasswordChar = true;
        }

        private void textPassword2_Click(object sender, EventArgs e)
        {
            if (textPassword2.Text == "确认密码")
            {
                textPassword2.Text = "";

            }
            textPassword2.ForeColor = Color.Black;
            textPassword2.UseSystemPasswordChar = true;

        }
        private void textPassword2_Leave(object sender, EventArgs e)
        {
            if (textPassword2.Text == "")
            {
                textPassword2.UseSystemPasswordChar = false;
                textPassword2.Text = "确认密码";
                textPassword2.ForeColor = Color.DarkGray;

            }
        }
        private void textPassword2_Enter(object sender, EventArgs e)
        {
            if (textPassword2.Text == "确认密码")
            {
                textPassword2.Text = "";

            }
            textPassword2.ForeColor = Color.Black;
            textPassword2.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textPassword.Text != textPassword2.Text)
            {
                MessageBox.Show("请输入相同密码");
            }
            else
            {
                // 连接数据库，写入该账号、密码，策略等默认为0 （未完成）
                // 在本地文档写入该账号

                for(int i = 1; i < 5; i++)
                {
                    string temp = "user" + i.ToString();
                    if (Properties.Settings.Default[temp] == "")
                    {
                        Properties.Settings.Default[temp] = textUser.Text;
                        Properties.Settings.Default.Save();
                        break;
                    }                    
                }
                 
            }
        }


    }
}
