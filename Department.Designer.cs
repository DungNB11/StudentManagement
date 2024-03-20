namespace Project
{
    partial class Department
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnDoEdit = new Button();
            btnDoAdd = new Button();
            txtName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtCode = new TextBox();
            label2 = new Label();
            dgDepartment = new DataGridView();
            groupBox1 = new GroupBox();
            btnDoDelete = new Button();
            label4 = new Label();
            panel4 = new Panel();
            btnExportExcel = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgDepartment).BeginInit();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.Black;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Image = Properties.Resources.icons8_delete_30;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(782, 176);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(20, 0, 0, 0);
            btnDelete.Size = new Size(175, 45);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "   Xóa";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.Black;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Image = Properties.Resources.icons8_update_30;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(782, 110);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(20, 0, 0, 0);
            btnEdit.Size = new Size(175, 45);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "   Chỉnh sửa";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.Black;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Image = Properties.Resources.icons8_add_new_30;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(782, 43);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(20, 0, 0, 0);
            btnAdd.Size = new Size(175, 45);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "   Thêm mới";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDoEdit
            // 
            btnDoEdit.BackColor = Color.White;
            btnDoEdit.Cursor = Cursors.Hand;
            btnDoEdit.FlatAppearance.BorderColor = Color.Black;
            btnDoEdit.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnDoEdit.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnDoEdit.FlatStyle = FlatStyle.Flat;
            btnDoEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoEdit.ForeColor = Color.Black;
            btnDoEdit.Image = Properties.Resources.icons8_update_30;
            btnDoEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoEdit.Location = new Point(364, 142);
            btnDoEdit.Name = "btnDoEdit";
            btnDoEdit.Padding = new Padding(4, 0, 0, 0);
            btnDoEdit.Size = new Size(125, 37);
            btnDoEdit.TabIndex = 21;
            btnDoEdit.Text = "  Cập nhật";
            btnDoEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDoEdit.UseVisualStyleBackColor = false;
            btnDoEdit.Click += btnDoEdit_Click;
            // 
            // btnDoAdd
            // 
            btnDoAdd.BackColor = Color.White;
            btnDoAdd.Cursor = Cursors.Hand;
            btnDoAdd.FlatAppearance.BorderColor = Color.FromArgb(76, 174, 254);
            btnDoAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(170, 248, 220);
            btnDoAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 248, 220);
            btnDoAdd.FlatStyle = FlatStyle.Flat;
            btnDoAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoAdd.ForeColor = Color.FromArgb(76, 174, 254);
            btnDoAdd.Image = Properties.Resources.plus_sm;
            btnDoAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoAdd.Location = new Point(364, 142);
            btnDoAdd.Name = "btnDoAdd";
            btnDoAdd.Padding = new Padding(4, 0, 0, 0);
            btnDoAdd.Size = new Size(125, 37);
            btnDoAdd.TabIndex = 20;
            btnDoAdd.Text = " Thêm mới";
            btnDoAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDoAdd.UseVisualStyleBackColor = false;
            btnDoAdd.Click += btnDoAdd_Click;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.ForeColor = Color.DimGray;
            txtName.Location = new Point(198, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(217, 25);
            txtName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(52, 0);
            label1.Name = "label1";
            label1.Size = new Size(299, 26);
            label1.TabIndex = 1;
            label1.Text = "DEPARTMENT INFORMATION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(79, 62);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 4;
            label3.Text = "Mã khoa";
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.White;
            txtCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCode.ForeColor = Color.DimGray;
            txtCode.Location = new Point(198, 56);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(153, 25);
            txtCode.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(153, 267);
            label2.Name = "label2";
            label2.Size = new Size(186, 26);
            label2.TabIndex = 3;
            label2.Text = "DEPARTMENT LIST";
            // 
            // dgDepartment
            // 
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dgDepartment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDepartment.BackgroundColor = Color.WhiteSmoke;
            dgDepartment.BorderStyle = BorderStyle.Fixed3D;
            dgDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDepartment.Location = new Point(153, 352);
            dgDepartment.Name = "dgDepartment";
            dgDepartment.RowHeadersWidth = 51;
            dgDepartment.RowTemplate.Height = 25;
            dgDepartment.Size = new Size(866, 326);
            dgDepartment.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDoDelete);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(btnDoEdit);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnDoAdd);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCode);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(76, 174, 254);
            groupBox1.Location = new Point(153, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 196);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // btnDoDelete
            // 
            btnDoDelete.BackColor = Color.White;
            btnDoDelete.Cursor = Cursors.Hand;
            btnDoDelete.FlatAppearance.BorderColor = Color.Black;
            btnDoDelete.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnDoDelete.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnDoDelete.FlatStyle = FlatStyle.Flat;
            btnDoDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoDelete.ForeColor = Color.Black;
            btnDoDelete.Image = Properties.Resources.icons8_delete_30;
            btnDoDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoDelete.Location = new Point(390, 142);
            btnDoDelete.Name = "btnDoDelete";
            btnDoDelete.Padding = new Padding(4, 0, 0, 0);
            btnDoDelete.Size = new Size(99, 37);
            btnDoDelete.TabIndex = 27;
            btnDoDelete.Text = "   Xóa";
            btnDoDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDoDelete.UseVisualStyleBackColor = false;
            btnDoDelete.Click += btnDoDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(79, 101);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 6;
            label4.Text = "Tên khoa";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(btnExportExcel);
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(btnEdit);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(dgDepartment);
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1384, 715);
            panel4.TabIndex = 5;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.White;
            btnExportExcel.Cursor = Cursors.Hand;
            btnExportExcel.FlatAppearance.BorderColor = Color.Black;
            btnExportExcel.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnExportExcel.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportExcel.ForeColor = Color.Black;
            btnExportExcel.Image = Properties.Resources.icons8_excel_30;
            btnExportExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportExcel.Location = new Point(895, 302);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Padding = new Padding(4, 0, 0, 0);
            btnExportExcel.Size = new Size(124, 44);
            btnExportExcel.TabIndex = 28;
            btnExportExcel.Text = " Xuất Excel";
            btnExportExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(153, 309);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = " Tìm mã khoa, tên khoa";
            txtSearch.Size = new Size(224, 26);
            txtSearch.TabIndex = 19;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // Department
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 715);
            Controls.Add(panel4);
            Name = "Department";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Department";
            Load += Department_Load;
            ((System.ComponentModel.ISupportInitialize)dgDepartment).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnDoEdit;
        private Button btnDoAdd;
        private TextBox txtName;
        private Label label1;
        private Label label3;
        private TextBox txtCode;
        private Label label2;
        private DataGridView dgDepartment;
        private GroupBox groupBox1;
        private Label label4;
        private Panel panel4;
        private Button btnDoDelete;
        private TextBox txtSearch;
        private Button btnExportExcel;
    }
}