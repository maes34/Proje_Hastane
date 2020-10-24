namespace Proje_Hastane
{
    partial class DoctorİnformationEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorİnformationEdit));
            this.label7 = new System.Windows.Forms.Label();
            this.DocUpdate = new System.Windows.Forms.Button();
            this.DocPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DocName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DocSurname = new System.Windows.Forms.TextBox();
            this.DocTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DocBranch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 22);
            this.label7.TabIndex = 46;
            this.label7.Text = "Doktor Bilgilerini Güncelle";
            // 
            // DocUpdate
            // 
            this.DocUpdate.Location = new System.Drawing.Point(122, 266);
            this.DocUpdate.Name = "DocUpdate";
            this.DocUpdate.Size = new System.Drawing.Size(172, 37);
            this.DocUpdate.TabIndex = 45;
            this.DocUpdate.Text = "Güncelle";
            this.DocUpdate.UseVisualStyleBackColor = true;
            this.DocUpdate.Click += new System.EventHandler(this.DocUpdate_Click);
            // 
            // DocPass
            // 
            this.DocPass.Location = new System.Drawing.Point(122, 228);
            this.DocPass.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DocPass.Name = "DocPass";
            this.DocPass.Size = new System.Drawing.Size(172, 30);
            this.DocPass.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 22);
            this.label6.TabIndex = 42;
            this.label6.Text = "Şifre:";
            // 
            // DocName
            // 
            this.DocName.Location = new System.Drawing.Point(122, 72);
            this.DocName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DocName.Name = "DocName";
            this.DocName.Size = new System.Drawing.Size(172, 30);
            this.DocName.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ad:";
            // 
            // DocSurname
            // 
            this.DocSurname.Location = new System.Drawing.Point(122, 112);
            this.DocSurname.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DocSurname.Name = "DocSurname";
            this.DocSurname.Size = new System.Drawing.Size(172, 30);
            this.DocSurname.TabIndex = 36;
            // 
            // DocTc
            // 
            this.DocTc.Location = new System.Drawing.Point(122, 152);
            this.DocTc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DocTc.Mask = "00000000000";
            this.DocTc.Name = "DocTc";
            this.DocTc.Size = new System.Drawing.Size(172, 30);
            this.DocTc.TabIndex = 35;
            this.DocTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "TC No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 47;
            this.label4.Text = "Branş:";
            // 
            // DocBranch
            // 
            this.DocBranch.FormattingEnabled = true;
            this.DocBranch.Location = new System.Drawing.Point(122, 190);
            this.DocBranch.Name = "DocBranch";
            this.DocBranch.Size = new System.Drawing.Size(172, 30);
            this.DocBranch.TabIndex = 48;
            // 
            // DoctorİnformationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(324, 351);
            this.Controls.Add(this.DocBranch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DocUpdate);
            this.Controls.Add(this.DocPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DocName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DocSurname);
            this.Controls.Add(this.DocTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimizeBox = false;
            this.Name = "DoctorİnformationEdit";
            this.Text = "Doktor Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.DoctorİnformationEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DocUpdate;
        private System.Windows.Forms.TextBox DocPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DocName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DocSurname;
        private System.Windows.Forms.MaskedTextBox DocTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DocBranch;
    }
}