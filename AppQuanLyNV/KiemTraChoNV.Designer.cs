
namespace AppQuanLyNV
{
    partial class KiemTraChoNV
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
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBaoDanh = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.nhanVienDataSet = new AppQuanLyNV.NhanVienDataSet();
            this.nhanVienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dangNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dangXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dangNhapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(123, 4);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(132, 22);
            this.txtMaNV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mã NV:";
            // 
            // dgvBaoDanh
            // 
            this.dgvBaoDanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoDanh.Location = new System.Drawing.Point(-5, 36);
            this.dgvBaoDanh.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBaoDanh.Name = "dgvBaoDanh";
            this.dgvBaoDanh.ReadOnly = true;
            this.dgvBaoDanh.RowHeadersWidth = 51;
            this.dgvBaoDanh.Size = new System.Drawing.Size(926, 480);
            this.dgvBaoDanh.TabIndex = 11;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(264, 2);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 25);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // nhanVienDataSet
            // 
            this.nhanVienDataSet.DataSetName = "NhanVienDataSet";
            this.nhanVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienDataSetBindingSource
            // 
            this.nhanVienDataSetBindingSource.DataSource = this.nhanVienDataSet;
            this.nhanVienDataSetBindingSource.Position = 0;
            // 
            // KiemTraChoNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(912, 506);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvBaoDanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaNV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KiemTraChoNV";
            this.Text = "KiemTraChoNV";
            this.Load += new System.EventHandler(this.KiemTraChoNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBaoDanh;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.BindingSource nhanVienDataSetBindingSource;
        private NhanVienDataSet nhanVienDataSet;

        private System.Windows.Forms.BindingSource dangNhapBindingSource;

        private System.Windows.Forms.BindingSource dangXuatBindingSource;

        private System.Windows.Forms.BindingSource dangNhapBindingSource1;
    }
}