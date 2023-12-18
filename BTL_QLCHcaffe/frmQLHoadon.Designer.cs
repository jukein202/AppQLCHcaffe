namespace BTL_QLCHcaffe
{
    partial class frmQLHoadon
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
            this.dghd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpNgayban = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmaBan = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdxoa = new System.Windows.Forms.Button();
            this.dgchitiethd = new System.Windows.Forms.DataGridView();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdxem = new System.Windows.Forms.Button();
            this.cmdketthuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dghd)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgchitiethd)).BeginInit();
            this.SuspendLayout();
            // 
            // dghd
            // 
            this.dghd.AllowUserToAddRows = false;
            this.dghd.AllowUserToDeleteRows = false;
            this.dghd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dghd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.NgayBan,
            this.Column5,
            this.Column2,
            this.Column3});
            this.dghd.Location = new System.Drawing.Point(12, 12);
            this.dghd.Name = "dghd";
            this.dghd.ReadOnly = true;
            this.dghd.RowTemplate.Height = 24;
            this.dghd.Size = new System.Drawing.Size(599, 190);
            this.dghd.TabIndex = 1;
            this.dghd.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dghd_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 160;
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "Ngày Bán";
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.ReadOnly = true;
            this.NgayBan.Width = 140;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenKH";
            this.Column5.HeaderText = "Tên khách hàng";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaBan";
            this.Column2.HeaderText = "Mã Bàn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TongTien";
            this.Column3.HeaderText = "Tổng Tiền";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 160;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtpNgayban);
            this.panel4.Controls.Add(this.txtTongTien);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtmaBan);
            this.panel4.Controls.Add(this.txtTenKH);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtmahd);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(12, 208);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(608, 204);
            this.panel4.TabIndex = 6;
            // 
            // dtpNgayban
            // 
            this.dtpNgayban.Enabled = false;
            this.dtpNgayban.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayban.Location = new System.Drawing.Point(174, 48);
            this.dtpNgayban.Name = "dtpNgayban";
            this.dtpNgayban.Size = new System.Drawing.Size(203, 32);
            this.dtpNgayban.TabIndex = 10;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(174, 162);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(425, 32);
            this.txtTongTien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng Tiền :";
            // 
            // txtmaBan
            // 
            this.txtmaBan.Location = new System.Drawing.Point(174, 124);
            this.txtmaBan.Name = "txtmaBan";
            this.txtmaBan.ReadOnly = true;
            this.txtmaBan.Size = new System.Drawing.Size(425, 32);
            this.txtmaBan.TabIndex = 7;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(174, 86);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(425, 32);
            this.txtTenKH.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Bàn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên KH :";
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(174, 10);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.ReadOnly = true;
            this.txtmahd.Size = new System.Drawing.Size(425, 32);
            this.txtmahd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Bán :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn :";
            // 
            // cmdxoa
            // 
            this.cmdxoa.Location = new System.Drawing.Point(12, 418);
            this.cmdxoa.Name = "cmdxoa";
            this.cmdxoa.Size = new System.Drawing.Size(108, 45);
            this.cmdxoa.TabIndex = 7;
            this.cmdxoa.Text = "Xóa";
            this.cmdxoa.UseVisualStyleBackColor = true;
            this.cmdxoa.Click += new System.EventHandler(this.cmdxoa_Click);
            // 
            // dgchitiethd
            // 
            this.dgchitiethd.AllowUserToAddRows = false;
            this.dgchitiethd.AllowUserToDeleteRows = false;
            this.dgchitiethd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgchitiethd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.Column4,
            this.Column6,
            this.Column7});
            this.dgchitiethd.Location = new System.Drawing.Point(639, 12);
            this.dgchitiethd.Name = "dgchitiethd";
            this.dgchitiethd.ReadOnly = true;
            this.dgchitiethd.RowTemplate.Height = 24;
            this.dgchitiethd.Size = new System.Drawing.Size(422, 400);
            this.dgchitiethd.TabIndex = 8;
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "MaHD";
            this.mahd.HeaderText = "Mã hóa đơn";
            this.mahd.Name = "mahd";
            this.mahd.ReadOnly = true;
            this.mahd.Width = 140;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaMonAn";
            this.Column4.HeaderText = "Mã món ăn";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SoLuong";
            this.Column6.HeaderText = "Số lượng";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 130;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ThanhTien";
            this.Column7.HeaderText = "Thành tiền";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // cmdxem
            // 
            this.cmdxem.Location = new System.Drawing.Point(848, 418);
            this.cmdxem.Name = "cmdxem";
            this.cmdxem.Size = new System.Drawing.Size(213, 45);
            this.cmdxem.TabIndex = 9;
            this.cmdxem.Text = "xem chi tiết";
            this.cmdxem.UseVisualStyleBackColor = true;
            this.cmdxem.Click += new System.EventHandler(this.cmdxem_Click);
            // 
            // cmdketthuc
            // 
            this.cmdketthuc.Location = new System.Drawing.Point(139, 418);
            this.cmdketthuc.Name = "cmdketthuc";
            this.cmdketthuc.Size = new System.Drawing.Size(153, 45);
            this.cmdketthuc.TabIndex = 10;
            this.cmdketthuc.Text = "Kết Thúc";
            this.cmdketthuc.UseVisualStyleBackColor = true;
            this.cmdketthuc.Click += new System.EventHandler(this.cmdketthuc_Click);
            // 
            // frmQLHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 469);
            this.Controls.Add(this.cmdketthuc);
            this.Controls.Add(this.cmdxem);
            this.Controls.Add(this.dgchitiethd);
            this.Controls.Add(this.cmdxoa);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dghd);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQLHoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLHoadon";
            this.Load += new System.EventHandler(this.frmQLHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dghd)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgchitiethd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dghd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpNgayban;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaBan;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdxoa;
        private System.Windows.Forms.DataGridView dgchitiethd;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button cmdxem;
        private System.Windows.Forms.Button cmdketthuc;
    }
}