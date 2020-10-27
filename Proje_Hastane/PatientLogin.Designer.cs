namespace Proje_Hastane
{
    partial class PatientLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PatTc = new System.Windows.Forms.MaskedTextBox();
            this.PatPass = new System.Windows.Forms.TextBox();
            this.PatReg = new System.Windows.Forms.LinkLabel();
            this.PatLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // PatTc
            // 
            this.PatTc.Location = new System.Drawing.Point(110, 90);
            this.PatTc.Mask = "00000000000";
            this.PatTc.Name = "PatTc";
            this.PatTc.Size = new System.Drawing.Size(188, 30);
            this.PatTc.TabIndex = 3;
            this.PatTc.ValidatingType = typeof(int);
            // 
            // PatPass
            // 
            this.PatPass.Location = new System.Drawing.Point(110, 137);
            this.PatPass.Name = "PatPass";
            this.PatPass.Size = new System.Drawing.Size(188, 30);
            this.PatPass.TabIndex = 4;
            this.PatPass.UseSystemPasswordChar = true;
            // 
            // PatReg
            // 
            this.PatReg.AutoSize = true;
            this.PatReg.Location = new System.Drawing.Point(214, 209);
            this.PatReg.Name = "PatReg";
            this.PatReg.Size = new System.Drawing.Size(84, 22);
            this.PatReg.TabIndex = 5;
            this.PatReg.TabStop = true;
            this.PatReg.Text = "Kayıt Ol!";
            this.PatReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PatReg_LinkClicked);
            // 
            // PatLogin
            // 
            this.PatLogin.Location = new System.Drawing.Point(167, 173);
            this.PatLogin.Name = "PatLogin";
            this.PatLogin.Size = new System.Drawing.Size(131, 33);
            this.PatLogin.TabIndex = 6;
            this.PatLogin.Text = "Giriş Yap";
            this.PatLogin.UseVisualStyleBackColor = true;
            this.PatLogin.Click += new System.EventHandler(this.PatLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PatientLogin
            // 
            this.AcceptButton = this.PatLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PatLogin);
            this.Controls.Add(this.PatReg);
            this.Controls.Add(this.PatPass);
            this.Controls.Add(this.PatTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "PatientLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox PatTc;
        private System.Windows.Forms.TextBox PatPass;
        private System.Windows.Forms.LinkLabel PatReg;
        private System.Windows.Forms.Button PatLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}