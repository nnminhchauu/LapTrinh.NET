namespace QuanLySachTruyen
{
    partial class ThongKe
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
            this.cbthang = new System.Windows.Forms.ComboBox();
            this.datathongke = new System.Windows.Forms.DataGridView();
            this.bthuy = new System.Windows.Forms.Button();
            this.bttao = new System.Windows.Forms.Button();
            this.lbldoanhthu = new System.Windows.Forms.Label();
            this.lblTheLoaiNhieuNhat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datathongke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng";
            // 
            // cbthang
            // 
            this.cbthang.FormattingEnabled = true;
            this.cbthang.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cbthang.Location = new System.Drawing.Point(227, 53);
            this.cbthang.Name = "cbthang";
            this.cbthang.Size = new System.Drawing.Size(185, 28);
            this.cbthang.TabIndex = 1;
            // 
            // datathongke
            // 
            this.datathongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datathongke.Location = new System.Drawing.Point(98, 161);
            this.datathongke.Name = "datathongke";
            this.datathongke.RowHeadersWidth = 62;
            this.datathongke.RowTemplate.Height = 28;
            this.datathongke.Size = new System.Drawing.Size(627, 193);
            this.datathongke.TabIndex = 2;
            // 
            // bthuy
            // 
            this.bthuy.Location = new System.Drawing.Point(247, 398);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(98, 40);
            this.bthuy.TabIndex = 3;
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // bttao
            // 
            this.bttao.Location = new System.Drawing.Point(461, 397);
            this.bttao.Name = "bttao";
            this.bttao.Size = new System.Drawing.Size(96, 41);
            this.bttao.TabIndex = 4;
            this.bttao.Text = "Tạo";
            this.bttao.UseVisualStyleBackColor = true;
            this.bttao.Click += new System.EventHandler(this.bttao_Click);
            // 
            // lbldoanhthu
            // 
            this.lbldoanhthu.AutoSize = true;
            this.lbldoanhthu.Location = new System.Drawing.Point(166, 96);
            this.lbldoanhthu.Name = "lbldoanhthu";
            this.lbldoanhthu.Size = new System.Drawing.Size(0, 20);
            this.lbldoanhthu.TabIndex = 5;
            // 
            // lblTheLoaiNhieuNhat
            // 
            this.lblTheLoaiNhieuNhat.AutoSize = true;
            this.lblTheLoaiNhieuNhat.Location = new System.Drawing.Point(358, 109);
            this.lblTheLoaiNhieuNhat.Name = "lblTheLoaiNhieuNhat";
            this.lblTheLoaiNhieuNhat.Size = new System.Drawing.Size(0, 20);
            this.lblTheLoaiNhieuNhat.TabIndex = 6;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTheLoaiNhieuNhat);
            this.Controls.Add(this.lbldoanhthu);
            this.Controls.Add(this.bttao);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.datathongke);
            this.Controls.Add(this.cbthang);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datathongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbthang;
        private System.Windows.Forms.DataGridView datathongke;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button bttao;
        private System.Windows.Forms.Label lbldoanhthu;
        private System.Windows.Forms.Label lblTheLoaiNhieuNhat;
    }
}