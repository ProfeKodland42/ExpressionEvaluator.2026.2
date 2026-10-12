using Backend;

namespace Frontend.Windows
{
    public partial class Evaluator : Form
    {
        public Evaluator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void T0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void btnIqual_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += $"={ExpressionEvaluator.Evalute(txtDisplay.Text)}";
        }

        private void btnrest_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "-";
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "(";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "/";
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ")";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "+";
        }

        private void btnMulty_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "*";
        }

        private void btnExpo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "^";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }
    }
}
