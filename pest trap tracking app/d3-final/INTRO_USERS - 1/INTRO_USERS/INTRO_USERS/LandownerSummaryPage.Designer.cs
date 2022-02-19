namespace INTRO_USERS
{
    partial class LandownerSummaryPage
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
            this.labelLandownerID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLandownerID = new System.Windows.Forms.TextBox();
            this.textBoxLandownerName = new System.Windows.Forms.TextBox();
            this.buttonAddCatch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.listViewLandSum = new System.Windows.Forms.ListView();
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAnimal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTrapType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(166, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Landowner Summary";
            // 
            // labelLandownerID
            // 
            this.labelLandownerID.AutoSize = true;
            this.labelLandownerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelLandownerID.Location = new System.Drawing.Point(53, 87);
            this.labelLandownerID.Name = "labelLandownerID";
            this.labelLandownerID.Size = new System.Drawing.Size(107, 18);
            this.labelLandownerID.TabIndex = 2;
            this.labelLandownerID.Text = "Landowner ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(53, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name of landowner:";
            // 
            // textBoxLandownerID
            // 
            this.textBoxLandownerID.Location = new System.Drawing.Point(200, 87);
            this.textBoxLandownerID.Name = "textBoxLandownerID";
            this.textBoxLandownerID.Size = new System.Drawing.Size(133, 20);
            this.textBoxLandownerID.TabIndex = 4;
            // 
            // textBoxLandownerName
            // 
            this.textBoxLandownerName.Location = new System.Drawing.Point(200, 134);
            this.textBoxLandownerName.Name = "textBoxLandownerName";
            this.textBoxLandownerName.ReadOnly = true;
            this.textBoxLandownerName.Size = new System.Drawing.Size(133, 20);
            this.textBoxLandownerName.TabIndex = 5;
            // 
            // buttonAddCatch
            // 
            this.buttonAddCatch.Location = new System.Drawing.Point(97, 486);
            this.buttonAddCatch.Name = "buttonAddCatch";
            this.buttonAddCatch.Size = new System.Drawing.Size(147, 46);
            this.buttonAddCatch.TabIndex = 6;
            this.buttonAddCatch.Text = "Register another catch";
            this.buttonAddCatch.UseVisualStyleBackColor = true;
            this.buttonAddCatch.Click += new System.EventHandler(this.buttonAddCatch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Statistics";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(452, 486);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(147, 46);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(354, 77);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(123, 38);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update Summary";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // listViewLandSum
            // 
            this.listViewLandSum.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDate,
            this.columnHeaderAnimal,
            this.columnHeaderTrapType});
            this.listViewLandSum.Location = new System.Drawing.Point(46, 173);
            this.listViewLandSum.Name = "listViewLandSum";
            this.listViewLandSum.Size = new System.Drawing.Size(605, 289);
            this.listViewLandSum.TabIndex = 14;
            this.listViewLandSum.UseCompatibleStateImageBehavior = false;
            this.listViewLandSum.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date of Catch";
            this.columnHeaderDate.Width = 200;
            // 
            // columnHeaderAnimal
            // 
            this.columnHeaderAnimal.Text = "Animal";
            this.columnHeaderAnimal.Width = 200;
            // 
            // columnHeaderTrapType
            // 
            this.columnHeaderTrapType.Text = "Trap Type";
            this.columnHeaderTrapType.Width = 200;
            // 
            // LandownerSummaryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(698, 567);
            this.Controls.Add(this.listViewLandSum);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddCatch);
            this.Controls.Add(this.textBoxLandownerName);
            this.Controls.Add(this.textBoxLandownerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLandownerID);
            this.Controls.Add(this.label1);
            this.Name = "LandownerSummaryPage";
            this.Text = "LandownerSummaryPage";
            this.Load += new System.EventHandler(this.LandownerSummaryPage_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLandownerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLandownerID;
        private System.Windows.Forms.TextBox textBoxLandownerName;
        private System.Windows.Forms.Button buttonAddCatch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ListView listViewLandSum;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderAnimal;
        private System.Windows.Forms.ColumnHeader columnHeaderTrapType;
    }
}