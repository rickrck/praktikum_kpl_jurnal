namespace Modul3_1302223051
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int nilai, total = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += button1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            nilai = Int32.Parse(label1.Text);
            label1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text += button0.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += button9.Text;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            total += nilai + Int32.Parse(label1.Text);
            label1.Text = (total).ToString();
        }
    }
}
