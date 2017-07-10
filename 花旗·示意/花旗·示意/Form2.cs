using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;

namespace 花旗_示意
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
            

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public class login_state : Object
        {
            public bool whether_login =false;
            public List<bool> Strategy_list = new List<bool> { false, false };


        }


        private void button1_Click(object sender, EventArgs e)
        // 点击登录
        // 登录状态保存至 whether_login
        {
            string user = richTextBox1.Text;
            string password = richTextBox2.Text;
            string en_password =md5_Encryption(password);
            ls.whether_login = checkPw(user, en_password);

            if (checkBox1.Checked) //保存密码
            {

            }
            if (checkBox2.Checked)//自动登录
            {
                
            }


        }

        private string md5_Encryption(string password)
        // MD5加密密码
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] palindata = Encoding.Default.GetBytes(password);//将要加密的字符串转换为字节数组
            byte[] encryptdata = md5.ComputeHash(palindata);//将字符串加密后也转换为字符数组
            return Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为加密字符串
        }
        
        private bool checkPw(string user, string en_pw)
        // user：用户名 ； en_pw：MD5加密后的密码
        // List<bool> Strategy_list 中为策略是否选中
        {
            // 将用户名、密码传入数据库，返回值赋值给check(未完成）
            Boolean check = true;

            if (check)
            {
                // 将user传入数据库，返回一个list （Boolean）,bl,
                // {false, true, false} 代表选择策略二
                ls.Strategy_list = new List<bool> { false, true, false };
                
                return true;
            }
            else
            {
                MessageBox.Show("密码错误");
                return false;
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            public login_state ls = new login_state();

    }
    }
}
