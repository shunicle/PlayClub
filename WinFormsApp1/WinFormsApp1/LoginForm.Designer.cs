namespace WinFormsApp1
{
    partial class LoginForm
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
            buttonLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxLogin = new TextBox();
            buttonRegister = new Button();
            textBoxPassword = new TextBox();
            label3 = new Label();
            comboBoxRole = new ComboBox();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.DarkOrchid;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Location = new Point(324, 292);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(163, 43);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumOrchid;
            label1.Location = new Point(295, 129);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 1;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumOrchid;
            label2.Location = new Point(295, 199);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(295, 152);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(214, 27);
            textBoxLogin.TabIndex = 3;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.DarkOrchid;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Location = new Point(324, 353);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(163, 46);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Регистрация";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(295, 222);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(214, 27);
            textBoxPassword.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumOrchid;
            label3.Location = new Point(295, 61);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 7;
            label3.Text = "Роль";
            // 
            // comboBoxRole
            // 
            comboBoxRole.FlatStyle = FlatStyle.Flat;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(295, 84);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(214, 28);
            comboBoxRole.TabIndex = 8;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            BackgroundImage = Properties.Resources.colorful_illumination_table_depicts_colored_gaming_accessories_computer_game_playing_esports_business_online_world_are_all_depicted_1257429_61113;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(797, 471);
            Controls.Add(comboBoxRole);
            Controls.Add(label3);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonLogin);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label label1;
        private Label label2;
        private TextBox textBoxLogin;
        private Button buttonRegister;
        private TextBox textBoxPassword;
        private Label label3;
        private ComboBox comboBoxRole;
    }
}
