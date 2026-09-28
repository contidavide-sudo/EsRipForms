namespace EsRipForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            int cel = int.Parse(txtCel.Text);

            double far = (cel * 1.8) + 32;

            label2.Text = far.ToString();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            double N = double.Parse(n1.Text);
            double n = double.Parse(n2.Text);

            double ris = N + n;

            ris3.Text = ris.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double N = double.Parse(n1.Text);
            double n = double.Parse(n2.Text);

            double ris = N - n;

            ris3.Text = ris.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double N = double.Parse(n1.Text);
            double n = double.Parse(n2.Text);

            double ris = N * n;

            ris3.Text = ris.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double N = double.Parse(n1.Text);
            double n = double.Parse(n2.Text);

            double ris = N / n;

            ris3.Text = ris.ToString();
        }

    }
}
