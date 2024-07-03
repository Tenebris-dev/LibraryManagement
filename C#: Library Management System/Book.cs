// Book.cs
namespace LibraryManagement
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsCheckedOut { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsCheckedOut = false;
        }

        public void CheckOut()
        {
            IsCheckedOut = true;
        }

        public void Return()
        {
            IsCheckedOut = false;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} - {(IsCheckedOut ? "Checked Out" : "Available")}";
        }
    }
}