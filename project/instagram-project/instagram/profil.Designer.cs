namespace instagram
{
    partial class profil
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
            this.lbkuladi = new System.Windows.Forms.Label();
            this.dgprofilim = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgprofilim)).BeginInit();
            this.SuspendLayout();
            // 
            // lbkuladi
            // 
            this.lbkuladi.AutoSize = true;
            this.lbkuladi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbkuladi.Location = new System.Drawing.Point(107, 37);
            this.lbkuladi.Name = "lbkuladi";
            this.lbkuladi.Size = new System.Drawing.Size(0, 20);
            this.lbkuladi.TabIndex = 0;
            // 
            // dgprofilim
            // 
            this.dgprofilim.AllowUserToAddRows = false;
            this.dgprofilim.AllowUserToDeleteRows = false;
            this.dgprofilim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgprofilim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgprofilim.Location = new System.Drawing.Point(71, 82);
            this.dgprofilim.Name = "dgprofilim";
            this.dgprofilim.ReadOnly = true;
            this.dgprofilim.RowHeadersWidth = 50;
            this.dgprofilim.Size = new System.Drawing.Size(748, 373);
            this.dgprofilim.TabIndex = 1;
           // 
            // profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 467);
            this.Controls.Add(this.dgprofilim);
            this.Controls.Add(this.lbkuladi);
            this.Name = "profil";
            this.Text = "profil";
            this.Load += new System.EventHandler(this.profil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgprofilim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgprofilim;
        public System.Windows.Forms.Label lbkuladi;

    }
}