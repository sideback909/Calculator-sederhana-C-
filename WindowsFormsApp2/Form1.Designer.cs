namespace WindowsFormsApp2
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
            this.btnHitung = new System.Windows.Forms.Button();
            this.nilai2 = new System.Windows.Forms.TextBox();
            this.nilai1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstHasil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.operasi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(195, 56);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 10;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // nilai2
            // 
            this.nilai2.Location = new System.Drawing.Point(65, 56);
            this.nilai2.Name = "nilai2";
            this.nilai2.Size = new System.Drawing.Size(100, 20);
            this.nilai2.TabIndex = 9;
            this.nilai2.TextChanged += new System.EventHandler(this.nilai2_TextChanged);
            // 
            // nilai1
            // 
            this.nilai1.Location = new System.Drawing.Point(65, 6);
            this.nilai1.Name = "nilai1";
            this.nilai1.Size = new System.Drawing.Size(100, 20);
            this.nilai1.TabIndex = 8;
            this.nilai1.TextChanged += new System.EventHandler(this.nilai1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nilai B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nilai A";
            // 
            // lstHasil
            // 
            this.lstHasil.Location = new System.Drawing.Point(65, 111);
            this.lstHasil.Multiline = true;
            this.lstHasil.Name = "lstHasil";
            this.lstHasil.Size = new System.Drawing.Size(100, 20);
            this.lstHasil.TabIndex = 11;
            this.lstHasil.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hasil";
            // 
            // operasi
            // 
            this.operasi.FormattingEnabled = true;
            this.operasi.Items.AddRange(new object[] {
            "Pertambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.operasi.Location = new System.Drawing.Point(65, 174);
            this.operasi.Name = "operasi";
            this.operasi.Size = new System.Drawing.Size(100, 21);
            this.operasi.TabIndex = 13;
            this.operasi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Operasi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.operasi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstHasil);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.nilai2);
            this.Controls.Add(this.nilai1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.TextBox nilai2;
        private System.Windows.Forms.TextBox nilai1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lstHasil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox operasi;
        private System.Windows.Forms.Label label4;
    }
}

