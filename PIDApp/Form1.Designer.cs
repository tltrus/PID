namespace PID
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl1PID = new System.Windows.Forms.Label();
            this.lbl2Xreal = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKp = new System.Windows.Forms.TextBox();
            this.tbKi = new System.Windows.Forms.TextBox();
            this.tbKd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tbTimerInterval = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 96);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "11";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(49, 73);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(38, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "1";
            // 
            // lbl1PID
            // 
            this.lbl1PID.AutoSize = true;
            this.lbl1PID.Location = new System.Drawing.Point(172, 76);
            this.lbl1PID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1PID.Name = "lbl1PID";
            this.lbl1PID.Size = new System.Drawing.Size(13, 13);
            this.lbl1PID.TabIndex = 3;
            this.lbl1PID.Text = "0";
            // 
            // lbl2Xreal
            // 
            this.lbl2Xreal.AutoSize = true;
            this.lbl2Xreal.Location = new System.Drawing.Point(172, 98);
            this.lbl2Xreal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2Xreal.Name = "lbl2Xreal";
            this.lbl2Xreal.Size = new System.Drawing.Size(13, 13);
            this.lbl2Xreal.TabIndex = 4;
            this.lbl2Xreal.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(14, 125);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(72, 26);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PID result (U):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y real:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y need:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "dt:";
            // 
            // tbKp
            // 
            this.tbKp.Location = new System.Drawing.Point(49, 5);
            this.tbKp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbKp.Name = "tbKp";
            this.tbKp.Size = new System.Drawing.Size(38, 20);
            this.tbKp.TabIndex = 0;
            this.tbKp.Text = "0,5";
            // 
            // tbKi
            // 
            this.tbKi.Location = new System.Drawing.Point(49, 28);
            this.tbKi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbKi.Name = "tbKi";
            this.tbKi.Size = new System.Drawing.Size(38, 20);
            this.tbKi.TabIndex = 0;
            this.tbKi.Text = "0,3";
            // 
            // tbKd
            // 
            this.tbKd.Location = new System.Drawing.Point(49, 50);
            this.tbKd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbKd.Name = "tbKd";
            this.tbKd.Size = new System.Drawing.Size(38, 20);
            this.tbKd.TabIndex = 0;
            this.tbKd.Text = "0,1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ki:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kd:";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(260, 7);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Y+PID";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Y target";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(622, 266);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(14, 176);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(154, 95);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "PID:\n\nU (t)  = P (t) + I (t) + D (t)\nP (t)  = Kp * e (t)\nI (t)   = I (t - 1) + Ki" +
    " * e (t)\nD (t) = Kd * (e (t) - e (t - 1))";
            // 
            // tbTimerInterval
            // 
            this.tbTimerInterval.Location = new System.Drawing.Point(189, 5);
            this.tbTimerInterval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTimerInterval.MaxLength = 4;
            this.tbTimerInterval.Name = "tbTimerInterval";
            this.tbTimerInterval.Size = new System.Drawing.Size(27, 20);
            this.tbTimerInterval.TabIndex = 0;
            this.tbTimerInterval.Text = "200";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Speed of timer:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "msec.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 281);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl2Xreal);
            this.Controls.Add(this.lbl1PID);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbKd);
            this.Controls.Add(this.tbKi);
            this.Controls.Add(this.tbTimerInterval);
            this.Controls.Add(this.tbKp);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "PID. Proportional–integral–derivative controller";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl1PID;
        private System.Windows.Forms.Label lbl2Xreal;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKp;
        private System.Windows.Forms.TextBox tbKi;
        private System.Windows.Forms.TextBox tbKd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox tbTimerInterval;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

