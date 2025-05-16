namespace baitaplon
{
    partial class Vipham
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
            this.datavipham = new System.Windows.Forms.DataGridView();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmavipham = new System.Windows.Forms.TextBox();
            this.txttenvipham = new System.Windows.Forms.TextBox();
            this.bthuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datavipham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(194, 11);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20);
            this.label1.Size = new System.Drawing.Size(460, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG MƯỢN SÁCH ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã vi phạm";
            // 
            // datavipham
            // 
            this.datavipham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datavipham.Location = new System.Drawing.Point(52, 268);
            this.datavipham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datavipham.Name = "datavipham";
            this.datavipham.RowHeadersWidth = 62;
            this.datavipham.RowTemplate.Height = 28;
            this.datavipham.Size = new System.Drawing.Size(660, 160);
            this.datavipham.TabIndex = 3;
            this.datavipham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datavipham_CellContentClick);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(35, 492);
            this.btthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(80, 35);
            this.btthem.TabIndex = 4;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(158, 492);
            this.btsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(83, 35);
            this.btsua.TabIndex = 4;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(279, 492);
            this.btxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(78, 35);
            this.btxoa.TabIndex = 4;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btluu
            // 
            this.btluu.Location = new System.Drawing.Point(390, 492);
            this.btluu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(81, 35);
            this.btluu.TabIndex = 4;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(624, 492);
            this.btthoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(86, 35);
            this.btthoat.TabIndex = 4;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên vi phạm";
            // 
            // txtmavipham
            // 
            this.txtmavipham.Location = new System.Drawing.Point(291, 130);
            this.txtmavipham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmavipham.Name = "txtmavipham";
            this.txtmavipham.ShortcutsEnabled = false;
            this.txtmavipham.Size = new System.Drawing.Size(112, 26);
            this.txtmavipham.TabIndex = 5;
            // 
            // txttenvipham
            // 
            this.txttenvipham.Location = new System.Drawing.Point(291, 192);
            this.txttenvipham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttenvipham.Name = "txttenvipham";
            this.txttenvipham.Size = new System.Drawing.Size(112, 26);
            this.txttenvipham.TabIndex = 5;
            // 
            // bthuy
            // 
            this.bthuy.Location = new System.Drawing.Point(512, 492);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(85, 34);
            this.bthuy.TabIndex = 6;
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // Vipham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.txttenvipham);
            this.Controls.Add(this.txtmavipham);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.datavipham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Vipham";
            this.Text = "vipham";
            this.Load += new System.EventHandler(this.Vipham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datavipham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datavipham;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmavipham;
        private System.Windows.Forms.TextBox txttenvipham;
        private System.Windows.Forms.Button bthuy;
    }
}