using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        double secondNumber = 0;
        string operation = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result.Text += "1";
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void num2_Click(object sender, EventArgs e)
        {
            Result.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            Result.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            Result.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            Result.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            Result.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            Result.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            Result.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            Result.Text += "9";
        }

        private void X_Click(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                firstNumber = Convert.ToDouble(Result.Text);
                operation = "*";
                Result.Clear();
            }
        }

        private void dev_Click(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                firstNumber = Convert.ToDouble(Result.Text);
                operation = "/";
                Result.Clear();
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                firstNumber = Convert.ToDouble(Result.Text);
                operation = "-";
                Result.Clear();
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                firstNumber = Convert.ToDouble(Result.Text);
                operation = "+";
                Result.Clear();
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (Result.Text == "")
                return;

            secondNumber = Convert.ToDouble(Result.Text);

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    break;

                case "*":
                    result = firstNumber * secondNumber;
                    break;

                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }

                    result = firstNumber / secondNumber;
                    break;
            }

            Result.Text = result.ToString();

            firstNumber = result;
            operation = "";
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            Result.Text = "0";


        }

        private void CE_Click(object sender, EventArgs e)
        {
            Result.Text = "";
        }
    }
}
