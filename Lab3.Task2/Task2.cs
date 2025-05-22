using System.Reflection.Metadata.Ecma335;

namespace Lab3.Task2
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string BookTitle { get; set; }

            public string BookAuthor { get; set; }

            public Book(string BookTitle, string BookAuthor)
            {
                this.BookTitle = BookTitle;
                this.BookAuthor = BookAuthor;
            }

            public virtual string GetInfo()
            {
                return $"{BookTitle} by {BookAuthor}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }

            public Magazine(string BookTitle, string BookAuthor, int IssueNumber) 
                : base(BookTitle, BookAuthor)
            {
                this.IssueNumber = IssueNumber;
            }

            public override string GetInfo()
            {
                return $"{BookTitle} - Issue {IssueNumber}, Type: Magazine";
            }
        }

        public class Ebook : Book
        {
            public int IssueNumber { get; set; }

            public Ebook(string BookTitle, string BookAuthor, int IssueNumber) 
                : base(BookTitle, BookAuthor)
            {
                this.IssueNumber = IssueNumber;
            }

            public override string GetInfo()
            {
                return $"{BookTitle} - Issue {IssueNumber}, Type: Ebook";
            }
        }

        private class BookInfoLister
        {
            public static List<string> Listing(List<Book> Books)
            {
                List<string> newList = new List<string>();
                foreach(Book b in Books)
                {
                    newList.Add(b.GetInfo());
                }

                return newList;
            }
        }


        private void ShowBehavior(List<Book> Books)
        {
            listBox1.DataSource = BookInfoLister.Listing(Books);
        }

        public List<Book> CreateBooks()
        {
            List<Book> Books = new List<Book>();

            Books.Add(new Magazine("TechNews", "Jacob Hill", 0035));
            Books.Add(new Ebook("Random Gadgets", "Xander Wright", 890));
            Books.Add(new Ebook("1984", "George Orwell", 7890));
            Books.Add(new Magazine("A Mind for Numbers", "Barbara Oakley", 3478));
            Books.Add(new Ebook("Laws of Power", "Rober Green", 6754));

            return Books;
        }

        private void buttonShowBehavior_Click(object sender, EventArgs e)
        {
            ShowBehavior(CreateBooks());
        }
    }
}
