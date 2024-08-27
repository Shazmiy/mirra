namespace mirra1._0
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            pictureBox1 = new PictureBox();
            Pay_page_button = new Button();
            Main = new GroupBox();
            Record_page_button = new Button();
            Registr_page_button = new Button();
            Second = new GroupBox();
            Contacts_page_button = new Button();
            Pool_page_button = new Button();
            Booking_page_button = new Button();
            Menu_page_button = new Button();
            Spa_page_button = new Button();
            LogIn_page_button = new Button();
            Admin_button = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Main.SuspendLayout();
            Second.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(99, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(613, 260);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Pay_page_button
            // 
            Pay_page_button.Location = new Point(6, 43);
            Pay_page_button.Name = "Pay_page_button";
            Pay_page_button.Size = new Size(196, 83);
            Pay_page_button.TabIndex = 1;
            Pay_page_button.Text = "Платежи";
            Pay_page_button.UseVisualStyleBackColor = true;
            Pay_page_button.Click += Pay_page_button_Click;
            // 
            // Main
            // 
            Main.Controls.Add(Record_page_button);
            Main.Controls.Add(Registr_page_button);
            Main.Controls.Add(Pay_page_button);
            Main.Location = new Point(175, 320);
            Main.Name = "Main";
            Main.Size = new Size(217, 315);
            Main.TabIndex = 2;
            Main.TabStop = false;
            // 
            // Record_page_button
            // 
            Record_page_button.Location = new Point(6, 221);
            Record_page_button.Name = "Record_page_button";
            Record_page_button.Size = new Size(196, 83);
            Record_page_button.TabIndex = 3;
            Record_page_button.Text = "Услуги";
            Record_page_button.UseVisualStyleBackColor = true;
            Record_page_button.Click += Record_page_button_Click;
            // 
            // Registr_page_button
            // 
            Registr_page_button.Location = new Point(6, 132);
            Registr_page_button.Name = "Registr_page_button";
            Registr_page_button.Size = new Size(196, 83);
            Registr_page_button.TabIndex = 2;
            Registr_page_button.Text = "Регистрация";
            Registr_page_button.UseVisualStyleBackColor = true;
            Registr_page_button.Click += Registr_page_button_Click;
            // 
            // Second
            // 
            Second.Controls.Add(Contacts_page_button);
            Second.Controls.Add(Pool_page_button);
            Second.Controls.Add(Booking_page_button);
            Second.Controls.Add(Menu_page_button);
            Second.Controls.Add(Spa_page_button);
            Second.Controls.Add(LogIn_page_button);
            Second.Location = new Point(424, 320);
            Second.Name = "Second";
            Second.Size = new Size(242, 315);
            Second.TabIndex = 3;
            Second.TabStop = false;
            // 
            // Contacts_page_button
            // 
            Contacts_page_button.Location = new Point(132, 225);
            Contacts_page_button.Name = "Contacts_page_button";
            Contacts_page_button.Size = new Size(93, 84);
            Contacts_page_button.TabIndex = 5;
            Contacts_page_button.Text = "Контакты";
            Contacts_page_button.UseVisualStyleBackColor = true;
            Contacts_page_button.Click += Contacts_page_button_Click;
            // 
            // Pool_page_button
            // 
            Pool_page_button.Location = new Point(15, 225);
            Pool_page_button.Name = "Pool_page_button";
            Pool_page_button.Size = new Size(93, 84);
            Pool_page_button.TabIndex = 4;
            Pool_page_button.Text = "Бассейн";
            Pool_page_button.UseVisualStyleBackColor = true;
            Pool_page_button.Click += Pool_page_button_Click;
            // 
            // Booking_page_button
            // 
            Booking_page_button.Location = new Point(132, 133);
            Booking_page_button.Name = "Booking_page_button";
            Booking_page_button.Size = new Size(93, 84);
            Booking_page_button.TabIndex = 3;
            Booking_page_button.Text = "Бронь залов";
            Booking_page_button.UseVisualStyleBackColor = true;
            Booking_page_button.Click += Booking_page_button_Click;
            // 
            // Menu_page_button
            // 
            Menu_page_button.Location = new Point(132, 43);
            Menu_page_button.Name = "Menu_page_button";
            Menu_page_button.Size = new Size(93, 84);
            Menu_page_button.TabIndex = 2;
            Menu_page_button.Text = "Меню";
            Menu_page_button.UseVisualStyleBackColor = true;
            Menu_page_button.Click += Menu_page_button_Click;
            // 
            // Spa_page_button
            // 
            Spa_page_button.Location = new Point(15, 132);
            Spa_page_button.Name = "Spa_page_button";
            Spa_page_button.Size = new Size(93, 84);
            Spa_page_button.TabIndex = 1;
            Spa_page_button.Text = "Спа";
            Spa_page_button.UseVisualStyleBackColor = true;
            Spa_page_button.Click += Spa_page_button_Click;
            // 
            // LogIn_page_button
            // 
            LogIn_page_button.Location = new Point(15, 42);
            LogIn_page_button.Name = "LogIn_page_button";
            LogIn_page_button.Size = new Size(93, 84);
            LogIn_page_button.TabIndex = 0;
            LogIn_page_button.Text = "Личный кабинет";
            LogIn_page_button.UseVisualStyleBackColor = true;
            // 
            // Admin_button
            // 
            Admin_button.Location = new Point(565, 641);
            Admin_button.Name = "Admin_button";
            Admin_button.Size = new Size(147, 29);
            Admin_button.TabIndex = 6;
            Admin_button.Text = "Admin";
            Admin_button.UseVisualStyleBackColor = true;
            Admin_button.Click += Admin_button_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 702);
            panel1.TabIndex = 7;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 702);
            Controls.Add(pictureBox1);
            Controls.Add(Main);
            Controls.Add(Second);
            Controls.Add(Admin_button);
            Controls.Add(panel1);
            Name = "Main_Form";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Main.ResumeLayout(false);
            Second.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Pay_page_button;
        private GroupBox Main;
        private Button Record_page_button;
        private Button Registr_page_button;
        private GroupBox Second;
        private Button Contacts_page_button;
        private Button Pool_page_button;
        private Button Booking_page_button;
        private Button Menu_page_button;
        private Button Spa_page_button;
        private Button LogIn_page_button;
        private Button Admin_button;
        private Panel panel1;
    }
}
