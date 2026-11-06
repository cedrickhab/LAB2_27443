namespace Lab2Desktop;

public partial class ChooseForm : Form
{
    private readonly LoginForm loginForm;

    public ChooseForm(LoginForm loginForm)
    {
        InitializeComponent();
        this.loginForm = loginForm;
    }

    private void bicycleButton_Click(object sender, EventArgs e)
    {
        BicycleForm bicycleForm = new BicycleForm(this, loginForm);
        bicycleForm.Show();
        Hide();
    }
}
