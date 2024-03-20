namespace Project
{
    partial class InputMark
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
            label3 = new Label();
            label4 = new Label();
            txtStudentName = new TextBox();
            txtSubjectName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            btnDoAdd = new Button();
            gbInfor = new GroupBox();
            numMark = new NumericUpDown();
            cboSubjectCode = new ComboBox();
            cboStudentCode = new ComboBox();
            btnDoDelete = new Button();
            dgMark = new DataGridView();
            label6 = new Label();
            btnDelete = new Button();
            btnAdd = new Button();
            gbInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMark).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgMark).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(63, 36);
            label3.Name = "label3";
            label3.Size = new Size(87, 17);
            label3.TabIndex = 17;
            label3.Text = "Mã sinh viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(63, 76);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 19;
            label4.Text = "Họ tên";
            // 
            // txtStudentName
            // 
            txtStudentName.BackColor = Color.White;
            txtStudentName.Enabled = false;
            txtStudentName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudentName.ForeColor = Color.DimGray;
            txtStudentName.Location = new Point(186, 76);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(281, 25);
            txtStudentName.TabIndex = 20;
            // 
            // txtSubjectName
            // 
            txtSubjectName.BackColor = Color.White;
            txtSubjectName.Enabled = false;
            txtSubjectName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubjectName.ForeColor = Color.DimGray;
            txtSubjectName.Location = new Point(186, 161);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(317, 25);
            txtSubjectName.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(63, 164);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 26;
            label1.Text = "Tên môn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(63, 118);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 24;
            label2.Text = "Mã môn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(63, 208);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 28;
            label5.Text = "Điểm";
            // 
            // btnDoAdd
            // 
            btnDoAdd.BackColor = Color.White;
            btnDoAdd.Cursor = Cursors.Hand;
            btnDoAdd.FlatAppearance.BorderColor = Color.Black;
            btnDoAdd.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnDoAdd.FlatAppearance.MouseOverBackColor = Color.Black;
            btnDoAdd.FlatStyle = FlatStyle.Flat;
            btnDoAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoAdd.ForeColor = Color.Black;
            btnDoAdd.Image = Properties.Resources.icons8_pen_30;
            btnDoAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoAdd.Location = new Point(653, 277);
            btnDoAdd.Name = "btnDoAdd";
            btnDoAdd.Padding = new Padding(4, 0, 0, 0);
            btnDoAdd.Size = new Size(127, 37);
            btnDoAdd.TabIndex = 30;
            btnDoAdd.Text = " Nhập điểm";
            btnDoAdd.UseVisualStyleBackColor = false;
            btnDoAdd.Click += btnDoAdd_Click;
            // 
            // gbInfor
            // 
            gbInfor.BackColor = Color.Transparent;
            gbInfor.Controls.Add(numMark);
            gbInfor.Controls.Add(cboSubjectCode);
            gbInfor.Controls.Add(cboStudentCode);
            gbInfor.Controls.Add(label5);
            gbInfor.Controls.Add(label3);
            gbInfor.Controls.Add(txtSubjectName);
            gbInfor.Controls.Add(label1);
            gbInfor.Controls.Add(label4);
            gbInfor.Controls.Add(label2);
            gbInfor.Controls.Add(txtStudentName);
            gbInfor.FlatStyle = FlatStyle.Popup;
            gbInfor.Location = new Point(184, 28);
            gbInfor.Margin = new Padding(3, 2, 3, 2);
            gbInfor.Name = "gbInfor";
            gbInfor.Padding = new Padding(3, 2, 3, 2);
            gbInfor.Size = new Size(640, 264);
            gbInfor.TabIndex = 31;
            gbInfor.TabStop = false;
            // 
            // numMark
            // 
            numMark.CausesValidation = false;
            numMark.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            numMark.ForeColor = Color.DimGray;
            numMark.Location = new Point(186, 208);
            numMark.Margin = new Padding(3, 2, 3, 2);
            numMark.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numMark.Name = "numMark";
            numMark.Size = new Size(180, 25);
            numMark.TabIndex = 32;
            // 
            // cboSubjectCode
            // 
            cboSubjectCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboSubjectCode.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboSubjectCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboSubjectCode.ForeColor = Color.DimGray;
            cboSubjectCode.FormattingEnabled = true;
            cboSubjectCode.Location = new Point(186, 118);
            cboSubjectCode.Margin = new Padding(3, 2, 3, 2);
            cboSubjectCode.Name = "cboSubjectCode";
            cboSubjectCode.Size = new Size(181, 25);
            cboSubjectCode.TabIndex = 31;
            cboSubjectCode.SelectedValueChanged += cboSubjectCode_SelectedValueChanged;
            // 
            // cboStudentCode
            // 
            cboStudentCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboStudentCode.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboStudentCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboStudentCode.ForeColor = Color.DimGray;
            cboStudentCode.FormattingEnabled = true;
            cboStudentCode.Location = new Point(186, 36);
            cboStudentCode.Margin = new Padding(3, 2, 3, 2);
            cboStudentCode.Name = "cboStudentCode";
            cboStudentCode.Size = new Size(181, 25);
            cboStudentCode.TabIndex = 30;
            cboStudentCode.SelectedValueChanged += cboStudentCode_SelectedValueChanged;
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
            btnDoDelete.Location = new Point(681, 277);
            btnDoDelete.Name = "btnDoDelete";
            btnDoDelete.Padding = new Padding(4, 0, 0, 0);
            btnDoDelete.Size = new Size(99, 37);
            btnDoDelete.TabIndex = 34;
            btnDoDelete.Text = "   Xóa";
            btnDoDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDoDelete.UseVisualStyleBackColor = false;
            btnDoDelete.Click += btnDoDelete_Click;
            // 
            // dgMark
            // 
            dgMark.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMark.BackgroundColor = Color.White;
            dgMark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMark.Location = new Point(184, 406);
            dgMark.Margin = new Padding(3, 2, 3, 2);
            dgMark.Name = "dgMark";
            dgMark.RowHeadersWidth = 51;
            dgMark.RowTemplate.Height = 29;
            dgMark.Size = new Size(858, 290);
            dgMark.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(184, 350);
            label6.Name = "label6";
            label6.Size = new Size(206, 32);
            label6.TabIndex = 36;
            label6.Text = "STUDENT MARK";
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
            btnDelete.Location = new Point(858, 134);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(20, 0, 0, 0);
            btnDelete.Size = new Size(184, 45);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "   Xóa điểm";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            btnAdd.Image = Properties.Resources.icons8_pen_30;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(858, 64);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(20, 0, 0, 0);
            btnAdd.Size = new Size(184, 45);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "   Nhập điểm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // InputMark
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 715);
            Controls.Add(btnDelete);
            Controls.Add(label6);
            Controls.Add(dgMark);
            Controls.Add(btnAdd);
            Controls.Add(btnDoDelete);
            Controls.Add(btnDoAdd);
            Controls.Add(gbInfor);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "InputMark";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Input Mark";
            Load += InputMark_Load;
            gbInfor.ResumeLayout(false);
            gbInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMark).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgMark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private TextBox txtStudentName;
        private TextBox txtSubjectName;
        private Label label1;
        private Label label2;
        private Label label5;
        private Button btnDoAdd;
        private GroupBox gbInfor;
        private ComboBox cboSubjectCode;
        private ComboBox cboStudentCode;
        private NumericUpDown numMark;
        private Button btnDoDelete;
        private DataGridView dgMark;
        private Label label6;
        private Button btnDelete;
        private Button btnAdd;
    }
}