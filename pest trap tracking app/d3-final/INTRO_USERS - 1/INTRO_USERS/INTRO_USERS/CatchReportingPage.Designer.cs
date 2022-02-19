namespace INTRO_USERS
{
    partial class CatchReportingPage
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
            this.labelCatchRep = new System.Windows.Forms.Label();
            this.labelElseCatch = new System.Windows.Forms.Label();
            this.textBoxElseCatch = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonInfoStroat = new System.Windows.Forms.Button();
            this.buttonInfoPossum = new System.Windows.Forms.Button();
            this.buttonInfoRat = new System.Windows.Forms.Button();
            this.dateTimePickerCaught = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonPossum = new System.Windows.Forms.RadioButton();
            this.radioButtonStoat = new System.Windows.Forms.RadioButton();
            this.radioButtonRat = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelCatchRep
            // 
            this.labelCatchRep.AutoSize = true;
            this.labelCatchRep.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.labelCatchRep.Location = new System.Drawing.Point(63, 39);
            this.labelCatchRep.Name = "labelCatchRep";
            this.labelCatchRep.Size = new System.Drawing.Size(150, 22);
            this.labelCatchRep.TabIndex = 0;
            this.labelCatchRep.Text = "Animal caught:";
            this.labelCatchRep.Click += new System.EventHandler(this.labelCatchRep_Click);
            // 
            // labelElseCatch
            // 
            this.labelElseCatch.AutoSize = true;
            this.labelElseCatch.Font = new System.Drawing.Font("Consolas", 12F);
            this.labelElseCatch.Location = new System.Drawing.Point(117, 209);
            this.labelElseCatch.Name = "labelElseCatch";
            this.labelElseCatch.Size = new System.Drawing.Size(207, 19);
            this.labelElseCatch.TabIndex = 1;
            this.labelElseCatch.Text = "Was it something else?";
            // 
            // textBoxElseCatch
            // 
            this.textBoxElseCatch.ForeColor = System.Drawing.Color.Black;
            this.textBoxElseCatch.Location = new System.Drawing.Point(121, 231);
            this.textBoxElseCatch.Name = "textBoxElseCatch";
            this.textBoxElseCatch.Size = new System.Drawing.Size(173, 20);
            this.textBoxElseCatch.TabIndex = 5;
            this.textBoxElseCatch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(197, 388);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(102, 38);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonInfoStroat
            // 
            this.buttonInfoStroat.Location = new System.Drawing.Point(218, 78);
            this.buttonInfoStroat.Name = "buttonInfoStroat";
            this.buttonInfoStroat.Size = new System.Drawing.Size(24, 23);
            this.buttonInfoStroat.TabIndex = 7;
            this.buttonInfoStroat.Text = "?";
            this.buttonInfoStroat.UseVisualStyleBackColor = true;
            this.buttonInfoStroat.Click += new System.EventHandler(this.buttonInfoStroat_Click);
            // 
            // buttonInfoPossum
            // 
            this.buttonInfoPossum.Location = new System.Drawing.Point(218, 123);
            this.buttonInfoPossum.Name = "buttonInfoPossum";
            this.buttonInfoPossum.Size = new System.Drawing.Size(24, 23);
            this.buttonInfoPossum.TabIndex = 8;
            this.buttonInfoPossum.Text = "?";
            this.buttonInfoPossum.UseVisualStyleBackColor = true;
            this.buttonInfoPossum.Click += new System.EventHandler(this.buttonInfoPossum_Click);
            // 
            // buttonInfoRat
            // 
            this.buttonInfoRat.Location = new System.Drawing.Point(218, 166);
            this.buttonInfoRat.Name = "buttonInfoRat";
            this.buttonInfoRat.Size = new System.Drawing.Size(24, 23);
            this.buttonInfoRat.TabIndex = 9;
            this.buttonInfoRat.Text = "?";
            this.buttonInfoRat.UseVisualStyleBackColor = true;
            this.buttonInfoRat.Click += new System.EventHandler(this.buttonInfoRat_Click);
            // 
            // dateTimePickerCaught
            // 
            this.dateTimePickerCaught.Location = new System.Drawing.Point(66, 318);
            this.dateTimePickerCaught.MaxDate = new System.DateTime(2019, 6, 6, 7, 45, 51, 0);
            this.dateTimePickerCaught.Name = "dateTimePickerCaught";
            this.dateTimePickerCaught.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCaught.TabIndex = 11;
            this.dateTimePickerCaught.Value = new System.DateTime(2019, 5, 29, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(62, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date caught: ";
            // 
            // radioButtonPossum
            // 
            this.radioButtonPossum.AutoSize = true;
            this.radioButtonPossum.Location = new System.Drawing.Point(121, 123);
            this.radioButtonPossum.Name = "radioButtonPossum";
            this.radioButtonPossum.Size = new System.Drawing.Size(62, 17);
            this.radioButtonPossum.TabIndex = 14;
            this.radioButtonPossum.TabStop = true;
            this.radioButtonPossum.Text = "Possum";
            this.radioButtonPossum.UseVisualStyleBackColor = true;
            this.radioButtonPossum.CheckedChanged += new System.EventHandler(this.radioButtonPossum_CheckedChanged);
            // 
            // radioButtonStoat
            // 
            this.radioButtonStoat.AutoSize = true;
            this.radioButtonStoat.Location = new System.Drawing.Point(121, 78);
            this.radioButtonStoat.Name = "radioButtonStoat";
            this.radioButtonStoat.Size = new System.Drawing.Size(91, 17);
            this.radioButtonStoat.TabIndex = 15;
            this.radioButtonStoat.TabStop = true;
            this.radioButtonStoat.Text = "Stoat/Weasel";
            this.radioButtonStoat.UseVisualStyleBackColor = true;
            this.radioButtonStoat.CheckedChanged += new System.EventHandler(this.radioButtonStoat_CheckedChanged);
            // 
            // radioButtonRat
            // 
            this.radioButtonRat.AutoSize = true;
            this.radioButtonRat.Location = new System.Drawing.Point(121, 166);
            this.radioButtonRat.Name = "radioButtonRat";
            this.radioButtonRat.Size = new System.Drawing.Size(42, 17);
            this.radioButtonRat.TabIndex = 16;
            this.radioButtonRat.TabStop = true;
            this.radioButtonRat.Text = "Rat";
            this.radioButtonRat.UseVisualStyleBackColor = true;
            this.radioButtonRat.CheckedChanged += new System.EventHandler(this.radioButtonRat_CheckedChanged);
            // 
            // CatchReportingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(447, 473);
            this.Controls.Add(this.radioButtonRat);
            this.Controls.Add(this.radioButtonStoat);
            this.Controls.Add(this.radioButtonPossum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerCaught);
            this.Controls.Add(this.buttonInfoRat);
            this.Controls.Add(this.buttonInfoPossum);
            this.Controls.Add(this.buttonInfoStroat);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxElseCatch);
            this.Controls.Add(this.labelElseCatch);
            this.Controls.Add(this.labelCatchRep);
            this.Name = "CatchReportingPage";
            this.Text = "CatchReportingPage";
            this.Load += new System.EventHandler(this.CatchReportingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCatchRep;
        private System.Windows.Forms.Label labelElseCatch;
        private System.Windows.Forms.TextBox textBoxElseCatch;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonInfoStroat;
        private System.Windows.Forms.Button buttonInfoPossum;
        private System.Windows.Forms.Button buttonInfoRat;
        private System.Windows.Forms.DateTimePicker dateTimePickerCaught;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonPossum;
        private System.Windows.Forms.RadioButton radioButtonStoat;
        private System.Windows.Forms.RadioButton radioButtonRat;
    }
}