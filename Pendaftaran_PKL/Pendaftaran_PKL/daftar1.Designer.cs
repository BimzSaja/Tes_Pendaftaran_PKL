namespace Pendaftaran_PKL
{
    partial class daftar1
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
            this.bupdate = new System.Windows.Forms.Button();
            this.bsubmit = new System.Windows.Forms.Button();
            this.dgdaftar = new System.Windows.Forms.DataGridView();
            this.ralasan = new System.Windows.Forms.RichTextBox();
            this.cbminat = new System.Windows.Forms.ComboBox();
            this.tjurusan = new System.Windows.Forms.TextBox();
            this.tsekolah = new System.Windows.Forms.TextBox();
            this.tnama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgdaftar)).BeginInit();
            this.SuspendLayout();
            // 
            // bupdate
            // 
            this.bupdate.BackColor = System.Drawing.Color.Cyan;
            this.bupdate.Location = new System.Drawing.Point(608, 290);
            this.bupdate.Name = "bupdate";
            this.bupdate.Size = new System.Drawing.Size(95, 32);
            this.bupdate.TabIndex = 44;
            this.bupdate.Text = "Update";
            this.bupdate.UseVisualStyleBackColor = false;
            // 
            // bsubmit
            // 
            this.bsubmit.BackColor = System.Drawing.Color.Lime;
            this.bsubmit.Location = new System.Drawing.Point(14, 290);
            this.bsubmit.Name = "bsubmit";
            this.bsubmit.Size = new System.Drawing.Size(95, 32);
            this.bsubmit.TabIndex = 45;
            this.bsubmit.Text = "Submit";
            this.bsubmit.UseVisualStyleBackColor = false;
            this.bsubmit.Click += new System.EventHandler(this.bsubmit_Click);
            // 
            // dgdaftar
            // 
            this.dgdaftar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdaftar.Location = new System.Drawing.Point(14, 91);
            this.dgdaftar.Name = "dgdaftar";
            this.dgdaftar.Size = new System.Drawing.Size(689, 193);
            this.dgdaftar.TabIndex = 43;
            // 
            // ralasan
            // 
            this.ralasan.Location = new System.Drawing.Point(507, 33);
            this.ralasan.Name = "ralasan";
            this.ralasan.Size = new System.Drawing.Size(196, 43);
            this.ralasan.TabIndex = 42;
            this.ralasan.Text = "";
            // 
            // cbminat
            // 
            this.cbminat.FormattingEnabled = true;
            this.cbminat.Items.AddRange(new object[] {
            "Back End Developer",
            "Front End Developer",
            "Digital Creative & Implementation Consultant"});
            this.cbminat.Location = new System.Drawing.Point(507, 6);
            this.cbminat.Name = "cbminat";
            this.cbminat.Size = new System.Drawing.Size(196, 21);
            this.cbminat.TabIndex = 41;
            // 
            // tjurusan
            // 
            this.tjurusan.Location = new System.Drawing.Point(72, 56);
            this.tjurusan.Name = "tjurusan";
            this.tjurusan.Size = new System.Drawing.Size(196, 20);
            this.tjurusan.TabIndex = 38;
            // 
            // tsekolah
            // 
            this.tsekolah.Location = new System.Drawing.Point(72, 30);
            this.tsekolah.Name = "tsekolah";
            this.tsekolah.Size = new System.Drawing.Size(196, 20);
            this.tsekolah.TabIndex = 39;
            // 
            // tnama
            // 
            this.tnama.Location = new System.Drawing.Point(72, 7);
            this.tnama.Name = "tnama";
            this.tnama.Size = new System.Drawing.Size(196, 20);
            this.tnama.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Alasan Memilih Di Bidang Tersebut :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Pilih Salah Satu Minat Bidang :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Jurusan :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Sekolah :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nama :";
            // 
            // daftar1
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
            this.Controls.Add(this.tnama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "daftar1";
            this.Size = new System.Drawing.Size(715, 328);
            ((System.ComponentModel.ISupportInitialize)(this.dgdaftar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bupdate;
        private System.Windows.Forms.Button bsubmit;
        private System.Windows.Forms.DataGridView dgdaftar;
        private System.Windows.Forms.RichTextBox ralasan;
        private System.Windows.Forms.ComboBox cbminat;
        private System.Windows.Forms.TextBox tjurusan;
        private System.Windows.Forms.TextBox tsekolah;
        private System.Windows.Forms.TextBox tnama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
