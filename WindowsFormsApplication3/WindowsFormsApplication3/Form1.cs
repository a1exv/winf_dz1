using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        Label l = new Label();
        public bool ctrlon=false;
        public Form1()
        {
            InitializeComponent();
         
            l.Text = String.Empty;
            
            l.Location = new Point(this.Width / 2, this.Height / 2);
            this.Controls.Add(l);
            MouseClick+=Form1_MouseClick;
            MouseMove += new MouseEventHandler(delegate(object sender, MouseEventArgs e)
            {
                this.Text = String.Format(Cursor.Position.X + "  " + Cursor.Position.Y.ToString());
            });
          
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                l.Location = new Point(this.Width / 2, this.Height / 2);
                if (Control.ModifierKeys == Keys.Control) this.Close();
                if (e.X > 10 && e.Y > 10)
                {
                    l.Text = "Внутри_прямоугольника";
                }
                else
                {
                    l.Text = "Вне_прямоугольника";
                }
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
               
                this.Text = String.Format("x=" + this.Width + "  y=" + this.Height);
            }
        }
        
    }
}
