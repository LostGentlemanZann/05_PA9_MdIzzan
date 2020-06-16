using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {

        public float USD = 0.74f;
        public float Yen = 81.97f;
        public float SGD = 1f;
        public float amount;
        public float convertedAmount;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                amount = Convert.ToSingle(txtAmount.Text);

                if (!(amount <0))
                {
                    if (rb_USD.Checked)
                    {
                        convertedAmount = 0.74f * amount;
                    }
                    else if (rb_Yen.Checked)
                    {
                        convertedAmount = 81.97f * amount;
                    }
                    else if (rb_Myr.Checked)
                    {
                        convertedAmount = 3.01f * amount;
                    }
                    else
                    {
                        MessageBox.Show("Please check a Button");
                    }
                    txtConvertedAmount.Text = convertedAmount.ToString(); 
                }
                else
                {
                    txtConvertedAmount.Text = "Cannot convert negative amount";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid amount after cicking on Converter");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConvertedAmount.Clear();
            txtAmount.Clear();
            rb_USD.Checked = false;
            rb_Yen.Checked = false;
        }
    }
}
