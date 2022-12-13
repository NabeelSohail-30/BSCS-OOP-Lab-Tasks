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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(num1.Text) || string.IsNullOrEmpty(num2.Text))
                {
                    throw new Exception("Textbox cannot be NULL");
                }
                else
                {
                    result.Text = (int.Parse(num1.Text) + int.Parse(num2.Text)).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(num1.Text) || string.IsNullOrEmpty(num2.Text))
                {
                    throw new Exception("Textbox cannot be NULL");
                }
                else
                {
                    result.Text = (int.Parse(num2.Text) - int.Parse(num1.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(num1.Text) || string.IsNullOrEmpty(num2.Text))
                {
                    throw new Exception("Textbox cannot be NULL");
                }
                else
                {
                    result.Text = (int.Parse(num1.Text) * int.Parse(num2.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(num1.Text) || string.IsNullOrEmpty(num2.Text))
                {
                    throw new Exception("Textbox cannot be NULL");
                }
                else
                {
                    result.Text = (int.Parse(num1.Text) / int.Parse(num2.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num2.Text = string.Empty;
            num1.Text = string.Empty;
            result.Text = string.Empty;
        }
    }
}
