namespace pogoda
{
    partial class Form1
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
            this.TBCity = new System.Windows.Forms.TextBox();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.labDetails = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.labTemp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labConditions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miasto";
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TBCity.ForeColor = System.Drawing.Color.Black;
            this.TBCity.Location = new System.Drawing.Point(153, 31);
            this.TBCity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(356, 31);
            this.TBCity.TabIndex = 1;
            // 
            // BTNSearch
            // 
            this.BTNSearch.BackColor = System.Drawing.Color.Transparent;
            this.BTNSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTNSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BTNSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTNSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTNSearch.ForeColor = System.Drawing.Color.White;
            this.BTNSearch.Location = new System.Drawing.Point(529, 31);
            this.BTNSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(133, 31);
            this.BTNSearch.TabIndex = 2;
            this.BTNSearch.Text = "Pokaż";
            this.BTNSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTNSearch.UseVisualStyleBackColor = false;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labDetails.ForeColor = System.Drawing.Color.White;
            this.labDetails.Location = new System.Drawing.Point(168, 218);
            this.labDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(39, 23);
            this.labDetails.TabIndex = 3;
            this.labDetails.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wshcód Słońca:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labSunrise.ForeColor = System.Drawing.Color.White;
            this.labSunrise.Location = new System.Drawing.Point(168, 256);
            this.labSunrise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(39, 23);
            this.labSunrise.TabIndex = 6;
            this.labSunrise.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Zachód Słońca:";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labSunset.ForeColor = System.Drawing.Color.White;
            this.labSunset.Location = new System.Drawing.Point(168, 295);
            this.labSunset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(39, 23);
            this.labSunset.TabIndex = 8;
            this.labSunset.Text = "N/A";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPressure.ForeColor = System.Drawing.Color.White;
            this.labPressure.Location = new System.Drawing.Point(526, 218);
            this.labPressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(39, 23);
            this.labPressure.TabIndex = 11;
            this.labPressure.Text = "N/A";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labWindSpeed.ForeColor = System.Drawing.Color.White;
            this.labWindSpeed.Location = new System.Drawing.Point(525, 179);
            this.labWindSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(39, 23);
            this.labWindSpeed.TabIndex = 9;
            this.labWindSpeed.Text = "N/A";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(51, 95);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(100, 50);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 13;
            this.picIcon.TabStop = false;
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.BackColor = System.Drawing.Color.Transparent;
            this.labTemp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTemp.ForeColor = System.Drawing.Color.White;
            this.labTemp.Location = new System.Drawing.Point(526, 256);
            this.labTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(39, 23);
            this.labTemp.TabIndex = 14;
            this.labTemp.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(400, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Temperatrua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(386, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ciśnienie:  [hPa]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(386, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Wiatr prędkość:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(66, 179);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Warunki:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(51, 217);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Szczegóły:";
            // 
            // labConditions
            // 
            this.labConditions.AutoSize = true;
            this.labConditions.BackColor = System.Drawing.Color.Transparent;
            this.labConditions.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labConditions.ForeColor = System.Drawing.Color.White;
            this.labConditions.Location = new System.Drawing.Point(168, 179);
            this.labConditions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labConditions.Name = "labConditions";
            this.labConditions.Size = new System.Drawing.Size(39, 23);
            this.labConditions.TabIndex = 20;
            this.labConditions.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pogoda.Properties.Resources.noc_z_błyskawica;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 399);
            this.Controls.Add(this.labConditions);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labTemp);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.BTNSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)), true);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Pogoda";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label labTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labConditions;
    }
}

