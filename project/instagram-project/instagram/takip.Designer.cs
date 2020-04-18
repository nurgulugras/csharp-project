namespace instagram
{
    partial class takip
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
            this.tbgelenkul = new System.Windows.Forms.TextBox();
            this.bttakip = new System.Windows.Forms.Button();
            this.tbtakipkul = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gelen Kullanıcı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // tbgelenkul
            // 
            this.tbgelenkul.Location = new System.Drawing.Point(123, 24);
            this.tbgelenkul.Name = "tbgelenkul";
            this.tbgelenkul.Size = new System.Drawing.Size(100, 20);
            this.tbgelenkul.TabIndex = 3;
            // 
            // bttakip
            // 
            this.bttakip.Location = new System.Drawing.Point(40, 92);
            this.bttakip.Name = "bttakip";
            this.bttakip.Size = new System.Drawing.Size(183, 23);
            this.bttakip.TabIndex = 6;
            this.bttakip.Text = "Takip Et";
            this.bttakip.UseVisualStyleBackColor = true;
            this.bttakip.Click += new System.EventHandler(this.bttakip_Click);
            // 
            // tbtakipkul
            // 
            this.tbtakipkul.Location = new System.Drawing.Point(123, 55);
            this.tbtakipkul.Name = "tbtakipkul";
            this.tbtakipkul.Size = new System.Drawing.Size(100, 20);
            this.tbtakipkul.TabIndex = 4;
            // 
            // takip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 155);
            this.Controls.Add(this.bttakip);
            this.Controls.Add(this.tbtakipkul);
            this.Controls.Add(this.tbgelenkul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "takip";
            this.Text = "takip";
            this.Load += new System.EventHandler(this.takip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbgelenkul;
        private System.Windows.Forms.Button bttakip;
        private System.Windows.Forms.TextBox tbtakipkul;
    }
}