using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        DateTime fdt = new DateTime();
        public Form1()
        {
           
            InitializeComponent();
            fdt = monthCalendar1.SelectionStart;
            monthCalendar1.MouseDown += monthCalendar1_MouseDown;
        }

        void monthCalendar1_MouseDown(object sender, MouseEventArgs e)
        {
            fdt = monthCalendar1.SelectionStart;
            if(radioButton1.Checked) radioButton1_CheckedChanged( sender, e);
            if (radioButton2.Checked) radioButton2_CheckedChanged(sender, e);
            if (radioButton3.Checked) radioButton3_CheckedChanged(sender, e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (fdt > DateTime.Now)
            {
                TimeSpan tmp = fdt - DateTime.Now;
                double years = tmp.TotalDays / 365;
                label2.Text = years.ToString();
            }
            else label2.Text = "Уже в прошлом";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (fdt > DateTime.Now)
            {
                TimeSpan tmp = fdt - DateTime.Now;
                double month = tmp.TotalDays / 30; ;
                label2.Text = month.ToString();
            }
            else label2.Text = "Уже в прошлом";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (fdt > DateTime.Now)
            {
                TimeSpan tmp = fdt - DateTime.Now;
                double days = tmp.TotalDays;
                label2.Text = days.ToString();
            }
            else label2.Text = "Уже в прошлом";
        }
    }
}
