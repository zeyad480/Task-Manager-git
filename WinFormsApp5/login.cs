namespace WinFormsApp5
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtusername.Text) || string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Please enter both your username or email and password.", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Login validation passed. Authentication is not connected to a backend yet.",
                "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CreateAccountLink_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Account creation is not connected to a backend yet.",
                "Create account", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rememberCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
