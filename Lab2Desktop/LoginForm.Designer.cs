namespace Lab2Desktop;

partial class LoginForm
{
    private System.ComponentModel.IContainer components = null;
    private Label titleLabel;
    private Label usernameLabel;
    private TextBox usernameTextBox;
    private Label passwordLabel;
    private TextBox passwordTextBox;
    private Button loginButton;

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
        usernameLabel = new Label();
        usernameTextBox = new TextBox();
        passwordLabel = new Label();
        passwordTextBox = new TextBox();
        loginButton = new Button();
        SuspendLayout();
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        titleLabel.Location = new Point(92, 24);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(230, 21);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Bicycle Rental and Mushroom";
        usernameLabel.AutoSize = true;
        usernameLabel.Location = new Point(48, 82);
        usernameLabel.Name = "usernameLabel";
        usernameLabel.Size = new Size(63, 15);
        usernameLabel.TabIndex = 1;
        usernameLabel.Text = "Username:";
        usernameTextBox.Location = new Point(160, 78);
        usernameTextBox.Name = "usernameTextBox";
        usernameTextBox.Size = new Size(200, 23);
        usernameTextBox.TabIndex = 2;
        passwordLabel.AutoSize = true;
        passwordLabel.Location = new Point(48, 126);
        passwordLabel.Name = "passwordLabel";
        passwordLabel.Size = new Size(60, 15);
        passwordLabel.TabIndex = 3;
        passwordLabel.Text = "Password:";
        passwordTextBox.Location = new Point(160, 122);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.Size = new Size(200, 23);
        passwordTextBox.TabIndex = 4;
        passwordTextBox.UseSystemPasswordChar = true;
        loginButton.Location = new Point(160, 172);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(120, 34);
        loginButton.TabIndex = 5;
        loginButton.Text = "Login";
        loginButton.UseVisualStyleBackColor = true;
        loginButton.Click += loginButton_Click;
        AcceptButton = loginButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(404, 241);
        Controls.Add(loginButton);
        Controls.Add(passwordTextBox);
        Controls.Add(passwordLabel);
        Controls.Add(usernameTextBox);
        Controls.Add(usernameLabel);
        Controls.Add(titleLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }
}
