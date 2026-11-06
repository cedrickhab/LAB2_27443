namespace Lab2Desktop;

partial class BicycleForm
{
    private System.ComponentModel.IContainer components = null;
    private Label titleLabel;
    private Label startLabel;
    private TextBox startTextBox;
    private Label endLabel;
    private TextBox endTextBox;
    private Button calculateButton;
    private Label totalLabel;
    private TextBox totalTextBox;
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
        startLabel = new Label();
        startTextBox = new TextBox();
        endLabel = new Label();
        endTextBox = new TextBox();
        calculateButton = new Button();
        totalLabel = new Label();
        totalTextBox = new TextBox();
        backButton = new Button();
        logoutButton = new Button();
        SuspendLayout();
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        titleLabel.Location = new Point(28, 20);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(139, 21);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Bicycle rental";
        startLabel.AutoSize = true;
        startLabel.Location = new Point(28, 72);
        startLabel.Name = "startLabel";
        startLabel.Size = new Size(139, 15);
        startLabel.TabIndex = 1;
        startLabel.Text = "Starting hour (0 - 23):";
        startTextBox.Location = new Point(252, 68);
        startTextBox.Name = "startTextBox";
        startTextBox.Size = new Size(120, 23);
        startTextBox.TabIndex = 2;
        endLabel.AutoSize = true;
        endLabel.Location = new Point(28, 112);
        endLabel.Name = "endLabel";
        endLabel.Size = new Size(137, 15);
        endLabel.TabIndex = 3;
        endLabel.Text = "Ending hour (1 - 24):";
        endTextBox.Location = new Point(252, 108);
        endTextBox.Name = "endTextBox";
        endTextBox.Size = new Size(120, 23);
        endTextBox.TabIndex = 4;
        calculateButton.Location = new Point(252, 152);
        calculateButton.Name = "calculateButton";
        calculateButton.Size = new Size(120, 34);
        calculateButton.TabIndex = 5;
        calculateButton.Text = "Calculate";
        calculateButton.UseVisualStyleBackColor = true;
        calculateButton.Click += calculateButton_Click;
        totalLabel.AutoSize = true;
        totalLabel.Location = new Point(28, 212);
        totalLabel.Name = "totalLabel";
        totalLabel.Size = new Size(72, 15);
        totalLabel.TabIndex = 6;
        totalLabel.Text = "Total (RWF):";
        totalTextBox.Location = new Point(252, 208);
        totalTextBox.Name = "totalTextBox";
        totalTextBox.ReadOnly = true;
        totalTextBox.Size = new Size(120, 23);
        totalTextBox.TabIndex = 7;
        backButton.Location = new Point(328, 268);
        backButton.Name = "backButton";
        backButton.Size = new Size(95, 34);
        backButton.TabIndex = 8;
        backButton.Text = "Back";
        backButton.UseVisualStyleBackColor = true;
        backButton.Click += backButton_Click;
        logoutButton.Location = new Point(438, 268);
        logoutButton.Name = "logoutButton";
        logoutButton.Size = new Size(95, 34);
        logoutButton.TabIndex = 9;
        logoutButton.Text = "Logout";
        logoutButton.UseVisualStyleBackColor = true;
        logoutButton.Click += logoutButton_Click;
        AcceptButton = calculateButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(560, 325);
        Controls.Add(logoutButton);
        Controls.Add(backButton);
        Controls.Add(totalTextBox);
        Controls.Add(totalLabel);
        Controls.Add(calculateButton);
        Controls.Add(endTextBox);
        Controls.Add(endLabel);
        Controls.Add(startTextBox);
        Controls.Add(startLabel);
        Controls.Add(titleLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "BicycleForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bicycle";
        ResumeLayout(false);
        PerformLayout();
    }
}
