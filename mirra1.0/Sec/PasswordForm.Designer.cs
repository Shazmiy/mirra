namespace mirra1._0
{
    partial class PasswordForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox passwordTextBox;
        private Button submitButton;

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
            passwordTextBox = new TextBox();
            submitButton = new Button();
            SuspendLayout();
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(12, 12);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(260, 27);
            passwordTextBox.TabIndex = 0;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(197, 45);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 32);
            submitButton.TabIndex = 1;
            submitButton.Text = "Войти";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // PasswordForm
            // 
            ClientSize = new Size(284, 79);
            Controls.Add(submitButton);
            Controls.Add(passwordTextBox);
            Name = "PasswordForm";
            Load += PasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
