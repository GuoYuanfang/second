using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 花旗_示意
{
    public partial class Form1 : Form
    {
        private Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateTime()
        {
            label6.Text = DateTime.Now.ToString();

        }

        private void operate(int strategy, string stock, int num, Boolean inOrOut)
        {
            string IO = inOrOut ? "买入" : "卖出";
            if (strategy == 1) richTextBox1.Text += IO + stock + num.ToString() + "股\n";
            if (strategy == 2) richTextBox2.Text += IO + stock + num.ToString() + "股\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“_300DataSet._20170612”中。您可以根据需要移动或删除它。
            this._20170612TableAdapter.Fill(this._300DataSet._20170612);
            updateTime();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this._20170612TableAdapter.FillBy(this._300DataSet._20170612);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this._20170612TableAdapter.FillBy1(this._300DataSet._20170612);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 登陆退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            f2.Show();
            f2.Close();


    
        }
    }
}
