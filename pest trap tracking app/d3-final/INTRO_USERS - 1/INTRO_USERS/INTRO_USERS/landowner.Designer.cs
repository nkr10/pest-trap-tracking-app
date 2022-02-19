namespace INTRO_USERS
{
    partial class landowner
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
            this.labelLandowner = new System.Windows.Forms.Label();
            this.dataGridViewLandowner = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLandowner)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLandowner
            // 
            this.labelLandowner.AutoSize = true;
            this.labelLandowner.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelLandowner.Location = new System.Drawing.Point(166, 35);
            this.labelLandowner.Name = "labelLandowner";
            this.labelLandowner.Size = new System.Drawing.Size(345, 32);
            this.labelLandowner.TabIndex = 0;
            this.labelLandowner.Text = "Landowners Information";
            this.labelLandowner.Click += new System.EventHandler(this.labelLandowner_Click);
            // 
            // dataGridViewLandowner
            // 
            this.dataGridViewLandowner.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLandowner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLandowner.Location = new System.Drawing.Point(29, 102);
            this.dataGridViewLandowner.Name = "dataGridViewLandowner";
            this.dataGridViewLandowner.Size = new System.Drawing.Size(649, 268);
            this.dataGridViewLandowner.TabIndex = 1;
            this.dataGridViewLandowner.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // landowner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(712, 401);
            this.Controls.Add(this.dataGridViewLandowner);
            this.Controls.Add(this.labelLandowner);
            this.Name = "landowner";
            this.Text = "landowner data";
            this.Load += new System.EventHandler(this.landowner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLandowner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLandowner;
        private System.Windows.Forms.DataGridView dataGridViewLandowner;
    }
}