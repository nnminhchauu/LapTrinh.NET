namespace NhanVien
{
    partial class NhanVien
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            checkBox1 = new CheckBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(227, 27);
            label1.Name = "label1";
            label1.Size = new Size(339, 32);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(142, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(142, 240);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(507, 80);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 83);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 6;
            label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 137);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 7;
            label3.Text = "Tên nhân viên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 192);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 8;
            label4.Text = "Ca làm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 243);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 9;
            label5.Text = "Lương tháng: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(420, 83);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 10;
            label6.Text = "Địa chỉ: ";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(507, 134);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 11;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(507, 189);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 27);
            maskedTextBox2.TabIndex = 12;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(420, 137);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 13;
            label7.Text = "Điện thoại:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(420, 192);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 14;
            label8.Text = "Ngày sinh: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(429, 243);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 15;
            label9.Text = "Giới tính: ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(507, 243);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 24);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Nam";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 293);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(642, 86);
            dataGridView1.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(67, 406);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 18;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(227, 406);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 19;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(388, 406);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 20;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(527, 406);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 21;
            button4.Text = "Lưu";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(669, 406);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 22;
            button5.Text = "Đóng";
            button5.UseVisualStyleBackColor = true;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(checkBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "NhanVien";
            Text = "Form1";
            Load += NhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckBox checkBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
