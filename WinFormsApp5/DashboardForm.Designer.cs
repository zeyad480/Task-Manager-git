namespace WinFormsApp5
{
    partial class DashboardForm
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
            panel2 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            lblNotifications = new Label();
            lblReports = new Label();
            label1 = new Label();
            lblKanbanboard = new Label();
            lblDashbord = new Label();
            lblproject = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            lblConnection = new Label();
            lblUsername = new Label();
            lblUserEmail = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 37, 64);
            panel2.Controls.Add(lblUserEmail);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(lblConnection);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lblNotifications);
            panel2.Controls.Add(lblReports);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblKanbanboard);
            panel2.Controls.Add(lblDashbord);
            panel2.Controls.Add(lblproject);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 634);
            panel2.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Lime;
            label9.Location = new Point(12, 206);
            label9.Name = "label9";
            label9.Size = new Size(15, 20);
            label9.TabIndex = 7;
            label9.Text = "•";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Lime;
            label8.Location = new Point(12, 169);
            label8.Name = "label8";
            label8.Size = new Size(15, 20);
            label8.TabIndex = 7;
            label8.Text = "•";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Lime;
            label7.Location = new Point(12, 135);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 7;
            label7.Text = "•";
            // 
            // lblNotifications
            // 
            lblNotifications.AutoSize = true;
            lblNotifications.ForeColor = SystemColors.ButtonHighlight;
            lblNotifications.Location = new Point(33, 206);
            lblNotifications.Name = "lblNotifications";
            lblNotifications.Size = new Size(94, 20);
            lblNotifications.TabIndex = 2;
            lblNotifications.Text = "Notifications";
            lblNotifications.Click += lblNotifications_Click;
            // 
            // lblReports
            // 
            lblReports.AutoSize = true;
            lblReports.ForeColor = SystemColors.ButtonHighlight;
            lblReports.Location = new Point(34, 169);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(60, 20);
            lblReports.TabIndex = 5;
            lblReports.Text = "Reports";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 6;
            label1.Text = "•";
            // 
            // lblKanbanboard
            // 
            lblKanbanboard.AutoSize = true;
            lblKanbanboard.ForeColor = SystemColors.ButtonHighlight;
            lblKanbanboard.Location = new Point(33, 135);
            lblKanbanboard.Name = "lblKanbanboard";
            lblKanbanboard.Size = new Size(103, 20);
            lblKanbanboard.TabIndex = 2;
            lblKanbanboard.Text = "Kanban board";
            lblKanbanboard.Click += label2_Click;
            // 
            // lblDashbord
            // 
            lblDashbord.AutoSize = true;
            lblDashbord.ForeColor = SystemColors.ButtonHighlight;
            lblDashbord.Location = new Point(34, 60);
            lblDashbord.Name = "lblDashbord";
            lblDashbord.Size = new Size(82, 20);
            lblDashbord.TabIndex = 1;
            lblDashbord.Text = "Dashboard";
            // 
            // lblproject
            // 
            lblproject.AutoSize = true;
            lblproject.ForeColor = SystemColors.ButtonHighlight;
            lblproject.Location = new Point(33, 97);
            lblproject.Name = "lblproject";
            lblproject.Size = new Size(61, 20);
            lblproject.TabIndex = 4;
            lblproject.Text = "Projects";
            lblproject.Click += lblproject_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 3;
            label3.Text = "•";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 2;
            label2.Text = "Task Manager";
            label2.Click += label2_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(220, 53, 69);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(133, 206);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 4;
            label4.Text = "3";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConnection
            // 
            lblConnection.AutoSize = true;
            lblConnection.ForeColor = SystemColors.ButtonHighlight;
            lblConnection.Location = new Point(12, 482);
            lblConnection.Name = "lblConnection";
            lblConnection.Size = new Size(196, 20);
            lblConnection.TabIndex = 8;
            lblConnection.Text = "● Connected · 127.0.0.1:5000";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = SystemColors.ButtonHighlight;
            lblUsername.Location = new Point(33, 519);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(52, 20);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Yousef";
            // 
            // lblUserEmail
            // 
            lblUserEmail.AutoSize = true;
            lblUserEmail.ForeColor = SystemColors.ButtonHighlight;
            lblUserEmail.Location = new Point(12, 558);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(209, 20);
            lblUserEmail.TabIndex = 10;
            lblUserEmail.Text = "Owner · yousef@example.com";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 587);
            panel1.TabIndex = 1;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(939, 587);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblDashbord;
        private Label lblKanbanboard;
        private Label label3;
        private Label lblproject;
        private Label lblReports;
        private Label label1;
        private Label lblNotifications;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label2;
        private Label label4;
        private Label lblUserEmail;
        private Label lblUsername;
        private Label lblConnection;
        private Panel panel1;
    }
}