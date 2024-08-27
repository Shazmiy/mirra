using System;
using System.Windows.Forms;

namespace mirra1._0
{
    public partial class PasswordForm : Form
    {
        public bool IsPasswordCorrect { get; private set; }

        public PasswordForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Проверка пароля
            if (passwordTextBox.Text == "1234")
            {
                IsPasswordCorrect = true;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Неверный пароль, попробуйте снова.");
                IsPasswordCorrect = false;
                DialogResult = DialogResult.Cancel;
            }
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {
            // Вы можете настроить форму при ее загрузке, если нужно
        }
    }
}
