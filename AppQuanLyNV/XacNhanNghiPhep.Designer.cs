
namespace AppQuanLyNV
{
    partial class XacNhanNghiPhep
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCoPhep = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nghiTuNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nghiDenNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lyDoNghiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xacNhanChoNghiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nghiPhepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienDataSet5 = new AppQuanLyNV.NhanVienDataSet5();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nghiPhepTableAdapter = new AppQuanLyNV.NhanVienDataSet5TableAdapters.NghiPhepTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiPhepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã NV:";
            // 
            // cbxCoPhep
            // 
            this.cbxCoPhep.FormattingEnabled = true;
            this.cbxCoPhep.Items.AddRange(new object[] {
            "Chap nhan",
            "Khong chap nhan"});
            this.cbxCoPhep.Location = new System.Drawing.Point(472, 85);
            this.cbxCoPhep.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCoPhep.Name = "cbxCoPhep";
            this.cbxCoPhep.Size = new System.Drawing.Size(132, 24);
            this.cbxCoPhep.TabIndex = 19;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(215, 21);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(132, 22);
            this.txtMaNV.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(613, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.AutoGenerateColumns = false;
            this.dgvThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.nghiTuNgayDataGridViewTextBoxColumn,
            this.nghiDenNgayDataGridViewTextBoxColumn,
            this.lyDoNghiDataGridViewTextBoxColumn,
            this.xacNhanChoNghiDataGridViewTextBoxColumn});
            this.dgvThongTin.DataSource = this.nghiPhepBindingSource;
            this.dgvThongTin.Location = new System.Drawing.Point(16, 123);
            this.dgvThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.RowHeadersWidth = 51;
            this.dgvThongTin.Size = new System.Drawing.Size(923, 384);
            this.dgvThongTin.TabIndex = 14;
            this.dgvThongTin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTin_CellContentClick);
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "Tên NV";
            this.tenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            // 
            // nghiTuNgayDataGridViewTextBoxColumn
            // 
            this.nghiTuNgayDataGridViewTextBoxColumn.DataPropertyName = "NghiTuNgay";
            this.nghiTuNgayDataGridViewTextBoxColumn.HeaderText = "Tù ngày";
            this.nghiTuNgayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nghiTuNgayDataGridViewTextBoxColumn.Name = "nghiTuNgayDataGridViewTextBoxColumn";
            // 
            // nghiDenNgayDataGridViewTextBoxColumn
            // 
            this.nghiDenNgayDataGridViewTextBoxColumn.DataPropertyName = "NghiDenNgay";
            this.nghiDenNgayDataGridViewTextBoxColumn.HeaderText = "Đến ngày";
            this.nghiDenNgayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nghiDenNgayDataGridViewTextBoxColumn.Name = "nghiDenNgayDataGridViewTextBoxColumn";
            // 
            // lyDoNghiDataGridViewTextBoxColumn
            // 
            this.lyDoNghiDataGridViewTextBoxColumn.DataPropertyName = "LyDoNghi";
            this.lyDoNghiDataGridViewTextBoxColumn.HeaderText = "Lý do";
            this.lyDoNghiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lyDoNghiDataGridViewTextBoxColumn.Name = "lyDoNghiDataGridViewTextBoxColumn";
            // 
            // xacNhanChoNghiDataGridViewTextBoxColumn
            // 
            this.xacNhanChoNghiDataGridViewTextBoxColumn.DataPropertyName = "XacNhanChoNghi";
            this.xacNhanChoNghiDataGridViewTextBoxColumn.HeaderText = "Xác nhận";
            this.xacNhanChoNghiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xacNhanChoNghiDataGridViewTextBoxColumn.Name = "xacNhanChoNghiDataGridViewTextBoxColumn";
            // 
            // nghiPhepBindingSource
            // 
            this.nghiPhepBindingSource.DataMember = "NghiPhep";
            this.nghiPhepBindingSource.DataSource = this.nhanVienDataSet5;
            // 
            // nhanVienDataSet5
            // 
            this.nhanVienDataSet5.DataSetName = "NhanVienDataSet5";
            this.nhanVienDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên NV:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(215, 58);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(132, 22);
            this.txtTenNV.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Lý do nghỉ:";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(215, 90);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(4);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.ReadOnly = true;
            this.txtLyDo.Size = new System.Drawing.Size(132, 22);
            this.txtLyDo.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Từ ngày:";
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(472, 21);
            this.txtTu.Margin = new System.Windows.Forms.Padding(4);
            this.txtTu.Name = "txtTu";
            this.txtTu.ReadOnly = true;
            this.txtTu.Size = new System.Drawing.Size(132, 22);
            this.txtTu.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Đến ngày:";
            // 
            // txtDen
            // 
            this.txtDen.Location = new System.Drawing.Point(472, 53);
            this.txtDen.Margin = new System.Windows.Forms.Padding(4);
            this.txtDen.Name = "txtDen";
            this.txtDen.ReadOnly = true;
            this.txtDen.Size = new System.Drawing.Size(132, 22);
            this.txtDen.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Xét duyệt:";
            // 
            // nghiPhepTableAdapter
            // 
            this.nghiPhepTableAdapter.ClearBeforeFill = true;
            // 
            // XacNhanNghiPhep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(912, 506);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCoPhep);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvThongTin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XacNhanNghiPhep";
            this.Text = "NghiPhep";
            this.Load += new System.EventHandler(this.XacNhanNghiPhep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiPhepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCoPhep;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDen;
        private System.Windows.Forms.Label label6;
        private NhanVienDataSet5 nhanVienDataSet5;
        private System.Windows.Forms.BindingSource nghiPhepBindingSource;
        private NhanVienDataSet5TableAdapters.NghiPhepTableAdapter nghiPhepTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nghiTuNgayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nghiDenNgayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lyDoNghiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xacNhanChoNghiDataGridViewTextBoxColumn;
    }
}