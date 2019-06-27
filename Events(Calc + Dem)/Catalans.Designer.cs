namespace Events_Calc___Dem_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBRestTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BStart = new System.Windows.Forms.Button();
            this.Bstop = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBShootPause = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBShootSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBResult
            // 
            this.TBResult.Location = new System.Drawing.Point(113, 81);
            this.TBResult.Multiline = true;
            this.TBResult.Name = "TBResult";
            this.TBResult.ReadOnly = true;
            this.TBResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBResult.Size = new System.Drawing.Size(623, 253);
            this.TBResult.TabIndex = 0;
            this.TBResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Числа Каталана:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBRestTime
            // 
            this.TBRestTime.Location = new System.Drawing.Point(113, 416);
            this.TBRestTime.Name = "TBRestTime";
            this.TBRestTime.Size = new System.Drawing.Size(157, 22);
            this.TBRestTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(108, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Время \"отдыха\"\r\n вычислителя";
            // 
            // BStart
            // 
            this.BStart.BackColor = System.Drawing.SystemColors.Menu;
            this.BStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BStart.Location = new System.Drawing.Point(276, 351);
            this.BStart.Name = "BStart";
            this.BStart.Size = new System.Drawing.Size(149, 62);
            this.BStart.TabIndex = 4;
            this.BStart.Text = "Начать \r\nвычисления";
            this.BStart.UseVisualStyleBackColor = false;
            this.BStart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // Bstop
            // 
            this.Bstop.BackColor = System.Drawing.SystemColors.Menu;
            this.Bstop.Enabled = false;
            this.Bstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bstop.Location = new System.Drawing.Point(426, 351);
            this.Bstop.Name = "Bstop";
            this.Bstop.Size = new System.Drawing.Size(167, 62);
            this.Bstop.TabIndex = 5;
            this.Bstop.Text = "Прекратить \r\nвычисления";
            this.Bstop.UseVisualStyleBackColor = false;
            this.Bstop.Click += new System.EventHandler(this.button1_Click);
            // 
            // BClear
            // 
            this.BClear.BackColor = System.Drawing.SystemColors.Menu;
            this.BClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BClear.Location = new System.Drawing.Point(594, 351);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(142, 61);
            this.BClear.TabIndex = 6;
            this.BClear.Text = "Очистить";
            this.BClear.UseVisualStyleBackColor = false;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(751, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Параметры мишени";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(756, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Задержка";
            // 
            // TBShootPause
            // 
            this.TBShootPause.Location = new System.Drawing.Point(890, 130);
            this.TBShootPause.Name = "TBShootPause";
            this.TBShootPause.Size = new System.Drawing.Size(100, 22);
            this.TBShootPause.TabIndex = 9;
            this.TBShootPause.Text = "800";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(756, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Размер";
            // 
            // TBShootSize
            // 
            this.TBShootSize.Location = new System.Drawing.Point(890, 182);
            this.TBShootSize.Name = "TBShootSize";
            this.TBShootSize.Size = new System.Drawing.Size(100, 22);
            this.TBShootSize.TabIndex = 11;
            this.TBShootSize.Text = "90";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.TBShootSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBShootPause);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.Bstop);
            this.Controls.Add(this.BStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBRestTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBRestTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BStart;
        private System.Windows.Forms.Button Bstop;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBShootPause;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBShootSize;
    }
}

