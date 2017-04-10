using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public DialogResult but;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (true)
            {
               but= MessageBox.Show(String.Format(r.Next(1, 2000) + " - Ваше число!"), String.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (but == DialogResult.No) continue;
               else
               {
                   but = MessageBox.Show("Еще разок?", String.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                   if (but == DialogResult.Yes) continue;
                   else break;
               }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
