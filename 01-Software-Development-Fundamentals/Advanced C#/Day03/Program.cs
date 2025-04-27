namespace Day03
{
    internal class Program
    {
        public delegate string MyCustomBookDel(Book B);
        public delegate string AnonymousFunctionDel(Book B);
        public delegate string LambdaExpresionDel(Book B);

        static void Main(string[] args)
        {
            Book b1 = new Book("3010", "Book 1", new[] { "Mustafa", "Hegazy" }, DateTime.Now, 120);
            Book b2 = new Book("2710", "Book 2", new[] { "Ahmed", "Mohamed" }, DateTime.Now, 150);
            Book b3 = new Book("1497", "Book 3", new[] { "Mariam", "Ghada" }, DateTime.Now, 90);

            MyCustomBookDel bookDel = BookFunctions.GetTitle;

            Func<Book, string> builtInDel = BookFunctions.GetAuthors;

            AnonymousFunctionDel anonymousFunctionDel = delegate (Book B)
            {
                return $"Book ISBN: {B.ISBN}";
            };

            LambdaExpresionDel lambdaExpresionDel = B => $"Book Publish date: {B.PublicationDate.ToString("d")}";

            Book[] libraryList = { b1, b2, b3 };

            
            LibraryEngine.ProcessBooks(libraryList, book => bookDel(book));
            LibraryEngine.ProcessBooks(libraryList, book => builtInDel(book));
            LibraryEngine.ProcessBooks(libraryList, book => anonymousFunctionDel(book));
            LibraryEngine.ProcessBooks(libraryList, book => lambdaExpresionDel(book));
        }
    }
}
