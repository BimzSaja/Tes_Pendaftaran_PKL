namespace Pendaftaran_PKL
{
    partial class registerr
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
            this.bcancel = new System.Windows.Forms.Button();
            this.bsubmit = new System.Windows.Forms.Button();
            this.tpassword = new System.Windows.Forms.TextBox();
            this.tnis = new System.Windows.Forms.TextBox();
            this.llogin = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tusername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bcancel
            // 
            this.bcancel.BackColor = System.Drawing.Color.Red;
            this.bcancel.Location = new System.Drawing.Point(259, 218);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(75, 23);
            this.bcancel.TabIndex = 12;
            this.bcancel.Text = "CANCEL";
            this.bcancel.UseVisualStyleBackColor = false;
            this.bcancel.Click += new System.EventHandler(this.bcancel_Click);
            // 
            // bsubmit
            // 
            this.bsubmit.BackColor = System.Drawing.Color.Lime;
            this.bsubmit.Location = new System.Drawing.Point(134, 218);
            this.bsubmit.Name = "bsubmit";
            this.bsubmit.Size = new System.Drawing.Size(75, 23);
            this.bsubmit.TabIndex = 13;
            this.bsubmit.Text = "SUBMIT";
            this.bsubmit.UseVisualStyleBackColor = false;
            this.bsubmit.Click += new System.EventHandler(this.bsubmit_Click);
            // 
            // tpassword
            // 
            this.tpassword.Location = new System.Drawing.Point(197, 170);
            this.tpassword.Name = "tpassword";
            this.tpassword.Size = new System.Drawing.Size(137, 20);
            this.tpassword.TabIndex = 10;
            // 
            // tnis
            // 
            this.tnis.Location = new System.Drawing.Point(197, 107);
            this.tnis.Name = "tnis";
            this.tnis.Size = new System.Drawing.Size(137, 20);
            this.tnis.TabIndex = 11;
            // 
            // llogin
            // 
            this.llogin.AutoSize = true;
            this.llogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llogin.Location = new System.Drawing.Point(294, 268);
            this.llogin.Name = "llogin";
            this.llogin.Size = new System.Drawing.Size(24, 12);
            this.llogin.TabIndex = 9;
            this.llogin.TabStop = true;
            this.llogin.Text = "login";
            this.llogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llogin_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "sudah mempunyai akun? silahkan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "nis :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "REGISTER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "username :";
            // 
            // tusername
            // 
            this.tusername.Location = new System.Drawing.Point(197, 139);
            this.tusername.Name = "tusername";
            this.tusername.Size = new System.Drawing.Size(137, 20);
            this.tusername.TabIndex = 11;
            // 
            // registerr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.bcancel);
            this.Controls.Add(this.bsubmit);
            this.Controls.Add(this.tpassword);
            this.Controls.Add(this.tusername);
            this.Controls.Add(this.tnis);
            this.Controls.Add(this.llogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registerr";
            this.Text = "registerr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bcancel;
        private System.Windows.Forms.Button bsubmit;
        private System.Windows.Forms.TextBox tpassword;
        private System.Windows.Forms.TextBox tnis;
        private System.Windows.Forms.LinkLabel llogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tusername;
    }
}