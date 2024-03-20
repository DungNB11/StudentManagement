namespace Project
{
    partial class Statistic
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
            pie1 = new ScottPlot.FormsPlot();
            pie2 = new ScottPlot.FormsPlot();
            label2 = new Label();
            label1 = new Label();
            pie3 = new ScottPlot.FormsPlot();
            pie4 = new ScottPlot.FormsPlot();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtQuit = new TextBox();
            SuspendLayout();
            // 
            // pie1
            // 
            pie1.BackColor = Color.Transparent;
            pie1.Location = new Point(21, 10);
            pie1.Margin = new Padding(4, 3, 4, 3);
            pie1.Name = "pie1";
            pie1.Size = new Size(420, 298);
            pie1.TabIndex = 0;
            // 
            // pie2
            // 
            pie2.BackColor = Color.Transparent;
            pie2.Location = new Point(525, 10);
            pie2.Margin = new Padding(4, 3, 4, 3);
            pie2.Name = "pie2";
            pie2.Size = new Size(399, 298);
            pie2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(598, 331);
            label2.Name = "label2";
            label2.Size = new Size(265, 32);
            label2.TabIndex = 3;
            label2.Text = "SINH VIÊN CÁC KHOA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(128, 331);
            label1.Name = "label1";
            label1.Size = new Size(193, 32);
            label1.TabIndex = 2;
            label1.Text = "TỈ LỆ GIỚI TÍNH";
            // 
            // pie3
            // 
            pie3.BackColor = Color.Transparent;
            pie3.Location = new Point(21, 378);
            pie3.Margin = new Padding(4, 3, 4, 3);
            pie3.Name = "pie3";
            pie3.Size = new Size(420, 308);
            pie3.TabIndex = 4;
            // 
            // pie4
            // 
            pie4.BackColor = Color.Transparent;
            pie4.Location = new Point(527, 383);
            pie4.Margin = new Padding(4, 3, 4, 3);
            pie4.Name = "pie4";
            pie4.Size = new Size(397, 303);
            pie4.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(136, 689);
            label3.Name = "label3";
            label3.Size = new Size(204, 32);
            label3.TabIndex = 6;
            label3.Text = "TỈ LỆ ĐỖ/TRƯỢT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(593, 689);
            label4.Name = "label4";
            label4.Size = new Size(269, 32);
            label4.TabIndex = 7;
            label4.Text = "TỈ LỆ CHUYỂN NGÀNH";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(971, 403);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 8;
            label5.Text = "THÔI HỌC";
            // 
            // txtQuit
            // 
            txtQuit.Enabled = false;
            txtQuit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuit.Location = new Point(1093, 403);
            txtQuit.Margin = new Padding(3, 2, 3, 2);
            txtQuit.Name = "txtQuit";
            txtQuit.Size = new Size(110, 29);
            txtQuit.TabIndex = 9;
            // 
            // Statistic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 753);
            Controls.Add(txtQuit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pie4);
            Controls.Add(pie3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pie2);
            Controls.Add(pie1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Statistic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DepartmentStudent";
            Load += Statistic_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.FormsPlot pie1;
        private ScottPlot.FormsPlot pie2;
        private Label label2;
        private Label label1;
        private ScottPlot.FormsPlot pie3;
        private ScottPlot.FormsPlot pie4;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtQuit;
    }
}