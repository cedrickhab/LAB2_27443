namespace Lab2Desktop;

public partial class ChooseForm : Form
{
    private readonly LoginForm loginForm;

    public ChooseForm(LoginForm loginForm)
    {
        InitializeComponent();
        this.loginForm = loginForm;
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);

        if (!Program.HasVisibleForm())
        {
            Application.Exit();
        }
    }

    private void bicycleButton_Click(object sender, EventArgs e)
    {
        BicycleForm bicycleForm = new BicycleForm(this, loginForm);
        bicycleForm.Show();
        Hide();
    }

    private void mushroomButton_Click(object sender, EventArgs e)
    {
        MushroomForm mushroomForm = new MushroomForm(this, loginForm);
        mushroomForm.Show();
        Hide();
    }
}
