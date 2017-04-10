using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public  struct amount
        {
            public int symbols;
            public int boxes;
        
        }
        public static amount Amount;

        public Form1()
        {
            Amount.symbols = 0;
            Amount.boxes = 0;
            InitializeComponent();
            string mb1 = "imya = Aleksandr";
            string mb2 = "familiya = Volodkevich";
            string mb3 = "zhivet v Minske";
            MessageBox.Show(mb1);
            Amount.boxes++;
            Amount.symbols+=mb1.Count();
            MessageBox.Show(mb2);
            Amount.boxes++;
            Amount.symbols += mb2.Count();
            Amount.boxes++;
            Amount.symbols += mb3.Count();
            MessageBox.Show(mb3, String.Format(Amount.boxes + "  " + Amount.symbols));
           
        }
    }
}
