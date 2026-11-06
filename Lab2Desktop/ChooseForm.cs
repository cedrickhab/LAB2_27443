namespace Lab2Desktop;

public partial class ChooseForm : Form
{
    private readonly LoginForm loginForm;

    public ChooseForm(LoginForm loginForm)
    {
        InitializeComponent();
        this.loginForm = loginForm;
    }
}
