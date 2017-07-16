using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms.DataVisualization;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace 花旗_二
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Candlestick_Load();
        }






        public void Candlestick_Load()
        {
            chart1.Series.Add("Daily");
            chart1.Series["Daily"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            chart1.Series["Daily"]["PriceUpColor"] = "Red";
            chart1.Series["Daily"]["PriceDownColor"] = "Green";
            chart1.Series["Daily"].XValueType = ChartValueType.DateTime;
            chart1.Legends.Clear();

            string mysqlConnectionString = "Server=localhost;Database=my_oa;Uid=root;Pwd=gyf999o184";
            MySqlConnection conn = new MySqlConnection(mysqlConnectionString);
            MySqlCommand command;
            conn.Open();
            command = conn.CreateCommand();
            command.CommandText = "SELECT Max(HIGH), Min(LOW) FROM my_oa.`000001.sz` WHERE DATETIME > '2007-07-01' AND DATETIME < '2008-12-31'";
            //   FROM my_oa.`000001.sz` order by DATETIME DESC LIMIT 100


            MySqlDataReader dataReader = null;
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                double max = System.Convert.ToDouble(dataReader.GetString(0));
                double min = System.Convert.ToDouble(dataReader.GetString(1));
                chart1.ChartAreas[0].AxisY.Maximum = (9 * max - min) / 8;
                chart1.ChartAreas[0].AxisY.Minimum = (9 * min - max) / 8;
            }
            conn.Close();
            conn.Open();
            command.CommandText = "SELECT DATETIME, HIGH, LOW, OPEN, CLOSE FROM my_oa.`000001.sz` WHERE DATETIME > '2007-07-01' AND DATETIME < '2008-12-31'";
            dataReader = null;
            dataReader = command.ExecuteReader();
            int i = 0;
            while (dataReader.Read())
            {
                chart1.Series["Daily"].Points.AddXY(dataReader.GetString(0), System.Convert.ToDouble(dataReader.GetString(1)));
                chart1.Series["Daily"].Points[i].YValues[1] = System.Convert.ToDouble(dataReader.GetString(2));
                chart1.Series["Daily"].Points[i].YValues[2] = System.Convert.ToDouble(dataReader.GetString(3));
                chart1.Series["Daily"].Points[i].YValues[3] = System.Convert.ToDouble(dataReader.GetString(4));
                i++;
            }


            // grid line - parallel to Y
            chart1.ChartAreas[0].AxisX.StripLines.Add(new StripLine
            {
                BorderDashStyle = ChartDashStyle.Dash,
                BorderColor = Color.DarkGoldenrod,
                Interval = 0
            });

            // grid line - parallel to X
            chart1.ChartAreas[0].AxisY.StripLines.Add(new StripLine
            {
                BorderDashStyle = ChartDashStyle.Dash,
                BorderColor = Color.DarkBlue,
                Interval = 0
            });

            

            }
              
        private void chart1_MouseHover(object sender, EventArgs e)
        {
            chart1.GetToolTipText += new EventHandler<ToolTipEventArgs>(chart1_GetToolTipText);
        }

        private void chart1_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                int i = e.HitTestResult.PointIndex;
                DataPoint dp = e.HitTestResult.Series.Points[i];
                e.Text = "High: " + dp.YValues[0] + "\nLow: " + dp.YValues[1] + "\nOpen: " + dp.YValues[2] + "\nClose: " + dp.YValues[3];
            }

            

            // gridline  -  平行于Y
            chart1.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
            
            int j = (int)Math.Round(chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.X)); 

            chart1.ChartAreas[0].AxisX.StripLines[0].Text = j.ToString();
            //chart1.ChartAreas[0].AxisX.StripLines.Text = chart1.Series["Daily"].Points[j].XValue.ToString(); #值一直为0


            // 平行于X
            chart1.ChartAreas[0].AxisY.StripLines[0].IntervalOffset = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);
            chart1.ChartAreas[0].AxisY.StripLines[0].Text = Math.Round(chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Y),3).ToString();



        }
    }
}