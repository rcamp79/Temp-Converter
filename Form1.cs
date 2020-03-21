using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConvert2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            try
            {
                decimal temp = Convert.ToDecimal(tempValue.Text);

                decimal tempC = ((temp - 32) * (9 / 5));

                valueC.Text = tempC.ToString("g");
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Invalid numeric format. Please check all entries.",
                    "Entry Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                    "Overflow error. Please enter smaller values.",
                    "Entry Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    ex.GetType().ToString());
            }




        }

        private void ButtonF_Click(object sender, EventArgs e)
        {
            try
            {
                decimal temp = Convert.ToDecimal(tempValue.Text);

                decimal tempF = ((9 / 5) * temp) + 32;

                valueF.Text = tempF.ToString("g");
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Invalid numeric format. Please check all entries.",
                    "Entry Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                    "Overflow error. Please enter smaller values.",
                    "Entry Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    ex.GetType().ToString());
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            tempValue.Clear();
            valueC.Clear();
            valueF.Clear();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
