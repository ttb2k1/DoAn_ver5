
namespace DoAn_ver5.GUI.HeThong
{
    partial class SaoLuuPhucHoi
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDuyetSaoLuu = new System.Windows.Forms.TextBox();
            this.btnDuyetSaoLuu = new System.Windows.Forms.Button();
            this.btnSaoLuu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDuyetKhoiPhuc = new System.Windows.Forms.TextBox();
            this.btnDuyetPhucHoi = new System.Windows.Forms.Button();
            this.btnPhucHoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = global::DoAn_ver5.Properties.Resources.saoLuuPhucHoi;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 59);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sao lưu và phục hồi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chọn vị trí để sao lưu hoặc file để phục hồi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaoLuu);
            this.groupBox1.Controls.Add(this.btnDuyetSaoLuu);
            this.groupBox1.Controls.Add(this.txtDuyetSaoLuu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao lưu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vị trí sao lưu:";
            // 
            // txtDuyetSaoLuu
            // 
            this.txtDuyetSaoLuu.Location = new System.Drawing.Point(26, 48);
            this.txtDuyetSaoLuu.Name = "txtDuyetSaoLuu";
            this.txtDuyetSaoLuu.Size = new System.Drawing.Size(290, 23);
            this.txtDuyetSaoLuu.TabIndex = 1;
            // 
            // btnDuyetSaoLuu
            // 
            this.btnDuyetSaoLuu.Location = new System.Drawing.Point(322, 48);
            this.btnDuyetSaoLuu.Name = "btnDuyetSaoLuu";
            this.btnDuyetSaoLuu.Size = new System.Drawing.Size(98, 25);
            this.btnDuyetSaoLuu.TabIndex = 2;
            this.btnDuyetSaoLuu.Text = "Duyệt";
            this.btnDuyetSaoLuu.UseVisualStyleBackColor = true;
            this.btnDuyetSaoLuu.Click += new System.EventHandler(this.btnDuyetSaoLuu_Click);
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Location = new System.Drawing.Point(26, 77);
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.Size = new System.Drawing.Size(98, 25);
            this.btnSaoLuu.TabIndex = 3;
            this.btnSaoLuu.Text = "Sao lưu";
            this.btnSaoLuu.UseVisualStyleBackColor = true;
            this.btnSaoLuu.Click += new System.EventHandler(this.btnSaoLuu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPhucHoi);
            this.groupBox2.Controls.Add(this.txtDuyetKhoiPhuc);
            this.groupBox2.Controls.Add(this.btnDuyetPhucHoi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(15, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phục hồi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chọn file để phục hồi:";
            // 
            // txtDuyetKhoiPhuc
            // 
            this.txtDuyetKhoiPhuc.Location = new System.Drawing.Point(26, 48);
            this.txtDuyetKhoiPhuc.Name = "txtDuyetKhoiPhuc";
            this.txtDuyetKhoiPhuc.Size = new System.Drawing.Size(290, 23);
            this.txtDuyetKhoiPhuc.TabIndex = 1;
            // 
            // btnDuyetPhucHoi
            // 
            this.btnDuyetPhucHoi.Location = new System.Drawing.Point(322, 48);
            this.btnDuyetPhucHoi.Name = "btnDuyetPhucHoi";
            this.btnDuyetPhucHoi.Size = new System.Drawing.Size(98, 25);
            this.btnDuyetPhucHoi.TabIndex = 2;
            this.btnDuyetPhucHoi.Text = "Duyệt";
            this.btnDuyetPhucHoi.UseVisualStyleBackColor = true;
            this.btnDuyetPhucHoi.Click += new System.EventHandler(this.btnDuyetPhucHoi_Click);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Location = new System.Drawing.Point(26, 77);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(98, 25);
            this.btnPhucHoi.TabIndex = 3;
            this.btnPhucHoi.Text = "Phục hồi";
            this.btnPhucHoi.UseVisualStyleBackColor = true;
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // SaoLuuPhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 394);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SaoLuuPhucHoi";
            this.Text = "SaoLuuPhucHoi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaoLuu;
        private System.Windows.Forms.Button btnDuyetSaoLuu;
        private System.Windows.Forms.TextBox txtDuyetSaoLuu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPhucHoi;
        private System.Windows.Forms.TextBox txtDuyetKhoiPhuc;
        private System.Windows.Forms.Button btnDuyetPhucHoi;
        private System.Windows.Forms.Label label5;
    }
}