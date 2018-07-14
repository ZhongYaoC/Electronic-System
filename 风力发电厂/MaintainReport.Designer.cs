namespace 风力发电厂
{
    partial class MaintainReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.alphaBlendTextBox1 = new ZBobb.AlphaBlendTextBox();
            this.account = new ZBobb.AlphaBlendTextBox();
            this.normal = new ZBobb.AlphaBlendTextBox();
            this.error = new ZBobb.AlphaBlendTextBox();
            this.fixing = new ZBobb.AlphaBlendTextBox();
            this.percent = new ZBobb.AlphaBlendTextBox();
            this.electronicSystemDataSet = new 风力发电厂.ElectronicSystemDataSet();
            this.machinedataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.machine_dataTableAdapter = new 风力发电厂.ElectronicSystemDataSetTableAdapters.machine_dataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.electronicSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinedataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // alphaBlendTextBox1
            // 
            this.alphaBlendTextBox1.BackAlpha = 10;
            this.alphaBlendTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.alphaBlendTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alphaBlendTextBox1.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alphaBlendTextBox1.Location = new System.Drawing.Point(104, 87);
            this.alphaBlendTextBox1.Multiline = true;
            this.alphaBlendTextBox1.Name = "alphaBlendTextBox1";
            this.alphaBlendTextBox1.ReadOnly = true;
            this.alphaBlendTextBox1.Size = new System.Drawing.Size(230, 189);
            this.alphaBlendTextBox1.TabIndex = 1;
            this.alphaBlendTextBox1.Text = "当前拥有总机器数量：\r\n\r\n正常：\r\n\r\n故障中：\r\n\r\n维护中：\r\n\r\n故障率：";
            // 
            // account
            // 
            this.account.BackAlpha = 10;
            this.account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.account.Location = new System.Drawing.Point(340, 87);
            this.account.Name = "account";
            this.account.ReadOnly = true;
            this.account.Size = new System.Drawing.Size(100, 14);
            this.account.TabIndex = 2;
            // 
            // normal
            // 
            this.normal.BackAlpha = 10;
            this.normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.normal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.normal.Location = new System.Drawing.Point(340, 123);
            this.normal.Name = "normal";
            this.normal.ReadOnly = true;
            this.normal.Size = new System.Drawing.Size(100, 14);
            this.normal.TabIndex = 3;
            // 
            // error
            // 
            this.error.BackAlpha = 10;
            this.error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.error.Location = new System.Drawing.Point(340, 164);
            this.error.Name = "error";
            this.error.ReadOnly = true;
            this.error.Size = new System.Drawing.Size(100, 14);
            this.error.TabIndex = 4;
            this.error.TextChanged += new System.EventHandler(this.error_TextChanged);
            // 
            // fixing
            // 
            this.fixing.BackAlpha = 10;
            this.fixing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fixing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fixing.Location = new System.Drawing.Point(340, 200);
            this.fixing.Name = "fixing";
            this.fixing.ReadOnly = true;
            this.fixing.Size = new System.Drawing.Size(100, 14);
            this.fixing.TabIndex = 5;
            // 
            // percent
            // 
            this.percent.BackAlpha = 10;
            this.percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.percent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.percent.Location = new System.Drawing.Point(340, 240);
            this.percent.Name = "percent";
            this.percent.ReadOnly = true;
            this.percent.Size = new System.Drawing.Size(100, 14);
            this.percent.TabIndex = 6;
            // 
            // electronicSystemDataSet
            // 
            this.electronicSystemDataSet.DataSetName = "ElectronicSystemDataSet";
            this.electronicSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // machinedataBindingSource
            // 
            this.machinedataBindingSource.DataMember = "machine_data";
            this.machinedataBindingSource.DataSource = this.electronicSystemDataSet;
            // 
            // machine_dataTableAdapter
            // 
            this.machine_dataTableAdapter.ClearBeforeFill = true;
            // 
            // MaintainReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.fixing);
            this.Controls.Add(this.error);
            this.Controls.Add(this.normal);
            this.Controls.Add(this.account);
            this.Controls.Add(this.alphaBlendTextBox1);
            this.Name = "MaintainReport";
            this.Text = "MaintainReport";
            this.Load += new System.EventHandler(this.MaintainReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.electronicSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinedataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ZBobb.AlphaBlendTextBox alphaBlendTextBox1;
        private ZBobb.AlphaBlendTextBox account;
        private ZBobb.AlphaBlendTextBox normal;
        private ZBobb.AlphaBlendTextBox error;
        private ZBobb.AlphaBlendTextBox fixing;
        private ZBobb.AlphaBlendTextBox percent;
        private ElectronicSystemDataSet electronicSystemDataSet;
        private System.Windows.Forms.BindingSource machinedataBindingSource;
        private ElectronicSystemDataSetTableAdapters.machine_dataTableAdapter machine_dataTableAdapter;
    }
}