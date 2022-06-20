
namespace AppQuanLyNV
{
    partial class KiemTra
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
            this.btnTimKiem1 = new System.Windows.Forms.Button();
            this.cbxTrangThaiDangNhap = new System.Windows.Forms.ComboBox();
            this.cbxTrangThaiDangXuat = new System.Windows.Forms.ComboBox();
            this.btnTimKiem2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBaoDanh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(289, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lịch sử báo công";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Trạng thái đăng nhập:";
            // 
            // btnTimKiem1
            // 
            this.btnTimKiem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem1.Location = new System.Drawing.Point(343, 29);
            this.btnTimKiem1.Name = "btnTimKiem1";
            this.btnTimKiem1.Size = new System.Drawing.Size(87, 23);
            this.btnTimKiem1.TabIndex = 14;
            this.btnTimKiem1.Text = "Tìm kiếm";
            this.btnTimKiem1.UseVisualStyleBackColor = true;
            this.btnTimKiem1.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbxTrangThaiDangNhap
            // 
            this.cbxTrangThaiDangNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTrangThaiDangNhap.FormattingEnabled = true;
            this.cbxTrangThaiDangNhap.Items.AddRange(new object[] {
            "Di tre",
            "Dung gio"});
            this.cbxTrangThaiDangNhap.Location = new System.Drawing.Point(197, 29);
            this.cbxTrangThaiDangNhap.Name = "cbxTrangThaiDangNhap";
            this.cbxTrangThaiDangNhap.Size = new System.Drawing.Size(140, 25);
            this.cbxTrangThaiDangNhap.TabIndex = 15;
            // 
            // cbxTrangThaiDangXuat
            // 
            this.cbxTrangThaiDangXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTrangThaiDangXuat.FormattingEnabled = true;
            this.cbxTrangThaiDangXuat.Items.AddRange(new object[] {
            "Dung gio",
            "Ve som"});
            this.cbxTrangThaiDangXuat.Location = new System.Drawing.Point(197, 59);
            this.cbxTrangThaiDangXuat.Name = "cbxTrangThaiDangXuat";
            this.cbxTrangThaiDangXuat.Size = new System.Drawing.Size(140, 25);
            this.cbxTrangThaiDangXuat.TabIndex = 18;
            // 
            // btnTimKiem2
            // 
            this.btnTimKiem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem2.Location = new System.Drawing.Point(343, 62);
            this.btnTimKiem2.Name = "btnTimKiem2";
            this.btnTimKiem2.Size = new System.Drawing.Size(87, 23);
            this.btnTimKiem2.TabIndex = 17;
            this.btnTimKiem2.Text = "Tìm kiếm";
            this.btnTimKiem2.UseVisualStyleBackColor = true;
            this.btnTimKiem2.Click += new System.EventHandler(this.btnTimKiem2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Trạng thái đăng xuất:";
            // 
            // dgvBaoDanh
            // 
            this.dgvBaoDanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoDanh.Location = new System.Drawing.Point(-1, 90);
            this.dgvBaoDanh.Name = "dgvBaoDanh";
            this.dgvBaoDanh.RowHeadersWidth = 51;
            this.dgvBaoDanh.Size = new System.Drawing.Size(702, 329);
            this.dgvBaoDanh.TabIndex = 22;
            // 
            // KiemTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTimKiem2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTrangThaiDangXuat);
            this.Controls.Add(this.btnTimKiem1);
            this.Controls.Add(this.dgvBaoDanh);
            this.Controls.Add(this.cbxTrangThaiDangNhap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "KiemTra";
            this.Text = "KiemTra";
            this.Load += new System.EventHandler(this.KiemTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoDanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem1;
        private System.Windows.Forms.ComboBox cbxTrangThaiDangNhap;
        private System.Windows.Forms.ComboBox cbxTrangThaiDangXuat;
        private System.Windows.Forms.Button btnTimKiem2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBaoDanh;
    }
}