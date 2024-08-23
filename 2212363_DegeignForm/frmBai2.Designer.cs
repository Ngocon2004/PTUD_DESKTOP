namespace _2212363_DegeignForm
{
    partial class frmBai2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bntChonHang = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bntBohang = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bntTinhTien = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bntChonHang);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(62, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 327);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Hàng Hóa:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Chuột",
            "Bàn Phím ",
            "Máy in",
            "USB Kingmax"});
            this.listBox1.Location = new System.Drawing.Point(14, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(190, 154);
            this.listBox1.TabIndex = 1;
            // 
            // bntChonHang
            // 
            this.bntChonHang.Location = new System.Drawing.Point(229, 119);
            this.bntChonHang.Name = "bntChonHang";
            this.bntChonHang.Size = new System.Drawing.Size(105, 23);
            this.bntChonHang.TabIndex = 2;
            this.bntChonHang.Text = "Chọn Hàng ->";
            this.bntChonHang.UseVisualStyleBackColor = true;
            this.bntChonHang.Click += new System.EventHandler(this.bntChonHang_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblSoTien);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.bntTinhTien);
            this.panel3.Controls.Add(this.bntBohang);
            this.panel3.Controls.Add(this.listBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(432, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 327);
            this.panel3.TabIndex = 2;
            // 
            // bntBohang
            // 
            this.bntBohang.Location = new System.Drawing.Point(3, 119);
            this.bntBohang.Name = "bntBohang";
            this.bntBohang.Size = new System.Drawing.Size(105, 23);
            this.bntBohang.TabIndex = 2;
            this.bntBohang.Text = "<- Bỏ Hàng";
            this.bntBohang.UseVisualStyleBackColor = true;
            this.bntBohang.Click += new System.EventHandler(this.bntBohang_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(142, 54);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(190, 154);
            this.listBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mặt Hàng:";
            // 
            // bntTinhTien
            // 
            this.bntTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bntTinhTien.Location = new System.Drawing.Point(189, 226);
            this.bntTinhTien.Name = "bntTinhTien";
            this.bntTinhTien.Size = new System.Drawing.Size(89, 23);
            this.bntTinhTien.TabIndex = 3;
            this.bntTinhTien.Text = "Tính Tiền";
            this.bntTinhTien.UseVisualStyleBackColor = true;
            this.bntTinhTien.Click += new System.EventHandler(this.bntTinhTien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(3, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng Tiền Thanh Toán:";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSoTien.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSoTien.Location = new System.Drawing.Point(184, 291);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(17, 25);
            this.lblSoTien.TabIndex = 5;
            this.lblSoTien.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 541);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmBai2";
            this.Text = "Bán Hàn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntChonHang;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bntBohang;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntTinhTien;
    }
}