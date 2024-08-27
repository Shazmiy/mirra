using mirra1._0.Pages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace mirra1._0
{
    public partial class Main_Form : Form
    {
        private bool isHeaderRemoved = false;
        private int clickCount = 0;
        private Stack<Form> formStack = new Stack<Form>();
        private Panel headerPanel;
        private ComboBox langComboBox;
        private Label timeLabel;
        private System.Windows.Forms.Timer timeTimer;
        private Label clickLabel;
        private ResourceManager resourceManager;

        public Main_Form()
        {
            InitializeComponent();
            Admin_button.Visible = true;
            headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50, // Высота заголовка
                BackColor = Color.DarkSlateGray // Цвет фона заголовка
            };
            this.Controls.Add(headerPanel);

            langComboBox = new ComboBox
            {
                Dock = DockStyle.Left,
                Width = 150,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Items = { "English", "Русский" }
            };
            langComboBox.SelectedIndex = 0; // Установка значения по умолчанию
            langComboBox.SelectedIndexChanged += langComboBox_SelectedIndexChanged;
            headerPanel.Controls.Add(langComboBox);

            timeLabel = new Label
            {
                Dock = DockStyle.Right,
                Width = 150,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Arial", 12, FontStyle.Regular)
            };
            headerPanel.Controls.Add(timeLabel);

            timeTimer = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };
            timeTimer.Tick += TimeTimer_Tick;
            timeTimer.Start();

            clickLabel = new Label
            {
                Name = "clickLabel",
                BackColor = Color.Transparent,
                Text = "",
                Dock = DockStyle.Fill,
                Visible = false
            };
            clickLabel.Click += ClickLabel_Click;
            Controls.Add(clickLabel);

            Admin_button.SizeChanged += (s, e) => {
                clickLabel.Size = Admin_button.Size;
                clickLabel.Location = Admin_button.Location;
            };

            // Инициализация ResourceManager
            resourceManager = new ResourceManager("mirra1._0.Properties.Resources", typeof(Main_Form).Assembly);

            // Примените локализованные строки при загрузке формы
            ApplyResources();
        }

        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Admin_button_Click(object sender, EventArgs e)
        {
            using (PasswordForm passwordForm = new PasswordForm())
            {
                if (passwordForm.ShowDialog() == DialogResult.OK && passwordForm.IsPasswordCorrect)
                {
                    Admin_button.Visible = false;
                    clickLabel.Visible = true;
                }
                else
                {
                    MessageBox.Show(resourceManager.GetString("AccessDenied"));
                }
            }
        }

        private void ClickLabel_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount >= 3)
            {
                Admin_button.Visible = true;
                clickLabel.Visible = false;
                clickCount = 0;
            }
        }

        private void ToggleFormBorders()
        {
            isHeaderRemoved = !isHeaderRemoved;
            foreach (Form form in Application.OpenForms)
            {
                form.FormBorderStyle = isHeaderRemoved ? FormBorderStyle.None : FormBorderStyle.Sizable;
                form.WindowState = isHeaderRemoved ? FormWindowState.Maximized : FormWindowState.Normal;
            }
        }

        private void OpenForm<T>() where T : Form, new()
        {
            Form form = new T();
            form.Show();
            Hide(); // Скрытие текущей формы
        }

        private void OpenFormInPanel<T>(Panel panel, bool isNewBranch) where T : Form, new()
        {
            if (isNewBranch)
            {
                formStack.Clear();
                panel.Controls.Clear();
            }
            if (panel.Controls.Count > 0 && panel.Controls[0] is Form currentForm)
            {
                formStack.Push(currentForm);
            }
            Form form = new T();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Button backButton = new Button
            {
                Text = resourceManager.GetString("BackButtonText"),
                Size = new Size(75, 23),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                Location = new Point(form.ClientSize.Width - 85, form.ClientSize.Height - 35)
            };
            backButton.Click += (sender, e) => GoBack(panel);
            form.Controls.Add(backButton);

            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
            panel1.BringToFront();
            panel.Visible = true;
        }

        private void GoBack(Panel panel)
        {
            if (formStack.Count > 0)
            {
                Form previousForm = formStack.Pop();
                panel.Controls.Clear();
                panel.Controls.Add(previousForm);
                previousForm.Show();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
                formStack.Clear();
            }
        }

        private void langComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = langComboBox.SelectedItem.ToString();
            switch (selectedLanguage)
            {
                case "English":
                    ChangeCulture("en-US");
                    break;
                case "Русский":
                    ChangeCulture("ru-RU");
                    break;
                    // Добавьте другие языки по мере необходимости
            }
        }
        
        private void ChangeCulture(string cultureCode)
        {
            CultureInfo culture = new CultureInfo(cultureCode);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            // Обновите все текстовые элементы
            ApplyResources();
        }

        private void ApplyResources()
        {
            // Примените текст для кнопок и других элементов
            Pay_page_button.Text = resourceManager.GetString("PayPageButtonText");
            // Обновите другие элементы, если нужно
        }

        private void Pay_page_button_Click(object sender, EventArgs e) => OpenFormInPanel<Pay_Form>(panel1, true);
        private void Registr_page_button_Click(object sender, EventArgs e) => OpenFormInPanel<Registr_Form>(panel1, true);
        private void Record_page_button_Click(object sender, EventArgs e) => OpenFormInPanel<Record_Form>(panel1, true);
        private void Menu_page_button_Click(object sender, EventArgs e) => OpenFormInPanel<Menu_Form>(panel1, true);
        private void Spa_page_button_Click(object sender, EventArgs e) => OpenFormInPanel<Spa_Form>(panel1, true);
        private void Booking_page_button_Click(object sender, EventArgs e) => OpenFormInPanel<Booking_Form>(panel1, true);
        private void Pool_page_button_Click(object sender, EventArgs e) => OpenFormInPanel<Pool_Form>(panel1, true);
        private void Contacts_page_button_Click(object sender, EventArgs e) => OpenFormInPanel<Contacts_Form>(panel1, true);
    }
}
