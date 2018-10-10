using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad1
{
    public partial class Calc : Form
    {
        bool znak = false;
        public Calc()
        {
            InitializeComponent();
        }

        private void Button_one_Click(object sender, EventArgs e)
        {
            if (textBox_output_all.Text == "0" && textBox_output_all.Text != null)
            {
                textBox_output_all.Text = "1";
            }
            else
            {
                textBox_output_all.Text = textBox_output_all.Text + "1";
            }

            textBox_output.Text = "1";
            znak = false;
        }

        private void Button_two_Click(object sender, EventArgs e)
        {
            if (textBox_output_all.Text == "0" && textBox_output_all.Text != null)
            {
                textBox_output_all.Text = "2";
            }
            else
            {
                textBox_output_all.Text = textBox_output_all.Text + "2";
            }

            textBox_output.Text = "2";
            znak = false;
        }

        private void Button_three_Click(object sender, EventArgs e)
        {
            if (textBox_output_all.Text == "0" && textBox_output_all.Text != null)
            {
                textBox_output_all.Text = "3";
            }
            else
            {
                textBox_output_all.Text = textBox_output_all.Text + "3";
            }

            textBox_output.Text = "3";
            znak = false;
        }

        private void Button_four_Click(object sender, EventArgs e)
        {
            if (textBox_output_all.Text == "0" && textBox_output_all.Text != null)
            {
                textBox_output_all.Text = "4";
            }
            else
            {
                textBox_output_all.Text = textBox_output_all.Text + "4";
            }

            textBox_output.Text = "4";
            znak = false;
        }

        private void Button_five_Click(object sender, EventArgs e)
        {
            if (textBox_output_all.Text == "0" && textBox_output_all.Text != null)
            {
                textBox_output_all.Text = "5";
            }
            else
            {
                textBox_output_all.Text = textBox_output_all.Text + "5";
            }

            textBox_output.Text = "5";
            znak = false;
        }

        private void Button_six_Click(object sender, EventArgs e)
        {
            if (textBox_output_all.Text == "0" && textBox_output_all.Text != null)
            {
                textBox_output_all.Text = "6";
            }
            else
            {
                textBox_output_all.Text = textBox_output_all.Text + "6";
            }

            textBox_output.Text = "6";
            znak = false;
        }

        private void Button_seven_Click(object sender, EventArgs e)
        {
            if (textBox_output_all.Text == "0" && textBox_output_all.Text != null)
            {
                textBox_output_all.Text = "7";
            }
            else
            {
                textBox_output_all.Text = textBox_output_all.Text + "7";
            }

            textBox_output.Text = "7";
            znak = false;
        }

        private void Button_eight_Click(object sender, EventArgs e)
        {
            if (textBox_output_all.Text == "0" && textBox_output_all.Text != null)
            {
                textBox_output_all.Text = "8";
            }
            else
            {
                textBox_output_all.Text = textBox_output_all.Text + "8";
            }

            textBox_output.Text = "8";
            znak = false;
        }

        private void Button_nine_Click(object sender, EventArgs e)
        {
            if (textBox_output_all.Text == "0" && textBox_output_all.Text != null)
            {
                textBox_output_all.Text = "9";
            }
            else
            {
                textBox_output_all.Text = textBox_output_all.Text + "9";
            }

            textBox_output.Text = "9";
            znak = false;
        }

        private void Button_zero_Click(object sender, EventArgs e)
        {
            textBox_output_all.Text = textBox_output_all.Text + "0";
            textBox_output.Text = "0";
            znak = false;
        }

        private void Znak_click(string s)
        {
            if (znak == false)
            {
                textBox_output_all.Text = textBox_output_all.Text + s;
                textBox_output.Text = s;
                znak = true;
            }
            else
            {
                int lenght = textBox_output_all.Text.Length - 1;
                string text = textBox_output_all.Text;
                textBox_output.Text = s;
                textBox_output_all.Clear();

                for (int i = 0; i < lenght; i++)
                {
                    textBox_output_all.Text = textBox_output_all.Text + text[i];
                }

                textBox_output_all.Text = textBox_output_all.Text + s;
            }
        }

        private void Button_plus_Click(object sender, EventArgs e)
        {
            Znak_click("+");
        }

        private void Button_minus_Click(object sender, EventArgs e)
        {
            Znak_click("-");
        }

        private void Button_mult_Click(object sender, EventArgs e)
        {
            textBox_output_all.Text = textBox_output_all.Text + "*";
            textBox_output.Text = "*";
        }

        private void Button_div_Click(object sender, EventArgs e)
        {
            textBox_output_all.Text = textBox_output_all.Text + "/";
            textBox_output.Text = "/";
        }

        private void Button_pow_Click(object sender, EventArgs e)
        {
            textBox_output_all.Text = textBox_output_all.Text + "^";
            textBox_output.Text = "^";
        }

        private void Button_root_Click(object sender, EventArgs e)
        {
            textBox_output_all.Text = textBox_output_all.Text + "√";
            textBox_output.Text = "√";
        }

        private void Button_enter_Click(object sender, EventArgs e)
        {
            textBox_output_all.Text = " ";
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            textBox_output_all.Text = "0";
            textBox_output.Text = "0";
        }

        private void Button_plusmin_Click(object sender, EventArgs e)
        {
            textBox_output_all.Text = textBox_output_all.Text + ",";
            textBox_output.Text = textBox_output.Text + ",";
        }

        private void Button_dot_Click(object sender, EventArgs e)
        {
            textBox_output_all.Text = textBox_output_all.Text + ",";
            textBox_output.Text = textBox_output.Text + ",";
        }

        private void Button_backspace_Click(object sender, EventArgs e)
        {
            textBox_output_all.Text = textBox_output_all.Text;
            textBox_output.Text = "0";

            int lenght = textBox_output_all.Text.Length - 1;
            string text = textBox_output_all.Text;
            textBox_output.Text = "0";
            textBox_output_all.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox_output_all.Text = textBox_output_all.Text + text[i];
            }
        }

        private void TextBox_output_all_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_output_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calc_Load(object sender, EventArgs e)
        {

        }

    }
}