namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.userControl11 = new SuperProxy.SpeedLimt4Fiddler.SpeedLimitControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.userControl12 = new SuperProxy.SpeedLimt4Fiddler.SpeedLimitControl();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(31, 24);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(192, 174);
            this.userControl11.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 323);
            this.tabControl1.TabIndex = 0;
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(161, 17);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(8, 8);
            this.userControl12.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 323);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperProxy.SpeedLimt4Fiddler.SpeedLimitControl userControl11;
        private System.Windows.Forms.TabControl tabControl1;
        private SuperProxy.SpeedLimt4Fiddler.SpeedLimitControl userControl12;
    }
}

