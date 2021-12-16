namespace ProgrammerTool
{
    partial class MyContainer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyContainer));
            this.StringTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UnicodeBtn = new System.Windows.Forms.Button();
            this.SQLBtn = new System.Windows.Forms.Button();
            this.JSONBtn = new System.Windows.Forms.Button();
            this.StringTextBox = new System.Windows.Forms.TextBox();
            this.UnicodeBtn2 = new System.Windows.Forms.Button();
            this.StringTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StringTab
            // 
            this.StringTab.Controls.Add(this.tabPage1);
            this.StringTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StringTab.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StringTab.Location = new System.Drawing.Point(12, 12);
            this.StringTab.Name = "StringTab";
            this.StringTab.SelectedIndex = 0;
            this.StringTab.Size = new System.Drawing.Size(754, 526);
            this.StringTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.UnicodeBtn2);
            this.tabPage1.Controls.Add(this.UnicodeBtn);
            this.tabPage1.Controls.Add(this.SQLBtn);
            this.tabPage1.Controls.Add(this.JSONBtn);
            this.tabPage1.Controls.Add(this.StringTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(746, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "字符串处理";
            // 
            // UnicodeBtn
            // 
            this.UnicodeBtn.BackColor = System.Drawing.Color.White;
            this.UnicodeBtn.ForeColor = System.Drawing.Color.Black;
            this.UnicodeBtn.Location = new System.Drawing.Point(242, 395);
            this.UnicodeBtn.Name = "UnicodeBtn";
            this.UnicodeBtn.Size = new System.Drawing.Size(127, 37);
            this.UnicodeBtn.TabIndex = 3;
            this.UnicodeBtn.Text = "Unicode编码";
            this.UnicodeBtn.UseVisualStyleBackColor = false;
            this.UnicodeBtn.Click += new System.EventHandler(this.UnicodeBtn_Click);
            // 
            // SQLBtn
            // 
            this.SQLBtn.BackColor = System.Drawing.Color.White;
            this.SQLBtn.ForeColor = System.Drawing.Color.Black;
            this.SQLBtn.Location = new System.Drawing.Point(125, 395);
            this.SQLBtn.Name = "SQLBtn";
            this.SQLBtn.Size = new System.Drawing.Size(111, 37);
            this.SQLBtn.TabIndex = 2;
            this.SQLBtn.Text = "SQL美化";
            this.SQLBtn.UseVisualStyleBackColor = false;
            this.SQLBtn.Click += new System.EventHandler(this.SQLBtn_Click);
            // 
            // JSONBtn
            // 
            this.JSONBtn.BackColor = System.Drawing.Color.White;
            this.JSONBtn.ForeColor = System.Drawing.Color.Black;
            this.JSONBtn.Location = new System.Drawing.Point(8, 395);
            this.JSONBtn.Name = "JSONBtn";
            this.JSONBtn.Size = new System.Drawing.Size(111, 37);
            this.JSONBtn.TabIndex = 1;
            this.JSONBtn.Text = "JSON格式";
            this.JSONBtn.UseVisualStyleBackColor = false;
            this.JSONBtn.Click += new System.EventHandler(this.JSONBtn_Click);
            // 
            // StringTextBox
            // 
            this.StringTextBox.BackColor = System.Drawing.Color.White;
            this.StringTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StringTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StringTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StringTextBox.Location = new System.Drawing.Point(3, 3);
            this.StringTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.StringTextBox.Multiline = true;
            this.StringTextBox.Name = "StringTextBox";
            this.StringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StringTextBox.Size = new System.Drawing.Size(740, 376);
            this.StringTextBox.TabIndex = 0;
            // 
            // UnicodeBtn2
            // 
            this.UnicodeBtn2.BackColor = System.Drawing.Color.White;
            this.UnicodeBtn2.ForeColor = System.Drawing.Color.Black;
            this.UnicodeBtn2.Location = new System.Drawing.Point(375, 395);
            this.UnicodeBtn2.Name = "UnicodeBtn2";
            this.UnicodeBtn2.Size = new System.Drawing.Size(127, 37);
            this.UnicodeBtn2.TabIndex = 4;
            this.UnicodeBtn2.Text = "Unicode解码";
            this.UnicodeBtn2.UseVisualStyleBackColor = false;
            this.UnicodeBtn2.Click += new System.EventHandler(this.UnicodeBtn2_Click);
            // 
            // MyContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 550);
            this.Controls.Add(this.StringTab);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MyContainer";
            this.Text = "程序员工具";
            this.StringTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl StringTab;
        private TabPage tabPage1;
        private TextBox StringTextBox;
        private Button JSONBtn;
        private Button SQLBtn;
        private Button UnicodeBtn;
        private Button UnicodeBtn2;
    }
}