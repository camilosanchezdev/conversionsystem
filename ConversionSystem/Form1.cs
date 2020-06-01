using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionSystem
{
    public partial class Form1 : Form
    {
        string option = "decimal";
        public Form1()
        {
            InitializeComponent();
        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            // read only
            decimalTextBox.ReadOnly = false;
            binaryTextBox.ReadOnly = true;
            octalTextBox.ReadOnly = true;
            hexadecimalTextBox.ReadOnly = true;

            // clean textbox

            decimalTextBox.Text = "";
            binaryTextBox.Text = "";
            octalTextBox.Text = "";
            hexadecimalTextBox.Text = "";

            option = "decimal";
        }
        // ONLY NUMBERS
        private void decimalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void binrayBtn_Click(object sender, EventArgs e)
        {
            decimalTextBox.ReadOnly = true;
            binaryTextBox.ReadOnly = false;
            octalTextBox.ReadOnly = true;
            hexadecimalTextBox.ReadOnly = true;
            // clean textbox

            decimalTextBox.Text = "";
            binaryTextBox.Text = "";
            octalTextBox.Text = "";
            hexadecimalTextBox.Text = "";

            option = "binary";
        }
        // ONLY BINARY NUMBERS
        private void binaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !("\b01".Contains(e.KeyChar));
            }
        }
        private void octalBtn_Click(object sender, EventArgs e)
        {
            decimalTextBox.ReadOnly = true;
            binaryTextBox.ReadOnly = true;
            octalTextBox.ReadOnly = false;
            hexadecimalTextBox.ReadOnly = true;
            // clean textbox

            decimalTextBox.Text = "";
            binaryTextBox.Text = "";
            octalTextBox.Text = "";
            hexadecimalTextBox.Text = "";

            option = "octal";
        }
        // ONLY NUMBERS
        private void octalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void hexaBtn_Click(object sender, EventArgs e)
        {
            decimalTextBox.ReadOnly = true;
            binaryTextBox.ReadOnly = true;
            octalTextBox.ReadOnly = true;
            hexadecimalTextBox.ReadOnly = false;
            // clean textbox

            decimalTextBox.Text = "";
            binaryTextBox.Text = "";
            octalTextBox.Text = "";
            hexadecimalTextBox.Text = "";

            option = "hexadecimal";
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            switch (option)
            {
                case "decimal":
                    binaryTextBox.Text = Convert.ToString(int.Parse(decimalTextBox.Text), 2);
                    octalTextBox.Text = Convert.ToString(int.Parse(decimalTextBox.Text), 8);
                    hexadecimalTextBox.Text = Convert.ToString(int.Parse(decimalTextBox.Text), 16);
                    break;
                case "binary":
                    decimalTextBox.Text = Convert.ToInt32(binaryTextBox.Text, 2).ToString();
                    octalTextBox.Text = Convert.ToString(Convert.ToInt32(binaryTextBox.Text, 2), 8);
                    hexadecimalTextBox.Text = Convert.ToString(Convert.ToInt32(binaryTextBox.Text, 2), 16);
                    break;
                case "octal":
                    decimalTextBox.Text = Convert.ToInt32(octalTextBox.Text, 8).ToString();
                    binaryTextBox.Text = Convert.ToString(Convert.ToInt32(octalTextBox.Text, 8), 2);
                    hexadecimalTextBox.Text = Convert.ToString(Convert.ToInt32(octalTextBox.Text, 8), 16);
                    break;
                case "hexadecimal":
                    decimalTextBox.Text = Convert.ToInt32(hexadecimalTextBox.Text, 16).ToString();
                    binaryTextBox.Text = Convert.ToString(Convert.ToInt32(hexadecimalTextBox.Text, 16), 2);
                    octalTextBox.Text = Convert.ToString(Convert.ToInt32(hexadecimalTextBox.Text, 16), 8);
                    break;
                
            }

            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            decimalTextBox.Text = "";
            binaryTextBox.Text = "";
            octalTextBox.Text = "";
            hexadecimalTextBox.Text = "";
        }

        
    }
}
