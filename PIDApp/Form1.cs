using System;
using System.Windows.Forms;

namespace PID
{
    public partial class Form1 : Form
    {
        private double Y_need, Y_real;
        private double dt;
        private double Kp, Ki, Kd;
        private double P, I, D, U;
        private double error, lastError;
        private int i, y;
        private double x = 1;

        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart1.ChartAreas[0].AxisX.Maximum = 40; //Max size of Axis X
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Y_need = Double.Parse(textBox1.Text);
            dt = Double.Parse(textBox3.Text);

            // PID:
            //u(t) = P (t) + I (t) + D (t);
            //P (t) = Kp * e (t);
            //I (t) = I (t — 1) + Ki * e (t);
            //D (t) = Kd * (e (t) — e (t — 1));

            error = Y_need - Y_real;                //е(t) = Target - Current position
            P = Kp * error;                         //P(t) = Kp * e(t);
            I = I + Ki * error * dt;                //I(t) = I(t — 1) + Ki * e(t);
            D = Kd * (error - lastError)/dt;        //D (t) = Kd * (e (t) — e (t — 1));
            U = P + I + D;                          //u(t) = P(t) + I(t) + D(t);

            lastError = error;
            Y_real += U;

            double X = Math.Round(Y_real, 2);

            lbl1PID.Text = Math.Round(U, 4).ToString();
            lbl2Xreal.Text = X.ToString();

            i++;
            chart1.Series[0].Points.AddXY(i, X);
            chart1.Series[1].Points.AddXY(i, Math.Round(Y_need,2) * 1.0);

            if (X == Y_need) timer1.Stop();
         }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetValues();

            timer1.Interval = int.Parse(tbTimerInterval.Text);

            Kp = Double.Parse(tbKp.Text);
            Ki = Double.Parse(tbKi.Text);
            Kd = Double.Parse(tbKd.Text);

            timer1.Start();

            chart1.Series[0].Points.AddXY(0, 0);
            chart1.Series[1].Points.AddXY(0, 0);
        }

        void ResetValues()
        {
            timer1.Stop();
            Kp = Ki = Kd = 0;
            P = I = D = U = 0;
            Y_real = 0;
            i = 0;

            lbl1PID.Text = "0";
            lbl2Xreal.Text = "0";
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }
    }
}
