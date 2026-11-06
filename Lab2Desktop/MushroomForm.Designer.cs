namespace Lab2Desktop;

partial class MushroomForm
{
    private System.ComponentModel.IContainer components = null;
    private Label titleLabel;
    private Button startButton;
    private Label questionLabel;
    private Button yesButton;
    private Button noButton;
    private Label resultLabel;
    private Button backButton;
    private Button logoutButton;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        titleLabel = new Label();
        startButton = new Button();
        questionLabel = new Label();
        yesButton = new Button();
        noButton = new Button();
        resultLabel = new Label();
        backButton = new Button();
        logoutButton = new Button();
        SuspendLayout();
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        titleLabel.Location = new Point(28, 20);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(186, 21);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Mushroom guesser";
        startButton.Location = new Point(28, 60);
        startButton.Name = "startButton";
        startButton.Size = new Size(95, 34);
        startButton.TabIndex = 1;
        startButton.Text = "Start";
        startButton.UseVisualStyleBackColor = true;
        startButton.Click += startButton_Click;
        questionLabel.BorderStyle = BorderStyle.FixedSingle;
        questionLabel.Font = new Font("Segoe UI", 10F);
        questionLabel.Location = new Point(28, 114);
        questionLabel.Name = "questionLabel";
        questionLabel.Size = new Size(540, 56);
        questionLabel.TabIndex = 2;
        questionLabel.TextAlign = ContentAlignment.MiddleLeft;
        yesButton.Enabled = false;
        yesButton.Location = new Point(28, 190);
        yesButton.Name = "yesButton";
        yesButton.Size = new Size(95, 38);
        yesButton.TabIndex = 3;
        yesButton.Text = "Yes";
        yesButton.UseVisualStyleBackColor = true;
        yesButton.Click += yesButton_Click;
        noButton.Enabled = false;
        noButton.Location = new Point(138, 190);
        noButton.Name = "noButton";
        noButton.Size = new Size(95, 38);
        noButton.TabIndex = 4;
        noButton.Text = "No";
        noButton.UseVisualStyleBackColor = true;
        noButton.Click += noButton_Click;
        resultLabel.BorderStyle = BorderStyle.FixedSingle;
        resultLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        resultLabel.Location = new Point(28, 248);
        resultLabel.Name = "resultLabel";
        resultLabel.Size = new Size(540, 34);
        resultLabel.TabIndex = 5;
        resultLabel.TextAlign = ContentAlignment.MiddleLeft;
        backButton.Location = new Point(368, 300);
        backButton.Name = "backButton";
        backButton.Size = new Size(95, 34);
        backButton.TabIndex = 6;
        backButton.Text = "Back";
        backButton.UseVisualStyleBackColor = true;
        backButton.Click += backButton_Click;
        logoutButton.Location = new Point(473, 300);
        logoutButton.Name = "logoutButton";
        logoutButton.Size = new Size(95, 34);
        logoutButton.TabIndex = 7;
        logoutButton.Text = "Logout";
        logoutButton.UseVisualStyleBackColor = true;
        logoutButton.Click += logoutButton_Click;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(600, 355);
        Controls.Add(logoutButton);
        Controls.Add(backButton);
        Controls.Add(resultLabel);
        Controls.Add(noButton);
        Controls.Add(yesButton);
        Controls.Add(questionLabel);
        Controls.Add(startButton);
        Controls.Add(titleLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MushroomForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Mushroom";
        ResumeLayout(false);
        PerformLayout();
    }
}
