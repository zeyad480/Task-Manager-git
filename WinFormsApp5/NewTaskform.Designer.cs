namespace WinFormsApp7
{
    partial class NewTaskform
    {
        private System.ComponentModel.IContainer components = null;
        private Panel page;
        private Label sectionTitle;
        private Panel card;
        private Panel header;
        private Label headerTitle;
        private Panel body;
        private Label titleLabel;
        private Panel titleBorder;
        private Panel titleSurfacePanel;
        private TextBox titleInput;
        private Label descriptionLabel;
        private Panel descriptionBorder;
        private Panel descriptionSurfacePanel;
        private TextBox descriptionInput;
        private Label projectLabel;
        private Panel projectBorder;
        private Panel projectSurfacePanel;
        private ComboBox projectInput;
        private Label assigneeLabel;
        private Panel assigneeBorder;
        private Panel assigneeSurfacePanel;
        private ComboBox assigneeInput;
        private Label priorityLabel;
        private Panel priorityPanel;
        private Button priorityLowButton;
        private Button priorityMediumButton;
        private Button priorityHighButton;
        private Button priorityUrgentButton;
        private Label statusLabel;
        private Panel statusBorder;
        private Panel statusSurfacePanel;
        private ComboBox statusInput;
        private Label deadlineLabel;
        private Panel deadlineBorder;
        private Panel deadlineSurfacePanel;
        private DateTimePicker deadlineInput;
        private Label deadlineError;
        private Panel notificationPanel;
        private Panel notificationSurfacePanel;
        private Label notificationText;
        private ErrorProvider titleErrorProvider;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            page = new Panel();
            sectionTitle = new Label();
            card = new Panel();
            body = new Panel();
            titleLabel = new Label();
            titleBorder = new Panel();
            titleSurfacePanel = new Panel();
            titleInput = new TextBox();
            descriptionLabel = new Label();
            descriptionBorder = new Panel();
            descriptionSurfacePanel = new Panel();
            descriptionInput = new TextBox();
            projectLabel = new Label();
            projectBorder = new Panel();
            projectSurfacePanel = new Panel();
            projectInput = new ComboBox();
            assigneeLabel = new Label();
            assigneeBorder = new Panel();
            assigneeSurfacePanel = new Panel();
            assigneeInput = new ComboBox();
            priorityLabel = new Label();
            priorityPanel = new Panel();
            priorityLowButton = new Button();
            priorityMediumButton = new Button();
            priorityHighButton = new Button();
            priorityUrgentButton = new Button();
            statusLabel = new Label();
            statusBorder = new Panel();
            statusSurfacePanel = new Panel();
            statusInput = new ComboBox();
            deadlineLabel = new Label();
            deadlineBorder = new Panel();
            deadlineSurfacePanel = new Panel();
            deadlineInput = new DateTimePicker();
            deadlineError = new Label();
            notificationPanel = new Panel();
            notificationSurfacePanel = new Panel();
            notificationText = new Label();
            header = new Panel();
            headerTitle = new Label();
            titleErrorProvider = new ErrorProvider(components);
            page.SuspendLayout();
            card.SuspendLayout();
            body.SuspendLayout();
            titleBorder.SuspendLayout();
            titleSurfacePanel.SuspendLayout();
            descriptionBorder.SuspendLayout();
            descriptionSurfacePanel.SuspendLayout();
            projectBorder.SuspendLayout();
            projectSurfacePanel.SuspendLayout();
            assigneeBorder.SuspendLayout();
            assigneeSurfacePanel.SuspendLayout();
            priorityPanel.SuspendLayout();
            statusBorder.SuspendLayout();
            statusSurfacePanel.SuspendLayout();
            deadlineBorder.SuspendLayout();
            deadlineSurfacePanel.SuspendLayout();
            notificationPanel.SuspendLayout();
            notificationSurfacePanel.SuspendLayout();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)titleErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // page
            // 
            page.AutoScroll = true;
            page.BackColor = Color.FromArgb(229, 229, 229);
            page.Controls.Add(sectionTitle);
            page.Controls.Add(card);
            page.Dock = DockStyle.Fill;
            page.Location = new Point(0, 0);
            page.Margin = new Padding(3, 4, 3, 4);
            page.Name = "page";
            page.Size = new Size(1120, 1055);
            page.TabIndex = 0;
            page.Paint += page_Paint;
            // 
            // sectionTitle
            // 
            sectionTitle.AutoSize = true;
            sectionTitle.Font = new Font("Segoe UI", 9F);
            sectionTitle.ForeColor = Color.FromArgb(105, 105, 105);
            sectionTitle.Location = new Point(192, 35);
            sectionTitle.Name = "sectionTitle";
            sectionTitle.Size = new Size(126, 20);
            sectionTitle.TabIndex = 0;
            sectionTitle.Text = "3 · Add / Edit task";
            // 
            // card
            // 
            card.BackColor = Color.FromArgb(245, 246, 250);
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Controls.Add(body);
            card.Controls.Add(header);
            card.Location = new Point(192, 69);
            card.Margin = new Padding(3, 4, 3, 4);
            card.Name = "card";
            card.Size = new Size(736, 818);
            card.TabIndex = 1;
            // 
            // body
            // 
            body.BackColor = Color.FromArgb(245, 246, 250);
            body.Controls.Add(titleLabel);
            body.Controls.Add(titleBorder);
            body.Controls.Add(descriptionLabel);
            body.Controls.Add(descriptionBorder);
            body.Controls.Add(projectLabel);
            body.Controls.Add(projectBorder);
            body.Controls.Add(assigneeLabel);
            body.Controls.Add(assigneeBorder);
            body.Controls.Add(priorityLabel);
            body.Controls.Add(priorityPanel);
            body.Controls.Add(statusLabel);
            body.Controls.Add(statusBorder);
            body.Controls.Add(deadlineLabel);
            body.Controls.Add(deadlineBorder);
            body.Controls.Add(deadlineError);
            body.Controls.Add(notificationPanel);
            body.Location = new Point(0, 73);
            body.Margin = new Padding(3, 4, 3, 4);
            body.Name = "body";
            body.Size = new Size(734, 744);
            body.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(74, 88, 118);
            titleLabel.Location = new Point(34, 24);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(51, 20);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title *";
            // 
            // titleBorder
            // 
            titleBorder.BackColor = Color.FromArgb(205, 214, 230);
            titleBorder.Controls.Add(titleSurfacePanel);
            titleBorder.Location = new Point(34, 56);
            titleBorder.Margin = new Padding(3, 4, 3, 4);
            titleBorder.Name = "titleBorder";
            titleBorder.Size = new Size(665, 59);
            titleBorder.TabIndex = 1;
            // 
            // titleSurfacePanel
            // 
            titleSurfacePanel.BackColor = Color.White;
            titleSurfacePanel.Controls.Add(titleInput);
            titleSurfacePanel.Location = new Point(1, 1);
            titleSurfacePanel.Margin = new Padding(3, 4, 3, 4);
            titleSurfacePanel.Name = "titleSurfacePanel";
            titleSurfacePanel.Size = new Size(663, 56);
            titleSurfacePanel.TabIndex = 0;
            titleSurfacePanel.Paint += titleSurfacePanel_Paint;
            // 
            // titleInput
            // 
            titleInput.BorderStyle = BorderStyle.None;
            titleInput.Font = new Font("Segoe UI", 10F);
            titleInput.Location = new Point(13, 13);
            titleInput.Margin = new Padding(3, 4, 3, 4);
            titleInput.Name = "titleInput";
            titleInput.Size = new Size(638, 23);
            titleInput.TabIndex = 0;
            titleInput.Text = "Create SQL script";
            titleInput.TextChanged += titleInput_TextChanged;
            titleInput.Validating += titleInput_Validating;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            descriptionLabel.ForeColor = Color.FromArgb(74, 88, 118);
            descriptionLabel.Location = new Point(34, 131);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(89, 20);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description";
            // 
            // descriptionBorder
            // 
            descriptionBorder.BackColor = Color.FromArgb(205, 214, 230);
            descriptionBorder.Controls.Add(descriptionSurfacePanel);
            descriptionBorder.Location = new Point(34, 163);
            descriptionBorder.Margin = new Padding(3, 4, 3, 4);
            descriptionBorder.Name = "descriptionBorder";
            descriptionBorder.Size = new Size(665, 111);
            descriptionBorder.TabIndex = 3;
            // 
            // descriptionSurfacePanel
            // 
            descriptionSurfacePanel.BackColor = Color.White;
            descriptionSurfacePanel.Controls.Add(descriptionInput);
            descriptionSurfacePanel.Location = new Point(1, 1);
            descriptionSurfacePanel.Margin = new Padding(3, 4, 3, 4);
            descriptionSurfacePanel.Name = "descriptionSurfacePanel";
            descriptionSurfacePanel.Size = new Size(663, 108);
            descriptionSurfacePanel.TabIndex = 0;
            // 
            // descriptionInput
            // 
            descriptionInput.BorderStyle = BorderStyle.None;
            descriptionInput.Font = new Font("Segoe UI", 10F);
            descriptionInput.Location = new Point(13, 11);
            descriptionInput.Margin = new Padding(3, 4, 3, 4);
            descriptionInput.Multiline = true;
            descriptionInput.Name = "descriptionInput";
            descriptionInput.Size = new Size(638, 87);
            descriptionInput.TabIndex = 0;
            descriptionInput.Text = "Tables: Users, Projects, ProjectMembers, Tasks, Notifications";
            // 
            // projectLabel
            // 
            projectLabel.AutoSize = true;
            projectLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            projectLabel.ForeColor = Color.FromArgb(74, 88, 118);
            projectLabel.Location = new Point(34, 288);
            projectLabel.Name = "projectLabel";
            projectLabel.Size = new Size(69, 20);
            projectLabel.TabIndex = 4;
            projectLabel.Text = "Project *";
            // 
            // projectBorder
            // 
            projectBorder.BackColor = Color.FromArgb(205, 214, 230);
            projectBorder.Controls.Add(projectSurfacePanel);
            projectBorder.Location = new Point(34, 320);
            projectBorder.Margin = new Padding(3, 4, 3, 4);
            projectBorder.Name = "projectBorder";
            projectBorder.Size = new Size(323, 59);
            projectBorder.TabIndex = 5;
            // 
            // projectSurfacePanel
            // 
            projectSurfacePanel.BackColor = Color.White;
            projectSurfacePanel.Controls.Add(projectInput);
            projectSurfacePanel.Location = new Point(1, 1);
            projectSurfacePanel.Margin = new Padding(3, 4, 3, 4);
            projectSurfacePanel.Name = "projectSurfacePanel";
            projectSurfacePanel.Size = new Size(321, 56);
            projectSurfacePanel.TabIndex = 0;
            // 
            // projectInput
            // 
            projectInput.DropDownStyle = ComboBoxStyle.DropDownList;
            projectInput.FlatStyle = FlatStyle.Flat;
            projectInput.Font = new Font("Segoe UI", 10F);
            projectInput.FormattingEnabled = true;
            projectInput.Items.AddRange(new object[] { "CS312 Project", "Mobile App", "Website Redesign" });
            projectInput.Location = new Point(8, 8);
            projectInput.Margin = new Padding(3, 4, 3, 4);
            projectInput.Name = "projectInput";
            projectInput.Size = new Size(305, 31);
            projectInput.TabIndex = 0;
            // 
            // assigneeLabel
            // 
            assigneeLabel.AutoSize = true;
            assigneeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            assigneeLabel.ForeColor = Color.FromArgb(74, 88, 118);
            assigneeLabel.Location = new Point(376, 288);
            assigneeLabel.Name = "assigneeLabel";
            assigneeLabel.Size = new Size(86, 20);
            assigneeLabel.TabIndex = 6;
            assigneeLabel.Text = "Assign to *";
            // 
            // assigneeBorder
            // 
            assigneeBorder.BackColor = Color.FromArgb(205, 214, 230);
            assigneeBorder.Controls.Add(assigneeSurfacePanel);
            assigneeBorder.Location = new Point(376, 320);
            assigneeBorder.Margin = new Padding(3, 4, 3, 4);
            assigneeBorder.Name = "assigneeBorder";
            assigneeBorder.Size = new Size(323, 59);
            assigneeBorder.TabIndex = 7;
            // 
            // assigneeSurfacePanel
            // 
            assigneeSurfacePanel.BackColor = Color.White;
            assigneeSurfacePanel.Controls.Add(assigneeInput);
            assigneeSurfacePanel.Location = new Point(1, 1);
            assigneeSurfacePanel.Margin = new Padding(3, 4, 3, 4);
            assigneeSurfacePanel.Name = "assigneeSurfacePanel";
            assigneeSurfacePanel.Size = new Size(321, 56);
            assigneeSurfacePanel.TabIndex = 0;
            // 
            // assigneeInput
            // 
            assigneeInput.DropDownStyle = ComboBoxStyle.DropDownList;
            assigneeInput.FlatStyle = FlatStyle.Flat;
            assigneeInput.Font = new Font("Segoe UI", 10F);
            assigneeInput.FormattingEnabled = true;
            assigneeInput.Items.AddRange(new object[] { "Ahmed", "Sarah", "Michael", "Unassigned" });
            assigneeInput.Location = new Point(8, 8);
            assigneeInput.Margin = new Padding(3, 4, 3, 4);
            assigneeInput.Name = "assigneeInput";
            assigneeInput.Size = new Size(305, 31);
            assigneeInput.TabIndex = 0;
            assigneeInput.SelectedIndexChanged += assigneeInput_SelectedIndexChanged;
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            priorityLabel.ForeColor = Color.FromArgb(74, 88, 118);
            priorityLabel.Location = new Point(34, 397);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(72, 20);
            priorityLabel.TabIndex = 8;
            priorityLabel.Text = "Priority *";
            // 
            // priorityPanel
            // 
            priorityPanel.BackColor = Color.FromArgb(205, 214, 230);
            priorityPanel.Controls.Add(priorityLowButton);
            priorityPanel.Controls.Add(priorityMediumButton);
            priorityPanel.Controls.Add(priorityHighButton);
            priorityPanel.Controls.Add(priorityUrgentButton);
            priorityPanel.Location = new Point(34, 429);
            priorityPanel.Margin = new Padding(3, 4, 3, 4);
            priorityPanel.Name = "priorityPanel";
            priorityPanel.Size = new Size(665, 56);
            priorityPanel.TabIndex = 9;
            // 
            // priorityLowButton
            // 
            priorityLowButton.BackColor = Color.White;
            priorityLowButton.FlatAppearance.BorderColor = Color.FromArgb(205, 214, 230);
            priorityLowButton.FlatStyle = FlatStyle.Flat;
            priorityLowButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            priorityLowButton.ForeColor = Color.FromArgb(28, 39, 69);
            priorityLowButton.Location = new Point(0, 0);
            priorityLowButton.Margin = new Padding(3, 4, 3, 4);
            priorityLowButton.Name = "priorityLowButton";
            priorityLowButton.Size = new Size(167, 56);
            priorityLowButton.TabIndex = 0;
            priorityLowButton.Tag = "Low";
            priorityLowButton.Text = "Low";
            priorityLowButton.UseVisualStyleBackColor = false;
            priorityLowButton.Click += PriorityButton_Click;
            // 
            // priorityMediumButton
            // 
            priorityMediumButton.BackColor = Color.White;
            priorityMediumButton.FlatAppearance.BorderColor = Color.FromArgb(205, 214, 230);
            priorityMediumButton.FlatStyle = FlatStyle.Flat;
            priorityMediumButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            priorityMediumButton.ForeColor = Color.FromArgb(28, 39, 69);
            priorityMediumButton.Location = new Point(167, 0);
            priorityMediumButton.Margin = new Padding(3, 4, 3, 4);
            priorityMediumButton.Name = "priorityMediumButton";
            priorityMediumButton.Size = new Size(167, 56);
            priorityMediumButton.TabIndex = 1;
            priorityMediumButton.Tag = "Medium";
            priorityMediumButton.Text = "Medium";
            priorityMediumButton.UseVisualStyleBackColor = false;
            priorityMediumButton.Click += PriorityButton_Click;
            // 
            // priorityHighButton
            // 
            priorityHighButton.BackColor = Color.White;
            priorityHighButton.FlatAppearance.BorderColor = Color.FromArgb(205, 214, 230);
            priorityHighButton.FlatStyle = FlatStyle.Flat;
            priorityHighButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            priorityHighButton.ForeColor = Color.FromArgb(28, 39, 69);
            priorityHighButton.Location = new Point(334, 0);
            priorityHighButton.Margin = new Padding(3, 4, 3, 4);
            priorityHighButton.Name = "priorityHighButton";
            priorityHighButton.Size = new Size(166, 56);
            priorityHighButton.TabIndex = 2;
            priorityHighButton.Tag = "High";
            priorityHighButton.Text = "High";
            priorityHighButton.UseVisualStyleBackColor = false;
            priorityHighButton.Click += PriorityButton_Click;
            // 
            // priorityUrgentButton
            // 
            priorityUrgentButton.BackColor = Color.FromArgb(252, 229, 229);
            priorityUrgentButton.FlatAppearance.BorderColor = Color.FromArgb(180, 35, 35);
            priorityUrgentButton.FlatStyle = FlatStyle.Flat;
            priorityUrgentButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            priorityUrgentButton.ForeColor = Color.FromArgb(180, 35, 35);
            priorityUrgentButton.Location = new Point(499, 0);
            priorityUrgentButton.Margin = new Padding(3, 4, 3, 4);
            priorityUrgentButton.Name = "priorityUrgentButton";
            priorityUrgentButton.Size = new Size(166, 56);
            priorityUrgentButton.TabIndex = 3;
            priorityUrgentButton.Tag = "Urgent";
            priorityUrgentButton.Text = "Urgent";
            priorityUrgentButton.UseVisualStyleBackColor = false;
            priorityUrgentButton.Click += PriorityButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            statusLabel.ForeColor = Color.FromArgb(74, 88, 118);
            statusLabel.Location = new Point(34, 511);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(53, 20);
            statusLabel.TabIndex = 10;
            statusLabel.Text = "Status";
            // 
            // statusBorder
            // 
            statusBorder.BackColor = Color.FromArgb(205, 214, 230);
            statusBorder.Controls.Add(statusSurfacePanel);
            statusBorder.Location = new Point(34, 543);
            statusBorder.Margin = new Padding(3, 4, 3, 4);
            statusBorder.Name = "statusBorder";
            statusBorder.Size = new Size(323, 59);
            statusBorder.TabIndex = 11;
            // 
            // statusSurfacePanel
            // 
            statusSurfacePanel.BackColor = Color.White;
            statusSurfacePanel.Controls.Add(statusInput);
            statusSurfacePanel.Location = new Point(1, 1);
            statusSurfacePanel.Margin = new Padding(3, 4, 3, 4);
            statusSurfacePanel.Name = "statusSurfacePanel";
            statusSurfacePanel.Size = new Size(321, 56);
            statusSurfacePanel.TabIndex = 0;
            // 
            // statusInput
            // 
            statusInput.DropDownStyle = ComboBoxStyle.DropDownList;
            statusInput.FlatStyle = FlatStyle.Flat;
            statusInput.Font = new Font("Segoe UI", 10F);
            statusInput.FormattingEnabled = true;
            statusInput.Items.AddRange(new object[] { "In progress", "Not started", "Completed", "On hold" });
            statusInput.Location = new Point(8, 8);
            statusInput.Margin = new Padding(3, 4, 3, 4);
            statusInput.Name = "statusInput";
            statusInput.Size = new Size(305, 31);
            statusInput.TabIndex = 0;
            // 
            // deadlineLabel
            // 
            deadlineLabel.AutoSize = true;
            deadlineLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deadlineLabel.ForeColor = Color.FromArgb(74, 88, 118);
            deadlineLabel.Location = new Point(376, 511);
            deadlineLabel.Name = "deadlineLabel";
            deadlineLabel.Size = new Size(81, 20);
            deadlineLabel.TabIndex = 12;
            deadlineLabel.Text = "Deadline *";
            // 
            // deadlineBorder
            // 
            deadlineBorder.BackColor = Color.FromArgb(180, 35, 35);
            deadlineBorder.Controls.Add(deadlineSurfacePanel);
            deadlineBorder.Location = new Point(376, 543);
            deadlineBorder.Margin = new Padding(3, 4, 3, 4);
            deadlineBorder.Name = "deadlineBorder";
            deadlineBorder.Size = new Size(323, 59);
            deadlineBorder.TabIndex = 13;
            // 
            // deadlineSurfacePanel
            // 
            deadlineSurfacePanel.BackColor = Color.FromArgb(255, 247, 247);
            deadlineSurfacePanel.Controls.Add(deadlineInput);
            deadlineSurfacePanel.Location = new Point(1, 1);
            deadlineSurfacePanel.Margin = new Padding(3, 4, 3, 4);
            deadlineSurfacePanel.Name = "deadlineSurfacePanel";
            deadlineSurfacePanel.Size = new Size(321, 56);
            deadlineSurfacePanel.TabIndex = 0;
            // 
            // deadlineInput
            // 
            deadlineInput.CalendarTitleBackColor = Color.FromArgb(28, 39, 69);
            deadlineInput.CustomFormat = "MMM dd, yyyy";
            deadlineInput.Font = new Font("Segoe UI", 10F);
            deadlineInput.Format = DateTimePickerFormat.Custom;
            deadlineInput.Location = new Point(8, 8);
            deadlineInput.Margin = new Padding(3, 4, 3, 4);
            deadlineInput.Name = "deadlineInput";
            deadlineInput.Size = new Size(305, 30);
            deadlineInput.TabIndex = 0;
            deadlineInput.Value = new DateTime(2026, 10, 29, 0, 0, 0, 0);
            deadlineInput.ValueChanged += deadlineInput_ValueChanged;
            // 
            // deadlineError
            // 
            deadlineError.AutoSize = true;
            deadlineError.Font = new Font("Segoe UI", 8.5F);
            deadlineError.ForeColor = Color.FromArgb(180, 35, 35);
            deadlineError.Location = new Point(376, 604);
            deadlineError.Name = "deadlineError";
            deadlineError.Size = new Size(212, 20);
            deadlineError.TabIndex = 14;
            deadlineError.Text = "Deadline cannot be in the past";
            // 
            // notificationPanel
            // 
            notificationPanel.BackColor = Color.FromArgb(199, 216, 255);
            notificationPanel.Controls.Add(notificationSurfacePanel);
            notificationPanel.Location = new Point(34, 640);
            notificationPanel.Margin = new Padding(3, 4, 3, 4);
            notificationPanel.Name = "notificationPanel";
            notificationPanel.Size = new Size(665, 59);
            notificationPanel.TabIndex = 15;
            // 
            // notificationSurfacePanel
            // 
            notificationSurfacePanel.BackColor = Color.FromArgb(234, 241, 255);
            notificationSurfacePanel.Controls.Add(notificationText);
            notificationSurfacePanel.Location = new Point(1, 1);
            notificationSurfacePanel.Margin = new Padding(3, 4, 3, 4);
            notificationSurfacePanel.Name = "notificationSurfacePanel";
            notificationSurfacePanel.Size = new Size(663, 56);
            notificationSurfacePanel.TabIndex = 0;
            // 
            // notificationText
            // 
            notificationText.AutoSize = true;
            notificationText.Font = new Font("Segoe UI", 9F);
            notificationText.ForeColor = Color.FromArgb(54, 90, 156);
            notificationText.Location = new Point(14, 16);
            notificationText.Name = "notificationText";
            notificationText.Size = new Size(361, 20);
            notificationText.TabIndex = 0;
            notificationText.Text = "Ahmed will get an instant notification when you save.";
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(28, 39, 69);
            header.Controls.Add(headerTitle);
            header.Location = new Point(0, 0);
            header.Margin = new Padding(3, 4, 3, 4);
            header.Name = "header";
            header.Size = new Size(734, 73);
            header.TabIndex = 0;
            // 
            // headerTitle
            // 
            headerTitle.AutoSize = true;
            headerTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            headerTitle.ForeColor = Color.White;
            headerTitle.Location = new Point(33, 23);
            headerTitle.Name = "headerTitle";
            headerTitle.Size = new Size(100, 28);
            headerTitle.TabIndex = 0;
            headerTitle.Text = "New task";
            // 
            // titleErrorProvider
            // 
            titleErrorProvider.ContainerControl = this;
            // 
            // NewTaskform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(1120, 1055);
            Controls.Add(page);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(489, 918);
            Name = "NewTaskform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit task";
            page.ResumeLayout(false);
            page.PerformLayout();
            card.ResumeLayout(false);
            body.ResumeLayout(false);
            body.PerformLayout();
            titleBorder.ResumeLayout(false);
            titleSurfacePanel.ResumeLayout(false);
            titleSurfacePanel.PerformLayout();
            descriptionBorder.ResumeLayout(false);
            descriptionSurfacePanel.ResumeLayout(false);
            descriptionSurfacePanel.PerformLayout();
            projectBorder.ResumeLayout(false);
            projectSurfacePanel.ResumeLayout(false);
            assigneeBorder.ResumeLayout(false);
            assigneeSurfacePanel.ResumeLayout(false);
            priorityPanel.ResumeLayout(false);
            statusBorder.ResumeLayout(false);
            statusSurfacePanel.ResumeLayout(false);
            deadlineBorder.ResumeLayout(false);
            deadlineSurfacePanel.ResumeLayout(false);
            notificationPanel.ResumeLayout(false);
            notificationSurfacePanel.ResumeLayout(false);
            notificationSurfacePanel.PerformLayout();
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)titleErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
