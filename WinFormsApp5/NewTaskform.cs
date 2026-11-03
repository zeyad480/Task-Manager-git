namespace WinFormsApp7
{
    public partial class NewTaskform : Form
    {
        private static readonly Color BorderColor = Color.FromArgb(205, 214, 230);
        private static readonly Color ErrorColor = Color.FromArgb(180, 35, 35);
        private static readonly Color ErrorSurfaceColor = Color.FromArgb(255, 247, 247);
        private static readonly Color SelectedPriorityColor = Color.FromArgb(252, 229, 229);
        private static readonly DateTime DesignToday = new(2026, 11, 1);
        private bool titleHasBeenValidated;

        public NewTaskform()
        {
            InitializeComponent();
        }

        private void titleInput_Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            titleHasBeenValidated = true;
            UpdateTitleValidation();
        }

        private void titleInput_TextChanged(object? sender, EventArgs e)
        {
            if (titleHasBeenValidated)
                UpdateTitleValidation();
        }

        private void UpdateTitleValidation()
        {
            bool missingTitle = string.IsNullOrWhiteSpace(titleInput.Text);
            titleBorder.BackColor = missingTitle ? ErrorColor : BorderColor;
            titleErrorProvider.SetError(titleInput, missingTitle ? "Title is required" : "");
        }

        private void deadlineInput_ValueChanged(object? sender, EventArgs e)
        {
            DateTime today = DateTime.Today > DesignToday ? DateTime.Today : DesignToday;
            bool deadlineInPast = deadlineInput.Value.Date < today;

            deadlineError.Visible = deadlineInPast;
            deadlineBorder.BackColor = deadlineInPast ? ErrorColor : BorderColor;
            deadlineSurfacePanel.BackColor = deadlineInPast ? ErrorSurfaceColor : Color.White;
            notificationPanel.Location = new Point(30, deadlineInPast ? 480 : 453);
        }

        private void assigneeInput_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string assignee = assigneeInput.SelectedItem?.ToString() ?? "";
            notificationText.Text = $"{assignee} will get an instant notification when you save.";
        }

        private void PriorityButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button selectedButton)
                return;

            foreach (Button button in new[] { priorityLowButton, priorityMediumButton, priorityHighButton, priorityUrgentButton })
            {
                bool selected = button == selectedButton;
                button.BackColor = selected ? SelectedPriorityColor : Color.White;
                button.ForeColor = selected ? ErrorColor : Color.FromArgb(28, 39, 69);
                button.FlatAppearance.BorderColor = selected ? ErrorColor : BorderColor;
            }
        }

        private void titleSurfacePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void page_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
