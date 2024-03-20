namespace Project
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            btnExit = new Button();
            btnDepartmentStudent = new Button();
            btnStudentMark = new Button();
            btnInputMark = new Button();
            btnSubject = new Button();
            btnDepartment = new Button();
            btnStudent = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            panelBody = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBody.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnDepartmentStudent);
            panel1.Controls.Add(btnStudentMark);
            panel1.Controls.Add(btnInputMark);
            panel1.Controls.Add(btnSubject);
            panel1.Controls.Add(btnDepartment);
            panel1.Controls.Add(btnStudent);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 950);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Black;
            btnExit.Image = Properties.Resources.icons8_logout_50;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 865);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(35, 0, 0, 0);
            btnExit.Size = new Size(300, 85);
            btnExit.TabIndex = 7;
            btnExit.Text = "  Thoát";
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseHover += btn_MouseHover;
            // 
            // btnDepartmentStudent
            // 
            btnDepartmentStudent.BackColor = Color.White;
            btnDepartmentStudent.Cursor = Cursors.Hand;
            btnDepartmentStudent.Dock = DockStyle.Top;
            btnDepartmentStudent.FlatAppearance.BorderSize = 0;
            btnDepartmentStudent.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnDepartmentStudent.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnDepartmentStudent.FlatStyle = FlatStyle.Flat;
            btnDepartmentStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepartmentStudent.ForeColor = Color.Black;
            btnDepartmentStudent.Image = Properties.Resources.icons8_laptop_metrics_50;
            btnDepartmentStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepartmentStudent.Location = new Point(0, 631);
            btnDepartmentStudent.Name = "btnDepartmentStudent";
            btnDepartmentStudent.Padding = new Padding(35, 0, 0, 0);
            btnDepartmentStudent.Size = new Size(300, 85);
            btnDepartmentStudent.TabIndex = 6;
            btnDepartmentStudent.Text = "  Thống kê";
            btnDepartmentStudent.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepartmentStudent.UseVisualStyleBackColor = false;
            btnDepartmentStudent.Click += btnDepartmentStudent_Click;
            btnDepartmentStudent.MouseEnter += btnExit_MouseEnter;
            btnDepartmentStudent.MouseHover += btn_MouseHover;
            // 
            // btnStudentMark
            // 
            btnStudentMark.BackColor = Color.White;
            btnStudentMark.Cursor = Cursors.Hand;
            btnStudentMark.Dock = DockStyle.Top;
            btnStudentMark.FlatAppearance.BorderSize = 0;
            btnStudentMark.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnStudentMark.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnStudentMark.FlatStyle = FlatStyle.Flat;
            btnStudentMark.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudentMark.ForeColor = Color.Black;
            btnStudentMark.Image = Properties.Resources.icons8_search_property_50;
            btnStudentMark.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudentMark.Location = new Point(0, 546);
            btnStudentMark.Name = "btnStudentMark";
            btnStudentMark.Padding = new Padding(35, 0, 0, 0);
            btnStudentMark.Size = new Size(300, 85);
            btnStudentMark.TabIndex = 5;
            btnStudentMark.Text = "  Tra cứu điểm";
            btnStudentMark.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStudentMark.UseVisualStyleBackColor = false;
            btnStudentMark.Click += btnStudentMark_Click;
            btnStudentMark.MouseEnter += btnExit_MouseEnter;
            btnStudentMark.MouseHover += btn_MouseHover;
            // 
            // btnInputMark
            // 
            btnInputMark.BackColor = Color.White;
            btnInputMark.Cursor = Cursors.Hand;
            btnInputMark.Dock = DockStyle.Top;
            btnInputMark.FlatAppearance.BorderSize = 0;
            btnInputMark.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnInputMark.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnInputMark.FlatStyle = FlatStyle.Flat;
            btnInputMark.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInputMark.ForeColor = Color.Black;
            btnInputMark.Image = Properties.Resources.icons8_writing_50;
            btnInputMark.ImageAlign = ContentAlignment.MiddleLeft;
            btnInputMark.Location = new Point(0, 461);
            btnInputMark.Name = "btnInputMark";
            btnInputMark.Padding = new Padding(35, 0, 0, 0);
            btnInputMark.Size = new Size(300, 85);
            btnInputMark.TabIndex = 4;
            btnInputMark.Text = "  Nhập điểm";
            btnInputMark.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInputMark.UseVisualStyleBackColor = false;
            btnInputMark.Click += btnInputMark_Click;
            btnInputMark.MouseEnter += btnExit_MouseEnter;
            btnInputMark.MouseHover += btn_MouseHover;
            // 
            // btnSubject
            // 
            btnSubject.BackColor = Color.White;
            btnSubject.Cursor = Cursors.Hand;
            btnSubject.Dock = DockStyle.Top;
            btnSubject.FlatAppearance.BorderSize = 0;
            btnSubject.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnSubject.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnSubject.FlatStyle = FlatStyle.Flat;
            btnSubject.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubject.ForeColor = Color.Black;
            btnSubject.Image = Properties.Resources.icons8_book_50;
            btnSubject.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubject.Location = new Point(0, 376);
            btnSubject.Name = "btnSubject";
            btnSubject.Padding = new Padding(35, 0, 0, 0);
            btnSubject.Size = new Size(300, 85);
            btnSubject.TabIndex = 3;
            btnSubject.Text = "  Môn học";
            btnSubject.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSubject.UseVisualStyleBackColor = false;
            btnSubject.Click += btnSubject_Click;
            btnSubject.MouseEnter += btnExit_MouseEnter;
            btnSubject.MouseHover += btn_MouseHover;
            // 
            // btnDepartment
            // 
            btnDepartment.BackColor = Color.White;
            btnDepartment.Cursor = Cursors.Hand;
            btnDepartment.Dock = DockStyle.Top;
            btnDepartment.FlatAppearance.BorderSize = 0;
            btnDepartment.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnDepartment.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnDepartment.FlatStyle = FlatStyle.Flat;
            btnDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepartment.ForeColor = Color.Black;
            btnDepartment.Image = Properties.Resources.icons8_department_50;
            btnDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepartment.Location = new Point(0, 291);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Padding = new Padding(35, 0, 0, 0);
            btnDepartment.Size = new Size(300, 85);
            btnDepartment.TabIndex = 2;
            btnDepartment.Text = "  Khoa";
            btnDepartment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepartment.UseVisualStyleBackColor = false;
            btnDepartment.Click += btnDepartment_Click;
            btnDepartment.MouseEnter += btnExit_MouseEnter;
            btnDepartment.MouseHover += btn_MouseHover;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.White;
            btnStudent.Cursor = Cursors.Hand;
            btnStudent.Dock = DockStyle.Top;
            btnStudent.FlatAppearance.BorderSize = 0;
            btnStudent.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnStudent.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudent.ForeColor = Color.Black;
            btnStudent.Image = Properties.Resources.icons8_student_50;
            btnStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudent.Location = new Point(0, 206);
            btnStudent.Name = "btnStudent";
            btnStudent.Padding = new Padding(35, 0, 0, 0);
            btnStudent.Size = new Size(300, 85);
            btnStudent.TabIndex = 0;
            btnStudent.Text = "  Sinh Viên";
            btnStudent.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            btnStudent.MouseEnter += btnExit_MouseEnter;
            btnStudent.MouseHover += btn_MouseHover;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 206);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fpt_png1;
            pictureBox1.Location = new Point(27, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(5);
            pictureBox1.Size = new Size(245, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Dock = DockStyle.Left;
            panel3.ForeColor = SystemColors.Desktop;
            panel3.Location = new Point(300, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 950);
            panel3.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1882, 3);
            panel6.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(28, 36);
            label1.Name = "label1";
            label1.Size = new Size(413, 41);
            label1.TabIndex = 1;
            label1.Text = "STUDENT MANAGEMENT";
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.White;
            panelBody.BackgroundImageLayout = ImageLayout.Zoom;
            panelBody.Controls.Add(label1);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panelBody.ForeColor = Color.Black;
            panelBody.Location = new Point(305, 3);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1577, 950);
            panelBody.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1882, 953);
            Controls.Add(panelBody);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel6);
            DoubleBuffered = true;
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(113, 96, 232);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "STUDENT MANAGEMENT";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnDepartmentStudent;
        private Button btnStudentMark;
        private Button btnInputMark;
        private Button btnSubject;
        private Button btnDepartment;
        private Button btnStudent;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel6;
        private Label label1;
        private Panel panelBody;
    }
}