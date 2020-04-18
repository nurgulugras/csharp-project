namespace instagram
{
    partial class kesfet
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
            this.tbara = new System.Windows.Forms.TextBox();
            this.dgkesfet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgkesfet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(148, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARA:";
            // 
            // tbara
            // 
            this.tbara.Location = new System.Drawing.Point(218, 15);
            this.tbara.Name = "tbara";
            this.tbara.Size = new System.Drawing.Size(181, 20);
            this.tbara.TabIndex = 1;
            this.tbara.TextChanged += new System.EventHandler(this.tbara_TextChanged);
            // 
            // dgkesfet
            // 
            this.dgkesfet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgkesfet.Location = new System.Drawing.Point(55, 65);
            this.dgkesfet.Name = "dgkesfet";
            this.dgkesfet.Size = new System.Drawing.Size(480, 193);
            this.dgkesfet.TabIndex = 2;
            this.dgkesfet.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgkesfet_RowHeaderMouseDoubleClick);
            // 
            // kesfet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 306);
            this.Controls.Add(this.dgkesfet);
            this.Controls.Add(this.tbara);
            this.Controls.Add(this.label1);
            this.Name = "kesfet";
            this.Text = "kesfet";
            this.Load += new System.EventHandler(this.kesfet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgkesfet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbara;
        private System.Windows.Forms.DataGridView dgkesfet;
    }
}