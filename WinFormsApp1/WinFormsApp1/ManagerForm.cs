using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ManagerForm : Form
    {
        string conn = "server=localhost;database=testdb;uid=root;pwd=1234;";

        public ManagerForm()
        {
            InitializeComponent();
            LoadStatusFilter();
            LoadClients();
            LoadData();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        void LoadStatusFilter()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Все");
            cmbStatus.Items.Add("Новая");
            cmbStatus.Items.Add("В работе");
            cmbStatus.Items.Add("Завершена");
            cmbStatus.SelectedIndex = 0;
        }

        void LoadClients()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(conn))
            {
                new MySqlDataAdapter("SELECT id, login FROM users WHERE role='client'", con).Fill(dt);
            }

            DataRow allRow = dt.NewRow();
            allRow["id"] = -1;
            allRow["login"] = "Все";
            dt.Rows.InsertAt(allRow, 0);

            cmbClientFilter.DataSource = dt;
            cmbClientFilter.DisplayMember = "login";
            cmbClientFilter.ValueMember = "id";
            cmbClientFilter.SelectedIndex = 0; 
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
            string sql = "SELECT r.id AS 'Номер', u.login AS 'Клиент', r.title AS 'Название', r.description AS 'Описание', " +
                         "CASE r.status WHEN 'New' THEN 'Новая' WHEN 'In_progress' THEN 'В работе' WHEN 'Completed' THEN 'Завершена' END AS 'Статус', " +
                         "r.created_date AS 'Дата' " +
                         "FROM requests r JOIN users u ON r.client_id = u.id WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                sql += " AND r.title LIKE '%" + txtSearch.Text + "%'";

            if (cmbStatus.Text != "Все")
                sql += " AND r.status='" + StatusRuToDb(cmbStatus.Text) + "'";

            if (cmbClientFilter.SelectedValue is int clientId && clientId != -1)
                sql += " AND r.client_id=" + clientId;

            DataTable dt = new DataTable();
            new MySqlDataAdapter(sql, conn).Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e) => LoadData();

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e) => LoadData();

        private void cmbClientFilter_SelectedIndexChanged(object sender, EventArgs e) => LoadData();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(cmbClientFilter.SelectedValue is int clientId) || clientId == -1)
            {
                MessageBox.Show("Выберите конкретного клиента!");
                return;
            }

            string title = Microsoft.VisualBasic.Interaction.InputBox("Название:", "Добавить", "");
            if (string.IsNullOrWhiteSpace(title)) { MessageBox.Show("Вы ничего не ввели!"); return; }

            string desc = Microsoft.VisualBasic.Interaction.InputBox("Описание:", "Добавить", "");
            if (string.IsNullOrWhiteSpace(desc)) { MessageBox.Show("Вы ничего не ввели!"); return; }

            using (MySqlConnection con = new MySqlConnection(conn))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO requests (client_id, title, description, status) VALUES (@id, @title, @desc, 'New')", con);
                cmd.Parameters.AddWithValue("@id", clientId);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.ExecuteNonQuery();
            }

            LoadData();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) { MessageBox.Show("Выберите заявку!"); return; }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Номер"].Value);
            string status = Microsoft.VisualBasic.Interaction.InputBox("Статус (Новая / В работе / Завершена):", "Изменить", "");
            if (string.IsNullOrWhiteSpace(status)) { MessageBox.Show("Вы ничего не ввели!"); return; }

            string dbStatus = StatusRuToDb(status);
            if (dbStatus == "") { MessageBox.Show("Статус должен быть: Новая, В работе или Завершена!"); return; }

            using (MySqlConnection con = new MySqlConnection(conn))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE requests SET status=@status WHERE id=@id", con);
                cmd.Parameters.AddWithValue("@status", dbStatus);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            LoadData();
            MessageBox.Show("Статус изменен!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) { MessageBox.Show("Выберите заявку!"); return; }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Номер"].Value);

            if (MessageBox.Show("Удалить заявку?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection con = new MySqlConnection(conn))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM requests WHERE id=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                LoadData();
                MessageBox.Show("Заявка удалена!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
