namespace task3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxNumber.Text = "0";
        }

        static int nthFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return nthFibonacci(n - 1) + nthFibonacci(n - 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int TheNumber = Convert.ToInt32(textBoxNumber.Text);

            int FiboNum = nthFibonacci(TheNumber);

            MessageBox.Show($"the nth Term is: {FiboNum}");
        }
    }
}
