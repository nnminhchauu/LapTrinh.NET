namespace QuanLySachTruyen
{
    partial class DangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.btdangnhap = new System.Windows.Forms.Button();
            this.btdangky = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(180, 23);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20);
            this.label1.Size = new System.Drawing.Size(460, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG MƯỢN SÁCH ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(214, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(377, 136);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(153, 26);
            this.txttendangnhap.TabIndex = 1;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(377, 184);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(153, 26);
            this.txtmatkhau.TabIndex = 2;
            // 
            // btdangnhap
            // 
            this.btdangnhap.Location = new System.Drawing.Point(265, 299);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(116, 37);
            this.btdangnhap.TabIndex = 3;
            this.btdangnhap.Text = "Đăng nhập";
            this.btdangnhap.UseVisualStyleBackColor = true;
            // 
            // btdangky
            // 
            this.btdangky.Location = new System.Drawing.Point(447, 299);
            this.btdangky.Name = "btdangky";
            this.btdangky.Size = new System.Drawing.Size(108, 37);
            this.btdangky.TabIndex = 4;
            this.btdangky.Text = "Đăng ký";
            this.btdangky.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(214, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên đăng nhập";
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btdangky);
            this.Controls.Add(this.btdangnhap);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dangnhap";
            this.Text = "Dangnhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.Button btdangky;
        private System.Windows.Forms.Label label3;
    }
}