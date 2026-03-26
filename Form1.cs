namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        bool isResultShown = false;
        decimal num1;
        decimal num2;
        char character;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                lblShowCalculation.Text = "1";
                isResultShown = false;
            }
            else
            {
                lblShowCalculation.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                lblShowCalculation.Text = "2";
                isResultShown = false;
            }
            else
            {
                lblShowCalculation.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                lblShowCalculation.Text = "3";
                isResultShown = false;
            }
            else
            {
                lblShowCalculation.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                lblShowCalculation.Text = "4";
                isResultShown = false;
            }
            else
            {
                lblShowCalculation.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                lblShowCalculation.Text = "5";
                isResultShown = false;
            }
            else
            {
                lblShowCalculation.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                lblShowCalculation.Text = "6";
                isResultShown = false;
            }
            else
            {
                lblShowCalculation.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                lblShowCalculation.Text = "7";
                isResultShown = false;
            }
            else
            {
                lblShowCalculation.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                lblShowCalculation.Text = "8";
                isResultShown = false;
            }
            else
            {
                lblShowCalculation.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                lblShowCalculation.Text = "9";
                isResultShown = false;
            }
            else
            {
                lblShowCalculation.Text += "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                lblShowCalculation.Text = "0";
                isResultShown = false;
            }
            else
            {
                lblShowCalculation.Text += "0";
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                lblShowCalculation.Text = ".";
                isResultShown = false;
            }
            else
            {
                lblShowCalculation.Text += ".";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                num1 = decimal.Parse(lblResult.Text);
                isResultShown = false;
            }
            else
            {
                num1 = decimal.Parse(lblShowCalculation.Text);
            }

            character = '+';
            lblShowCalculation.Text = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                num1 = decimal.Parse(lblResult.Text);
                isResultShown = false;
            }
            else
            {
                num1 = decimal.Parse(lblShowCalculation.Text);
            }

            character = '-';
            lblShowCalculation.Text = "";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                num1 = decimal.Parse(lblResult.Text);
                isResultShown = false;
            }
            else
            {
                num1 = decimal.Parse(lblShowCalculation.Text);
            }

            character = '*';
            lblShowCalculation.Text = "";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                num1 = decimal.Parse(lblResult.Text);
                isResultShown = false;
            }
            else
            {
                num1 = decimal.Parse(lblShowCalculation.Text);
            }

            character = '/';

            lblShowCalculation.Text = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            num2 = decimal.Parse(lblShowCalculation.Text);

            decimal result = 0;

            if (character == '+')
                result = num1 + num2;
            else if (character == '-')
                result = num1 - num2;
            else if (character == '*')
                result = num1 * num2;
            else if (character == '/')
                result = num1 / num2;

            lblResult.Visible = true;
            lblShowCalculation.Visible = false;
            lblResult.Text = result.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            isResultShown = true;
            lblResult.Visible = false;
            lblShowCalculation.Visible = true;
            lblShowCalculation.Text = "";
        }
    }
}
