namespace Project
{
    partial class Subject
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
            panel4 = new Panel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExportExcel = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            dgSubject = new DataGridView();
            groupBox1 = new GroupBox();
            btnDoDelete = new Button();
            numSlot = new NumericUpDown();
            label5 = new Label();
            btnDoEdit = new Button();
            btnDoAdd = new Button();
            txtName = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtCode = new TextBox();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSubject).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSlot).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(btnEdit);
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(btnExportExcel);
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(dgSubject);
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1384, 715);
            panel4.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.Black;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Black;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Image = Properties.Resources.icons8_add_new_30;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(853, 55);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(20, 0, 0, 0);
            btnAdd.Size = new Size(184, 45);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "   Thêm mới";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.Black;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.Black;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Image = Properties.Resources.icons8_update_30;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(853, 118);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(20, 0, 0, 0);
            btnEdit.Size = new Size(184, 45);
            btnEdit.TabIndex = 31;
            btnEdit.Text = "   Chỉnh sửa";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.Black;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Black;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Image = Properties.Resources.icons8_delete_30;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(853, 182);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(20, 0, 0, 0);
            btnDelete.Size = new Size(184, 45);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "   Xóa";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.White;
            btnExportExcel.Cursor = Cursors.Hand;
            btnExportExcel.FlatAppearance.BorderColor = Color.Black;
            btnExportExcel.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnExportExcel.FlatAppearance.MouseOverBackColor = Color.Black;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportExcel.ForeColor = Color.Black;
            btnExportExcel.Image = Properties.Resources.icons8_excel_30;
            btnExportExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportExcel.Location = new Point(956, 289);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Padding = new Padding(4, 0, 0, 0);
            btnExportExcel.Size = new Size(124, 39);
            btnExportExcel.TabIndex = 29;
            btnExportExcel.Text = " Xuất Excel";
            btnExportExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(122, 304);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = " Tìm mã môn, tên môn";
            txtSearch.Size = new Size(214, 26);
            txtSearch.TabIndex = 19;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(122, 268);
            label2.Name = "label2";
            label2.Size = new Size(140, 26);
            label2.TabIndex = 3;
            label2.Text = "SUBJECT LIST";
            // 
            // dgSubject
            // 
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dgSubject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgSubject.BackgroundColor = Color.WhiteSmoke;
            dgSubject.BorderStyle = BorderStyle.Fixed3D;
            dgSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSubject.Location = new Point(122, 338);
            dgSubject.Name = "dgSubject";
            dgSubject.RowHeadersWidth = 51;
            dgSubject.RowTemplate.Height = 25;
            dgSubject.Size = new Size(959, 331);
            dgSubject.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDoDelete);
            groupBox1.Controls.Add(numSlot);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnDoEdit);
            groupBox1.Controls.Add(btnDoAdd);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCode);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(76, 174, 254);
            groupBox1.Location = new Point(122, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(616, 195);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // btnDoDelete
            // 
            btnDoDelete.BackColor = Color.White;
            btnDoDelete.Cursor = Cursors.Hand;
            btnDoDelete.FlatAppearance.BorderColor = Color.Black;
            btnDoDelete.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnDoDelete.FlatAppearance.MouseOverBackColor = Color.Black;
            btnDoDelete.FlatStyle = FlatStyle.Flat;
            btnDoDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoDelete.ForeColor = Color.Black;
            btnDoDelete.Image = Properties.Resources.icons8_delete_30;
            btnDoDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoDelete.Location = new Point(466, 139);
            btnDoDelete.Name = "btnDoDelete";
            btnDoDelete.Padding = new Padding(4, 0, 0, 0);
            btnDoDelete.Size = new Size(99, 37);
            btnDoDelete.TabIndex = 28;
            btnDoDelete.Text = "   Xóa";
            btnDoDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDoDelete.UseVisualStyleBackColor = false;
            btnDoDelete.Click += btnDoDelete_Click;
            // 
            // numSlot
            // 
            numSlot.CausesValidation = false;
            numSlot.ForeColor = Color.DimGray;
            numSlot.Location = new Point(434, 54);
            numSlot.Margin = new Padding(3, 2, 3, 2);
            numSlot.Name = "numSlot";
            numSlot.Size = new Size(131, 25);
            numSlot.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(346, 54);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 22;
            label5.Text = "Số tiết";
            // 
            // btnDoEdit
            // 
            btnDoEdit.BackColor = Color.White;
            btnDoEdit.Cursor = Cursors.Hand;
            btnDoEdit.FlatAppearance.BorderColor = Color.Black;
            btnDoEdit.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnDoEdit.FlatAppearance.MouseOverBackColor = Color.Black;
            btnDoEdit.FlatStyle = FlatStyle.Flat;
            btnDoEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoEdit.ForeColor = Color.Black;
            btnDoEdit.Image = Properties.Resources.icons8_update_30;
            btnDoEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoEdit.Location = new Point(440, 139);
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
            btnDoAdd.Location = new Point(440, 139);
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
            txtName.Location = new Point(144, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(173, 25);
            txtName.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(37, 102);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 6;
            label4.Text = "Tên môn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(37, -2);
            label1.Name = "label1";
            label1.Size = new Size(253, 26);
            label1.TabIndex = 1;
            label1.Text = "SUBJECT INFORMATION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(37, 54);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 4;
            label3.Text = "Mã môn";
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.White;
            txtCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCode.ForeColor = Color.DimGray;
            txtCode.Location = new Point(144, 50);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(143, 25);
            txtCode.TabIndex = 5;
            // 
            // Subject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 715);
            Controls.Add(panel4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Subject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Subject";
            Load += Subject_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgSubject).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSlot).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Label label2;
        private DataGridView dgSubject;
        private GroupBox groupBox1;
        private NumericUpDown numSlot;
        private Label label5;
        private Button btnDoEdit;
        private Button btnDoAdd;
        private TextBox txtName;
        private Label label4;
        private Label label1;
        private Label label3;
        private TextBox txtCode;
        private Button btnDoDelete;
        private TextBox txtSearch;
        private Button btnExportExcel;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}