using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace 风力发电厂
{
    public partial class MaintainReport : Form
    {
        public MaintainReport()
        {
            InitializeComponent();
            Init_gridview();
        }

        private void Init_gridview()
        {
            SqlDataReader normr = DBhelp.ExecuteReader("select count(*) from config where Meter_malfunc=1");
            while (normr.Read())
            {
                normal.Text = Convert.ToString(normr.GetInt32(0));
            }
            normr.Close();

            SqlDataReader accr = DBhelp.ExecuteReader("select count(*) from config");
            while (accr.Read())
            {
                account.Text = Convert.ToString(accr.GetInt32(0));
            }
            accr.Close();

            SqlDataReader fixr = DBhelp.ExecuteReader("select count(*) from config where Meter_malfunc = 0 and 开始维护时间 is not null");
            while (fixr.Read())
            {
                fixing.Text = Convert.ToString(fixr.GetInt32(0));
            }
            fixr.Close();

            SqlDataReader badr = DBhelp.ExecuteReader("select count(*) from config where Meter_malfunc=0");
            while (badr.Read())
            {
                error.Text = Convert.ToString(badr.GetInt32(0));
            }
            badr.Close();

            percent.Text = Convert.ToString((Convert.ToDecimal(error.Text)/Convert.ToDecimal(account.Text))*100)+"%";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void error_TextChanged(object sender, EventArgs e)
        {

        }

        private void lightningChartUltimate1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
