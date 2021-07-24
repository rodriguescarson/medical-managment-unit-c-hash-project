namespace MMU
{
    partial class create_acc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.contact = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.age);
            this.groupBox1.Controls.Add(this.contact);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Pass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.sex);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(261, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 310);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(49, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contact No";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(128, 222);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(148, 22);
            this.age.TabIndex = 3;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(128, 92);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(148, 22);
            this.contact.TabIndex = 12;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(128, 56);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(148, 22);
            this.Username.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username";
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(128, 125);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(148, 22);
            this.Pass.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(128, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(148, 22);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // sex
            // 
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Others"});
            this.sex.Location = new System.Drawing.Point(128, 159);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(148, 24);
            this.sex.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(49, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sex";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(92)))), ((int)(((byte)(131)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(84, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(49, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(261, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 70);
            this.label7.TabIndex = 12;
            this.label7.Text = "CREATE ACCOUNT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::MMU.Properties.Resources.back_btn;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(-2, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 100);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(45, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Email";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(128, 194);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(148, 22);
            this.Email.TabIndex = 14;
            this.Email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // create_acc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = global::MMU.Properties.Resources.WhatsApp_Image_2021_07_20_at_3_36_19_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 505);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "create_acc";
            this.Text = "create_acc";
            this.Load += new System.EventHandler(this.create_acc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Email;
    }
}