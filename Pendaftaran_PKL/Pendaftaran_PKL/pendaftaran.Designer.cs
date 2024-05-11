namespace Pendaftaran_PKL
{
    partial class pendaftaran
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

        #region Component Designer generated code

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
            this.label5 = new System.Windows.Forms.Label();
            this.tnama = new System.Windows.Forms.TextBox();
            this.tsekolah = new System.Windows.Forms.TextBox();
            this.tjurusan = new System.Windows.Forms.TextBox();
            this.cbminat = new System.Windows.Forms.ComboBox();
            this.ralasan = new System.Windows.Forms.RichTextBox();
            this.dgdaftar = new System.Windows.Forms.DataGridView();
            this.bsubmit = new System.Windows.Forms.Button();
            this.bupdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tnis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdaftar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sekolah :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Jurusan :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pilih salah 1 minat bidang :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Alasan memilih di bidang tersebut :";
            // 
            // tnama
            // 
            this.tnama.Location = new System.Drawing.Point(74, 28);
            this.tnama.Name = "tnama";
            this.tnama.Size = new System.Drawing.Size(185, 20);
            this.tnama.TabIndex = 1;
            // 
            // tsekolah
            // 
            this.tsekolah.Location = new System.Drawing.Point(74, 54);
            this.tsekolah.Name = "tsekolah";
            this.tsekolah.Size = new System.Drawing.Size(185, 20);
            this.tsekolah.TabIndex = 1;
            // 
            // tjurusan
            // 
            this.tjurusan.Location = new System.Drawing.Point(74, 80);
            this.tjurusan.Name = "tjurusan";
            this.tjurusan.Size = new System.Drawing.Size(185, 20);
            this.tjurusan.TabIndex = 1;
            // 
            // cbminat
            // 
            this.cbminat.FormattingEnabled = true;
            this.cbminat.Items.AddRange(new object[] {
            "Back End Developer",
            "Front End Developer",
            "Digital Creative & Implementation Consultant"});
            this.cbminat.Location = new System.Drawing.Point(502, 7);
            this.cbminat.Name = "cbminat";
            this.cbminat.Size = new System.Drawing.Size(185, 21);
            this.cbminat.TabIndex = 3;
            // 
            // ralasan
            // 
            this.ralasan.Location = new System.Drawing.Point(502, 38);
            this.ralasan.Name = "ralasan";
            this.ralasan.Size = new System.Drawing.Size(185, 41);
            this.ralasan.TabIndex = 4;
            this.ralasan.Text = "";
            // 
            // dgdaftar
            // 
            this.dgdaftar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdaftar.Location = new System.Drawing.Point(43, 124);
            this.dgdaftar.Name = "dgdaftar";
            this.dgdaftar.Size = new System.Drawing.Size(628, 171);
            this.dgdaftar.TabIndex = 5;
            // 
            // bsubmit
            // 
            this.bsubmit.BackColor = System.Drawing.Color.Lime;
            this.bsubmit.Location = new System.Drawing.Point(16, 301);
            this.bsubmit.Name = "bsubmit";
            this.bsubmit.Size = new System.Drawing.Size(75, 23);
            this.bsubmit.TabIndex = 6;
            this.bsubmit.Text = "SUBMIT";
            this.bsubmit.UseVisualStyleBackColor = false;
            this.bsubmit.Click += new System.EventHandler(this.bsubmit_Click);
            // 
            // bupdate
            // 
            this.bupdate.BackColor = System.Drawing.Color.Cyan;
            this.bupdate.Location = new System.Drawing.Point(612, 301);
            this.bupdate.Name = "bupdate";
            this.bupdate.Size = new System.Drawing.Size(75, 23);
            this.bupdate.TabIndex = 6;
            this.bupdate.Text = "UPDATE";
            this.bupdate.UseVisualStyleBackColor = false;
            this.bupdate.Click += new System.EventHandler(this.bupdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nis :";
            // 
            // tnis
            // 
            this.tnis.Location = new System.Drawing.Point(74, 3);
            this.tnis.Name = "tnis";
            this.tnis.Size = new System.Drawing.Size(185, 20);
            this.tnis.TabIndex = 1;
            // 
            // pendaftaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bupdate);
            this.Controls.Add(this.bsubmit);
            this.Controls.Add(this.dgdaftar);
            this.Controls.Add(this.ralasan);
            this.Controls.Add(this.cbminat);
            this.Controls.Add(this.tjurusan);
            this.Controls.Add(this.tsekolah);
            this.Controls.Add(this.tnis);
            this.Controls.Add(this.tnama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "pendaftaran";
            this.Size = new System.Drawing.Size(715, 328);
            ((System.ComponentModel.ISupportInitialize)(this.dgdaftar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tnama;
        private System.Windows.Forms.TextBox tsekolah;
        private System.Windows.Forms.TextBox tjurusan;
        private System.Windows.Forms.ComboBox cbminat;
        private System.Windows.Forms.RichTextBox ralasan;
        private System.Windows.Forms.DataGridView dgdaftar;
        private System.Windows.Forms.Button bsubmit;
        private System.Windows.Forms.Button bupdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tnis;
    }
}
