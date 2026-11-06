namespace Lab2Desktop;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new LoginForm());
    }

    internal static bool HasVisibleForm()
    {
        foreach (Form form in Application.OpenForms)
        {
            if (form.Visible)
            {
                return true;
            }
        }

        return false;
    }
}
