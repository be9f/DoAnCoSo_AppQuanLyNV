
namespace AppQuanLyNV
{
    partial class KiemTraNghiPhep
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nghiTuNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nghiDenNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lyDoNghiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xacNhanChoNghiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nghiPhepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienDataSet2 = new AppQuanLyNV.NhanVienDataSet2();
            this.nghiPhepTableAdapter = new AppQuanLyNV.NhanVienDataSet2TableAdapters.NghiPhepTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiPhepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(275, 6);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 25);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhập mã NV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(133, 7);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(132, 22);
            this.txtMaNV.TabIndex = 13;
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.AutoGenerateColumns = false;
            this.dgvThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.nghiTuNgayDataGridViewTextBoxColumn,
            this.nghiDenNgayDataGridViewTextBoxColumn,
            this.lyDoNghiDataGridViewTextBoxColumn,
            this.xacNhanChoNghiDataGridViewTextBoxColumn});
            this.dgvThongTin.DataSource = this.nghiPhepBindingSource;
            this.dgvThongTin.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvThongTin.Location = new System.Drawing.Point(-3, 39);
            this.dgvThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.ReadOnly = true;
            this.dgvThongTin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongTin.RowHeadersVisible = false;
            this.dgvThongTin.RowHeadersWidth = 51;
            this.dgvThongTin.Size = new System.Drawing.Size(917, 459);
            this.dgvThongTin.TabIndex = 16;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "Tên NV";
            this.tenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nghiTuNgayDataGridViewTextBoxColumn
            // 
            this.nghiTuNgayDataGridViewTextBoxColumn.DataPropertyName = "NghiTuNgay";
            this.nghiTuNgayDataGridViewTextBoxColumn.HeaderText = "Từ ngày";
            this.nghiTuNgayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nghiTuNgayDataGridViewTextBoxColumn.Name = "nghiTuNgayDataGridViewTextBoxColumn";
            this.nghiTuNgayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nghiDenNgayDataGridViewTextBoxColumn
            // 
            this.nghiDenNgayDataGridViewTextBoxColumn.DataPropertyName = "NghiDenNgay";
            this.nghiDenNgayDataGridViewTextBoxColumn.HeaderText = "Đến ngày";
            this.nghiDenNgayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nghiDenNgayDataGridViewTextBoxColumn.Name = "nghiDenNgayDataGridViewTextBoxColumn";
            this.nghiDenNgayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lyDoNghiDataGridViewTextBoxColumn
            // 
            this.lyDoNghiDataGridViewTextBoxColumn.DataPropertyName = "LyDoNghi";
            this.lyDoNghiDataGridViewTextBoxColumn.HeaderText = "Lý do";
            this.lyDoNghiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lyDoNghiDataGridViewTextBoxColumn.Name = "lyDoNghiDataGridViewTextBoxColumn";
            this.lyDoNghiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xacNhanChoNghiDataGridViewTextBoxColumn
            // 
            this.xacNhanChoNghiDataGridViewTextBoxColumn.DataPropertyName = "XacNhanChoNghi";
            this.xacNhanChoNghiDataGridViewTextBoxColumn.HeaderText = "Xác Nhận";
            this.xacNhanChoNghiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xacNhanChoNghiDataGridViewTextBoxColumn.Name = "xacNhanChoNghiDataGridViewTextBoxColumn";
            this.xacNhanChoNghiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nghiPhepBindingSource
            // 
            this.nghiPhepBindingSource.DataMember = "NghiPhep";
            this.nghiPhepBindingSource.DataSource = this.nhanVienDataSet2;
            // 
            // nhanVienDataSet2
            // 
            this.nhanVienDataSet2.DataSetName = "NhanVienDataSet2";
            this.nhanVienDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nghiPhepTableAdapter
            // 
            this.nghiPhepTableAdapter.ClearBeforeFill = true;
            // 
            // KiemTraNghiPhep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(912, 506);
            this.Controls.Add(this.dgvThongTin);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaNV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KiemTraNghiPhep";
            this.Text = "KiemTraNghiPhep";
            this.Load += new System.EventHandler(this.KiemTraNghiPhep_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiPhepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private NhanVienDataSet2 nhanVienDataSet2;
        private System.Windows.Forms.BindingSource nghiPhepBindingSource;
        private NhanVienDataSet2TableAdapters.NghiPhepTableAdapter nghiPhepTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nghiTuNgayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nghiDenNgayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lyDoNghiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xacNhanChoNghiDataGridViewTextBoxColumn;
    }
}