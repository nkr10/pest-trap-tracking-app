namespace INTRO_USERS
{
    partial class CompareResultsPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelCompare = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelLandowner1 = new System.Windows.Forms.Label();
            this.labelLandowner2 = new System.Windows.Forms.Label();
            this.textBoxLandowner1 = new System.Windows.Forms.TextBox();
            this.textBoxLandowner2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTotalNumLan1 = new System.Windows.Forms.TextBox();
            this.textBoxTotalNumLan2 = new System.Windows.Forms.TextBox();
            this.textBoxTotalNumLanBoth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCompare
            // 
            this.labelCompare.AutoSize = true;
            this.labelCompare.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelCompare.Location = new System.Drawing.Point(182, 24);
            this.labelCompare.Name = "labelCompare";
            this.labelCompare.Size = new System.Drawing.Size(285, 32);
            this.labelCompare.TabIndex = 0;
            this.labelCompare.Text = "Compare Statistics";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(38, 99);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Landowner 1";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Landowner 2";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(535, 316);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // labelLandowner1
            // 
            this.labelLandowner1.AutoSize = true;
            this.labelLandowner1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLandowner1.Location = new System.Drawing.Point(604, 102);
            this.labelLandowner1.Name = "labelLandowner1";
            this.labelLandowner1.Size = new System.Drawing.Size(112, 20);
            this.labelLandowner1.TabIndex = 2;
            this.labelLandowner1.Text = "Landowner 1";
            // 
            // labelLandowner2
            // 
            this.labelLandowner2.AutoSize = true;
            this.labelLandowner2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLandowner2.Location = new System.Drawing.Point(604, 212);
            this.labelLandowner2.Name = "labelLandowner2";
            this.labelLandowner2.Size = new System.Drawing.Size(112, 20);
            this.labelLandowner2.TabIndex = 3;
            this.labelLandowner2.Text = "Landowner 2";
            // 
            // textBoxLandowner1
            // 
            this.textBoxLandowner1.Location = new System.Drawing.Point(725, 102);
            this.textBoxLandowner1.Name = "textBoxLandowner1";
            this.textBoxLandowner1.ReadOnly = true;
            this.textBoxLandowner1.Size = new System.Drawing.Size(100, 20);
            this.textBoxLandowner1.TabIndex = 4;
            // 
            // textBoxLandowner2
            // 
            this.textBoxLandowner2.Location = new System.Drawing.Point(725, 214);
            this.textBoxLandowner2.Name = "textBoxLandowner2";
            this.textBoxLandowner2.Size = new System.Drawing.Size(100, 20);
            this.textBoxLandowner2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 52);
            this.button2.TabIndex = 7;
            this.button2.Text = "Compare Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTotalNumLan1
            // 
            this.textBoxTotalNumLan1.Location = new System.Drawing.Point(725, 141);
            this.textBoxTotalNumLan1.Name = "textBoxTotalNumLan1";
            this.textBoxTotalNumLan1.ReadOnly = true;
            this.textBoxTotalNumLan1.Size = new System.Drawing.Size(38, 20);
            this.textBoxTotalNumLan1.TabIndex = 9;
            // 
            // textBoxTotalNumLan2
            // 
            this.textBoxTotalNumLan2.Location = new System.Drawing.Point(722, 253);
            this.textBoxTotalNumLan2.Name = "textBoxTotalNumLan2";
            this.textBoxTotalNumLan2.ReadOnly = true;
            this.textBoxTotalNumLan2.Size = new System.Drawing.Size(38, 20);
            this.textBoxTotalNumLan2.TabIndex = 10;
            // 
            // textBoxTotalNumLanBoth
            // 
            this.textBoxTotalNumLanBoth.Location = new System.Drawing.Point(766, 399);
            this.textBoxTotalNumLanBoth.Name = "textBoxTotalNumLanBoth";
            this.textBoxTotalNumLanBoth.ReadOnly = true;
            this.textBoxTotalNumLanBoth.Size = new System.Drawing.Size(59, 20);
            this.textBoxTotalNumLanBoth.TabIndex = 11;
            this.textBoxTotalNumLanBoth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(722, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total Landowner 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total Landowner 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total for Both Landowners:";
            // 
            // CompareResultsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(867, 479);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTotalNumLanBoth);
            this.Controls.Add(this.textBoxTotalNumLan2);
            this.Controls.Add(this.textBoxTotalNumLan1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxLandowner2);
            this.Controls.Add(this.textBoxLandowner1);
            this.Controls.Add(this.labelLandowner2);
            this.Controls.Add(this.labelLandowner1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelCompare);
            this.Name = "CompareResultsPage";
            this.Text = "CompareResultsPage";
            this.Load += new System.EventHandler(this.CompareResultsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCompare;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelLandowner1;
        private System.Windows.Forms.Label labelLandowner2;
        private System.Windows.Forms.TextBox textBoxLandowner1;
        private System.Windows.Forms.TextBox textBoxLandowner2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTotalNumLan1;
        private System.Windows.Forms.TextBox textBoxTotalNumLan2;
        private System.Windows.Forms.TextBox textBoxTotalNumLanBoth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}