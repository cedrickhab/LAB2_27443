namespace Lab2Desktop;

public partial class MushroomForm : Form
{
    private enum Question
    {
        None,
        Forest,
        ConvexCup,
        Ring,
        Gills
    }

    private readonly ChooseForm chooseForm;
    private readonly LoginForm loginForm;
    private Question currentQuestion = Question.None;
    private bool growsInForest;
    private bool hasConvexCup;

    public MushroomForm(ChooseForm chooseForm, LoginForm loginForm)
    {
        InitializeComponent();
        this.chooseForm = chooseForm;
        this.loginForm = loginForm;
        ShowIdleState();
    }

    private void ShowIdleState()
    {
        currentQuestion = Question.None;
        questionLabel.Text = "Think of one of the six mushrooms, then press Start.";
        yesButton.Enabled = false;
        noButton.Enabled = false;
        startButton.Enabled = true;
    }

    private void startButton_Click(object sender, EventArgs e)
    {
        growsInForest = false;
        hasConvexCup = false;
        resultLabel.Text = string.Empty;
        startButton.Enabled = false;
        Ask(Question.Forest, "Does your mushroom grow in a forest?");
    }

    private void Ask(Question question, string text)
    {
        currentQuestion = question;
        questionLabel.Text = text;
        yesButton.Enabled = true;
        noButton.Enabled = true;
    }

    private void yesButton_Click(object sender, EventArgs e)
    {
        Answer(true);
    }

    private void noButton_Click(object sender, EventArgs e)
    {
        Answer(false);
    }

    private void Answer(bool yes)
    {
        yesButton.Enabled = false;
        noButton.Enabled = false;

        switch (currentQuestion)
        {
            case Question.Forest:
                growsInForest = yes;
                Ask(Question.ConvexCup, "Does your mushroom have a convex cup?");
                break;
            case Question.ConvexCup:
                hasConvexCup = yes;

                if (!growsInForest)
                {
                    Guess(hasConvexCup ? "Agaric jaunissant" : "Coprin chevelu");
                }
                else if (hasConvexCup)
                {
                    Ask(Question.Ring, "Does your mushroom have a ring?");
                }
                else
                {
                    Ask(Question.Gills, "Does your mushroom have gills?");
                }

                break;
            case Question.Ring:
                Guess(yes ? "Amanite tue-mouche" : "Pied bleu");
                break;
            case Question.Gills:
                Guess(yes ? "Girolle" : "Cepe de bordeaux");
                break;
        }
    }

    private void Guess(string mushroom)
    {
        currentQuestion = Question.None;
        questionLabel.Text = "I have my answer.";
        resultLabel.Text = "Your mushroom is: " + mushroom;
        startButton.Enabled = true;
        MessageBox.Show("Your mushroom is " + mushroom + ".", "Mushroom", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
