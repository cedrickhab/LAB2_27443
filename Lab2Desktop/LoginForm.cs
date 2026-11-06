namespace Lab2Desktop;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    public void ResetInputs()
    {
        usernameTextBox.Clear();
        passwordTextBox.Clear();
        usernameTextBox.Focus();
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        string username = usernameTextBox.Text.Trim();
        string password = passwordTextBox.Text.Trim();

        if (username.Length == 0 || password.Length == 0)
        {
            MessageBox.Show("Username and password cannot be empty.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        ChooseForm chooseForm = new ChooseForm(this);
        chooseForm.Show();
        Hide();
    }
}
