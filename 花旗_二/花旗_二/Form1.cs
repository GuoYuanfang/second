using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;


namespace 花旗_二
{


    public partial class Form1 : Form
    {

        public static string value;


        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();

        public Form1()
        {
            InitializeComponent();
        }

        



        private void Form1_Load(object sender, EventArgs e)
        {
            fill_the_buttom();
            f3.Show();
         
            
        }

        public void fill_the_buttom()
            //将底部沪、深、创、300、Time的内容填满
            //涨则红色，跌则绿色
        {
            //连接数据库得到沪、深、创业、沪深300
            string H_content = "3222.42    + 4.26    + 0.13%";
            string S_content = "10427.79    - 38.31    - 0.37%";
            string C_content = "1745.57    - 33.29    - 1.87%";
            string hs300_content = "3730    + 1717    + 0.44";
            
            //填入内容
            labelH_content.Text = H_content;
            labelS_content.Text = S_content;
            labelC_content.Text = C_content;
            label300_content.Text = hs300_content;

            //改变颜色，涨红跌绿
            labelH_content.ForeColor = upOrDown(H_content) ? Color.Red : Color.Green;
            labelS_content.ForeColor = upOrDown(S_content) ? Color.Red : Color.Green;
            labelC_content.ForeColor = upOrDown(C_content) ? Color.Red : Color.Green;
            label300_content.ForeColor = upOrDown(hs300_content) ? Color.Red : Color.Green;


            labelTime.Text = DateTime.Now.ToString(); 
        }

        public bool upOrDown(string content)
            //给一段string，若涨,则返回true
            //若其中无'+'无'-'，会返回true
        {
            int temp = content.IndexOf('-');
            return temp == -1;
        }


        private void 登录ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            f2.Show();
        }

        private void tabP1_Click(object sender, EventArgs e)
        {

        }

        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.Show();
        }
    }




}
