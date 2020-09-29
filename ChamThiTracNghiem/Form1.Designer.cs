namespace ChamThiTracNghiem
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDapAn = new System.Windows.Forms.Button();
            this.txtSai = new System.Windows.Forms.TextBox();
            this.txtDung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grNhapDe = new System.Windows.Forms.GroupBox();
            this.btnDocFile = new System.Windows.Forms.Button();
            this.txtTenFile = new System.Windows.Forms.TextBox();
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBangGhi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grNhapDe.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.btnDapAn);
            this.groupBox1.Controls.Add(this.txtSai);
            this.groupBox1.Controls.Add(this.txtDung);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KẾT QUẢ";
            // 
            // btnDapAn
            // 
            this.btnDapAn.BackColor = System.Drawing.Color.White;
            this.btnDapAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDapAn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDapAn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDapAn.Location = new System.Drawing.Point(186, 103);
            this.btnDapAn.Name = "btnDapAn";
            this.btnDapAn.Size = new System.Drawing.Size(121, 34);
            this.btnDapAn.TabIndex = 5;
            this.btnDapAn.Text = "Xem đáp án";
            this.btnDapAn.UseVisualStyleBackColor = false;
            this.btnDapAn.Click += new System.EventHandler(this.btnDapAn_Click);
            // 
            // txtSai
            // 
            this.txtSai.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSai.Location = new System.Drawing.Point(130, 72);
            this.txtSai.Name = "txtSai";
            this.txtSai.Size = new System.Drawing.Size(225, 23);
            this.txtSai.TabIndex = 4;
            // 
            // txtDung
            // 
            this.txtDung.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDung.Location = new System.Drawing.Point(130, 35);
            this.txtDung.Name = "txtDung";
            this.txtDung.Size = new System.Drawing.Size(225, 23);
            this.txtDung.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(34, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số câu sai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(34, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số câu đúng";
            // 
            // grNhapDe
            // 
            this.grNhapDe.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.grNhapDe.Controls.Add(this.btnDocFile);
            this.grNhapDe.Controls.Add(this.txtTenFile);
            this.grNhapDe.Controls.Add(this.txtDuongDan);
            this.grNhapDe.Controls.Add(this.label2);
            this.grNhapDe.Controls.Add(this.label1);
            this.grNhapDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.grNhapDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grNhapDe.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grNhapDe.Location = new System.Drawing.Point(0, 0);
            this.grNhapDe.Name = "grNhapDe";
            this.grNhapDe.Size = new System.Drawing.Size(400, 150);
            this.grNhapDe.TabIndex = 1;
            this.grNhapDe.TabStop = false;
            this.grNhapDe.Text = "NHẬP ĐỀ";
            // 
            // btnDocFile
            // 
            this.btnDocFile.BackColor = System.Drawing.Color.White;
            this.btnDocFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocFile.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDocFile.Location = new System.Drawing.Point(186, 99);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(121, 34);
            this.btnDocFile.TabIndex = 4;
            this.btnDocFile.Text = "Đọc file";
            this.btnDocFile.UseVisualStyleBackColor = false;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // txtTenFile
            // 
            this.txtTenFile.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenFile.Location = new System.Drawing.Point(130, 66);
            this.txtTenFile.Name = "txtTenFile";
            this.txtTenFile.Size = new System.Drawing.Size(225, 23);
            this.txtTenFile.TabIndex = 3;
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuongDan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDuongDan.Location = new System.Drawing.Point(130, 30);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(225, 23);
            this.txtDuongDan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn file";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grNhapDe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 618);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(400, 318);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBangGhi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(400, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 618);
            this.panel2.TabIndex = 4;
            // 
            // txtBangGhi
            // 
            this.txtBangGhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBangGhi.Location = new System.Drawing.Point(0, 20);
            this.txtBangGhi.Multiline = true;
            this.txtBangGhi.Name = "txtBangGhi";
            this.txtBangGhi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBangGhi.Size = new System.Drawing.Size(876, 598);
            this.txtBangGhi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(876, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "BẢNG GHI";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 618);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Chấm thi trắc nghiệm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grNhapDe.ResumeLayout(false);
            this.grNhapDe.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grNhapDe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDapAn;
        private System.Windows.Forms.TextBox txtSai;
        private System.Windows.Forms.TextBox txtDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.TextBox txtTenFile;
        private System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBangGhi;
    }
}

