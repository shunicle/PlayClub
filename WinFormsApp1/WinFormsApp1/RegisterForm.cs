using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RegisterForm : Form
    {
        string conn = "server=localhost;database=testdb;uid=root;pwd=1234;";

        public RegisterForm()
        {
            InitializeComponent();
            comboBoxRole1.Items.Clear();
            comboBoxRole1.Items.Add("клиент");
            comboBoxRole1.Items.Add("менеджер");
            comboBoxRole1.SelectedIndex = 0;
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните логин и пароль!");
                return;
            }

            string roleValue = comboBoxRole1.Text == "менеджер" ? "manager" : "client";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conn))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users (login, password, role) VALUES (@login, @pass, @role)", con);
                    cmd.Parameters.AddWithValue("@login", textBoxLogin.Text);
                    cmd.Parameters.AddWithValue("@pass", textBoxPassword.Text);
                    cmd.Parameters.AddWithValue("@role", roleValue);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Регистрация успешна!");
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Duplicate entry"))
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                else
                    MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
