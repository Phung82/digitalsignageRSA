namespace Chukyso
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSADecryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateRSAKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sign = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_Encryp = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_showCode = new System.Windows.Forms.TextBox();
            this.btn_chonPrivate = new System.Windows.Forms.Button();
            this.btn_chonVB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_showVB = new System.Windows.Forms.TextBox();
            this.btn_KTra = new System.Windows.Forms.Button();
            this.btn_chonPublic = new System.Windows.Forms.Button();
            this.btn_VBTest = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rSAEncryptionToolStripMenuItem,
            this.rSADecryptionToolStripMenuItem,
            this.generateRSAKeyToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.toolToolStripMenuItem.Text = "Tool";
            this.toolToolStripMenuItem.Click += new System.EventHandler(this.toolToolStripMenuItem_Click);
            // 
            // rSAEncryptionToolStripMenuItem
            // 
            this.rSAEncryptionToolStripMenuItem.Name = "rSAEncryptionToolStripMenuItem";
            this.rSAEncryptionToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.rSAEncryptionToolStripMenuItem.Text = "RSA Encryption";
            this.rSAEncryptionToolStripMenuItem.Click += new System.EventHandler(this.rSAEncryptionToolStripMenuItem_Click);
            // 
            // rSADecryptionToolStripMenuItem
            // 
            this.rSADecryptionToolStripMenuItem.Name = "rSADecryptionToolStripMenuItem";
            this.rSADecryptionToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.rSADecryptionToolStripMenuItem.Text = "RSA Decryption";
            this.rSADecryptionToolStripMenuItem.Click += new System.EventHandler(this.rSADecryptionToolStripMenuItem_Click);
            // 
            // generateRSAKeyToolStripMenuItem
            // 
            this.generateRSAKeyToolStripMenuItem.Name = "generateRSAKeyToolStripMenuItem";
            this.generateRSAKeyToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.generateRSAKeyToolStripMenuItem.Text = "Generate RSA Key";
            this.generateRSAKeyToolStripMenuItem.Click += new System.EventHandler(this.generateRSAKeyToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(133, 26);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_sign);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.btn_Encryp);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btn_chonPrivate);
            this.groupBox1.Controls.Add(this.btn_chonVB);
            this.groupBox1.Location = new System.Drawing.Point(13, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(889, 357);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modul tạo chữ ký";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Họ và Tên";
            // 
            // txt_sign
            // 
            this.txt_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sign.Location = new System.Drawing.Point(28, 288);
            this.txt_sign.Multiline = true;
            this.txt_sign.Name = "txt_sign";
            this.txt_sign.Size = new System.Drawing.Size(295, 45);
            this.txt_sign.TabIndex = 16;
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.Black;
            this.btn_luu.Location = new System.Drawing.Point(691, 316);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(172, 33);
            this.btn_luu.TabIndex = 15;
            this.btn_luu.Text = "Lưu Văn Bản Chữ Ký";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click_1);
            // 
            // btn_Encryp
            // 
            this.btn_Encryp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Encryp.ForeColor = System.Drawing.Color.Black;
            this.btn_Encryp.Location = new System.Drawing.Point(691, 239);
            this.btn_Encryp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Encryp.Name = "btn_Encryp";
            this.btn_Encryp.Size = new System.Drawing.Size(172, 33);
            this.btn_Encryp.TabIndex = 14;
            this.btn_Encryp.Text = "Ký Xác Nhận";
            this.btn_Encryp.UseVisualStyleBackColor = true;
            this.btn_Encryp.Click += new System.EventHandler(this.btn_Encryp_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_showCode);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(16, 82);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(847, 149);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Văn bản đã ký";
            // 
            // txt_showCode
            // 
            this.txt_showCode.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_showCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_showCode.Location = new System.Drawing.Point(11, 17);
            this.txt_showCode.Margin = new System.Windows.Forms.Padding(4);
            this.txt_showCode.Multiline = true;
            this.txt_showCode.Name = "txt_showCode";
            this.txt_showCode.ReadOnly = true;
            this.txt_showCode.Size = new System.Drawing.Size(824, 112);
            this.txt_showCode.TabIndex = 6;
            // 
            // btn_chonPrivate
            // 
            this.btn_chonPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chonPrivate.ForeColor = System.Drawing.Color.Black;
            this.btn_chonPrivate.Location = new System.Drawing.Point(212, 23);
            this.btn_chonPrivate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chonPrivate.Name = "btn_chonPrivate";
            this.btn_chonPrivate.Size = new System.Drawing.Size(136, 33);
            this.btn_chonPrivate.TabIndex = 12;
            this.btn_chonPrivate.Text = "Chọn Private Key";
            this.btn_chonPrivate.UseVisualStyleBackColor = true;
            this.btn_chonPrivate.Click += new System.EventHandler(this.btn_chonPrivate_Click);
            // 
            // btn_chonVB
            // 
            this.btn_chonVB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chonVB.ForeColor = System.Drawing.Color.Black;
            this.btn_chonVB.Location = new System.Drawing.Point(28, 23);
            this.btn_chonVB.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chonVB.Name = "btn_chonVB";
            this.btn_chonVB.Size = new System.Drawing.Size(152, 33);
            this.btn_chonVB.TabIndex = 11;
            this.btn_chonVB.Text = "Chọn VB cần ký";
            this.btn_chonVB.UseVisualStyleBackColor = true;
            this.btn_chonVB.Click += new System.EventHandler(this.btn_chonVB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_showVB);
            this.groupBox2.Controls.Add(this.btn_KTra);
            this.groupBox2.Controls.Add(this.btn_chonPublic);
            this.groupBox2.Controls.Add(this.btn_VBTest);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(13, 397);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(889, 234);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modul xác thực";
            // 
            // txt_showVB
            // 
            this.txt_showVB.Location = new System.Drawing.Point(298, 111);
            this.txt_showVB.Multiline = true;
            this.txt_showVB.Name = "txt_showVB";
            this.txt_showVB.ReadOnly = true;
            this.txt_showVB.Size = new System.Drawing.Size(583, 116);
            this.txt_showVB.TabIndex = 14;
            // 
            // btn_KTra
            // 
            this.btn_KTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KTra.ForeColor = System.Drawing.Color.Black;
            this.btn_KTra.Location = new System.Drawing.Point(28, 150);
            this.btn_KTra.Margin = new System.Windows.Forms.Padding(4);
            this.btn_KTra.Name = "btn_KTra";
            this.btn_KTra.Size = new System.Drawing.Size(209, 30);
            this.btn_KTra.TabIndex = 13;
            this.btn_KTra.Text = "Kiểm tra";
            this.btn_KTra.UseVisualStyleBackColor = true;
            this.btn_KTra.Click += new System.EventHandler(this.btn_KTra_Click);
            // 
            // btn_chonPublic
            // 
            this.btn_chonPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chonPublic.ForeColor = System.Drawing.Color.Black;
            this.btn_chonPublic.Location = new System.Drawing.Point(27, 91);
            this.btn_chonPublic.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chonPublic.Name = "btn_chonPublic";
            this.btn_chonPublic.Size = new System.Drawing.Size(209, 30);
            this.btn_chonPublic.TabIndex = 12;
            this.btn_chonPublic.Text = "Chọn Public Key";
            this.btn_chonPublic.UseVisualStyleBackColor = true;
            this.btn_chonPublic.Click += new System.EventHandler(this.btn_chonPublic_Click);
            // 
            // btn_VBTest
            // 
            this.btn_VBTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VBTest.ForeColor = System.Drawing.Color.Black;
            this.btn_VBTest.Location = new System.Drawing.Point(28, 36);
            this.btn_VBTest.Margin = new System.Windows.Forms.Padding(4);
            this.btn_VBTest.Name = "btn_VBTest";
            this.btn_VBTest.Size = new System.Drawing.Size(209, 30);
            this.btn_VBTest.TabIndex = 11;
            this.btn_VBTest.Text = "Chọn VB cần Xác Nhận";
            this.btn_VBTest.UseVisualStyleBackColor = true;
            this.btn_VBTest.Click += new System.EventHandler(this.btn_VBTest_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_thongbao);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(298, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(583, 81);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông báo";
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongbao.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_thongbao.Location = new System.Drawing.Point(23, 35);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(0, 29);
            this.lb_thongbao.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(652, 664);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "BTL ATBMTT: Tiểu Phụng - Anh Tuấn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 690);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Chữ ký số";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSAEncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSADecryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateRSAKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_Encryp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_showCode;
        private System.Windows.Forms.Button btn_chonPrivate;
        private System.Windows.Forms.Button btn_chonVB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_KTra;
        private System.Windows.Forms.Button btn_chonPublic;
        private System.Windows.Forms.Button btn_VBTest;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_thongbao;
        private System.Windows.Forms.TextBox txt_showVB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sign;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
    }
}

