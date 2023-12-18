namespace BTL_QLCHcaffe
{
    partial class frmTKMonAn
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
            this.label4 = new System.Windows.Forms.Label();
            this.dgMA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.cmdKT = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.cmdtk = new System.Windows.Forms.Button();
            this.lswSL = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Món Ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng số món:";
            // 
            // dgMA
            // 
            this.dgMA.AllowUserToAddRows = false;
            this.dgMA.AllowUserToDeleteRows = false;
            this.dgMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgMA.Location = new System.Drawing.Point(17, 132);
            this.dgMA.MultiSelect = false;
            this.dgMA.Name = "dgMA";
            this.dgMA.ReadOnly = true;
            this.dgMA.RowTemplate.Height = 24;
            this.dgMA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMA.Size = new System.Drawing.Size(464, 284);
            this.dgMA.TabIndex = 4;
            this.dgMA.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgMA_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaMonAn";
            this.Column1.HeaderText = "Mã Món Ăn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 160;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenMonAn";
            this.Column2.HeaderText = "Tên Món Ăn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Gia";
            this.Column3.HeaderText = "Giá";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // cbbLoai
            // 
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Location = new System.Drawing.Point(124, 50);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(100, 33);
            this.cbbLoai.TabIndex = 5;
            this.cbbLoai.SelectedIndexChanged += new System.EventHandler(this.cbbLoai_SelectedIndexChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(124, 91);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(100, 32);
            this.txtTen.TabIndex = 6;
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(168, 433);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(189, 32);
            this.txtTong.TabIndex = 7;
            // 
            // cmdKT
            // 
            this.cmdKT.Location = new System.Drawing.Point(543, 422);
            this.cmdKT.Name = "cmdKT";
            this.cmdKT.Size = new System.Drawing.Size(169, 47);
            this.cmdKT.TabIndex = 8;
            this.cmdKT.Text = "Thoát";
            this.cmdKT.UseVisualStyleBackColor = true;
            this.cmdKT.Click += new System.EventHandler(this.cmdKT_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(455, 91);
            this.txtSL.Name = "txtSL";
            this.txtSL.ReadOnly = true;
            this.txtSL.Size = new System.Drawing.Size(257, 32);
            this.txtSL.TabIndex = 9;
            // 
            // cmdtk
            // 
            this.cmdtk.Location = new System.Drawing.Point(376, 422);
            this.cmdtk.Name = "cmdtk";
            this.cmdtk.Size = new System.Drawing.Size(161, 47);
            this.cmdtk.TabIndex = 12;
            this.cmdtk.Text = "Thống Kê";
            this.cmdtk.UseVisualStyleBackColor = true;
            this.cmdtk.Click += new System.EventHandler(this.cmdtk_Click);
            // 
            // lswSL
            // 
            this.lswSL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lswSL.FullRowSelect = true;
            this.lswSL.GridLines = true;
            this.lswSL.Location = new System.Drawing.Point(487, 132);
            this.lswSL.Name = "lswSL";
            this.lswSL.Size = new System.Drawing.Size(225, 284);
            this.lswSL.TabIndex = 13;
            this.lswSL.UseCompatibleStateImageBehavior = false;
            this.lswSL.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã CTHD";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            // 
            // txtMA
            // 
            this.txtMA.Location = new System.Drawing.Point(335, 50);
            this.txtMA.Name = "txtMA";
            this.txtMA.ReadOnly = true;
            this.txtMA.Size = new System.Drawing.Size(76, 32);
            this.txtMA.TabIndex = 14;
            this.txtMA.TextChanged += new System.EventHandler(this.txtMA_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mã Món:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số Lượng Bán Được:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tên Món:";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(541, 50);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.ReadOnly = true;
            this.txtTenMon.Size = new System.Drawing.Size(171, 32);
            this.txtTenMon.TabIndex = 18;
            // 
            // frmTKMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 481);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMA);
            this.Controls.Add(this.lswSL);
            this.Controls.Add(this.cmdtk);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.cmdKT);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.cbbLoai);
            this.Controls.Add(this.dgMA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTKMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTKMonAn";
            this.Load += new System.EventHandler(this.frmTKMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgMA;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Button cmdKT;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button cmdtk;
        private System.Windows.Forms.ListView lswSL;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtMA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenMon;
    }
}