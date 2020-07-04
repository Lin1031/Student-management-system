namespace Demo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PowerComboBox = new System.Windows.Forms.ComboBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.CancalButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.UserNameLabel.Location = new System.Drawing.Point(233, 81);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(61, 23);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "用户：";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.PasswordLabel.Location = new System.Drawing.Point(233, 139);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 23);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "密码：";
            // 
            // PowerLabel
            // 
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.PowerLabel.Location = new System.Drawing.Point(233, 197);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(61, 23);
            this.PowerLabel.TabIndex = 4;
            this.PowerLabel.Text = "权限：";
            this.PowerLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(301, 140);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(200, 25);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(301, 82);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(200, 25);
            this.UserNameTextBox.TabIndex = 7;
            // 
            // PowerComboBox
            // 
            this.PowerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PowerComboBox.FormattingEnabled = true;
            this.PowerComboBox.Items.AddRange(new object[] {
            "学生",
            "老师",
            "管理员"});
            this.PowerComboBox.Location = new System.Drawing.Point(301, 196);
            this.PowerComboBox.Name = "PowerComboBox";
            this.PowerComboBox.Size = new System.Drawing.Size(200, 23);
            this.PowerComboBox.TabIndex = 8;
            this.PowerComboBox.SelectedIndexChanged += new System.EventHandler(this.PowerComboBox_SelectedIndexChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.LoginButton.Location = new System.Drawing.Point(301, 251);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 30);
            this.LoginButton.TabIndex = 9;
            this.LoginButton.Text = "登录";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancalButton
            // 
            this.CancalButton.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.CancalButton.Location = new System.Drawing.Point(430, 251);
            this.CancalButton.Name = "CancalButton";
            this.CancalButton.Size = new System.Drawing.Size(75, 30);
            this.CancalButton.TabIndex = 10;
            this.CancalButton.Text = "取消";
            this.CancalButton.UseVisualStyleBackColor = true;
            this.CancalButton.Click += new System.EventHandler(this.CancalButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Photo
            // 
            this.Photo.Image = ((System.Drawing.Image)(resources.GetObject("Photo.Image")));
            this.Photo.Location = new System.Drawing.Point(50, 50);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(150, 200);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 1;
            this.Photo.TabStop = false;
            this.Photo.Click += new System.EventHandler(this.Photo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 353);
            this.Controls.Add(this.CancalButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PowerComboBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PowerLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.Photo);
            this.Name = "Form1";
            this.Text = "登陆";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.ComboBox PowerComboBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button CancalButton;
        private System.Windows.Forms.Timer timer1;
    }
}

