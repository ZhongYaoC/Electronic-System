using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using DAL;

namespace 风力发电厂
{
    public partial class Fan_output : Form
    {
        public Fan_output()
        {
            InitializeComponent();
            Set_chart(chart1, "输出电压", 500, 800);
            Set_chart(chart2, "输出电流", 1000, 1600);
            Set_chart(chart3, "切出风速", 20, 35);
            Set_chart(chart4, "当前环境温度", 20, 45);
        }

        private void Set_chart(Chart chart, string fname, int min, int max)
        {
            string sql = "select 数据载入时间," + fname + " from machine_data where Machine_id=1";
            string sql2 = "select 数据载入时间," + fname + " from machine_data where Machine_id=2";
            string sql3 = "select 数据载入时间," + fname + " from machine_data where Machine_id=3";

            DataTable dt = DBhelp.GetDataTable(sql);
            DataTable dt2 = DBhelp.GetDataTable(sql2);
            DataTable dt3 = DBhelp.GetDataTable(sql3);

            chart.Series["风机1"].Points.DataBind(dt.AsEnumerable(), "数据载入时间", fname, "");
            chart.Series["风机1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart.Series["风机1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            chart.Series["风机2"].Points.DataBind(dt2.AsEnumerable(), "数据载入时间", fname, "");
            chart.Series["风机2"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart.Series["风机2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            chart.Series["风机3"].Points.DataBind(dt3.AsEnumerable(), "数据载入时间", fname, "");
            chart.Series["风机3"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart.Series["风机3"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            chart.ChartAreas["ChartArea1"].AxisY.Minimum = min;
            chart.ChartAreas["ChartArea1"].AxisY.Maximum = max;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Set_chart(chart1, "输出电压", 500, 800);
            Set_chart(chart2, "输出电流", 1000, 1600);
            Set_chart(chart3, "切出风速", 20, 35);
            Set_chart(chart4, "当前环境温度", 20, 45);
        }
    }
}
