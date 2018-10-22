using System;
using System.Collections.Generic;
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
            Number_click("1");
        }

        private void Button_two_Click(object sender, EventArgs e)
        {
            Number_click("2");
        }

        private void Button_three_Click(object sender, EventArgs e)
        {
            Number_click("3");
        }

        private void Button_four_Click(object sender, EventArgs e)
        {
            Number_click("4");
        }

        private void Button_five_Click(object sender, EventArgs e)
        {
            Number_click("5");
        }

        private void Button_six_Click(object sender, EventArgs e)
        {
            Number_click("6");
        }

        private void Button_seven_Click(object sender, EventArgs e)
        {
            Number_click("7");
        }

        private void Button_eight_Click(object sender, EventArgs e)
        {
            Number_click("8");
        }

        private void Button_nine_Click(object sender, EventArgs e)
        {
            Number_click("9");
        }

        private void Number_click(string s)
        {
            if (textBox_output_all.Text == "0" && textBox_output_all.Text != null)
            {
                textBox_output_all.Text = s;
            }
            else
            {
                textBox_output_all.Text = textBox_output_all.Text + s;
            }

            znak = false;
        }

        private void Znak_click(string s)
        {
            if (znak == false)
            {
                textBox_output_all.Text = textBox_output_all.Text + s;
                znak = true;
            }
            else
            {
                int lenght = textBox_output_all.Text.Length - 1;
                string text = textBox_output_all.Text;
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
            znak = false;
        }

        private void Button_pow_Click(object sender, EventArgs e)
        {
            Znak_click("^");
        }

        private void Button_root_Click(object sender, EventArgs e)
        {
            Znak_click("√");
        }

        private void Zero_Clear()
        {
            textBox_output_all.Text = "0";
            znak = false;
        }

        private void Button_zero_Click(object sender, EventArgs e)
        {
            Number_click("0");
        }

        private String Calculate(String input)
        {
            String output = GetExpression(input);
            String result = Counting(output);
            return result;
        }

        static private string GetExpression(string input)
        {
            string output = string.Empty;
            Stack<char> operStack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (IsDelimeter(input[i]))
                {
                    continue;
                }

                if (Char.IsDigit(input[i]))
                {
                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        output += input[i];
                        i++;

                        if (i == input.Length) break;
                    }

                    output += " ";
                    i--;
                }

                if (IsOperator(input[i]))
                {
                    if (input[i] == '(')
                        operStack.Push(input[i]);
                    else if (input[i] == ')')
                    {
                        char s = operStack.Pop();

                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            s = operStack.Pop();
                        }
                    }
                    else
                    {
                        if (operStack.Count > 0)
                            if (GetPriority(input[i]) <= GetPriority(operStack.Peek()))
                                output += operStack.Pop().ToString() + " ";

                        operStack.Push(char.Parse(input[i].ToString()));
                    }
                }
            }

            while (operStack.Count > 0)
                output += operStack.Pop() + " ";

            return output;
        }

        static private string Counting(string input)
        {
            try
            {
                double result = 0;
                Stack<double> temp = new Stack<double>();

                for (int i = 0; i < input.Length; i++)
                {

                    if (Char.IsDigit(input[i]))
                    {
                        string a = string.Empty;

                        while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                        {
                            a += input[i];
                            i++;
                            if (i == input.Length) break;
                        }
                        temp.Push(double.Parse(a));
                        i--;
                    }
                    else if (IsOperator(input[i]))
                    {
                        double a = temp.Pop();
                        double b = temp.Pop();

                        switch (input[i])
                        {
                            case '+': result = b + a; break;
                            case '-': result = b - a; break;
                            case '*': result = b * a; break;
                            case '/': result = b / a; break;
                            case '^': result = double.Parse(Math.Pow(double.Parse(b.ToString()), double.Parse(a.ToString())).ToString()); break;
                            case '√': result = double.Parse(Math.Pow(double.Parse(a.ToString()), 1 / double.Parse(b.ToString())).ToString()); break;
                        }
                        temp.Push(result);
                    }
                }
                return temp.Peek().ToString();
            }
            catch
            {
                return "Ошибка ввода";
            }
        }

        static private bool IsDelimeter(char c)
        {
            if ((" =".IndexOf(c) != -1))
                return true;
            return false;
        }

        static private bool IsOperator(char с)
        {
            if (("+-/*^()√".IndexOf(с) != -1))
                return true;
            return false;
        }

        static private byte GetPriority(char s)
        {
            switch (s)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 4;
                case '^': return 5;
                case '√': return 6;
                default: return 7;
            }
        }

        private void Button_enter_Click(object sender, EventArgs e)
        {            textBox_output_all.Text = this.Calculate(textBox_output_all.Text);
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            Zero_Clear();
        }

        private void Button_dot_Click(object sender, EventArgs e)
        {
            Znak_click(",");
        }

        private void Button_backspace_Click(object sender, EventArgs e)
        {
            textBox_output_all.Text = textBox_output_all.Text;
            int lenght = textBox_output_all.Text.Length - 1;
            string text = textBox_output_all.Text;
            textBox_output_all.Clear();
            if (lenght == 0)
            {
                textBox_output_all.Text = "0";
            }
            else
            {
                for (int i = 0; i < lenght; i++)
                {
                    textBox_output_all.Text = textBox_output_all.Text + text[i];
                    if (Char.IsDigit(text[lenght-1]))
                        znak = true;
                    else
                        znak = false;
                }
            }
            znak = false;
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

        private void bracket_end_Click(object sender, EventArgs e)
        {
            Pow_Root(")");
        }

        private void bracket_start_Click(object sender, EventArgs e)
        {
            Pow_Root("(");
        }
    }
}