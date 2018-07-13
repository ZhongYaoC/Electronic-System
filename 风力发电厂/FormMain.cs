using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 风力发电厂
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void 运作灌录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 供应商管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void 维修计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new MaintainPlan();
            this.IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 维护需求ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new MaintainRequire();
            this.IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }

        private void 维修实施ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new MaintainPerform();
            this.IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }

        private void 维修报告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new MaintainReport();
            this.IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }

        private void 订单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new OrderManage();
            IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }

        private void 供应商信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new SupplierManage();
            this.IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }

        private void 用户信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            this.IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }

        private void 用户信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new User_manage();
            this.IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }

        private void 备件管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Component_manage();
            this.IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }
    }
}
