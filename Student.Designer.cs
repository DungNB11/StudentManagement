namespace Project
{
    partial class Student
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gbInfo = new GroupBox();
            dtpDOB = new DateTimePicker();
            btnDoAdd = new Button();
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            cboDepartment = new ComboBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label9 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtCode = new TextBox();
            label6 = new Label();
            btnDoDelete = new Button();
            btnDoEdit = new Button();
            btnAdd = new Button();
            dgStudent = new DataGridView();
            label2 = new Label();
            cboDepartmentSearch = new ComboBox();
            txtSearch = new TextBox();
            cboGenderSearch = new ComboBox();
            btnExportExcel = new Button();
            panel4 = new Panel();
            btnEdit = new Button();
            btnDelete = new Button();
            cboSort = new ComboBox();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgStudent).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(btnDoDelete);
            gbInfo.Controls.Add(btnDoEdit);
            gbInfo.Controls.Add(dtpDOB);
            gbInfo.Controls.Add(btnDoAdd);
            gbInfo.Controls.Add(rdFemale);
            gbInfo.Controls.Add(rdMale);
            gbInfo.Controls.Add(cboDepartment);
            gbInfo.Controls.Add(txtPhone);
            gbInfo.Controls.Add(txtAddress);
            gbInfo.Controls.Add(txtName);
            gbInfo.Controls.Add(label7);
            gbInfo.Controls.Add(label8);
            gbInfo.Controls.Add(label5);
            gbInfo.Controls.Add(label9);
            gbInfo.Controls.Add(label4);
            gbInfo.Controls.Add(label1);
            gbInfo.Controls.Add(label3);
            gbInfo.Controls.Add(txtCode);
            gbInfo.Controls.Add(label6);
            gbInfo.FlatStyle = FlatStyle.Flat;
            gbInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gbInfo.ForeColor = Color.FromArgb(76, 174, 254);
            gbInfo.Location = new Point(113, 27);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(924, 257);
            gbInfo.TabIndex = 12;
            gbInfo.TabStop = false;
            gbInfo.Enter += gbInfo_Enter;
            // 
            // dtpDOB
            // 
            dtpDOB.CalendarForeColor = Color.DimGray;
            dtpDOB.CalendarTitleForeColor = Color.DimGray;
            dtpDOB.CausesValidation = false;
            dtpDOB.CustomFormat = "  dd / MM / yyyy";
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.Location = new Point(208, 148);
            dtpDOB.Margin = new Padding(3, 2, 3, 2);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(143, 25);
            dtpDOB.TabIndex = 25;
            // 
            // btnDoAdd
            // 
            btnDoAdd.BackColor = Color.White;
            btnDoAdd.Cursor = Cursors.Hand;
            btnDoAdd.FlatAppearance.BorderColor = Color.Black;
            btnDoAdd.FlatAppearance.CheckedBackColor = Color.Silver;
            btnDoAdd.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnDoAdd.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnDoAdd.FlatStyle = FlatStyle.Flat;
            btnDoAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoAdd.ForeColor = Color.Black;
            btnDoAdd.Image = Properties.Resources.icons8_add_new_30;
            btnDoAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoAdd.Location = new Point(752, 200);
            btnDoAdd.Name = "btnDoAdd";
            btnDoAdd.Padding = new Padding(4, 0, 0, 0);
            btnDoAdd.Size = new Size(125, 37);
            btnDoAdd.TabIndex = 22;
            btnDoAdd.Text = " Thêm mới";
            btnDoAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDoAdd.UseVisualStyleBackColor = false;
            btnDoAdd.Click += btnDoAdd_Click;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rdFemale.ForeColor = Color.Black;
            rdFemale.Location = new Point(752, 99);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(43, 20);
            rdFemale.TabIndex = 18;
            rdFemale.TabStop = true;
            rdFemale.Text = "Nữ";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.FlatAppearance.BorderColor = Color.FromArgb(76, 174, 254);
            rdMale.FlatAppearance.BorderSize = 0;
            rdMale.FlatAppearance.CheckedBackColor = Color.FromArgb(76, 174, 254);
            rdMale.FlatAppearance.MouseDownBackColor = Color.FromArgb(76, 174, 254);
            rdMale.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 174, 254);
            rdMale.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rdMale.ForeColor = Color.Black;
            rdMale.Location = new Point(670, 99);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(56, 20);
            rdMale.TabIndex = 17;
            rdMale.TabStop = true;
            rdMale.Text = "Nam";
            rdMale.UseVisualStyleBackColor = true;
            rdMale.CheckedChanged += rdMale_CheckedChanged;
            // 
            // cboDepartment
            // 
            cboDepartment.ForeColor = Color.DimGray;
            cboDepartment.FormattingEnabled = true;
            cboDepartment.Location = new Point(661, 46);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(178, 25);
            cboDepartment.TabIndex = 16;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.CausesValidation = false;
            txtPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPhone.ForeColor = Color.DimGray;
            txtPhone.Location = new Point(661, 148);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(178, 25);
            txtPhone.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddress.ForeColor = Color.DimGray;
            txtAddress.Location = new Point(208, 196);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(231, 25);
            txtAddress.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.ForeColor = Color.DimGray;
            txtName.Location = new Point(208, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(231, 25);
            txtName.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(551, 100);
            label7.Name = "label7";
            label7.Size = new Size(62, 17);
            label7.TabIndex = 9;
            label7.Text = "Giới tính";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(551, 52);
            label8.Name = "label8";
            label8.Size = new Size(39, 17);
            label8.TabIndex = 10;
            label8.Text = "Khoa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(89, 148);
            label5.Name = "label5";
            label5.Size = new Size(70, 17);
            label5.TabIndex = 7;
            label5.Text = "Ngày sinh";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(89, 200);
            label9.Name = "label9";
            label9.Size = new Size(51, 17);
            label9.TabIndex = 11;
            label9.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(89, 100);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 6;
            label4.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(37, -3);
            label1.Name = "label1";
            label1.Size = new Size(252, 26);
            label1.TabIndex = 1;
            label1.Text = "STUDENT INFORMATION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(89, 52);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 4;
            label3.Text = "Mã số";
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.White;
            txtCode.CausesValidation = false;
            txtCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCode.ForeColor = Color.DimGray;
            txtCode.Location = new Point(208, 45);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(143, 25);
            txtCode.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(551, 148);
            label6.Name = "label6";
            label6.Size = new Size(73, 17);
            label6.TabIndex = 8;
            label6.Text = "Điện thoại";
            // 
            // btnDoDelete
            // 
            btnDoDelete.BackColor = Color.White;
            btnDoDelete.Cursor = Cursors.Hand;
            btnDoDelete.FlatAppearance.BorderColor = Color.Black;
            btnDoDelete.FlatAppearance.CheckedBackColor = Color.Silver;
            btnDoDelete.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnDoDelete.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnDoDelete.FlatStyle = FlatStyle.Flat;
            btnDoDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoDelete.ForeColor = Color.Black;
            btnDoDelete.Image = Properties.Resources.icons8_delete_30;
            btnDoDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoDelete.Location = new Point(778, 200);
            btnDoDelete.Name = "btnDoDelete";
            btnDoDelete.Padding = new Padding(4, 0, 0, 0);
            btnDoDelete.Size = new Size(99, 37);
            btnDoDelete.TabIndex = 26;
            btnDoDelete.Text = "   Xóa";
            btnDoDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDoDelete.UseVisualStyleBackColor = false;
            btnDoDelete.Click += btnDoDelete_Click;
            // 
            // btnDoEdit
            // 
            btnDoEdit.BackColor = Color.White;
            btnDoEdit.Cursor = Cursors.Hand;
            btnDoEdit.FlatAppearance.BorderColor = Color.Black;
            btnDoEdit.FlatAppearance.CheckedBackColor = Color.Silver;
            btnDoEdit.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnDoEdit.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnDoEdit.FlatStyle = FlatStyle.Flat;
            btnDoEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoEdit.ForeColor = Color.Black;
            btnDoEdit.Image = Properties.Resources.icons8_update_30;
            btnDoEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoEdit.Location = new Point(752, 200);
            btnDoEdit.Name = "btnDoEdit";
            btnDoEdit.Padding = new Padding(4, 0, 0, 0);
            btnDoEdit.Size = new Size(125, 37);
            btnDoEdit.TabIndex = 23;
            btnDoEdit.Text = "  Cập nhật";
            btnDoEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDoEdit.UseVisualStyleBackColor = false;
            btnDoEdit.Click += btnDoEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.CheckedBackColor = Color.Gray;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Image = Properties.Resources.icons8_student_center_30;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(1112, 37);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(20, 0, 0, 0);
            btnAdd.Size = new Size(184, 45);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "   Thêm mới";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgStudent
            // 
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dgStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStudent.BackgroundColor = Color.WhiteSmoke;
            dgStudent.BorderStyle = BorderStyle.Fixed3D;
            dgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudent.Location = new Point(113, 390);
            dgStudent.Name = "dgStudent";
            dgStudent.RowHeadersWidth = 51;
            dgStudent.RowTemplate.Height = 25;
            dgStudent.Size = new Size(1183, 442);
            dgStudent.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(113, 308);
            label2.Name = "label2";
            label2.Size = new Size(139, 26);
            label2.TabIndex = 3;
            label2.Text = "STUDENT LIST";
            // 
            // cboDepartmentSearch
            // 
            cboDepartmentSearch.CausesValidation = false;
            cboDepartmentSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboDepartmentSearch.ForeColor = Color.Black;
            cboDepartmentSearch.FormattingEnabled = true;
            cboDepartmentSearch.Location = new Point(391, 350);
            cboDepartmentSearch.Name = "cboDepartmentSearch";
            cboDepartmentSearch.Size = new Size(174, 25);
            cboDepartmentSearch.TabIndex = 17;
            cboDepartmentSearch.SelectedIndexChanged += Search_ValueChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(113, 349);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = " Tìm mã sv,  tên sv, địa chỉ, SĐT";
            txtSearch.Size = new Size(232, 26);
            txtSearch.TabIndex = 18;
            txtSearch.TextChanged += Search_ValueChanged;
            // 
            // cboGenderSearch
            // 
            cboGenderSearch.CausesValidation = false;
            cboGenderSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboGenderSearch.ForeColor = Color.Black;
            cboGenderSearch.FormattingEnabled = true;
            cboGenderSearch.Items.AddRange(new object[] { " Tất cả giới tính", " Nam", " Nữ" });
            cboGenderSearch.Location = new Point(612, 350);
            cboGenderSearch.Name = "cboGenderSearch";
            cboGenderSearch.Size = new Size(142, 25);
            cboGenderSearch.TabIndex = 19;
            cboGenderSearch.SelectedValueChanged += Search_ValueChanged;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.White;
            btnExportExcel.Cursor = Cursors.Hand;
            btnExportExcel.FlatAppearance.CheckedBackColor = Color.Gray;
            btnExportExcel.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnExportExcel.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportExcel.ForeColor = Color.Black;
            btnExportExcel.Image = Properties.Resources.icons8_excel_30;
            btnExportExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportExcel.Location = new Point(1172, 301);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Padding = new Padding(4, 0, 0, 0);
            btnExportExcel.Size = new Size(124, 39);
            btnExportExcel.TabIndex = 27;
            btnExportExcel.Text = "  Xuất Excel";
            btnExportExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(btnEdit);
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(cboSort);
            panel4.Controls.Add(btnExportExcel);
            panel4.Controls.Add(cboGenderSearch);
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(cboDepartmentSearch);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(dgStudent);
            panel4.Controls.Add(gbInfo);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1384, 857);
            panel4.TabIndex = 3;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.CheckedBackColor = Color.Gray;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Image = Properties.Resources.icons8_update_30;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(1112, 100);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(20, 0, 0, 0);
            btnEdit.Size = new Size(184, 45);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "   Chỉnh sửa";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.CheckedBackColor = Color.Gray;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Image = Properties.Resources.icons8_delete_30;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(1112, 164);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(20, 0, 0, 0);
            btnDelete.Size = new Size(184, 45);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "   Xóa";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cboSort
            // 
            cboSort.CausesValidation = false;
            cboSort.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboSort.ForeColor = Color.Black;
            cboSort.FormattingEnabled = true;
            cboSort.Items.AddRange(new object[] { " ID tăng dần", " ID giảm dần", " Tên A - Z", " Tên Z - A" });
            cboSort.Location = new Point(1161, 349);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(135, 25);
            cboSort.TabIndex = 28;
            cboSort.SelectedIndexChanged += Search_ValueChanged;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 857);
            Controls.Add(panel4);
            Name = "Student";
            StartPosition = FormStartPosition.Manual;
            Text = "Student";
            Load += Student_Load;
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgStudent).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbInfo;
        private Button btnDoDelete;
        private DateTimePicker dtpDOB;
        private Button btnDoEdit;
        private Button btnDoAdd;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private ComboBox cboDepartment;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label9;
        private Label label4;
        private Label label1;
        private Label label3;
        private TextBox txtCode;
        private Label label6;
        private DataGridView dgStudent;
        private Label label2;
        private ComboBox cboDepartmentSearch;
        private TextBox txtSearch;
        private ComboBox cboGenderSearch;
        private Button btnExportExcel;
        private Panel panel4;
        private ComboBox cboSort;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}