namespace Bai2
{
    partial class frmThongBaoGV
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
            this.lblTHongBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTHongBao
            // 
            this.lblTHongBao.AutoSize = true;
            this.lblTHongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTHongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTHongBao.Location = new System.Drawing.Point(51, 48);
            this.lblTHongBao.Name = "lblTHongBao";
            this.lblTHongBao.Size = new System.Drawing.Size(46, 17);
            this.lblTHongBao.TabIndex = 0;
            this.lblTHongBao.Text = "label1";
            // 
            // frmThongBaoGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTHongBao);
            this.Name = "frmThongBaoGV";
            this.Text = "Thông tin giáo vien nhập";
            this.Load += new System.EventHandler(this.lblThongBao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTHongBao;
    }
}