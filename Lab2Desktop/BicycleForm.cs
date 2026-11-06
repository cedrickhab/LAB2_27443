namespace Lab2Desktop;

public partial class BicycleForm : Form
{
    private readonly ChooseForm chooseForm;
    private readonly LoginForm loginForm;

    public BicycleForm(ChooseForm chooseForm, LoginForm loginForm)
    {
        InitializeComponent();
        this.chooseForm = chooseForm;
        this.loginForm = loginForm;
    }

    private void calculateButton_Click(object sender, EventArgs e)
    {
        if (!TryReadHours(out int start, out int end))
        {
            return;
        }

        int total = 0;

        for (int hour = start; hour < end; hour++)
        {
            total += HourlyRate(hour);
        }

        totalTextBox.Text = total.ToString();
    }

    private bool TryReadHours(out int start, out int end)
    {
        start = 0;
        end = 0;
        totalTextBox.Clear();

        string startText = startTextBox.Text.Trim();
        string endText = endTextBox.Text.Trim();

        if (startText.Length == 0 || endText.Length == 0)
        {
            MessageBox.Show("Please enter both the starting hour and the ending hour.", "Bicycle rental", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!int.TryParse(startText, out start) || !int.TryParse(endText, out end))
        {
            MessageBox.Show("The times must be whole numbers, decimal numbers are not accepted.", "Bicycle rental", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (start < 0 || start > 23)
        {
            MessageBox.Show("The starting hour must be between 0 and 23.", "Bicycle rental", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (end < 1 || end > 24)
        {
            MessageBox.Show("The ending hour must be between 1 and 24.", "Bicycle rental", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (start >= end)
        {
            MessageBox.Show("The starting hour must be less than the ending hour.", "Bicycle rental", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    private static int HourlyRate(int hour)
    {
        if (hour < 7 || hour >= 21)
        {
            return 500;
        }

        if (hour < 14)
        {
            return 1000;
        }

        if (hour < 19)
        {
            return 1500;
        }

        return 1000;
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);

        if (!Program.HasVisibleForm())
        {
            Application.Exit();
        }
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        chooseForm.Show();
        Close();
    }

    private void logoutButton_Click(object sender, EventArgs e)
    {
        loginForm.ResetInputs();
        loginForm.Show();
        chooseForm.Close();
        Close();
    }
}
