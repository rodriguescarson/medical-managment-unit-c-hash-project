namespace MMU
{
    partial class readings
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.o2level = new System.Windows.Forms.NumericUpDown();
            this.templevel = new System.Windows.Forms.NumericUpDown();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.o2level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templevel)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(103)))), ((int)(((byte)(79)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(77, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(103)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(90, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "OXYGEN LEVEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(103)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(90, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "TEMPERATURE";
            // 
            // o2level
            // 
            this.o2level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(79)))), ((int)(((byte)(68)))));
            this.o2level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.o2level.ForeColor = System.Drawing.SystemColors.Info;
            this.o2level.Location = new System.Drawing.Point(241, 195);
            this.o2level.Name = "o2level";
            this.o2level.Size = new System.Drawing.Size(143, 22);
            this.o2level.TabIndex = 4;
            this.o2level.ValueChanged += new System.EventHandler(this.o2level_ValueChanged);
            // 
            // templevel
            // 
            this.templevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(79)))), ((int)(((byte)(68)))));
            this.templevel.ForeColor = System.Drawing.SystemColors.Info;
            this.templevel.Location = new System.Drawing.Point(241, 243);
            this.templevel.Name = "templevel";
            this.templevel.Size = new System.Drawing.Size(143, 22);
            this.templevel.TabIndex = 5;
            // 
            // datepicker
            // 
            this.datepicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(103)))), ((int)(((byte)(79)))));
            this.datepicker.Location = new System.Drawing.Point(243, 149);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(141, 22);
            this.datepicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(103)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(90, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Todays Date";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::MMU.Properties.Resources.back_btn;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(0, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 100);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(123, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "ADD YOUR CURRENT DETAILS";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(103)))), ((int)(((byte)(79)))));
            this.label5.Location = new System.Drawing.Point(74, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 56);
            this.label5.TabIndex = 10;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // readings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = global::MMU.Properties.Resources.android_chrome_192x192;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 505);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.templevel);
            this.Controls.Add(this.o2level);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "readings";
            this.Text = "ADD DETAILS";
            this.Load += new System.EventHandler(this.readings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.o2level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown o2level;
        private System.Windows.Forms.NumericUpDown templevel;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}