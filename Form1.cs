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
            Number_clock("1");
        }

        private void Button_two_Click(object sender, EventArgs e)
        {
            Number_clock("2");
        }

        private void Button_three_Click(object sender, EventArgs e)
        {
            Number_clock("3");
        }

        private void Button_four_Click(object sender, EventArgs e)
        {
            Number_clock("4");
        }

        private void Button_five_Click(object sender, EventArgs e)
        {
            Number_clock("5");
        }

        private void Button_six_Click(object sender, EventArgs e)
        {
            Number_clock("6");
        }

        private void Button_seven_Click(object sender, EventArgs e)
        {
            Number_clock("7");
        }

        private void Button_eight_Click(object sender, EventArgs e)
        {
            Number_clock("8");
        }

        private void Button_nine_Click(object sender, EventArgs e)
        {
            Number_clock("9");
        }

        private void Number_clock(string s)
        {
            if (textBox_output_all.Text == "0" && textBox_output_all.Text != null)
            {
                textBox_output_all.Text = s;
            }
            else
            {
                textBox_output_all.Text = textBox_output_all.Text + s;
            }

            textBox_output.Text = s;
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
            Znak_click("*");
        }

        private void Button_div_Click(object sender, EventArgs e)
        {
            Znak_click("/");
        }

        private void Pow_Root(string s)
        {
            textBox_output_all.Text = textBox_output_all.Text + s;
            textBox_output.Text = s;
            znak = false;
        }

        private void Button_pow_Click(object sender, EventArgs e)
        {
            Pow_Root("^");
        }

        private void Button_root_Click(object sender, EventArgs e)
        {
            Pow_Root("√");
        }

        private void Zero_Clear()
        {
            textBox_output_all.Text = textBox_output_all.Text + "0";
            textBox_output.Text = "0";
            znak = false;
        }

        private void Button_zero_Click(object sender, EventArgs e)
        {
            Zero_Clear();
        }

        private void Button_enter_Click(object sender, EventArgs e)
        {
            textBox_output_all.Text = " ";
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            Zero_Clear();
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