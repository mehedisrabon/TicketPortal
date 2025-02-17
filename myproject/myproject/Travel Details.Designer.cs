namespace myproject
{
    partial class Travel_Details
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Travel_Details));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClass1 = new ButtonClass.form.ButtonClass();
            this.buttonClass3 = new ButtonClass.form.ButtonClass();
            this.buttonClass4 = new ButtonClass.form.ButtonClass();
            this.buttonClass2 = new ButtonClass.form.ButtonClass();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(103)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 85);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(441, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(406, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Welcome To TapNGo Metro Service!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(302, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 242);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonClass1);
            this.panel2.Controls.Add(this.buttonClass3);
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 615);
            this.panel2.TabIndex = 3;
            // 
            // buttonClass1
            // 
            this.buttonClass1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(103)))), ((int)(((byte)(202)))));
            this.buttonClass1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(103)))), ((int)(((byte)(202)))));
            this.buttonClass1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonClass1.BorderRadius = 10;
            this.buttonClass1.BorderSize = 0;
            this.buttonClass1.FlatAppearance.BorderSize = 0;
            this.buttonClass1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClass1.ForeColor = System.Drawing.Color.White;
            this.buttonClass1.Location = new System.Drawing.Point(97, 25);
            this.buttonClass1.Name = "buttonClass1";
            this.buttonClass1.Size = new System.Drawing.Size(76, 40);
            this.buttonClass1.TabIndex = 10;
            this.buttonClass1.Text = "Home";
            this.buttonClass1.TextColor = System.Drawing.Color.White;
            this.buttonClass1.UseVisualStyleBackColor = false;
            // 
            // buttonClass3
            // 
            this.buttonClass3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(103)))), ((int)(((byte)(202)))));
            this.buttonClass3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(103)))), ((int)(((byte)(202)))));
            this.buttonClass3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonClass3.BorderRadius = 10;
            this.buttonClass3.BorderSize = 0;
            this.buttonClass3.FlatAppearance.BorderSize = 0;
            this.buttonClass3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClass3.ForeColor = System.Drawing.Color.White;
            this.buttonClass3.Location = new System.Drawing.Point(15, 25);
            this.buttonClass3.Name = "buttonClass3";
            this.buttonClass3.Size = new System.Drawing.Size(76, 40);
            this.buttonClass3.TabIndex = 9;
            this.buttonClass3.Text = "←";
            this.buttonClass3.TextColor = System.Drawing.Color.White;
            this.buttonClass3.UseVisualStyleBackColor = false;
            this.buttonClass3.Click += new System.EventHandler(this.buttonClass3_Click);
            // 
            // buttonClass4
            // 
            this.buttonClass4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(103)))), ((int)(((byte)(202)))));
            this.buttonClass4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(103)))), ((int)(((byte)(202)))));
            this.buttonClass4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonClass4.BorderRadius = 20;
            this.buttonClass4.BorderSize = 0;
            this.buttonClass4.FlatAppearance.BorderSize = 0;
            this.buttonClass4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClass4.ForeColor = System.Drawing.Color.White;
            this.buttonClass4.Location = new System.Drawing.Point(1022, 595);
            this.buttonClass4.Name = "buttonClass4";
            this.buttonClass4.Size = new System.Drawing.Size(150, 40);
            this.buttonClass4.TabIndex = 5;
            this.buttonClass4.Text = "Exit";
            this.buttonClass4.TextColor = System.Drawing.Color.White;
            this.buttonClass4.UseVisualStyleBackColor = false;
            this.buttonClass4.Click += new System.EventHandler(this.buttonClass4_Click);
            // 
            // buttonClass2
            // 
            this.buttonClass2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(103)))), ((int)(((byte)(202)))));
            this.buttonClass2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(103)))), ((int)(((byte)(202)))));
            this.buttonClass2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonClass2.BorderRadius = 20;
            this.buttonClass2.BorderSize = 0;
            this.buttonClass2.FlatAppearance.BorderSize = 0;
            this.buttonClass2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClass2.ForeColor = System.Drawing.Color.White;
            this.buttonClass2.Location = new System.Drawing.Point(853, 595);
            this.buttonClass2.Name = "buttonClass2";
            this.buttonClass2.Size = new System.Drawing.Size(150, 40);
            this.buttonClass2.TabIndex = 4;
            this.buttonClass2.Text = "Cancel";
            this.buttonClass2.TextColor = System.Drawing.Color.White;
            this.buttonClass2.UseVisualStyleBackColor = false;
            this.buttonClass2.Click += new System.EventHandler(this.buttonClass2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1149, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "     ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(493, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 39);
            this.label1.TabIndex = 42;
            this.label1.Text = "Your Travel History";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(1014, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Remaining time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label9.Location = new System.Drawing.Point(1046, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 22);
            this.label9.TabIndex = 47;
            this.label9.Text = "Today\'s Date and Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label6.Location = new System.Drawing.Point(1094, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Time";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(1042, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Travel_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 661);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonClass4);
            this.Controls.Add(this.buttonClass2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Travel_Details";
            this.Text = "Travel_Details";
            this.Load += new System.EventHandler(this.Travel_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private ButtonClass.form.ButtonClass buttonClass3;
        private ButtonClass.form.ButtonClass buttonClass1;
        private ButtonClass.form.ButtonClass buttonClass2;
        private ButtonClass.form.ButtonClass buttonClass4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer2;
    }
}