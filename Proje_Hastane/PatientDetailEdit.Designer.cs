namespace Proje_Hastane
{
    partial class PatientDetailEdit
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
            this.PatUpdate = new System.Windows.Forms.Button();
            this.PatGender = new System.Windows.Forms.ComboBox();
            this.PatPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PatPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PatName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PatSurname = new System.Windows.Forms.TextBox();
            this.PatTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PatUpdate
            // 
            this.PatUpdate.Location = new System.Drawing.Point(122, 306);
            this.PatUpdate.Name = "PatUpdate";
            this.PatUpdate.Size = new System.Drawing.Size(172, 37);
            this.PatUpdate.TabIndex = 31;
            this.PatUpdate.Text = "Güncelle";
            this.PatUpdate.UseVisualStyleBackColor = true;
            this.PatUpdate.Click += new System.EventHandler(this.PatUpdate_Click);
            // 
            // PatGender
            // 
            this.PatGender.FormattingEnabled = true;
            this.PatGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.PatGender.Location = new System.Drawing.Point(122, 230);
            this.PatGender.Name = "PatGender";
            this.PatGender.Size = new System.Drawing.Size(172, 30);
            this.PatGender.TabIndex = 5;
            // 
            // PatPass
            // 
            this.PatPass.Location = new System.Drawing.Point(122, 268);
            this.PatPass.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PatPass.Name = "PatPass";
            this.PatPass.Size = new System.Drawing.Size(172, 30);
            this.PatPass.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Cinsiyet";
            // 
            // PatPhoneNumber
            // 
            this.PatPhoneNumber.Location = new System.Drawing.Point(122, 192);
            this.PatPhoneNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PatPhoneNumber.Mask = "(999) 000-0000";
            this.PatPhoneNumber.Name = "PatPhoneNumber";
            this.PatPhoneNumber.Size = new System.Drawing.Size(172, 30);
            this.PatPhoneNumber.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telefon No:";
            // 
            // PatName
            // 
            this.PatName.Location = new System.Drawing.Point(122, 72);
            this.PatName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(172, 30);
            this.PatName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ad:";
            // 
            // PatSurname
            // 
            this.PatSurname.Location = new System.Drawing.Point(122, 112);
            this.PatSurname.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PatSurname.Name = "PatSurname";
            this.PatSurname.Size = new System.Drawing.Size(172, 30);
            this.PatSurname.TabIndex = 2;
            // 
            // PatTc
            // 
            this.PatTc.Location = new System.Drawing.Point(122, 152);
            this.PatTc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PatTc.Mask = "00000000000";
            this.PatTc.Name = "PatTc";
            this.PatTc.Size = new System.Drawing.Size(172, 30);
            this.PatTc.TabIndex = 3;
            this.PatTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "TC No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 22);
            this.label7.TabIndex = 32;
            this.label7.Text = "Hasta Bilgilerini Güncelle";
            // 
            // PatientDetailEdit
            // 
            this.AcceptButton = this.PatUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(324, 351);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PatUpdate);
            this.Controls.Add(this.PatGender);
            this.Controls.Add(this.PatPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PatPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatSurname);
            this.Controls.Add(this.PatTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "PatientDetailEdit";
            this.Text = "Hasta Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.PatientDetailEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PatUpdate;
        private System.Windows.Forms.ComboBox PatGender;
        private System.Windows.Forms.TextBox PatPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox PatPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PatName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatSurname;
        private System.Windows.Forms.MaskedTextBox PatTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}