namespace instagram
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.lblogo = new System.Windows.Forms.LinkLabel();
            this.lbkullaniciad = new System.Windows.Forms.Label();
            this.btkesfet = new System.Windows.Forms.Button();
            this.btresimekle = new System.Windows.Forms.Button();
            this.btprofil = new System.Windows.Forms.Button();
            this.dgtakipfoto = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtakipfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblogo
            // 
            this.lblogo.AutoSize = true;
            this.lblogo.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblogo.LinkColor = System.Drawing.Color.Black;
            this.lblogo.Location = new System.Drawing.Point(23, 18);
            this.lblogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblogo.Name = "lblogo";
            this.lblogo.Size = new System.Drawing.Size(136, 32);
            this.lblogo.TabIndex = 0;
            this.lblogo.TabStop = true;
            this.lblogo.Text = "Instagram";
            // 
            // lbkullaniciad
            // 
            this.lbkullaniciad.AutoSize = true;
            this.lbkullaniciad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbkullaniciad.Location = new System.Drawing.Point(619, 28);
            this.lbkullaniciad.Name = "lbkullaniciad";
            this.lbkullaniciad.Size = new System.Drawing.Size(0, 22);
            this.lbkullaniciad.TabIndex = 7;
            // 
            // btkesfet
            // 
            this.btkesfet.BackColor = System.Drawing.SystemColors.Highlight;
            this.btkesfet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btkesfet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btkesfet.Location = new System.Drawing.Point(271, 25);
            this.btkesfet.Name = "btkesfet";
            this.btkesfet.Size = new System.Drawing.Size(96, 28);
            this.btkesfet.TabIndex = 9;
            this.btkesfet.Text = "Keşfet";
            this.btkesfet.UseVisualStyleBackColor = false;
            this.btkesfet.Click += new System.EventHandler(this.btkesfet_Click);
            // 
            // btresimekle
            // 
            this.btresimekle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btresimekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btresimekle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btresimekle.Location = new System.Drawing.Point(382, 25);
            this.btresimekle.Name = "btresimekle";
            this.btresimekle.Size = new System.Drawing.Size(99, 28);
            this.btresimekle.TabIndex = 13;
            this.btresimekle.Text = "Resim Ekle";
            this.btresimekle.UseVisualStyleBackColor = false;
            this.btresimekle.Click += new System.EventHandler(this.btresimekle_Click);
            // 
            // btprofil
            // 
            this.btprofil.BackColor = System.Drawing.SystemColors.Highlight;
            this.btprofil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btprofil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btprofil.Location = new System.Drawing.Point(497, 25);
            this.btprofil.Name = "btprofil";
            this.btprofil.Size = new System.Drawing.Size(82, 28);
            this.btprofil.TabIndex = 14;
            this.btprofil.Text = "Profilim";
            this.btprofil.UseVisualStyleBackColor = false;
            this.btprofil.Click += new System.EventHandler(this.btprofil_Click);
            // 
            // dgtakipfoto
            // 
            this.dgtakipfoto.AllowUserToAddRows = false;
            this.dgtakipfoto.AllowUserToDeleteRows = false;
            this.dgtakipfoto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtakipfoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtakipfoto.Location = new System.Drawing.Point(12, 110);
            this.dgtakipfoto.Name = "dgtakipfoto";
            this.dgtakipfoto.ReadOnly = true;
            this.dgtakipfoto.RowHeadersWidth = 50;
            this.dgtakipfoto.Size = new System.Drawing.Size(1020, 375);
            this.dgtakipfoto.TabIndex = 15;
            this.dgtakipfoto.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgtakipfoto_RowHeaderMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(729, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgtakipfoto);
            this.Controls.Add(this.btprofil);
            this.Controls.Add(this.btresimekle);
            this.Controls.Add(this.btkesfet);
            this.Controls.Add(this.lbkullaniciad);
            this.Controls.Add(this.lblogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "anasayfa";
            this.Text = "anasayfa";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtakipfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblogo;
        private System.Windows.Forms.Label lbkullaniciad;
        private System.Windows.Forms.Button btkesfet;
        private System.Windows.Forms.Button btresimekle;
        private System.Windows.Forms.Button btprofil;
        private System.Windows.Forms.DataGridView dgtakipfoto;
        private System.Windows.Forms.Button button1;
    }
}