using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Timer : Form
    {
        int timertimemili,timertimesec,timertimedk,timertimehour,timertimeday,timertimemonth,timertimeyear = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            timertimemili = 0;
            timertimesec = 0;
            timertimedk = 0;
            timertimehour = 0;
            timertimeday = 0;
            timertimeyear = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start Timer")
            {
                timer1.Enabled = true;
                button1.Text = "Stop Timer";
            }
            else if (button1.Text == "Stop Timer")
            {
                timer1.Enabled = false;
                button1.Text = "Start Timer";
            }
        }

        public Timer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timertimemili > 99)
            {
                timertimemili = 0;
                timertimesec++;
            }
            if (timertimesec > 59)
            {
                timertimesec = 0;
                timertimedk++;
            }
            if (timertimedk > 59)
            {
                timertimedk = 0;
                timertimehour++;
            }
            if (timertimehour > 23)
            {
                timertimehour = 0;
                timertimeday++;
            }
            if (timertimeday > 364)
            {
                timertimeday = 0;
                timertimeyear++;
            }
            milisec.Text = Convert.ToString(timertimemili);
            sec.Text = Convert.ToString(timertimesec);
            dk.Text = Convert.ToString(timertimedk);
            hour.Text = Convert.ToString(timertimehour);
            day.Text = Convert.ToString(timertimeday);
            year.Text = Convert.ToString(timertimeyear);
            timertimemili++;
            File.WriteAllText(@".\lastesttimer.time",timertimeyear + "year" + "  " + timertimeday + "day" + "  " + timertimehour + "hour" + "  " + timertimedk + "minute" + "  " + timertimesec + "second" + "  " + timertimemili + "milisecond");
        }
    }
}
