using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        static double liters = 0;
        static int clients = 0;
        static double benefit = 0;
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("A-80");
            comboBox1.Items.Add("A-92");
            comboBox1.Items.Add("A-95");
            comboBox1.Items.Add("A-98");
            comboBox1.SelectedItem=comboBox1.Items[1];
            textBox1.ReadOnly = true;
            radioButton1.Select();
            textBox3.Enabled = false;
            comboBox1.EnabledChanged += textBox2_TextChanged;
            comboBox1.SelectedIndexChanged += label6_change_text;
            comboBox1.SelectedIndexChanged += textBox3_TextChanged;
            textBox4.Text = "1,0";
            textBox4.Enabled = false;
            textBox4.ReadOnly = true;
            textBox5.Text = "2,0";
            textBox5.Enabled = false;
            textBox5.ReadOnly = true;
            textBox6.Text = "1,5";
            textBox6.Enabled = false;
            textBox6.ReadOnly = true;
            textBox7.Text = "1,0";
            textBox7.ReadOnly = true;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            checkBox1.CheckStateChanged+=checkBox1_CheckStateChanged;
            checkBox2.CheckStateChanged += checkBox2_CheckStateChanged;
            checkBox3.CheckStateChanged += checkBox3_CheckStateChanged;
            checkBox4.CheckStateChanged += checkBox4_CheckStateChanged;
            label10.Text = "0,0";
            label6.Text = "0,0";
            timer.Interval = 10000;
            timer.Tick+=timer_Tick;
            Disposed += Form1_Disposed;
            FormClosed += Form1_FormClosed;
        }

        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(String.Format("Выручка за день: " + benefit + "\n литров продано: " + liters + "\n клиентов обслужено: " + clients));
        }

        void Form1_Disposed(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Выручка за день: " + benefit + "\n литров продано: " + liters + "\n клиентов обслужено: " + clients));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            DialogResult res=MessageBox.Show("Перейти к следующему клиенту?", String.Empty, MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                button1.Enabled = true;
                textBox2.Text = String.Empty;
                textBox3.Text = String.Empty;
                comboBox1.SelectedItem=comboBox1.Items[1];
                checkBox1.CheckState = CheckState.Unchecked;
                checkBox2.CheckState = CheckState.Unchecked;
                checkBox3.CheckState = CheckState.Unchecked;
                checkBox4.CheckState = CheckState.Unchecked;
                label12.Text = "0,0";
            }
            else timer.Start();
        }

        private void checkBox4_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false)
            {
                label10.Text = (Convert.ToDouble(label10.Text) - Convert.ToDouble(textBox11.Text) * Convert.ToDouble(textBox7.Text)).ToString();
                textBox11.Text = String.Empty;
                textBox7.Enabled = false;
                textBox11.Enabled = false;
            }
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false){
            label10.Text = (Convert.ToDouble(label10.Text) - Convert.ToDouble(textBox10.Text) * Convert.ToDouble(textBox6.Text)).ToString();
            textBox10.Text = String.Empty;
            textBox6.Enabled = false;
            textBox10.Enabled = false;
        }
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                label10.Text = (Convert.ToDouble(label10.Text) - Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox5.Text)).ToString();
                textBox9.Text = String.Empty;
                textBox5.Enabled = false;
                textBox9.Enabled = false;
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                label10.Text = (Convert.ToDouble(label10.Text) - Convert.ToDouble(textBox8.Text) * Convert.ToDouble(textBox4.Text)).ToString();
                textBox8.Text = String.Empty;
                textBox4.Enabled = false;
                textBox8.Enabled = false;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label6_change_text(object sender, EventArgs e)
        {
            if (textBox2.Text != String.Empty)
            {
                label6.Text = (Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox1.Text)).ToString();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "A-80")
            {
                textBox1.Text = "1,02";
            }
            if (comboBox1.SelectedItem.ToString() == "A-92")
            {
                textBox1.Text = "1,2";
            }
            if (comboBox1.SelectedItem.ToString() == "A-95")
            {
                textBox1.Text = "1,27";
            }
            if (comboBox1.SelectedItem.ToString() == "A-98")
            {
                textBox1.Text = "1,35";
            }
           
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            textBox2.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
            textBox2.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != String.Empty)
            {
                label6.Text = (Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox1.Text)).ToString();
            }
            else label6.Text = "0,0";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != String.Empty)
            {
                textBox2.Text = (Convert.ToDouble(textBox3.Text) / Convert.ToDouble(textBox1.Text)).ToString();
                label6.Text = (Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox1.Text)).ToString();
            }
            else label6.Text = "0,0";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            textBox8.Enabled = true;
            textBox8.Text = "1";
          //  label10.Text = (Convert.ToDouble(label10.Text)+Convert.ToDouble(textBox8.Text) * Convert.ToDouble(textBox4.Text)).ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            textBox5.Enabled = true;
            textBox9.Enabled = true;
            textBox9.Text = "1";
          //  label10.Text = (Convert.ToDouble(label10.Text) + Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox5.Text)).ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = true;
            textBox10.Enabled = true;
            textBox10.Text = "1";
          //  label10.Text = (Convert.ToDouble(label10.Text) + Convert.ToDouble(textBox10.Text) * Convert.ToDouble(textBox6.Text)).ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Enabled = true;
            textBox11.Enabled = true;
            textBox11.Text = "1";
          //  label10.Text = (Convert.ToDouble(label10.Text) + Convert.ToDouble(textBox11.Text) * Convert.ToDouble(textBox7.Text)).ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != String.Empty)
                label10.Text = ((Double.Parse(label10.Text)) + (Double.Parse(textBox8.Text) * Double.Parse(textBox4.Text))).ToString();
            else label10.Text = "0,0";
        }
       
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != String.Empty)
            label10.Text = (Convert.ToDouble(label10.Text) + Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox5.Text)).ToString();
            else label10.Text = "0,0";
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != String.Empty)
            label10.Text = (Convert.ToDouble(label10.Text) + Convert.ToDouble(textBox10.Text) * Convert.ToDouble(textBox6.Text)).ToString();
            else label10.Text = "0,0";
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != String.Empty)
            label10.Text = (Convert.ToDouble(label10.Text) + Convert.ToDouble(textBox11.Text) * Convert.ToDouble(textBox7.Text)).ToString();
            else label10.Text = "0,0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label6.Text != String.Empty || label10.Text != String.Empty)
            {
                label12.Text = (Double.Parse(label6.Text) + Double.Parse(label10.Text)).ToString();
                clients++;
                benefit += (Double.Parse(label6.Text) + Double.Parse(label10.Text));
                liters += Double.Parse(textBox2.Text);
                button1.Enabled = false;
                timer.Start();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
