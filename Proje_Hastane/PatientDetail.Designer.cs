namespace Proje_Hastane
{
    partial class PatientDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PatNameSurname = new System.Windows.Forms.Label();
            this.PatDetailEdit = new System.Windows.Forms.LinkLabel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.PatTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PatSend = new System.Windows.Forms.Button();
            this.PatDoctor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PatBranch = new System.Windows.Forms.ComboBox();
            this.PatSubject = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PatNameSurname);
            this.groupBox1.Controls.Add(this.PatDetailEdit);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.PatTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // PatNameSurname
            // 
            this.PatNameSurname.AutoSize = true;
            this.PatNameSurname.Location = new System.Drawing.Point(9, 101);
            this.PatNameSurname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PatNameSurname.Name = "PatNameSurname";
            this.PatNameSurname.Size = new System.Drawing.Size(86, 22);
            this.PatNameSurname.TabIndex = 14;
            this.PatNameSurname.Text = "Null Null";
            // 
            // PatDetailEdit
            // 
            this.PatDetailEdit.AutoSize = true;
            this.PatDetailEdit.Location = new System.Drawing.Point(9, 132);
            this.PatDetailEdit.Name = "PatDetailEdit";
            this.PatDetailEdit.Size = new System.Drawing.Size(242, 22);
            this.PatDetailEdit.TabIndex = 4;
            this.PatDetailEdit.TabStop = true;
            this.PatDetailEdit.Text = "Kullanıcı Bilgilerini Düzenle";
            this.PatDetailEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PatDetailEdit_LinkClicked);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(9, 79);
            this.lbl1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(96, 22);
            this.lbl1.TabIndex = 12;
            this.lbl1.Text = "Ad Soyad:";
            // 
            // PatTc
            // 
            this.PatTc.AutoSize = true;
            this.PatTc.Location = new System.Drawing.Point(9, 48);
            this.PatTc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PatTc.Name = "PatTc";
            this.PatTc.Size = new System.Drawing.Size(131, 22);
            this.PatTc.TabIndex = 11;
            this.PatTc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtıd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.PatSend);
            this.groupBox2.Controls.Add(this.PatDoctor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PatBranch);
            this.groupBox2.Controls.Add(this.PatSubject);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(15, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Al";
            // 
            // txtıd
            // 
            this.txtıd.Enabled = false;
            this.txtıd.Location = new System.Drawing.Point(86, 29);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(155, 30);
            this.txtıd.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Şikayet:";
            // 
            // PatSend
            // 
            this.PatSend.Location = new System.Drawing.Point(86, 265);
            this.PatSend.Name = "PatSend";
            this.PatSend.Size = new System.Drawing.Size(157, 35);
            this.PatSend.TabIndex = 4;
            this.PatSend.Text = "Randevu Al";
            this.PatSend.UseVisualStyleBackColor = true;
            this.PatSend.Click += new System.EventHandler(this.PatSend_Click);
            // 
            // PatDoctor
            // 
            this.PatDoctor.FormattingEnabled = true;
            this.PatDoctor.Location = new System.Drawing.Point(86, 101);
            this.PatDoctor.Name = "PatDoctor";
            this.PatDoctor.Size = new System.Drawing.Size(155, 30);
            this.PatDoctor.TabIndex = 4;
            this.PatDoctor.SelectedIndexChanged += new System.EventHandler(this.PatDoctor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Doktor:";
            // 
            // PatBranch
            // 
            this.PatBranch.FormattingEnabled = true;
            this.PatBranch.Location = new System.Drawing.Point(86, 65);
            this.PatBranch.Name = "PatBranch";
            this.PatBranch.Size = new System.Drawing.Size(155, 30);
            this.PatBranch.TabIndex = 2;
            this.PatBranch.SelectedIndexChanged += new System.EventHandler(this.PatBranch_SelectedIndexChanged);
            // 
            // PatSubject
            // 
            this.PatSubject.Location = new System.Drawing.Point(86, 141);
            this.PatSubject.Name = "PatSubject";
            this.PatSubject.Size = new System.Drawing.Size(157, 118);
            this.PatSubject.TabIndex = 3;
            this.PatSubject.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Branş:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(274, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(755, 280);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Geçmiş Randevular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(277, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(755, 280);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(749, 251);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sistemden Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Futura Bk BT", 10.25F);
            this.label3.Location = new System.Drawing.Point(889, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Futura Bk BT", 10.25F);
            this.label7.Location = new System.Drawing.Point(785, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sistem Zamanı:";
            // 
            // PatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1040, 594);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "PatientDetail";
            this.Text = "Hasta Detay";
            this.Load += new System.EventHandler(this.PatientDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label PatTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PatSend;
        private System.Windows.Forms.ComboBox PatDoctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PatBranch;
        private System.Windows.Forms.RichTextBox PatSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel PatDetailEdit;
        private System.Windows.Forms.Label PatNameSurname;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
    }
}