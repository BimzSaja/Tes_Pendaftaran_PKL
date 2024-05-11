namespace Pendaftaran_PKL
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.blogout = new System.Windows.Forms.Button();
            this.bpendaftaran = new System.Windows.Forms.Button();
            this.bberanda = new System.Windows.Forms.Button();
            this.beranda1 = new Pendaftaran_PKL.beranda();
            this.pendaftaran2 = new Pendaftaran_PKL.pendaftaran();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 39);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(724, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selamat Datang";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Location = new System.Drawing.Point(0, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 39);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Controls.Add(this.blogout);
            this.panel3.Controls.Add(this.bpendaftaran);
            this.panel3.Controls.Add(this.bberanda);
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(81, 355);
            this.panel3.TabIndex = 1;
            // 
            // blogout
            // 
            this.blogout.BackColor = System.Drawing.Color.Red;
            this.blogout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.blogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blogout.Location = new System.Drawing.Point(0, 321);
            this.blogout.Name = "blogout";
            this.blogout.Size = new System.Drawing.Size(81, 34);
            this.blogout.TabIndex = 2;
            this.blogout.Text = "LOG OUT";
            this.blogout.UseVisualStyleBackColor = false;
            this.blogout.Click += new System.EventHandler(this.blogout_Click);
            // 
            // bpendaftaran
            // 
            this.bpendaftaran.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bpendaftaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bpendaftaran.Location = new System.Drawing.Point(0, 69);
            this.bpendaftaran.Name = "bpendaftaran";
            this.bpendaftaran.Size = new System.Drawing.Size(81, 69);
            this.bpendaftaran.TabIndex = 2;
            this.bpendaftaran.Text = "Pendaftaran PKL";
            this.bpendaftaran.UseVisualStyleBackColor = true;
            this.bpendaftaran.Click += new System.EventHandler(this.bpendaftaran_Click);
            // 
            // bberanda
            // 
            this.bberanda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bberanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bberanda.Location = new System.Drawing.Point(0, 0);
            this.bberanda.Name = "bberanda";
            this.bberanda.Size = new System.Drawing.Size(81, 69);
            this.bberanda.TabIndex = 2;
            this.bberanda.Text = "Beranda";
            this.bberanda.UseVisualStyleBackColor = true;
            this.bberanda.Click += new System.EventHandler(this.bberanda_Click);
            // 
            // beranda1
            // 
            this.beranda1.Location = new System.Drawing.Point(84, 43);
            this.beranda1.Name = "beranda1";
            this.beranda1.Size = new System.Drawing.Size(715, 328);
            this.beranda1.TabIndex = 3;
            // 
            // pendaftaran2
            // 
            this.pendaftaran2.Location = new System.Drawing.Point(84, 45);
            this.pendaftaran2.Name = "pendaftaran2";
            this.pendaftaran2.Size = new System.Drawing.Size(715, 328);
            this.pendaftaran2.TabIndex = 4;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.beranda1);
            this.Controls.Add(this.pendaftaran2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.Text = "home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bberanda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button blogout;
        private System.Windows.Forms.Button bpendaftaran;
        private System.Windows.Forms.Label label1;
        private pendaftaran pendaftaran1;
        private pendaftaran pendaftaran2;
        private beranda beranda1;
        private System.Windows.Forms.Button button1;
    }
}