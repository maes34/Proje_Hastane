namespace Proje_Hastane
{
    partial class SecretaryLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecretaryLogin));
            this.PerLogin = new System.Windows.Forms.Button();
            this.PerPass = new System.Windows.Forms.TextBox();
            this.PerTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PerLogin
            // 
            this.PerLogin.Location = new System.Drawing.Point(167, 173);
            this.PerLogin.Name = "PerLogin";
            this.PerLogin.Size = new System.Drawing.Size(131, 33);
            this.PerLogin.TabIndex = 19;
            this.PerLogin.Text = "Giriş Yap";
            this.PerLogin.UseVisualStyleBackColor = true;
            this.PerLogin.Click += new System.EventHandler(this.PerLogin_Click);
            // 
            // PerPass
            // 
            this.PerPass.Location = new System.Drawing.Point(110, 137);
            this.PerPass.Name = "PerPass";
            this.PerPass.Size = new System.Drawing.Size(188, 30);
            this.PerPass.TabIndex = 18;
            this.PerPass.UseSystemPasswordChar = true;
            // 
            // PerTc
            // 
            this.PerTc.Location = new System.Drawing.Point(110, 90);
            this.PerTc.Mask = "00000000000";
            this.PerTc.Name = "PerTc";
            this.PerTc.Size = new System.Drawing.Size(188, 30);
            this.PerTc.TabIndex = 17;
            this.PerTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "TC No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Personel Giriş Ekranı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "< Giriş Ekranı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SecretaryLogin
            // 
            this.AcceptButton = this.PerLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PerLogin);
            this.Controls.Add(this.PerPass);
            this.Controls.Add(this.PerTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "SecretaryLogin";
            this.Text = "Personel Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PerLogin;
        private System.Windows.Forms.TextBox PerPass;
        private System.Windows.Forms.MaskedTextBox PerTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}