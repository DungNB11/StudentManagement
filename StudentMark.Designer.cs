namespace Project
{
    partial class StudentMark
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgMark = new DataGridView();
            txtStudentName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            cboStudentCode = new ComboBox();
            txtAverage = new TextBox();
            label5 = new Label();
            btnExportExcel = new Button();
            cboDepartment = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgMark).BeginInit();
            SuspendLayout();
            // 
            // dgMark
            // 
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dgMark.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgMark.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMark.BackgroundColor = Color.White;
            dgMark.BorderStyle = BorderStyle.Fixed3D;
            dgMark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMark.Location = new Point(141, 274);
            dgMark.Name = "dgMark";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgMark.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgMark.RowHeadersWidth = 51;
            dgMark.RowTemplate.Height = 25;
            dgMark.Size = new Size(872, 399);
            dgMark.TabIndex = 3;
            // 
            // txtStudentName
            // 
            txtStudentName.BackColor = Color.White;
            txtStudentName.Enabled = false;
            txtStudentName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudentName.ForeColor = Color.DimGray;
            txtStudentName.Location = new Point(328, 135);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(231, 27);
            txtStudentName.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(171, 137);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 15;
            label4.Text = "TÊN SINH VIÊN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(171, 94);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 13;
            label3.Text = "MÃ SINH VIÊN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(171, 50);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 17;
            label1.Text = "KHOA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(141, 214);
            label2.Name = "label2";
            label2.Size = new Size(194, 32);
            label2.TabIndex = 19;
            label2.Text = "MARK REPORT";
            // 
            // cboStudentCode
            // 
            cboStudentCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboStudentCode.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboStudentCode.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cboStudentCode.ForeColor = Color.DimGray;
            cboStudentCode.FormattingEnabled = true;
            cboStudentCode.Location = new Point(328, 92);
            cboStudentCode.Margin = new Padding(3, 2, 3, 2);
            cboStudentCode.Name = "cboStudentCode";
            cboStudentCode.Size = new Size(231, 27);
            cboStudentCode.TabIndex = 32;
            cboStudentCode.SelectedValueChanged += cboStudentCode_SelectedValueChanged;
            // 
            // txtAverage
            // 
            txtAverage.BackColor = Color.White;
            txtAverage.Enabled = false;
            txtAverage.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtAverage.ForeColor = Color.DimGray;
            txtAverage.Location = new Point(1200, 278);
            txtAverage.MaxLength = 4;
            txtAverage.Name = "txtAverage";
            txtAverage.Size = new Size(141, 27);
            txtAverage.TabIndex = 34;
            txtAverage.TextChanged += txtAverage_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(1048, 281);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 33;
            label5.Text = "ĐIỂM TRUNG BÌNH";
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
            btnExportExcel.Location = new Point(888, 214);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Padding = new Padding(4, 0, 0, 0);
            btnExportExcel.Size = new Size(124, 35);
            btnExportExcel.TabIndex = 35;
            btnExportExcel.Text = " Xuất Excel";
            btnExportExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // cboDepartment
            // 
            cboDepartment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboDepartment.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboDepartment.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cboDepartment.ForeColor = Color.DimGray;
            cboDepartment.FormattingEnabled = true;
            cboDepartment.Location = new Point(328, 48);
            cboDepartment.Margin = new Padding(3, 2, 3, 2);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(231, 27);
            cboDepartment.TabIndex = 36;
            cboDepartment.SelectedValueChanged += cboDepartment_SelectedValueChanged;
            // 
            // StudentMark
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 715);
            Controls.Add(cboDepartment);
            Controls.Add(btnExportExcel);
            Controls.Add(txtAverage);
            Controls.Add(label5);
            Controls.Add(cboStudentCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtStudentName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgMark);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentMark";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentMark";
            Load += StudentMark_Load;
            ((System.ComponentModel.ISupportInitialize)dgMark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgMark;
        private TextBox txtStudentName;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private ComboBox cboStudentCode;
        private TextBox txtAverage;
        private Label label5;
        private Button btnExportExcel;
        private ComboBox cboDepartment;
    }
}