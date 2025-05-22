namespace Lab1.Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int[] numbers = { 100, 61, 01, 35, 42, 33, 44, 89, 12, 53 };

        public class Sort
        {
            public static int[] BubbleSortAscend(int[] Integers)
            {
                int n = Integers.Length;

                for (int i = 0; i < n - 1; i++) // Outer loop
                {
                    for (int j = 0; j < n - i - 1; j++) // Inner loop
                    {
                        if (Integers[j] > Integers[j + 1])
                        {
                            // Swap elements
                            int temp = Integers[j];
                            Integers[j] = Integers[j + 1];
                            Integers[j + 1] = temp;
                        }
                    }
                }

                return Integers;
            }
            public static List<int> Descending(int[] Integers)
            {
                List<int> nums = Integers.OrderByDescending(n => n).ToList();
                return nums;
            }
        }

        private void buttonAscend_Click(object sender, EventArgs e)
        {
            listBoxView.DataSource = Sort.BubbleSortAscend(numbers).ToList();
        }

        private void buttonDescend_Click(object sender, EventArgs e)
        {
            listBoxView.DataSource = Sort.Descending(numbers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxView.DataSource = numbers.ToList();
        }
    }
}
