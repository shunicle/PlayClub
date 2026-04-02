using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        string conn = "server=localhost;database=testdb;uid=root;pwd=1234;";

        public LoginForm()
        {
            InitializeComponent();
            comboBoxRole.Items.Clear();
            comboBoxRole.Items.Add("менеджер");
            comboBoxRole.Items.Add("клиент");
            comboBoxRole.SelectedIndex = 0;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните логин и пароль!");
                return;
            }

            if (comboBoxRole.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите роль!");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(conn))
                {
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT id, role FROM users WHERE login=@login AND password=@pass", con);
                    cmd.Parameters.AddWithValue("@login", textBoxLogin.Text);
                    cmd.Parameters.AddWithValue("@pass", textBoxPassword.Text);

                    int userId = 0;
                    string actualRole = "";

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userId = Convert.ToInt32(reader["id"]);
                            actualRole = reader["role"].ToString();
                        }
                    }

                    if (actualRole == "")
                    {
                        MessageBox.Show("Неверный логин или пароль!");
                        return;
                    }

                    string selectedRole = comboBoxRole.Text == "менеджер" ? "manager" : "client";

                    if (actualRole != selectedRole)
                    {
                        MessageBox.Show("Вы выбрали неверную роль!");
                        return;
                    }

                    if (actualRole == "manager")
                    {
                        ManagerForm managerForm = new ManagerForm();
                        managerForm.Show();
                    }
                    else
                    {
                        ClientForm clientForm = new ClientForm(userId);
                        clientForm.Show();
                    }

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
