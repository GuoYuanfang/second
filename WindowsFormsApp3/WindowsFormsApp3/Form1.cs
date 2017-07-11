using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;



using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // 设置曲线的样式
            
            Series series = chart1.Series[0];
            // 画样条曲线（Spline）
            series.ChartType = SeriesChartType.Spline;
            // 线宽2个像素
            series.BorderWidth = 2;
            // 线的颜色：红色
            series.Color = System.Drawing.Color.Red;
            // 图示上的文字
            series.LegendText = "大宗商品物价走势";

            // 准备数据 
            List<double> values = new List<double> { 95, 30, 20, 23, 60, 87, 42, 77, 92, 51, 29 };

            // 在chart中显示数据
            int x = 0;
            foreach (double v in values)
            {
                series.Points.AddXY(x, v);
                x++;
            }

            // 设置显示范围
            ChartArea chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = 10;
            chartArea.AxisY.Minimum = 0d;
            chartArea.AxisY.Maximum = 100d;
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            Random ra = new Random();

            Series se = chart2.Series[0];
            se.ChartType = SeriesChartType.Bar;
            se.BorderColor = System.Drawing.Color.DarkBlue;
            se.LegendText = "test chart";



            for(int i = 0; i < 10; i++)
            {
                se.Points.AddXY(i, ra.NextDouble());

            }
            ChartArea CA = chart2.ChartAreas[0];
            CA.AxisY.Minimum = 0d;
            CA.AxisY.Maximum = 1d;

        }

        private void chart3_Click(object sender, EventArgs e)
        {
            
            Random ran = new Random();
            Series ss = new Series();
            ss.ChartType = SeriesChartType.Candlestick;
            ss.BorderWidth = 2;

            ss.Color = System.Drawing.Color.Blue;
            ss.BorderColor = System.Drawing.Color.Red;
           
            

            ss.LegendText = "大宗商品物价走势";

            List<double> low = new List<double>();//最低

            List<double> high = new List<double>();//最高

            List<double> start = new List<double>();//开盘

            List<double> end = new List<double>();//收盘


            List<DataPoint> dp = new List<DataPoint>();

            for (int i = 0; i < 7; i++)
            {
               low.Add( 10 * ran.NextDouble());
                high.Add(low[i] + 2* ran.NextDouble());
                start.Add(low[i] + ran.NextDouble() * (high[i] - low[i]));
                end.Add(low[i] + ran.NextDouble() * (high[i] - low[i]));
                             

            }

            
            for (int i = 0; i < 7; i++)
            {
                double[] t = { high[i], low[i], start[i], end[i] }; // K线图点的纵坐标为一个double数组
                DataPoint temp = new DataPoint(i, t);
                ss.Points.Add(temp);
            }

            ChartArea caa = chart3.ChartAreas[0];
           

        }
    }
}
