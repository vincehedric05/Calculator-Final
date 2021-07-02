using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Final
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        // Variables
        bool decimal_point = false;

        double num1 = 0;
        double num2 = 0;

        double ms = 0;

        double ans = 0;

        int Operator = 0;



        // Input Output
        private void input_click(object sender, EventArgs e)
        {
            if (txtbox_io.Text == "0")
                txtbox_io.Clear();

            Button button = (Button)sender;
            txtbox_io.Text = txtbox_io.Text + button.Text;

            label_memory.Focus();
        }

        private void decimal_click(object sender, EventArgs e)
        {
            if (decimal_point == true)
                txtbox_io.Text = txtbox_io.Text + "";
            else
                txtbox_io.Text = txtbox_io.Text + ".";

            decimal_point = true;

            label_memory.Focus();
        }

        // Delete
        private void click_delete(object sender, EventArgs e)
        {
            string io_index = txtbox_io.Text;
            int index = io_index.Length;
            index--;


            txtbox_io.Text = txtbox_io.Text.Remove(index);

            if (txtbox_io.Text == "")
                txtbox_io.Text = "0";
        }

        // CE
        private void click_ce(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            txtbox_io.Text = "0";
        }

        // Equals
        private void click_equals(object sender, EventArgs e)
        {
            num2 = double.Parse(txtbox_io.Text);
            double ans = 0;

            switch (Operator)
            {
                case 1:
                    ans = num1 + num2;
                    txtbox_io.Text = ans.ToString();

                    num1 = 0;
                    num2 = 0;
                    ans = 0;
                    break;

                case 2:
                    ans = num1 - num2;
                    txtbox_io.Text = ans.ToString();

                    num1 = 0;
                    num2 = 0;
                    ans = 0;
                    break; ;

                case 3:
                    ans = num1 * num2;
                    txtbox_io.Text = ans.ToString();

                    num1 = 0;
                    num2 = 0;
                    ans = 0;
                    break;

                case 4:
                    ans = num1 / num2;
                    txtbox_io.Text = ans.ToString();

                    num1 = 0;
                    num2 = 0;
                    ans = 0;
                    break;
            }
        }

        // Sign
        private void click_sign(object sender, EventArgs e)
        {
            if (txtbox_io.Text.Contains('-'))
                txtbox_io.Text = txtbox_io.Text.Trim('-');
            else
                txtbox_io.Text = "-" + txtbox_io.Text;
        }

        // Addition
        private void click_addition(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = double.Parse(txtbox_io.Text);
                txtbox_io.Text = "0";
            }
            else if (num1 != 0)
            {
                num2 = double.Parse(txtbox_io.Text);
                txtbox_io.Text = "0";

                ans = num1 + num2;
            }

            Operator = 1;
            decimal_point = false;
        }

        // Subtraction
        private void click_subtraction(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = double.Parse(txtbox_io.Text);
                txtbox_io.Text = "0";
            }
            else if (num1 != 0)
            {
                num2 = double.Parse(txtbox_io.Text);
                txtbox_io.Text = "0";
            }

            Operator = 2;
            decimal_point = false;
        }

        private void click_multiplication(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = double.Parse(txtbox_io.Text);
                txtbox_io.Text = "0";
            }
            else if (num1 != 0)
            {
                num2 = double.Parse(txtbox_io.Text);
                txtbox_io.Text = "0";
            }

            Operator = 3;
            decimal_point = false;
        }

        private void click_division(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = double.Parse(txtbox_io.Text);
                txtbox_io.Text = "0";
            }
            else if (num1 != 0)
            {
                num2 = double.Parse(txtbox_io.Text);
                txtbox_io.Text = "0";
            }

            Operator = 4;
            decimal_point = false;
        }

        private void click_pi(object sender, EventArgs e)
        {
            txtbox_io.Text = "3.14159";
        }

        private void click_sqrt(object sender, EventArgs e)
        {
            double sqrt = double.Parse(txtbox_io.Text);
            txtbox_io.Text = (Math.Sqrt(sqrt)).ToString();
        }

        private void click_ms(object sender, EventArgs e)
        {
            ms = double.Parse(txtbox_io.Text);
            Label_memorysave.Text = txtbox_io.Text;
        }

        private void click_mr(object sender, EventArgs e)
        {
            txtbox_io.Text = ms.ToString();
        }
    }
}
