using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        Label st = new Label();
        Point p = new Point();
        public int speed = 1;
        public Form1()
        {
            InitializeComponent();
          
            this.Controls.Add(st);
            st.BackColor = Color.Purple;
            st.Size = new Size(20, 20);
            st.Location = new Point(this.Width / 2, this.Height / 2);
            p.X = st.Location.X + st.Size.Width / 2;
            p.Y = st.Location.Y + st.Size.Height / 2;
            
            MouseMove += Form1_MouseMove;
            st.MouseMove += st_MouseMove;
        }

        void st_MouseMove(object sender, MouseEventArgs e)
        {
            Label tmp = (Label)sender;
            tmp.Dispose();
        }
        public Point setPoint(Point p, Label st)
        {
            p = new Point(st.Location.X + st.Size.Width / 2,
             st.Location.Y + st.Size.Height / 2);
            return p;
        }
        void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           // if ((e.Location.X - (st.Location.X + st.Width/2)>-5)&&(e.Location.X - (st.Location.X + st.Width/2)<0))
           // {
           //     st.Location = new Point((st.Location.X + 1), st.Location.Y);
           //     Thread.Sleep(10);
           // }
           // if ((e.Location.Y - (st.Location.Y + st.Height / 2) > -5)&&(e.Location.Y - (st.Location.Y + st.Height / 2)<0))
           // {
           //     st.Location = new Point((st.Location.X), st.Location.Y + 1);
           //     Thread.Sleep(10);
           // }

            if (((e.Location.X - p.X < 25) && (e.Location.X - p.X >0))&&((e.Location.Y - p.Y < 25)&& (e.Location.Y - p.Y >0)))
            {
                st.Location = new Point((st.Location.X - speed), st.Location.Y - speed);
               p= setPoint(p, st);
                Thread.Sleep(2);
            }
            if (((e.Location.X - p.X > -25) && (e.Location.X - p.X < 0)) && ((e.Location.Y - p.Y > -25) && (e.Location.Y - p.Y < 0)))
            {
                st.Location = new Point((st.Location.X + speed), st.Location.Y + speed);
                p=setPoint(p, st);
                Thread.Sleep(2);
            }
            if (((e.Location.X - p.X > -25) && (e.Location.X - p.X < 0)) && ((e.Location.Y - p.Y < 25) && (e.Location.Y - p.Y >0)))
            {
                st.Location = new Point((st.Location.X + speed), st.Location.Y - speed);
                p = setPoint(p, st);
                Thread.Sleep(2);
            }
            if (((e.Location.X - p.X < 25) && (e.Location.X - p.X > 0)) && ((e.Location.Y - p.Y > -25) && (e.Location.Y - p.Y < 0)))
            {
                st.Location = new Point((st.Location.X - speed), st.Location.Y +speed);
                p = setPoint(p, st);
                Thread.Sleep(2);
            }
            if (Controls.Contains(st) == false)
            {
                st = new Label();
                speed++;
                this.Controls.Add(st);
                st.BackColor = Color.Red;
                st.Size = new Size(20, 20);
                st.Location = new Point(this.Width / 2, this.Height / 2);
                p.X = st.Location.X + st.Size.Width / 2;
                p.Y = st.Location.Y + st.Size.Height / 2;
                st.MouseMove+=st_MouseMove;
            }
          
          //  if ((e.Location.Y - (st.Location.Y + st.Height / 2) < 5)&& (e.Location.Y - (st.Location.Y + st.Height / 2) >0))
          //  {
          //      st.Location = new Point((st.Location.X), st.Location.Y - 1);
          //      Thread.Sleep(10);
          //  }
        }
    }
}
