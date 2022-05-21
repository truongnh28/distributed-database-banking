
namespace DDB_NGANHANG
{
    partial class ChuyenChiNhanhForm
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
            this.thoatChuyenBtn = new System.Windows.Forms.Button();
            this.xacNhanChuyenBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chiNhanhChuyenComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.thoatChuyenBtn);
            this.panel1.Controls.Add(this.xacNhanChuyenBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chiNhanhChuyenComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Markazi Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 339);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // thoatChuyenBtn
            // 
            this.thoatChuyenBtn.Location = new System.Drawing.Point(394, 249);
            this.thoatChuyenBtn.Name = "thoatChuyenBtn";
            this.thoatChuyenBtn.Size = new System.Drawing.Size(133, 41);
            this.thoatChuyenBtn.TabIndex = 10;
            this.thoatChuyenBtn.Text = "Thoát";
            this.thoatChuyenBtn.UseVisualStyleBackColor = true;
            // 
            // xacNhanChuyenBtn
            // 
            this.xacNhanChuyenBtn.Location = new System.Drawing.Point(131, 249);
            this.xacNhanChuyenBtn.Name = "xacNhanChuyenBtn";
            this.xacNhanChuyenBtn.Size = new System.Drawing.Size(133, 41);
            this.xacNhanChuyenBtn.TabIndex = 9;
            this.xacNhanChuyenBtn.Text = "Xác nhận";
            this.xacNhanChuyenBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn chi nhánh";
            // 
            // chiNhanhChuyenComboBox
            // 
            this.chiNhanhChuyenComboBox.FormattingEnabled = true;
            this.chiNhanhChuyenComboBox.Location = new System.Drawing.Point(289, 140);
            this.chiNhanhChuyenComboBox.Name = "chiNhanhChuyenComboBox";
            this.chiNhanhChuyenComboBox.Size = new System.Drawing.Size(305, 43);
            this.chiNhanhChuyenComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Markazi Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::DDB_NGANHANG.Properties.Resources.move_icon;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(85, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 107);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyển chi nhánh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChuyenChiNhanhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 339);
            this.Controls.Add(this.panel1);
            this.Name = "ChuyenChiNhanhForm";
            this.Text = "ChuyenChiNhanh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button thoatChuyenBtn;
        private System.Windows.Forms.Button xacNhanChuyenBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox chiNhanhChuyenComboBox;
    }
}