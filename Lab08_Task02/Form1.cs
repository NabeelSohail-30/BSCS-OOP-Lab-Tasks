using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08_Task02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double subT = double.Parse(subTotal.Text);
            double discPerc = 0;
            double disc = 0;
            double tot = 0;

            if(subT >= 500)
            {
                discPerc = 20;
            }
            else if(subT < 500 && subT >= 250)
            {
                discPerc = 15;
            }
            else if (subT < 250 && subT >= 100)
            {
                discPerc = 10;
            }
            else
            {
                discPerc = 0;
            }

            disc = (subT * discPerc) / 100;
            tot = subT - disc;
            discountPerc.Text = discPerc.ToString();
            Discount.Text = disc.ToString();
            Total.Text = tot.ToString();
            lblmsg.Text = $"Dear Customer, You have to pay: {tot}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
