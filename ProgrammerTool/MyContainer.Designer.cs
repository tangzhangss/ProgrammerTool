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
            System.Windows.Forms.TabControl StringTab;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyContainer));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.JSONBtn = new System.Windows.Forms.Button();
            this.StringTextBox = new System.Windows.Forms.TextBox();
            StringTab = new System.Windows.Forms.TabControl();
            StringTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StringTab
            // 
            StringTab.Controls.Add(this.tabPage1);
            StringTab.Cursor = System.Windows.Forms.Cursors.Hand;
            StringTab.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            StringTab.Location = new System.Drawing.Point(12, 12);
            StringTab.Name = "StringTab";
            StringTab.SelectedIndex = 0;
            StringTab.Size = new System.Drawing.Size(754, 526);
            StringTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.JSONBtn);
            this.tabPage1.Controls.Add(this.StringTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(746, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "字符串处理";
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
            // MyContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 550);
            this.Controls.Add(StringTab);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MyContainer";
            this.Text = "程序员工具";
            StringTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl StringTab;
        private TabPage tabPage1;
        private TextBox StringTextBox;
        private Button JSONBtn;
    }
}