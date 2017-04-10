using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        private int initialX;
        private int initialY;
        private int finalX;
        private int finalY;
        List<Label> labels = new List<Label>();
        public Form1()
        {
            InitializeComponent();
            MouseDown+=Form1_MouseDown;
            MouseUp+=Form1_MouseUp;
            
        }

      

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                finalX = e.X;
                finalY = e.Y;


                if (finalX - initialX > 10 && finalY - initialY > 10)
                {
                    labels.Add(new Label());
                    labels.FindLast(delegate(Label label)
                    {
                        return label != null;
                    }).BackColor = Color.Gold;
                    this.Controls.Add(labels.FindLast(delegate(Label label)
                    {
                        return label != null;
                    }));
                    labels.FindLast(delegate(Label label)
                    {
                        return label != null;
                    }).Location = new Point(initialX, initialY);
                    labels.FindLast(delegate(Label label)
                    {
                        return label != null;
                    }).Size = new Size(finalX - initialX, finalY - initialY);
                    labels.FindLast(delegate(Label label)
                    {
                        return label != null;
                    }).Text = labels.IndexOf(labels.FindLast(delegate(Label label)
                     {
                         return label != null;
                     })).ToString();
                     labels.FindLast(delegate(Label label)
                    {
                        return label != null;
                    }).MouseClick += Form1_Click;
                    labels.FindLast(delegate(Label label)
                    {
                        return label != null;
                    }).MouseDoubleClick+=Form1_MouseDoubleClick;

                }
                else
                {
                    MessageBox.Show("too small!", String.Empty, MessageBoxButtons.OK);
                }
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Label tmp = (Label)sender;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Text = String.Format(tmp.Width+"  "+tmp.Height);
            }
        }

        void Form1_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                Label tmp = (Label)sender;
                tmp.Dispose();
            }
            Point p = new Point();
            
           
        }
        public void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                initialX = e.X;
                initialY = e.Y;
            }
        }
    }
}
