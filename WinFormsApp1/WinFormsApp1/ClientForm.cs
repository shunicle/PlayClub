using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ClientForm : Form
    {
        string conn = "server=localhost;database=testdb;uid=root;pwd=1234;";
        int currentUserId;

        public ClientForm(int userId)
        {
            InitializeComponent();
            currentUserId = userId;

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Все");
            cmbStatus.Items.Add("Новая");
            cmbStatus.Items.Add("В работе");
            cmbStatus.Items.Add("Завершена");
            cmbStatus.SelectedIndex = 0;

            LoadData();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        string StatusRuToDb(string ru)
        {
            if (ru == "Новая") return "New";
            if (ru == "В работе") return "In_progress";
            if (ru == "Завершена") return "Completed";
            return "";
        }

        void LoadData()
        {
            string sql = "SELECT id AS 'Номер', title AS 'Название', description AS 'Описание', " +
                         "CASE status WHEN 'New' THEN 'Новая' WHEN 'In_progress' THEN 'В работе' WHEN 'Completed' THEN 'Завершена' END AS 'Статус', " +
                         "created_date AS 'Дата' " +
                         "FROM requests WHERE client_id=@id";

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                sql += " AND title LIKE @search";

            if (cmbStatus.Text != "Все")
                sql += " AND status=@status";

            DataTable dt = new DataTable();

            using (MySqlConnection con = new MySqlConnection(conn))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", currentUserId);

                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                    cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                if (cmbStatus.Text != "Все")
                    cmd.Parameters.AddWithValue("@status", StatusRuToDb(cmbStatus.Text));

                new MySqlDataAdapter(cmd).Fill(dt);
            }

            dgvMyRequests.DataSource = dt;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e) => LoadData();

        private void txtSearch_TextChanged_1(object sender, EventArgs e) => LoadData();

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            string title = Microsoft.VisualBasic.Interaction.InputBox("Название:", "Добавить заявку", "");
            if (string.IsNullOrWhiteSpace(title)) { MessageBox.Show("Вы ничего не ввели!"); return; }

            string desc = Microsoft.VisualBasic.Interaction.InputBox("Описание:", "Добавить заявку", "");
            if (string.IsNullOrWhiteSpace(desc)) { MessageBox.Show("Вы ничего не ввели!"); return; }

            using (MySqlConnection con = new MySqlConnection(conn))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO requests (client_id, title, description, status) VALUES (@id, @title, @desc, 'New')", con);
                cmd.Parameters.AddWithValue("@id", currentUserId);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.ExecuteNonQuery();
            }

            LoadData(); 
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoginForm zxc = new LoginForm();
            zxc.Show();
            this.Hide();
        }
    }
}
