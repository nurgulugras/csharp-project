namespace instagram
{
    partial class yorum
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
            this.label4 = new System.Windows.Forms.Label();
            this.btcikart = new System.Windows.Forms.Button();
            this.tbtakip = new System.Windows.Forms.TextBox();
            this.tbtakipkul = new System.Windows.Forms.TextBox();
            this.rtbyorum = new System.Windows.Forms.RichTextBox();
            this.btekle = new System.Windows.Forms.Button();
            this.tbfoto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Takipten Çıkart:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yorum Ekle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gelen Kullanıcı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // btcikart
            // 
            this.btcikart.Location = new System.Drawing.Point(114, 142);
            this.btcikart.Name = "btcikart";
            this.btcikart.Size = new System.Drawing.Size(199, 23);
            this.btcikart.TabIndex = 4;
            this.btcikart.Text = "Takipten Çıkart";
            this.btcikart.UseVisualStyleBackColor = true;
            this.btcikart.Click += new System.EventHandler(this.btcikart_Click);
            // 
            // tbtakip
            // 
            this.tbtakip.Location = new System.Drawing.Point(211, 50);
            this.tbtakip.Name = "tbtakip";
            this.tbtakip.Size = new System.Drawing.Size(100, 20);
            this.tbtakip.TabIndex = 5;
            // 
            // tbtakipkul
            // 
            this.tbtakipkul.Location = new System.Drawing.Point(211, 93);
            this.tbtakipkul.Name = "tbtakipkul";
            this.tbtakipkul.Size = new System.Drawing.Size(100, 20);
            this.tbtakipkul.TabIndex = 6;
            // 
            // rtbyorum
            // 
            this.rtbyorum.Location = new System.Drawing.Point(349, 36);
            this.rtbyorum.Name = "rtbyorum";
            this.rtbyorum.Size = new System.Drawing.Size(136, 96);
            this.rtbyorum.TabIndex = 7;
            this.rtbyorum.Text = "";
            // 
            // btekle
            // 
            this.btekle.Location = new System.Drawing.Point(349, 168);
            this.btekle.Name = "btekle";
            this.btekle.Size = new System.Drawing.Size(136, 23);
            this.btekle.TabIndex = 8;
            this.btekle.Text = "Yorum Ekle";
            this.btekle.UseVisualStyleBackColor = true;
            this.btekle.Click += new System.EventHandler(this.btekle_Click);
            // 
            // tbfoto
            // 
            this.tbfoto.Location = new System.Drawing.Point(401, 142);
            this.tbfoto.Name = "tbfoto";
            this.tbfoto.Size = new System.Drawing.Size(84, 20);
            this.tbfoto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fotoğraf:";
            // 
            // yorum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbfoto);
            this.Controls.Add(this.btekle);
            this.Controls.Add(this.rtbyorum);
            this.Controls.Add(this.tbtakipkul);
            this.Controls.Add(this.tbtakip);
            this.Controls.Add(this.btcikart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "yorum";
            this.Text = "yorum";
            this.Load += new System.EventHandler(this.yorum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btcikart;
        private System.Windows.Forms.TextBox tbtakip;
        private System.Windows.Forms.TextBox tbtakipkul;
        private System.Windows.Forms.RichTextBox rtbyorum;
        private System.Windows.Forms.Button btekle;
        private System.Windows.Forms.TextBox tbfoto;
        private System.Windows.Forms.Label label5;
    }
}