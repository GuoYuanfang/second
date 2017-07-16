using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace 花旗_二
{




    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public static class login_state : Object
        {
            public static bool whether_login;
            public static List<bool> Strategy_list;
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            textUser.Text = "用户名";
            textPassword.Text = "密码";







        }


        //用户名密码输入框
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




        //数据库格式为
        //table - login
        //username(varchar(45))      password(varchar(45)) # 已经过MD5加密
        //strategy1(tinyint)    strategy2(tinyint)  strategy3(tinyint)
        //remeber(tinyint)  login(tinyint)





        private void button1_Click(object sender, EventArgs e)
        // 点击登录
        // 登录状态保存至 login_state.whether_login
        {
            
            

            string user = textBox1.Text;
            string password = textBox2.Text;
            string en_password = md5_Encryption(password);


            login_state.whether_login = checkPw(user, en_password);




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

            Boolean check = false;

            string mysqlConnectionString = "Server=localhost;Database=my_oa;Uid=root;Pwd=gyf999o184";
            MySqlConnection conn = new MySqlConnection(mysqlConnectionString);
            MySqlCommand command;
            conn.Open();
            command = conn.CreateCommand();
            command.CommandText = "SELECT USER,PASSWORD,STRATEGY1,STRATEGY2,STRATEGY3 FROM my_oa.login where USERNAME = '"+user+ "'";
            MySqlDataReader dataReader = null;
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string data_user = dataReader.GetString(0);
                string data_pw = dataReader.GetString(1);
                string data_s1 = dataReader.GetString(2);
                string data_s2 = dataReader.GetString(3);
                string data_s3 = dataReader.GetString(4);

                if (en_pw == data_pw)
                {

                    check = true;
                    this.Close();
                }
              
            }





            if (check)
            {
                // 将user传入数据库，返回一个list （Boolean）,bl,
                // {false, true, false} 代表只选择策略二
                login_state.Strategy_list = new List<bool> { false, true, false };

                return true;
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
                return false;
            }

        }


    }
}
