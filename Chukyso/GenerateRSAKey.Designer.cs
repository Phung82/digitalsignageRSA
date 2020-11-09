namespace Chukyso
{
    partial class GenerateRSAKey_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateRSAKey_form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_privateName = new System.Windows.Forms.TextBox();
            this.txt_publicName = new System.Windows.Forms.TextBox();
            this.btn_privateCopy = new System.Windows.Forms.Button();
            this.btn_publicCopy = new System.Windows.Forms.Button();
            this.txt_privateShow = new System.Windows.Forms.TextBox();
            this.txt_publicShow = new System.Windows.Forms.TextBox();
            this.btn_CreateRSA = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_privateName);
            this.groupBox1.Controls.Add(this.txt_publicName);
            this.groupBox1.Controls.Add(this.btn_privateCopy);
            this.groupBox1.Controls.Add(this.btn_publicCopy);
            this.groupBox1.Controls.Add(this.txt_privateShow);
            this.groupBox1.Controls.Add(this.txt_publicShow);
            this.groupBox1.Controls.Add(this.btn_CreateRSA);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 565);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_privateName
            // 
            this.txt_privateName.Location = new System.Drawing.Point(559, 156);
            this.txt_privateName.Name = "txt_privateName";
            this.txt_privateName.Size = new System.Drawing.Size(194, 22);
            this.txt_privateName.TabIndex = 6;
            // 
            // txt_publicName
            // 
            this.txt_publicName.Location = new System.Drawing.Point(136, 158);
            this.txt_publicName.Name = "txt_publicName";
            this.txt_publicName.Size = new System.Drawing.Size(194, 22);
            this.txt_publicName.TabIndex = 6;
            // 
            // btn_privateCopy
            // 
            this.btn_privateCopy.Location = new System.Drawing.Point(602, 465);
            this.btn_privateCopy.Name = "btn_privateCopy";
            this.btn_privateCopy.Size = new System.Drawing.Size(75, 30);
            this.btn_privateCopy.TabIndex = 5;
            this.btn_privateCopy.Text = "Copy";
            this.btn_privateCopy.UseVisualStyleBackColor = true;
            this.btn_privateCopy.Click += new System.EventHandler(this.btn_privateCopy_Click);
            // 
            // btn_publicCopy
            // 
            this.btn_publicCopy.Location = new System.Drawing.Point(183, 465);
            this.btn_publicCopy.Name = "btn_publicCopy";
            this.btn_publicCopy.Size = new System.Drawing.Size(75, 30);
            this.btn_publicCopy.TabIndex = 5;
            this.btn_publicCopy.Text = "Copy";
            this.btn_publicCopy.UseVisualStyleBackColor = true;
            this.btn_publicCopy.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_privateShow
            // 
            this.txt_privateShow.Location = new System.Drawing.Point(424, 186);
            this.txt_privateShow.Multiline = true;
            this.txt_privateShow.Name = "txt_privateShow";
            this.txt_privateShow.Size = new System.Drawing.Size(399, 273);
            this.txt_privateShow.TabIndex = 5;
            // 
            // txt_publicShow
            // 
            this.txt_publicShow.Location = new System.Drawing.Point(19, 186);
            this.txt_publicShow.Multiline = true;
            this.txt_publicShow.Name = "txt_publicShow";
            this.txt_publicShow.Size = new System.Drawing.Size(399, 273);
            this.txt_publicShow.TabIndex = 5;
            // 
            // btn_CreateRSA
            // 
            this.btn_CreateRSA.Location = new System.Drawing.Point(309, 518);
            this.btn_CreateRSA.Name = "btn_CreateRSA";
            this.btn_CreateRSA.Size = new System.Drawing.Size(254, 31);
            this.btn_CreateRSA.TabIndex = 2;
            this.btn_CreateRSA.Text = "Generate RSA Key Pair";
            this.btn_CreateRSA.UseVisualStyleBackColor = true;
            this.btn_CreateRSA.Click += new System.EventHandler(this.btn_CreateRSA_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "512 bit",
            "1024 bit",
            "2048 bit"});
            this.comboBox1.Location = new System.Drawing.Point(81, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "File name:";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Private key";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(759, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = ".XML";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "File name:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = ".XML";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Public key";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select RSA Key Size";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GenerateRSAKey_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 590);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerateRSAKey_form";
            this.Text = "GenerateRSAKey";
            this.Load += new System.EventHandler(this.GenerateRSAKey_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_privateCopy;
        private System.Windows.Forms.Button btn_publicCopy;
        private System.Windows.Forms.TextBox txt_privateShow;
        private System.Windows.Forms.Button btn_CreateRSA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_privateName;
        private System.Windows.Forms.TextBox txt_publicName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_publicShow;
    }
}