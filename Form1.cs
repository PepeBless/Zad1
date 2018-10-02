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
        public Calc()
        {
            InitializeComponent();
        }

        private void Button_one_Click(object sender, EventArgs e)
        {
            textBox_output.Text = textBox_output.Text + "1";
        }

        private void Button_two_Click(object sender, EventArgs e)
        {
            textBox_output.Text = textBox_output.Text + "2";
        }

        private void Button_three_Click(object sender, EventArgs e)
        {
            textBox_output.Text = textBox_output.Text + "3";
        }

        private void Button_four_Click(object sender, EventArgs e)
        {
            textBox_output.Text = textBox_output.Text + "4";
        }

        private void Button_five_Click(object sender, EventArgs e)
        {
            textBox_output.Text = textBox_output.Text + "5";
        }

        private void Button_six_Click(object sender, EventArgs e)
        {
            textBox_output.Text = textBox_output.Text + "6";
        }

        private void Button_seven_Click(object sender, EventArgs e)
        {
            textBox_output.Text = textBox_output.Text + "7";
        }

        private void Button_eight_Click(object sender, EventArgs e)
        {
            textBox_output.Text = textBox_output.Text + "8";
        }

        private void Button_nine_Click(object sender, EventArgs e)
        {
            textBox_output.Text = textBox_output.Text + "9";
        }

        private void Button_zero_Click(object sender, EventArgs e)
        {
            textBox_output.Text = textBox_output.Text + "0";
        }

        private void Button_y_Click(object sender, EventArgs e)
        {

        }

        private void Button_x_Click(object sender, EventArgs e)
        {

        }

        private void Button_plus_Click(object sender, EventArgs e)
        {
            textBox_output.Text = textBox_output.Text + "+";
        }

        private void Button_minus_Click(object sender, EventArgs e)
        {

        }

        private void Button_mult_Click(object sender, EventArgs e)
        {

        }

        private void Button_div_Click(object sender, EventArgs e)
        {

        }

        private void Button_pow_Click(object sender, EventArgs e)
        {

        }

        private void Button_root_Click(object sender, EventArgs e)
        {

        }

        private void Button_enter_Click(object sender, EventArgs e)
        {

        }

        private void Button_backspace_Click(object sender, EventArgs e)
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