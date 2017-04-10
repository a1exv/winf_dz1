using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        private int day=0;
        private int month=0;
        private int year=0;
        public Form1()
        {
           
            InitializeComponent();
            label1.Text = String.Empty;
            textBox1.KeyPress += textBox1_KeyPress;
      
        }

       
        void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tx = (TextBox)sender;
            day = Convert.ToInt32(tx.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox tx = (TextBox)sender;
            month = Convert.ToInt32(tx.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox tx = (TextBox)sender;
            year = Convert.ToInt32(tx.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((day != 0) && (month != 0) && (year != 0))
            {
                DateTime dt = new DateTime(year, month, day);
                label1.Text = dt.ToString("dddd");
              
            }
            else
            {
                MessageBox.Show("Ожидаются данные");
            }
        }
    }
}
