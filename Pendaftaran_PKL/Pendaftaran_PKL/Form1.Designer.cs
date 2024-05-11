namespace Pendaftaran_PKL
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
            this.label1 = new System.Windows.Forms.Label();
            this.tusername = new System.Windows.Forms.TextBox();
            this.tpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bsubmit = new System.Windows.Forms.Button();
            this.bcancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lregister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // tusername
            // 
            this.tusername.Location = new System.Drawing.Point(196, 106);
            this.tusername.Name = "tusername";
            this.tusername.Size = new System.Drawing.Size(126, 20);
            this.tusername.TabIndex = 1;
            // 
            // tpassword
            // 
            this.tpassword.Location = new System.Drawing.Point(196, 162);
            this.tpassword.Name = "tpassword";
            this.tpassword.Size = new System.Drawing.Size(126, 20);
            this.tpassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "password :";
            // 
            // bsubmit
            // 
            this.bsubmit.BackColor = System.Drawing.Color.Lime;
            this.bsubmit.Location = new System.Drawing.Point(128, 214);
            this.bsubmit.Name = "bsubmit";
            this.bsubmit.Size = new System.Drawing.Size(75, 23);
            this.bsubmit.TabIndex = 4;
            this.bsubmit.Text = "SUBMIT";
            this.bsubmit.UseVisualStyleBackColor = false;
            this.bsubmit.Click += new System.EventHandler(this.bsubmit_Click);
            // 
            // bcancel
            // 
            this.bcancel.BackColor = System.Drawing.Color.Red;
            this.bcancel.Location = new System.Drawing.Point(247, 214);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(75, 23);
            this.bcancel.TabIndex = 4;
            this.bcancel.Text = "CANCEL";
            this.bcancel.UseVisualStyleBackColor = false;
            this.bcancel.Click += new System.EventHandler(this.bcancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "belum mepunyai akun? silahkan";
            // 
            // lregister
            // 
            this.lregister.AutoSize = true;
            this.lregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lregister.Location = new System.Drawing.Point(269, 262);
            this.lregister.Name = "lregister";
            this.lregister.Size = new System.Drawing.Size(36, 12);
            this.lregister.TabIndex = 6;
            this.lregister.TabStop = true;
            this.lregister.Text = "register";
            this.lregister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lregister_LinkClicked_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.lregister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bcancel);
            this.Controls.Add(this.tusername);
            this.Controls.Add(this.bsubmit);
            this.Controls.Add(this.tpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tusername;
        private System.Windows.Forms.TextBox tpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bsubmit;
        private System.Windows.Forms.Button bcancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lregister;
    }
}

