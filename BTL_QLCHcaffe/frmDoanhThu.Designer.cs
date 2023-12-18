namespace BTL_QLCHcaffe
{
    partial class frmDoanhThu
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
            this.cmdTK = new System.Windows.Forms.Button();
            this.lswHD = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbmahd = new System.Windows.Forms.ComboBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.cmdKT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNhan = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgDT = new System.Windows.Forms.DataGridView();
            this.txtTongALL = new System.Windows.Forms.TextBox();
            this.cmdTKA = new System.Windows.Forms.Button();
            this.lswhh = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dtTra = new System.Windows.Forms.DateTimePicker();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDT)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdTK
            // 
            this.cmdTK.Location = new System.Drawing.Point(649, 42);
            this.cmdTK.Name = "cmdTK";
            this.cmdTK.Size = new System.Drawing.Size(131, 83);
            this.cmdTK.TabIndex = 3;
            this.cmdTK.Text = "Thống Kê";
            this.cmdTK.UseVisualStyleBackColor = true;
            this.cmdTK.Click += new System.EventHandler(this.cmdTK_Click);
            // 
            // lswHD
            // 
            this.lswHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.lswHD.FullRowSelect = true;
            this.lswHD.GridLines = true;
            this.lswHD.Location = new System.Drawing.Point(467, 183);
            this.lswHD.Name = "lswHD";
            this.lswHD.Size = new System.Drawing.Size(447, 329);
            this.lswHD.TabIndex = 29;
            this.lswHD.UseCompatibleStateImageBehavior = false;
            this.lswHD.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Món";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã HD";
            this.columnHeader6.Width = 82;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số Lượng";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn Giá";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 129;
            // 
            // cbbmahd
            // 
            this.cbbmahd.FormattingEnabled = true;
            this.cbbmahd.Location = new System.Drawing.Point(162, 92);
            this.cbbmahd.Name = "cbbmahd";
            this.cbbmahd.Size = new System.Drawing.Size(170, 33);
            this.cbbmahd.TabIndex = 30;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(467, 92);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(176, 32);
            this.txtTongTien.TabIndex = 31;
            // 
            // cmdKT
            // 
            this.cmdKT.Location = new System.Drawing.Point(786, 42);
            this.cmdKT.Name = "cmdKT";
            this.cmdKT.Size = new System.Drawing.Size(128, 83);
            this.cmdKT.TabIndex = 32;
            this.cmdKT.Text = "Thoát";
            this.cmdKT.UseVisualStyleBackColor = true;
            this.cmdKT.Click += new System.EventHandler(this.cmdKT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 34);
            this.label1.TabIndex = 33;
            this.label1.Text = "Thống Kê Doanh Thu";
            // 
            // dtNhan
            // 
            this.dtNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNhan.Location = new System.Drawing.Point(162, 47);
            this.dtNhan.Name = "dtNhan";
            this.dtNhan.Size = new System.Drawing.Size(170, 32);
            this.dtNhan.TabIndex = 34;
            this.dtNhan.Value = new System.DateTime(2022, 4, 21, 0, 0, 0, 0);
            this.dtNhan.ValueChanged += new System.EventHandler(this.dtNhan_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Từ Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Đến Ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Mã Hóa Đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tổng Tiền:";
            // 
            // dgDT
            // 
            this.dgDT.AllowUserToAddRows = false;
            this.dgDT.AllowUserToDeleteRows = false;
            this.dgDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3});
            this.dgDT.Location = new System.Drawing.Point(12, 183);
            this.dgDT.Name = "dgDT";
            this.dgDT.ReadOnly = true;
            this.dgDT.RowTemplate.Height = 24;
            this.dgDT.Size = new System.Drawing.Size(446, 329);
            this.dgDT.TabIndex = 0;
            // 
            // txtTongALL
            // 
            this.txtTongALL.Location = new System.Drawing.Point(388, 139);
            this.txtTongALL.Name = "txtTongALL";
            this.txtTongALL.ReadOnly = true;
            this.txtTongALL.Size = new System.Drawing.Size(255, 32);
            this.txtTongALL.TabIndex = 40;
            // 
            // cmdTKA
            // 
            this.cmdTKA.Location = new System.Drawing.Point(649, 131);
            this.cmdTKA.Name = "cmdTKA";
            this.cmdTKA.Size = new System.Drawing.Size(266, 46);
            this.cmdTKA.TabIndex = 41;
            this.cmdTKA.Text = "Thống Kê Tất Cả";
            this.cmdTKA.UseVisualStyleBackColor = true;
            this.cmdTKA.Click += new System.EventHandler(this.cmdTKA_Click);
            // 
            // lswhh
            // 
            this.lswhh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.lswhh.FullRowSelect = true;
            this.lswhh.GridLines = true;
            this.lswhh.Location = new System.Drawing.Point(287, 22);
            this.lswhh.Name = "lswhh";
            this.lswhh.Size = new System.Drawing.Size(10, 10);
            this.lswhh.TabIndex = 42;
            this.lswhh.UseCompatibleStateImageBehavior = false;
            this.lswhh.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MaHD";
            this.columnHeader5.Width = 158;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Tổng Doanh Thu Của Các Hóa Đơn:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(622, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(10, 10);
            this.listView1.TabIndex = 44;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dtTra
            // 
            this.dtTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTra.Location = new System.Drawing.Point(464, 47);
            this.dtTra.Name = "dtTra";
            this.dtTra.Size = new System.Drawing.Size(179, 32);
            this.dtTra.TabIndex = 35;
            this.dtTra.Value = new System.DateTime(2022, 4, 21, 0, 0, 0, 0);
            this.dtTra.ValueChanged += new System.EventHandler(this.dtTra_ValueChanged);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaHD";
            this.Column2.HeaderText = "Mã HD";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaBan";
            this.Column1.HeaderText = "Mã Bàn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayBan";
            this.Column3.HeaderText = "Ngày Nhận";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 525);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lswhh);
            this.Controls.Add(this.cmdTKA);
            this.Controls.Add(this.txtTongALL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTra);
            this.Controls.Add(this.dtNhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdKT);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.cbbmahd);
            this.Controls.Add(this.lswHD);
            this.Controls.Add(this.cmdTK);
            this.Controls.Add(this.dgDT);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoanhThu";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdTK;
        private System.Windows.Forms.ListView lswHD;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox cbbmahd;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button cmdKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgDT;
        private System.Windows.Forms.TextBox txtTongALL;
        private System.Windows.Forms.Button cmdTKA;
        private System.Windows.Forms.ListView lswhh;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker dtTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}