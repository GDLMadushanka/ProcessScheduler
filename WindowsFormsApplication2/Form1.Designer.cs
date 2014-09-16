namespace WindowsFormsApplication2
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ready = new System.Windows.Forms.Label();
            this.blocked = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pro1 = new System.Windows.Forms.ProgressBar();
            this.pro2 = new System.Windows.Forms.ProgressBar();
            this.pro3 = new System.Windows.Forms.ProgressBar();
            this.pro4 = new System.Windows.Forms.ProgressBar();
            this.pro5 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mm = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.running = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Processes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ready Queue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Blocked Queue";
            // 
            // ready
            // 
            this.ready.AutoSize = true;
            this.ready.ForeColor = System.Drawing.Color.Blue;
            this.ready.Location = new System.Drawing.Point(12, 71);
            this.ready.Name = "ready";
            this.ready.Size = new System.Drawing.Size(35, 13);
            this.ready.TabIndex = 5;
            this.ready.Text = "label5";
            this.ready.Click += new System.EventHandler(this.ready_Click);
            // 
            // blocked
            // 
            this.blocked.AutoSize = true;
            this.blocked.ForeColor = System.Drawing.Color.Red;
            this.blocked.Location = new System.Drawing.Point(12, 121);
            this.blocked.Name = "blocked";
            this.blocked.Size = new System.Drawing.Size(35, 13);
            this.blocked.TabIndex = 6;
            this.blocked.Text = "label5";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pro1
            // 
            this.pro1.Location = new System.Drawing.Point(137, 146);
            this.pro1.Name = "pro1";
            this.pro1.Size = new System.Drawing.Size(164, 22);
            this.pro1.TabIndex = 9;
            // 
            // pro2
            // 
            this.pro2.Location = new System.Drawing.Point(137, 174);
            this.pro2.Name = "pro2";
            this.pro2.Size = new System.Drawing.Size(164, 22);
            this.pro2.TabIndex = 10;
            // 
            // pro3
            // 
            this.pro3.Location = new System.Drawing.Point(137, 202);
            this.pro3.Name = "pro3";
            this.pro3.Size = new System.Drawing.Size(164, 22);
            this.pro3.TabIndex = 11;
            // 
            // pro4
            // 
            this.pro4.Location = new System.Drawing.Point(137, 230);
            this.pro4.Name = "pro4";
            this.pro4.Size = new System.Drawing.Size(164, 22);
            this.pro4.TabIndex = 12;
            // 
            // pro5
            // 
            this.pro5.Location = new System.Drawing.Point(137, 258);
            this.pro5.Name = "pro5";
            this.pro5.Size = new System.Drawing.Size(164, 22);
            this.pro5.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Process 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Process 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Process 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Process 4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Process 5";
            // 
            // mm
            // 
            this.mm.Location = new System.Drawing.Point(347, 12);
            this.mm.Maximum = 5;
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(190, 63);
            this.mm.TabIndex = 19;
            this.mm.Value = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(385, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Main Memory";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(312, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "I/O Supply";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(376, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // running
            // 
            this.running.AutoEllipsis = true;
            this.running.AutoSize = true;
            this.running.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.running.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.running.ForeColor = System.Drawing.Color.Yellow;
            this.running.Location = new System.Drawing.Point(326, 146);
            this.running.Name = "running";
            this.running.Size = new System.Drawing.Size(197, 29);
            this.running.TabIndex = 0;
            this.running.Text = "Runnig Process";
            this.running.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.running.Click += new System.EventHandler(this.label4_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(331, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 42);
            this.button4.TabIndex = 25;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(394, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 42);
            this.button5.TabIndex = 26;
            this.button5.Text = ">>";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(549, 303);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.running);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pro5);
            this.Controls.Add(this.pro4);
            this.Controls.Add(this.pro3);
            this.Controls.Add(this.pro2);
            this.Controls.Add(this.pro1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.blocked);
            this.Controls.Add(this.ready);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fortis Process Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ready;
        private System.Windows.Forms.Label blocked;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar pro1;
        private System.Windows.Forms.ProgressBar pro2;
        private System.Windows.Forms.ProgressBar pro3;
        private System.Windows.Forms.ProgressBar pro4;
        private System.Windows.Forms.ProgressBar pro5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar mm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label running;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

