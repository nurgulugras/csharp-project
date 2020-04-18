namespace instagram
{
    partial class resimekle
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btekle = new System.Windows.Forms.Button();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btpaylas = new System.Windows.Forms.Button();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.lblogo = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbkullanici = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btekle
            // 
            this.btekle.Location = new System.Drawing.Point(253, 67);
            this.btekle.Name = "btekle";
            this.btekle.Size = new System.Drawing.Size(121, 23);
            this.btekle.TabIndex = 1;
            this.btekle.Text = "Resim Ekle";
            this.btekle.UseVisualStyleBackColor = true;
            this.btekle.Click += new System.EventHandler(this.btekle_Click);
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(12, 67);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(228, 165);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResim.TabIndex = 2;
            this.pbResim.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 9;
            // 
            // btpaylas
            // 
            this.btpaylas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btpaylas.Location = new System.Drawing.Point(356, 269);
            this.btpaylas.Name = "btpaylas";
            this.btpaylas.Size = new System.Drawing.Size(148, 27);
            this.btpaylas.TabIndex = 5;
            this.btpaylas.Text = "Paylaş";
            this.btpaylas.UseVisualStyleBackColor = true;
            this.btpaylas.Click += new System.EventHandler(this.btpaylas_Click_1);
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Location = new System.Drawing.Point(356, 167);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(148, 96);
            this.rtbAciklama.TabIndex = 7;
            this.rtbAciklama.Text = "";
            // 
            // lblogo
            // 
            this.lblogo.AutoSize = true;
            this.lblogo.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblogo.LinkColor = System.Drawing.Color.Black;
            this.lblogo.Location = new System.Drawing.Point(23, 9);
            this.lblogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblogo.Name = "lblogo";
            this.lblogo.Size = new System.Drawing.Size(136, 32);
            this.lblogo.TabIndex = 8;
            this.lblogo.TabStop = true;
            this.lblogo.Text = "Instagram";
            this.lblogo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblogo_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(250, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Açıklama Ekle:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(250, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gelen Kullanıcı:";
            // 
            // lbkullanici
            // 
            this.lbkullanici.AutoSize = true;
            this.lbkullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbkullanici.Location = new System.Drawing.Point(352, 134);
            this.lbkullanici.Name = "lbkullanici";
            this.lbkullanici.Size = new System.Drawing.Size(0, 20);
            this.lbkullanici.TabIndex = 15;
            // 
            // resimekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 361);
            this.Controls.Add(this.lbkullanici);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblogo);
            this.Controls.Add(this.rtbAciklama);
            this.Controls.Add(this.btpaylas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.btekle);
            this.Name = "resimekle";
            this.Text = "Resim Ekle";
            this.Load += new System.EventHandler(this.resimekle_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btekle;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btpaylas;
        private System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.LinkLabel lblogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbkullanici;
    }
}