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
    public partial class age : Form
    {
        public string Years { get; set; }
        public string Months { get; set; }
        public string Days { get; set; }
        public string Hours { get; set; }
        public string Minutes { get; set; }
        public string Seconds { get; set; }

        public age o = null;
        public age()
        {
            InitializeComponent();
        }

        private void label_year_Click(object sender, EventArgs e)
        {
            
        }

        private void label_days_Click(object sender, EventArgs e)
        {
            label_days.Show();
        }

        private void age_Load(object sender, EventArgs e)
        {
            label_year.Text = o.Years;
            label_month.Text = o.Months;
            label_days.Text = o.Days;
            label_hour.Text = o.Hours;
            label_minutes.Text = o.Minutes;
            label_second.Text = o.Seconds;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
