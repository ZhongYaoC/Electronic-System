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
        string limit;
        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(string li)
        {
            InitializeComponent();
            this.limit = li;
            Hide_item(limit);
        }

        private void Hide_item(string str)
        {
            switch (str)
            {
                case "0":
                    基础信息管理ToolStripMenuItem.Visible = false;
                    维修计划ToolStripMenuItem.Visible = false;
                    维修实施ToolStripMenuItem.Visible = false;
                    维修报告ToolStripMenuItem.Visible = false;
                    break;
                case "1":
                    基础信息管理ToolStripMenuItem.Visible = false;
                    break;
                case "2":
                    密码修改ToolStripMenuItem.Visible = false;
                    break;
                default:
                    MessageBox.Show("权限异常！");
                    break;
            }
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

        private void 风机状态监控ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 风机出力情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Changepassword();
            this.IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }
    }
}
