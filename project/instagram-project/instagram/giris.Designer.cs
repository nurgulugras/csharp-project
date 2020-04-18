namespace instagram
{
    partial class giris
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbkul = new System.Windows.Forms.TextBox();
            this.tbsif = new System.Windows.Forms.TextBox();
            this.btgiris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Kaydol = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instagram";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(272, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(272, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şifre:";
            // 
            // tbkul
            // 
            this.tbkul.Location = new System.Drawing.Point(406, 107);
            this.tbkul.Name = "tbkul";
            this.tbkul.Size = new System.Drawing.Size(152, 20);
            this.tbkul.TabIndex = 4;
            // 
            // tbsif
            // 
            this.tbsif.Location = new System.Drawing.Point(406, 140);
            this.tbsif.Name = "tbsif";
            this.tbsif.PasswordChar = '*';
            this.tbsif.Size = new System.Drawing.Size(152, 20);
            this.tbsif.TabIndex = 5;
            // 
            // btgiris
            // 
            this.btgiris.BackColor = System.Drawing.SystemColors.Highlight;
            this.btgiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btgiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btgiris.Location = new System.Drawing.Point(275, 183);
            this.btgiris.Name = "btgiris";
            this.btgiris.Size = new System.Drawing.Size(283, 32);
            this.btgiris.TabIndex = 6;
            this.btgiris.Text = "Giriş Yap";
            this.btgiris.UseVisualStyleBackColor = false;
            this.btgiris.Click += new System.EventHandler(this.btgiris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(324, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hesabın yok mu?";
            // 
            // Kaydol
            // 
            this.Kaydol.AutoSize = true;
            this.Kaydol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kaydol.Location = new System.Drawing.Point(453, 288);
            this.Kaydol.Name = "Kaydol";
            this.Kaydol.Size = new System.Drawing.Size(53, 18);
            this.Kaydol.TabIndex = 9;
            this.Kaydol.TabStop = true;
            this.Kaydol.Text = "Kaydol";
            this.Kaydol.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Kaydol_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(314, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 10;
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 332);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Kaydol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btgiris);
            this.Controls.Add(this.tbsif);
            this.Controls.Add(this.tbkul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "giris";
            this.Text = "Giriş yap";
            this.Load += new System.EventHandler(this.giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbkul;
        private System.Windows.Forms.TextBox tbsif;
        private System.Windows.Forms.Button btgiris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel Kaydol;
        private System.Windows.Forms.Label label5;
    }
}