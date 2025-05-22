namespace Lab3.Task3
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void Task3_Load(object sender, EventArgs e)
        {

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

        public class TextBook : Book
        {
            public string Subject { get; set; }
            public TextBook(string BookTitle, string BookAuthor, string subject) : base(BookTitle, BookAuthor)
            {
                this.Subject = subject;
            }

            public override string GetInfo()
            {
                return $"{BookTitle} by {BookAuthor}, Subject: {Subject}";
            }
        }

        public class AudioBook : Book
        {
            public string Duration { get; set; }
            public string Narrator { get; set; }
            public AudioBook(string BookTitle, string BookAuthor, string Duration, string Narrator) : base(BookTitle, BookAuthor)
            {
                this.Duration = Duration;
                this.Narrator = Narrator;
            }

            public override string GetInfo()
            {
                return $"{BookTitle} by {BookAuthor}, Duration: {Duration}, Narrator: {Narrator}";
            }
        }

        private class BookInfoLister
        {
            public static List<string> Listing(List<Book> Books)
            {
                List<string> newList = new List<string>();
                foreach (Book b in Books)
                {
                    newList.Add(b.GetInfo());
                }

                return newList;
            }
        }


        private void ShowBehavior(List<Book> Books)
        {
            listBoxBooks.DataSource = BookInfoLister.Listing(Books);
        }

        public List<Book> CreateBooks()
        {
            List<Book> Books = new List<Book>();

            Books.Add(new AudioBook("Dune in Crazy", "Jake Coll", "30mins", "Robert Capot"));
            Books.Add(new TextBook("Calculus for Generals", "James Stewart", "Calculus"));
            Books.Add(new AudioBook("Rich Dad Poor Dad", "Robert Kiyosaki", "1hr,12mins", "Bob Casandres"));
            Books.Add(new TextBook("Deep Down The Sink", "Cale Fernandez", "Economics"));
            Books.Add(new AudioBook("travel Outside", "Bell del Mundo", "6hrs,2mins", "Anna lewsit"));
            Books.Add(new TextBook("Rationalize it", "Freud Sigmund", "Philosophy"));

            return Books;
        }

        private void buttonShowBook_Click(object sender, EventArgs e)
        {
            ShowBehavior(CreateBooks());
        }
    }
}
