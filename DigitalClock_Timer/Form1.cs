using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hour = 0;
        int minute = 0;
        int second = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer3.Interval = 1000;

            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            if (second == 60)
            {
                minute++;
                second = 0;
            }
            lbl_second.Text = second.ToString("00");
            lbl_minute.Text = minute.ToString("00");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (minute == 60)
            {
                hour++;
                minute = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (hour == 24)
            {
                lbl_hour.Text = hour.ToString();
                MessageBox.Show("Congratulations, Your Application Has Been Working For Exactly 1 Day", "Successful Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hour = minute = second = 0;
            }
        }
    }
}
