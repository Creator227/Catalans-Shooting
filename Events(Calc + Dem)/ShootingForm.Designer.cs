namespace Events_Calc___Dem_
{
    partial class ShootingForm
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
            this.LAllShoots = new System.Windows.Forms.Label();
            this.LTShoots = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LAllShoots
            // 
            this.LAllShoots.AutoSize = true;
            this.LAllShoots.Location = new System.Drawing.Point(13, 53);
            this.LAllShoots.Name = "LAllShoots";
            this.LAllShoots.Size = new System.Drawing.Size(105, 34);
            this.LAllShoots.TabIndex = 0;
            this.LAllShoots.Text = "Все выстрелы:\r\n0";
            // 
            // LTShoots
            // 
            this.LTShoots.AutoSize = true;
            this.LTShoots.Location = new System.Drawing.Point(16, 114);
            this.LTShoots.Name = "LTShoots";
            this.LTShoots.Size = new System.Drawing.Size(86, 34);
            this.LTShoots.TabIndex = 1;
            this.LTShoots.Text = "Попадания:\r\n0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Прекратить\r\n стрельбу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShootingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LTShoots);
            this.Controls.Add(this.LAllShoots);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShootingForm";
            this.Text = "ShootingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShootingForm_FormClosing);
            this.Load += new System.EventHandler(this.ShootingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAllShoots;
        private System.Windows.Forms.Label LTShoots;
        private System.Windows.Forms.Button button1;
    }
}