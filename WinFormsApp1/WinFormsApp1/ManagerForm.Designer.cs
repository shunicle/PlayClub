namespace WinFormsApp1
{
    partial class ManagerForm
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
            txtSearch = new TextBox();
            btnUpdateStatus = new Button();
            cmbStatus = new ComboBox();
            btnDelete = new Button();
            btnAdd = new Button();
            cmbClientFilter = new ComboBox();
            Label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(195, 81);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(240, 27);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.DarkOrchid;
            btnUpdateStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateStatus.Location = new Point(455, 79);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(136, 29);
            btnUpdateStatus.TabIndex = 9;
            btnUpdateStatus.Text = "Изменить статус";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(27, 79);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 10;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkOrchid;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(597, 114);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkOrchid;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(597, 79);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbClientFilter
            // 
            cmbClientFilter.FlatStyle = FlatStyle.Flat;
            cmbClientFilter.FormattingEnabled = true;
            cmbClientFilter.Location = new Point(27, 139);
            cmbClientFilter.Name = "cmbClientFilter";
            cmbClientFilter.Size = new Size(151, 28);
            cmbClientFilter.TabIndex = 15;
            cmbClientFilter.SelectedIndexChanged += cmbClientFilter_SelectedIndexChanged;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.MediumOrchid;
            Label1.Location = new Point(27, 56);
            Label1.Name = "Label1";
            Label1.Size = new Size(120, 20);
            Label1.TabIndex = 16;
            Label1.Text = "Статус клиентов";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumOrchid;
            label2.Location = new Point(27, 116);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 17;
            label2.Text = "Выбрать клиента";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(745, 242);
            dataGridView1.TabIndex = 18;
            // 
            // button2
            // 
            button2.BackColor = Color.PowderBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(751, 12);
            button2.Name = "button2";
            button2.Size = new Size(37, 29);
            button2.TabIndex = 20;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumOrchid;
            label3.Location = new Point(195, 56);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 21;
            label3.Text = "Поиск";
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            BackgroundImage = Properties.Resources.abstract_futuristic_gaming_background_for_offline_twitch_stream_vector;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(cmbClientFilter);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(cmbStatus);
            Controls.Add(btnUpdateStatus);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ManagerForm";
            Text = "Личный кабинет менеджера";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearch;
        private Button btnUpdateStatus;
        private ComboBox cmbStatus;
        private Button btnDelete;
        private Button btnAdd;
        private ComboBox cmbClientFilter;
        private Label Label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label3;
    }
}