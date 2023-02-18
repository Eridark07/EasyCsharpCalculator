namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        // This is the textbox where all the operation are made
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // This is for the number buttons {1, 2, 3, ...}
        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text +1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        // Here is where the button signs are {+, /, *, -}
        private void btnadd_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void btnsust_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void btntimes_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }
        private void btnpoint_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        // Here the "result" with all of its logic its placed and a delete button
        private void btnresult_Click(object sender, EventArgs e)
        {
            string expresion = textBox1.Text;
            object result = new System.Data.DataTable().Compute(expresion, null);
            textBox1.Text = result.ToString();
        }

        private void dtndelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}