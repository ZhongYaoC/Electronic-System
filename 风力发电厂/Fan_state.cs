using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace 风力发电厂
{
    public partial class Fan_state : Form
    {
        public Fan_state()
        {
            InitializeComponent();
            Init_view();
        }

        private void Init_view()
        {
            fan_view.DataSource = MachineHelp.Get_fanview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fid = fan_id.Text.ToString();
            fan_view.DataSource = MachineHelp.Get_fanview(fid);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Init_view();
        }
    }
}
