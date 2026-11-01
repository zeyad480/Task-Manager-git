namespace WinFormsApp5
{
    partial class login
    {
        private System.ComponentModel.IContainer components = null;
        private Panel mainPanel;
        private Panel sidebarPanel;
        private Panel loginPanel;
        private Panel loginContentPanel;
        private Label projectLabel;
        private Label taskManagerLabel;
        private Label descriptionLabel;
        private Label featureBulletOne;
        private Label featureOneLabel;
        private Label featureBulletTwo;
        private Label featureTwoLabel;
        private Label featureBulletThree;
        private Label featureThreeLabel;
        private Label signInLabel;
        private Label subtitleLabel;
        private Label usernameLabel;
        private TextBox txtusername;
        private Label passwordLabel;
        private TextBox txtpassword;
        private CheckBox rememberCheckBox;
        private Button btnlogin;
        private Label serverIndicatorLabel;
        private Label serverStatusLabel;
        private LinkLabel createAccountLink;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            mainPanel = new Panel();
            sidebarPanel = new Panel();
            projectLabel = new Label();
            taskManagerLabel = new Label();
            descriptionLabel = new Label();
            featureBulletOne = new Label();
            featureOneLabel = new Label();
            featureBulletTwo = new Label();
            featureTwoLabel = new Label();
            featureBulletThree = new Label();
            featureThreeLabel = new Label();
            loginPanel = new Panel();
            loginContentPanel = new Panel();
            signInLabel = new Label();
            subtitleLabel = new Label();
            usernameLabel = new Label();
            txtusername = new TextBox();
            passwordLabel = new Label();
            txtpassword = new TextBox();
            rememberCheckBox = new CheckBox();
            btnlogin = new Button();
            serverIndicatorLabel = new Label();
            serverStatusLabel = new Label();
            createAccountLink = new LinkLabel();
            mainPanel.SuspendLayout();
            sidebarPanel.SuspendLayout();
            loginPanel.SuspendLayout();
            loginContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(sidebarPanel);
            mainPanel.Controls.Add(loginPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(17, 20);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1060, 743);
            mainPanel.TabIndex = 0;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(27, 37, 64);
            sidebarPanel.Controls.Add(projectLabel);
            sidebarPanel.Controls.Add(taskManagerLabel);
            sidebarPanel.Controls.Add(descriptionLabel);
            sidebarPanel.Controls.Add(featureBulletOne);
            sidebarPanel.Controls.Add(featureOneLabel);
            sidebarPanel.Controls.Add(featureBulletTwo);
            sidebarPanel.Controls.Add(featureTwoLabel);
            sidebarPanel.Controls.Add(featureBulletThree);
            sidebarPanel.Controls.Add(featureThreeLabel);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(3, 5, 3, 5);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(445, 743);
            sidebarPanel.TabIndex = 0;
            sidebarPanel.Paint += sidebarPanel_Paint;
            // 
            // projectLabel
            // 
            projectLabel.AutoSize = true;
            projectLabel.BackColor = Color.Transparent;
            projectLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            projectLabel.ForeColor = Color.FromArgb(157, 183, 255);
            projectLabel.Location = new Point(47, 69);
            projectLabel.Name = "projectLabel";
            projectLabel.Size = new Size(178, 20);
            projectLabel.TabIndex = 0;
            projectLabel.Text = "CS 312 · TEAM PROJECT";
            // 
            // taskManagerLabel
            // 
            taskManagerLabel.AutoSize = true;
            taskManagerLabel.BackColor = Color.Transparent;
            taskManagerLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            taskManagerLabel.ForeColor = Color.White;
            taskManagerLabel.Location = new Point(47, 111);
            taskManagerLabel.Name = "taskManagerLabel";
            taskManagerLabel.Size = new Size(313, 60);
            taskManagerLabel.TabIndex = 1;
            taskManagerLabel.Text = "Task Manager";
            // 
            // descriptionLabel
            // 
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.Font = new Font("Segoe UI", 11F);
            descriptionLabel.ForeColor = Color.FromArgb(196, 204, 221);
            descriptionLabel.Location = new Point(47, 183);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(354, 91);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Plan tasks with priorities and deadlines,\r\nassign them to teammates, and get\r\nnotified the moment something changes.";
            // 
            // featureBulletOne
            // 
            featureBulletOne.AutoSize = true;
            featureBulletOne.Font = new Font("Segoe UI", 9.75F);
            featureBulletOne.ForeColor = Color.FromArgb(61, 214, 140);
            featureBulletOne.Location = new Point(47, 593);
            featureBulletOne.Name = "featureBulletOne";
            featureBulletOne.Size = new Size(20, 23);
            featureBulletOne.TabIndex = 3;
            featureBulletOne.Text = "●";
            // 
            // featureOneLabel
            // 
            featureOneLabel.AutoSize = true;
            featureOneLabel.Font = new Font("Segoe UI", 9.75F);
            featureOneLabel.ForeColor = Color.FromArgb(196, 204, 221);
            featureOneLabel.Location = new Point(66, 593);
            featureOneLabel.Name = "featureOneLabel";
            featureOneLabel.Size = new Size(221, 23);
            featureOneLabel.TabIndex = 4;
            featureOneLabel.Text = "Real-time updates over TCP";
            // 
            // featureBulletTwo
            // 
            featureBulletTwo.AutoSize = true;
            featureBulletTwo.Font = new Font("Segoe UI", 9.75F);
            featureBulletTwo.ForeColor = Color.FromArgb(61, 214, 140);
            featureBulletTwo.Location = new Point(47, 627);
            featureBulletTwo.Name = "featureBulletTwo";
            featureBulletTwo.Size = new Size(20, 23);
            featureBulletTwo.TabIndex = 5;
            featureBulletTwo.Text = "●";
            // 
            // featureTwoLabel
            // 
            featureTwoLabel.AutoSize = true;
            featureTwoLabel.Font = new Font("Segoe UI", 9.75F);
            featureTwoLabel.ForeColor = Color.FromArgb(196, 204, 221);
            featureTwoLabel.Location = new Point(66, 627);
            featureTwoLabel.Name = "featureTwoLabel";
            featureTwoLabel.Size = new Size(152, 23);
            featureTwoLabel.TabIndex = 6;
            featureTwoLabel.Text = "Charts and reports";
            // 
            // featureBulletThree
            // 
            featureBulletThree.AutoSize = true;
            featureBulletThree.Font = new Font("Segoe UI", 9.75F);
            featureBulletThree.ForeColor = Color.FromArgb(61, 214, 140);
            featureBulletThree.Location = new Point(47, 660);
            featureBulletThree.Name = "featureBulletThree";
            featureBulletThree.Size = new Size(20, 23);
            featureBulletThree.TabIndex = 7;
            featureBulletThree.Text = "●";
            // 
            // featureThreeLabel
            // 
            featureThreeLabel.AutoSize = true;
            featureThreeLabel.Font = new Font("Segoe UI", 9.75F);
            featureThreeLabel.ForeColor = Color.FromArgb(196, 204, 221);
            featureThreeLabel.Location = new Point(66, 660);
            featureThreeLabel.Name = "featureThreeLabel";
            featureThreeLabel.Size = new Size(172, 23);
            featureThreeLabel.TabIndex = 8;
            featureThreeLabel.Text = "Shared team projects";
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.White;
            loginPanel.Controls.Add(loginContentPanel);
            loginPanel.Dock = DockStyle.Fill;
            loginPanel.Location = new Point(0, 0);
            loginPanel.Margin = new Padding(3, 5, 3, 5);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(1060, 743);
            loginPanel.TabIndex = 1;
            // 
            // loginContentPanel
            // 
            loginContentPanel.BackColor = Color.White;
            loginContentPanel.Controls.Add(signInLabel);
            loginContentPanel.Controls.Add(subtitleLabel);
            loginContentPanel.Controls.Add(usernameLabel);
            loginContentPanel.Controls.Add(txtusername);
            loginContentPanel.Controls.Add(passwordLabel);
            loginContentPanel.Controls.Add(txtpassword);
            loginContentPanel.Controls.Add(rememberCheckBox);
            loginContentPanel.Controls.Add(btnlogin);
            loginContentPanel.Controls.Add(serverIndicatorLabel);
            loginContentPanel.Controls.Add(serverStatusLabel);
            loginContentPanel.Controls.Add(createAccountLink);
            loginContentPanel.Location = new Point(475, 57);
            loginContentPanel.Margin = new Padding(3, 5, 3, 5);
            loginContentPanel.Name = "loginContentPanel";
            loginContentPanel.Size = new Size(520, 426);
            loginContentPanel.TabIndex = 0;
            // 
            // signInLabel
            // 
            signInLabel.AutoSize = true;
            signInLabel.Font = new Font("Segoe UI", 19.5F, FontStyle.Bold);
            signInLabel.ForeColor = Color.FromArgb(31, 41, 55);
            signInLabel.Location = new Point(0, 0);
            signInLabel.Name = "signInLabel";
            signInLabel.Size = new Size(126, 45);
            signInLabel.TabIndex = 0;
            signInLabel.Text = "Sign in";
            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Segoe UI", 10.5F);
            subtitleLabel.ForeColor = Color.FromArgb(100, 112, 138);
            subtitleLabel.Location = new Point(0, 43);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(233, 25);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "Use your username or email";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            usernameLabel.ForeColor = Color.FromArgb(100, 112, 138);
            usernameLabel.Location = new Point(0, 83);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(141, 20);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username or email";
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.White;
            txtusername.BorderStyle = BorderStyle.FixedSingle;
            txtusername.Font = new Font("Segoe UI", 10.5F);
            txtusername.ForeColor = Color.FromArgb(31, 41, 55);
            txtusername.Location = new Point(0, 107);
            txtusername.Margin = new Padding(0);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(480, 31);
            txtusername.TabIndex = 3;
            txtusername.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            passwordLabel.ForeColor = Color.FromArgb(100, 112, 138);
            passwordLabel.Location = new Point(0, 183);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(76, 20);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.White;
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Font = new Font("Segoe UI", 10.5F);
            txtpassword.ForeColor = Color.FromArgb(31, 41, 55);
            txtpassword.Location = new Point(0, 207);
            txtpassword.Margin = new Padding(0);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(480, 31);
            txtpassword.TabIndex = 5;
            txtpassword.UseSystemPasswordChar = true;
            txtpassword.TextChanged += passwordTextBox_TextChanged;
            // 
            // rememberCheckBox
            // 
            rememberCheckBox.AutoSize = true;
            rememberCheckBox.BackColor = Color.White;
            rememberCheckBox.Checked = true;
            rememberCheckBox.CheckState = CheckState.Checked;
            rememberCheckBox.Cursor = Cursors.Hand;
            rememberCheckBox.Font = new Font("Segoe UI", 9F);
            rememberCheckBox.ForeColor = Color.FromArgb(100, 112, 138);
            rememberCheckBox.Location = new Point(0, 281);
            rememberCheckBox.Margin = new Padding(3, 5, 3, 5);
            rememberCheckBox.Name = "rememberCheckBox";
            rememberCheckBox.Size = new Size(129, 24);
            rememberCheckBox.TabIndex = 6;
            rememberCheckBox.Text = "Remember me";
            rememberCheckBox.UseVisualStyleBackColor = false;
            rememberCheckBox.CheckedChanged += rememberCheckBox_CheckedChanged;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(47, 111, 237);
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(0, 323);
            btnlogin.Margin = new Padding(3, 5, 3, 5);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(480, 55);
            btnlogin.TabIndex = 7;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += LoginButton_Click;
            // 
            // serverIndicatorLabel
            // 
            serverIndicatorLabel.AutoSize = true;
            serverIndicatorLabel.Font = new Font("Segoe UI", 9F);
            serverIndicatorLabel.ForeColor = Color.FromArgb(61, 214, 140);
            serverIndicatorLabel.Location = new Point(0, 387);
            serverIndicatorLabel.Name = "serverIndicatorLabel";
            serverIndicatorLabel.Size = new Size(18, 20);
            serverIndicatorLabel.TabIndex = 8;
            serverIndicatorLabel.Text = "●";
            // 
            // serverStatusLabel
            // 
            serverStatusLabel.AutoSize = true;
            serverStatusLabel.Font = new Font("Segoe UI", 9F);
            serverStatusLabel.ForeColor = Color.FromArgb(100, 112, 138);
            serverStatusLabel.Location = new Point(19, 387);
            serverStatusLabel.Name = "serverStatusLabel";
            serverStatusLabel.Size = new Size(119, 20);
            serverStatusLabel.TabIndex = 9;
            serverStatusLabel.Text = "Server reachable";
            // 
            // createAccountLink
            // 
            createAccountLink.ActiveLinkColor = Color.FromArgb(33, 82, 183);
            createAccountLink.AutoSize = true;
            createAccountLink.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            createAccountLink.LinkBehavior = LinkBehavior.HoverUnderline;
            createAccountLink.LinkColor = Color.FromArgb(47, 111, 237);
            createAccountLink.Location = new Point(374, 387);
            createAccountLink.Name = "createAccountLink";
            createAccountLink.Size = new Size(113, 20);
            createAccountLink.TabIndex = 10;
            createAccountLink.TabStop = true;
            createAccountLink.Text = "Create account";
            createAccountLink.LinkClicked += CreateAccountLink_LinkClicked;
            // 
            // Form1
            // 
            AcceptButton = btnlogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(1094, 783);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 5, 3, 5);
            MinimumSize = new Size(866, 651);
            Name = "Form1";
            Padding = new Padding(17, 20, 17, 20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Manager";
            mainPanel.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            loginPanel.ResumeLayout(false);
            loginContentPanel.ResumeLayout(false);
            loginContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}