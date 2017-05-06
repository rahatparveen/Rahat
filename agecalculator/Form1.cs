using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agecalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dob = maskedTextBox1.Text;
            DateTime dob1 = DateTime.Parse(dob);

            //DateTime current = DateTime.Now;
            //int year = dob1.Year;
            //DateTime years = current - year;
          TimeSpan ts=  DateTime.Now.Subtract(dob1);
          //double days=  ts.TotalDays;
          //double min=  ts.TotalMinutes;
          //  double year = ts.TotalDays / 365;
          // double month= ts.TotalDays / 30;
          //double hours=  ts.TotalHours;
          //double sec=  ts.TotalSeconds;
            //TimeSpan ts= DateTime.Now.Subtract(dob1);

            //MessageBox.Show(ts.TotalDays.ToString());
            //MessageBox.Show(ts.TotalHours.ToString());
            //MessageBox.Show(ts.TotalMinutes.ToString());
            //MessageBox.Show(ts.TotalSeconds.ToString());
            double years = ts.TotalDays / 365;
            double months = ts.TotalDays / 30;
            string days = ts.TotalDays.ToString();
            string hours = ts.TotalHours.ToString();
            string minutes = ts.TotalMinutes.ToString();
            string seconds = ts.TotalSeconds.ToString();

            age oage = new age();
            oage.Years = years.ToString();
            oage.Months = months.ToString();
            oage.Days = days;
            oage.Hours = hours;
            oage.Minutes = minutes;
            oage.Seconds = seconds;


            age b = new age();
            b.o = oage;
            b.ShowDialog();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
