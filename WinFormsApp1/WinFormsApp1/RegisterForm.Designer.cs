namespace WinFormsApp1
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonReg = new Button();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            comboBoxRole1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumOrchid;
            label1.Location = new Point(287, 88);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 2;
            label1.Text = "Ваша роль";
            // 
            // buttonReg
            // 
            buttonReg.BackColor = Color.DarkOrchid;
            buttonReg.FlatStyle = FlatStyle.Flat;
            buttonReg.Location = new Point(323, 297);
            buttonReg.Name = "buttonReg";
            buttonReg.Size = new Size(163, 39);
            buttonReg.TabIndex = 6;
            buttonReg.Text = "Зарегистрироваться";
            buttonReg.UseVisualStyleBackColor = false;
            buttonReg.Click += buttonReg_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrchid;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(323, 342);
            button1.Name = "button1";
            button1.Size = new Size(163, 39);
            button1.TabIndex = 7;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumOrchid;
            label2.Location = new Point(287, 152);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 8;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumOrchid;
            label3.Location = new Point(287, 214);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 9;
            label3.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(287, 175);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(229, 27);
            textBoxLogin.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(287, 237);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(229, 27);
            textBoxPassword.TabIndex = 11;
            // 
            // comboBoxRole1
            // 
            comboBoxRole1.FlatStyle = FlatStyle.Flat;
            comboBoxRole1.FormattingEnabled = true;
            comboBoxRole1.Location = new Point(287, 111);
            comboBoxRole1.Name = "comboBoxRole1";
            comboBoxRole1.Size = new Size(229, 28);
            comboBoxRole1.TabIndex = 12;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            BackgroundImage = Properties.Resources.liquid_marbling_paint_texture_background_fluid_painting_abstract_texture_intensive_color_mix_wallpaper_1258_103713;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxRole1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(buttonReg);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "RegisterForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonReg;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private ComboBox comboBoxRole1;
    }
}