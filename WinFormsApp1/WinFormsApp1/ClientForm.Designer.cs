namespace WinFormsApp1
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            dgvMyRequests = new DataGridView();
            btnAddRequest = new Button();
            cmbStatus = new ComboBox();
            txtSearch = new TextBox();
            label3 = new Label();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMyRequests).BeginInit();
            SuspendLayout();
            // 
            // dgvMyRequests
            // 
            dgvMyRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyRequests.GridColor = Color.DarkOrchid;
            dgvMyRequests.Location = new Point(12, 210);
            dgvMyRequests.Name = "dgvMyRequests";
            dgvMyRequests.RowHeadersWidth = 51;
            dgvMyRequests.Size = new Size(776, 228);
            dgvMyRequests.TabIndex = 0;
            // 
            // btnAddRequest
            // 
            btnAddRequest.BackColor = Color.DarkOrchid;
            btnAddRequest.FlatStyle = FlatStyle.Flat;
            btnAddRequest.Location = new Point(307, 40);
            btnAddRequest.Name = "btnAddRequest";
            btnAddRequest.Size = new Size(140, 29);
            btnAddRequest.TabIndex = 3;
            btnAddRequest.Text = "Добавить заявку";
            btnAddRequest.UseVisualStyleBackColor = false;
            btnAddRequest.Click += btnAddRequest_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(12, 109);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(270, 28);
            cmbStatus.TabIndex = 6;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 41);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(270, 27);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumOrchid;
            label3.Location = new Point(12, 18);
            label3.Name = "label3";
            label3.Size = new Size(183, 20);
            label3.TabIndex = 11;
            label3.Text = "Поиск по своим заявкам";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumOrchid;
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 12;
            label1.Text = "Фильтр по статусу";
            // 
            // button2
            // 
            button2.BackColor = Color.PowderBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(751, 14);
            button2.Name = "button2";
            button2.Size = new Size(37, 29);
            button2.TabIndex = 21;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(cmbStatus);
            Controls.Add(btnAddRequest);
            Controls.Add(dgvMyRequests);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ClientForm";
            Text = "Личный кабинет клиента";
            ((System.ComponentModel.ISupportInitialize)dgvMyRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMyRequests;
        private Button btnAddRequest;
        private ComboBox cmbStatus;
        private TextBox txtSearch;
        private Label label3;
        private Label label1;
        private Button button2;
    }
}