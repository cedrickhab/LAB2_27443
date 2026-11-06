namespace Lab2Desktop;

partial class ChooseForm
{
    private System.ComponentModel.IContainer components = null;
    private Label titleLabel;
    private Button bicycleButton;
    private Button mushroomButton;

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
        bicycleButton = new Button();
        mushroomButton = new Button();
        SuspendLayout();
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        titleLabel.Location = new Point(104, 34);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(216, 21);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "What do you want to do?";
        bicycleButton.Location = new Point(74, 96);
        bicycleButton.Name = "bicycleButton";
        bicycleButton.Size = new Size(120, 48);
        bicycleButton.TabIndex = 1;
        bicycleButton.Text = "Bicycle";
        bicycleButton.UseVisualStyleBackColor = true;
        bicycleButton.Click += bicycleButton_Click;
        mushroomButton.Location = new Point(222, 96);
        mushroomButton.Name = "mushroomButton";
        mushroomButton.Size = new Size(120, 48);
        mushroomButton.TabIndex = 2;
        mushroomButton.Text = "Mushroom";
        mushroomButton.UseVisualStyleBackColor = true;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(420, 200);
        Controls.Add(mushroomButton);
        Controls.Add(bicycleButton);
        Controls.Add(titleLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "ChooseForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Choose";
        ResumeLayout(false);
        PerformLayout();
    }
}
