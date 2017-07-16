namespace 花旗_二
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabControl tabC;
            this.tabP1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabP2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTime = new System.Windows.Forms.Label();
            this.label300_content = new System.Windows.Forms.Label();
            this.label300 = new System.Windows.Forms.Label();
            this.labelC_content = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelS_content = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.labelH_content = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tabC = new System.Windows.Forms.TabControl();
            tabC.SuspendLayout();
            this.tabP1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabP2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabC
            // 
            tabC.Alignment = System.Windows.Forms.TabAlignment.Left;
            tabC.Controls.Add(this.tabP1);
            tabC.Controls.Add(this.tabP2);
            tabC.Dock = System.Windows.Forms.DockStyle.Fill;
            tabC.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            tabC.Location = new System.Drawing.Point(3, 3);
            tabC.Multiline = true;
            tabC.Name = "tabC";
            tabC.SelectedIndex = 0;
            tabC.Size = new System.Drawing.Size(1877, 1175);
            tabC.TabIndex = 2;
            // 
            // tabP1
            // 
            this.tabP1.Controls.Add(this.tableLayoutPanel3);
            this.tabP1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabP1.Location = new System.Drawing.Point(34, 4);
            this.tabP1.Name = "tabP1";
            this.tabP1.Padding = new System.Windows.Forms.Padding(3);
            this.tabP1.Size = new System.Drawing.Size(1839, 1167);
            this.tabP1.TabIndex = 0;
            this.tabP1.Text = "综合看盘";
            this.tabP1.UseVisualStyleBackColor = true;
            this.tabP1.Click += new System.EventHandler(this.tabP1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1164F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1833, 1161);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "各只股票信息 - 点击出现form3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(736, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "大盘信息、龙虎榜";
            // 
            // tabP2
            // 
            this.tabP2.Controls.Add(this.tableLayoutPanel4);
            this.tabP2.Font = new System.Drawing.Font("新宋体", 10.125F);
            this.tabP2.Location = new System.Drawing.Point(34, 4);
            this.tabP2.Name = "tabP2";
            this.tabP2.Padding = new System.Windows.Forms.Padding(3);
            this.tabP2.Size = new System.Drawing.Size(1839, 1170);
            this.tabP2.TabIndex = 1;
            this.tabP2.Text = "自选策略";
            this.tabP2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(73, 55);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1695, 1020);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(850, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 27);
            this.label6.TabIndex = 3;
            this.label6.Text = "策略介绍";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "持仓";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(850, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "交易历史";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "持仓";
            // 
            // 用户ToolStripMenuItem
            // 
            this.用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册ToolStripMenuItem,
            this.登录ToolStripMenuItem});
            this.用户ToolStripMenuItem.Name = "用户ToolStripMenuItem";
            this.用户ToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
            this.用户ToolStripMenuItem.Text = "用户";
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.登录ToolStripMenuItem.Text = "登录";
            this.登录ToolStripMenuItem.Click += new System.EventHandler(this.登录ToolStripMenuItem_Click_1);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1883, 42);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 1221);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1883, 20);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(tabC, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1883, 1241);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.tableLayoutPanel2.Controls.Add(this.labelTime, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.label300_content, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.label300, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelC_content, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelC, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelS_content, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelS, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelH_content, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelH, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 1184);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1877, 34);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTime.Location = new System.Drawing.Point(1816, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(58, 34);
            this.labelTime.TabIndex = 9;
            this.labelTime.Text = "time";
            // 
            // label300_content
            // 
            this.label300_content.AutoSize = true;
            this.label300_content.Location = new System.Drawing.Point(1273, 0);
            this.label300_content.Name = "label300_content";
            this.label300_content.Size = new System.Drawing.Size(82, 24);
            this.label300_content.TabIndex = 8;
            this.label300_content.Text = "label8";
            // 
            // label300
            // 
            this.label300.AutoSize = true;
            this.label300.Location = new System.Drawing.Point(1218, 0);
            this.label300.Name = "label300";
            this.label300.Size = new System.Drawing.Size(46, 24);
            this.label300.TabIndex = 7;
            this.label300.Text = "300";
            // 
            // labelC_content
            // 
            this.labelC_content.AutoSize = true;
            this.labelC_content.Location = new System.Drawing.Point(853, 0);
            this.labelC_content.Name = "labelC_content";
            this.labelC_content.Size = new System.Drawing.Size(82, 24);
            this.labelC_content.TabIndex = 6;
            this.labelC_content.Text = "label6";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(813, 0);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(34, 24);
            this.labelC.TabIndex = 5;
            this.labelC.Text = "创";
            // 
            // labelS_content
            // 
            this.labelS_content.AutoSize = true;
            this.labelS_content.Location = new System.Drawing.Point(448, 0);
            this.labelS_content.Name = "labelS_content";
            this.labelS_content.Size = new System.Drawing.Size(82, 24);
            this.labelS_content.TabIndex = 4;
            this.labelS_content.Text = "label4";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(408, 0);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(34, 24);
            this.labelS.TabIndex = 3;
            this.labelS.Text = "深";
            // 
            // labelH_content
            // 
            this.labelH_content.AutoSize = true;
            this.labelH_content.Location = new System.Drawing.Point(43, 0);
            this.labelH_content.Name = "labelH_content";
            this.labelH_content.Size = new System.Drawing.Size(238, 24);
            this.labelH_content.TabIndex = 2;
            this.labelH_content.Text = "3222.42+4.26 +0.13%";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(3, 0);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(34, 24);
            this.labelH.TabIndex = 1;
            this.labelH.Text = "沪";
            // 
            // 注册ToolStripMenuItem
            // 
            this.注册ToolStripMenuItem.Name = "注册ToolStripMenuItem";
            this.注册ToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.注册ToolStripMenuItem.Text = "注册";
            this.注册ToolStripMenuItem.Click += new System.EventHandler(this.注册ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1883, 1283);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            tabC.ResumeLayout(false);
            this.tabP1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabP2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabP1;
        private System.Windows.Forms.TabPage tabP2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label300_content;
        private System.Windows.Forms.Label label300;
        private System.Windows.Forms.Label labelC_content;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelS_content;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label labelH_content;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem 注册ToolStripMenuItem;
    }
}

