namespace Score_Management_System
{
    partial class loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            this.loginbtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.userNamelb = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.pwdlb = new System.Windows.Forms.Label();
            this.sturadio = new System.Windows.Forms.RadioButton();
            this.teachradio = new System.Windows.Forms.RadioButton();
            this.pwd = new System.Windows.Forms.TextBox();
            this.tip1 = new System.Windows.Forms.Label();
            this.tip2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Transparent;
            this.loginbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginbtn.BackgroundImage")));
            this.loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginbtn.FlatAppearance.BorderSize = 0;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Location = new System.Drawing.Point(186, 172);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(70, 32);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.Color.Transparent;
            this.resetbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetbtn.BackgroundImage")));
            this.resetbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetbtn.FlatAppearance.BorderSize = 0;
            this.resetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetbtn.Location = new System.Drawing.Point(262, 172);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(70, 32);
            this.resetbtn.TabIndex = 1;
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // userNamelb
            // 
            this.userNamelb.AutoSize = true;
            this.userNamelb.BackColor = System.Drawing.Color.Transparent;
            this.userNamelb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userNamelb.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userNamelb.Location = new System.Drawing.Point(58, 42);
            this.userNamelb.Name = "userNamelb";
            this.userNamelb.Size = new System.Drawing.Size(76, 16);
            this.userNamelb.TabIndex = 2;
            this.userNamelb.Text = "用户名：";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(140, 42);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(143, 21);
            this.username.TabIndex = 3;
            // 
            // pwdlb
            // 
            this.pwdlb.AutoSize = true;
            this.pwdlb.BackColor = System.Drawing.Color.Transparent;
            this.pwdlb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pwdlb.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdlb.Location = new System.Drawing.Point(75, 93);
            this.pwdlb.Name = "pwdlb";
            this.pwdlb.Size = new System.Drawing.Size(59, 16);
            this.pwdlb.TabIndex = 4;
            this.pwdlb.Text = "密码：";
            // 
            // sturadio
            // 
            this.sturadio.AutoSize = true;
            this.sturadio.BackColor = System.Drawing.Color.Transparent;
            this.sturadio.Checked = true;
            this.sturadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sturadio.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sturadio.Location = new System.Drawing.Point(253, 137);
            this.sturadio.Name = "sturadio";
            this.sturadio.Size = new System.Drawing.Size(48, 16);
            this.sturadio.TabIndex = 6;
            this.sturadio.TabStop = true;
            this.sturadio.Text = "学生";
            this.sturadio.UseVisualStyleBackColor = false;
            // 
            // teachradio
            // 
            this.teachradio.AutoSize = true;
            this.teachradio.BackColor = System.Drawing.Color.Transparent;
            this.teachradio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teachradio.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.teachradio.Location = new System.Drawing.Point(306, 137);
            this.teachradio.Name = "teachradio";
            this.teachradio.Size = new System.Drawing.Size(48, 16);
            this.teachradio.TabIndex = 7;
            this.teachradio.TabStop = true;
            this.teachradio.Text = "教师";
            this.teachradio.UseVisualStyleBackColor = false;
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(140, 93);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(143, 21);
            this.pwd.TabIndex = 5;
            // 
            // tip1
            // 
            this.tip1.AutoSize = true;
            this.tip1.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tip1.ForeColor = System.Drawing.Color.Red;
            this.tip1.Location = new System.Drawing.Point(290, 42);
            this.tip1.Name = "tip1";
            this.tip1.Size = new System.Drawing.Size(0, 12);
            this.tip1.TabIndex = 8;
            // 
            // tip2
            // 
            this.tip2.AutoSize = true;
            this.tip2.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tip2.ForeColor = System.Drawing.Color.Red;
            this.tip2.Location = new System.Drawing.Point(291, 98);
            this.tip2.Name = "tip2";
            this.tip2.Size = new System.Drawing.Size(0, 12);
            this.tip2.TabIndex = 9;
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 235);
            this.Controls.Add(this.tip2);
            this.Controls.Add(this.tip1);
            this.Controls.Add(this.teachradio);
            this.Controls.Add(this.sturadio);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.pwdlb);
            this.Controls.Add(this.username);
            this.Controls.Add(this.userNamelb);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.loginbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginform";
            this.Text = "打分管理系统Beta v1.0";
            this.Load += new System.EventHandler(this.loginform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Label userNamelb;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label pwdlb;
        private System.Windows.Forms.RadioButton sturadio;
        private System.Windows.Forms.RadioButton teachradio;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label tip1;
        private System.Windows.Forms.Label tip2;
    }
}

