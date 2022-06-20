
namespace AppQuanLyNV
{
    partial class XacNhan
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treGioCoPhepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dangNhapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienDataSet4 = new AppQuanLyNV.NhanVienDataSet4();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.cbxCoPhep = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayDangNhap = new System.Windows.Forms.DateTimePicker();
            this.dangNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dangXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dangNhapTableAdapter1 = new AppQuanLyNV.NhanVienDataSet4TableAdapters.DangNhapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangXuatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongTin
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThongTin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongTin.AutoGenerateColumns = false;
            this.dgvThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.ngayDangNhapDataGridViewTextBoxColumn,
            this.thoiGianDangNhapDataGridViewTextBoxColumn,
            this.trangThaiDangNhapDataGridViewTextBoxColumn,
            this.treGioCoPhepDataGridViewTextBoxColumn});
            this.dgvThongTin.DataSource = this.dangNhapBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTin.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongTin.Location = new System.Drawing.Point(17, 137);
            this.dgvThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThongTin.Name = "dgvThongTin";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTin.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThongTin.RowHeadersWidth = 51;
            this.dgvThongTin.Size = new System.Drawing.Size(879, 384);
            this.dgvThongTin.TabIndex = 0;
            this.dgvThongTin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTin_CellContentClick);
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // ngayDangNhapDataGridViewTextBoxColumn
            // 
            this.ngayDangNhapDataGridViewTextBoxColumn.DataPropertyName = "NgayDangNhap";
            this.ngayDangNhapDataGridViewTextBoxColumn.HeaderText = "Ngày vào";
            this.ngayDangNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayDangNhapDataGridViewTextBoxColumn.Name = "ngayDangNhapDataGridViewTextBoxColumn";
            // 
            // thoiGianDangNhapDataGridViewTextBoxColumn
            // 
            this.thoiGianDangNhapDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianDangNhap";
            this.thoiGianDangNhapDataGridViewTextBoxColumn.HeaderText = "Thời gian vào";
            this.thoiGianDangNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoiGianDangNhapDataGridViewTextBoxColumn.Name = "thoiGianDangNhapDataGridViewTextBoxColumn";
            // 
            // trangThaiDangNhapDataGridViewTextBoxColumn
            // 
            this.trangThaiDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TrangThaiDangNhap";
            this.trangThaiDangNhapDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.trangThaiDangNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangThaiDangNhapDataGridViewTextBoxColumn.Name = "trangThaiDangNhapDataGridViewTextBoxColumn";
            // 
            // treGioCoPhepDataGridViewTextBoxColumn
            // 
            this.treGioCoPhepDataGridViewTextBoxColumn.DataPropertyName = "TreGioCoPhep";
            this.treGioCoPhepDataGridViewTextBoxColumn.HeaderText = "Xác nhận";
            this.treGioCoPhepDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.treGioCoPhepDataGridViewTextBoxColumn.Name = "treGioCoPhepDataGridViewTextBoxColumn";
            // 
            // dangNhapBindingSource1
            // 
            this.dangNhapBindingSource1.DataMember = "DangNhap";
            this.dangNhapBindingSource1.DataSource = this.nhanVienDataSet4;
            // 
            // nhanVienDataSet4
            // 
            this.nhanVienDataSet4.DataSetName = "NhanVienDataSet4";
            this.nhanVienDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(452, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(147, 30);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(132, 22);
            this.txtMaNV.TabIndex = 2;
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Location = new System.Drawing.Point(147, 97);
            this.txtThoiGian.Margin = new System.Windows.Forms.Padding(4);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.ReadOnly = true;
            this.txtThoiGian.Size = new System.Drawing.Size(132, 22);
            this.txtThoiGian.TabIndex = 5;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(419, 30);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.Size = new System.Drawing.Size(132, 22);
            this.txtTrangThai.TabIndex = 6;
            // 
            // cbxCoPhep
            // 
            this.cbxCoPhep.FormattingEnabled = true;
            this.cbxCoPhep.Items.AddRange(new object[] {
            "Co",
            "Khong"});
            this.cbxCoPhep.Location = new System.Drawing.Point(419, 65);
            this.cbxCoPhep.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCoPhep.Name = "cbxCoPhep";
            this.cbxCoPhep.Size = new System.Drawing.Size(132, 24);
            this.cbxCoPhep.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã NV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Thời Gian Vao:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Trạng thái:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Đi trễ có phép:";
            // 
            // dtpNgayDangNhap
            // 
            this.dtpNgayDangNhap.Enabled = false;
            this.dtpNgayDangNhap.Location = new System.Drawing.Point(147, 63);
            this.dtpNgayDangNhap.Name = "dtpNgayDangNhap";
            this.dtpNgayDangNhap.Size = new System.Drawing.Size(141, 22);
            this.dtpNgayDangNhap.TabIndex = 16;
            // 
            // dangNhapBindingSource
            // 
            this.dangNhapBindingSource.DataMember = "DangNhap";
            // 
            // dangXuatBindingSource
            // 
            this.dangXuatBindingSource.DataMember = "DangXuat";
            // 
            // dangNhapTableAdapter1
            // 
            this.dangNhapTableAdapter1.ClearBeforeFill = true;
            // 
            // XacNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(912, 506);
            this.Controls.Add(this.dtpNgayDangNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCoPhep);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.txtThoiGian);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvThongTin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XacNhan";
            this.Text = "XacNhan";
            this.Load += new System.EventHandler(this.XacNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangXuatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtThoiGian;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.ComboBox cbxCoPhep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayDangNhap;

        private System.Windows.Forms.BindingSource dangNhapBindingSource;


        private System.Windows.Forms.BindingSource dangXuatBindingSource;

        private NhanVienDataSet4 nhanVienDataSet4;
        private System.Windows.Forms.BindingSource dangNhapBindingSource1;
        private NhanVienDataSet4TableAdapters.DangNhapTableAdapter dangNhapTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treGioCoPhepDataGridViewTextBoxColumn;
    }
}