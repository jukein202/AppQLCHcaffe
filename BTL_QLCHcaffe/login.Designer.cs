namespace BTL_QLCHcaffe
{
    partial class login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdthoai = new System.Windows.Forms.Button();
            this.cmdDangnhap = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdthoai);
            this.panel1.Controls.Add(this.cmdDangnhap);
            this.panel1.Controls.Add(this.txtMK);
            this.panel1.Controls.Add(this.txtTK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 214);
            this.panel1.TabIndex = 3;
            // 
            // cmdthoai
            // 
            this.cmdthoai.Location = new System.Drawing.Point(335, 151);
            this.cmdthoai.Name = "cmdthoai";
            this.cmdthoai.Size = new System.Drawing.Size(94, 37);
            this.cmdthoai.TabIndex = 5;
            this.cmdthoai.Text = "Thoát";
            this.cmdthoai.UseVisualStyleBackColor = true;
            this.cmdthoai.Click += new System.EventHandler(this.cmdthoai_Click);
            // 
            // cmdDangnhap
            // 
            this.cmdDangnhap.Location = new System.Drawing.Point(181, 151);
            this.cmdDangnhap.Name = "cmdDangnhap";
            this.cmdDangnhap.Size = new System.Drawing.Size(131, 37);
            this.cmdDangnhap.TabIndex = 4;
            this.cmdDangnhap.Text = "Đăng nhập";
            this.cmdDangnhap.UseVisualStyleBackColor = true;
            this.cmdDangnhap.Click += new System.EventHandler(this.cmdDangnhap_Click);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(195, 89);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(234, 32);
            this.txtMK.TabIndex = 3;
            this.txtMK.Text = "1";
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(195, 16);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(234, 32);
            this.txtTK.TabIndex = 2;
            this.txtTK.Text = "quan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập :";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 237);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdthoai;
        private System.Windows.Forms.Button cmdDangnhap;
    }
}

