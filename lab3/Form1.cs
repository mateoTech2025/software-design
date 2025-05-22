namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public class Book
        {
            public string BookTitle { get; set; }

            public string BookAuthor { get; set; }

            public virtual string GetInfo()
            {
                return $"{BookTitle} by {BookAuthor}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }

            public override string GetInfo()
            {
                return $"{BookTitle} - Issue {IssueNumber}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book newBook = new Magazine
            {
                BookTitle = "TechWeekly",
                BookAuthor = "John Doe",
                IssueNumber = 45
            };

            MessageBox.Show(newBook.GetInfo());
        }
    }
}
