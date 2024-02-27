namespace FinalProject3
{
    public class BookManager
    {
        private List<Book> bookList;

        public BookManager()
        {
            bookList = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (IsBookAlreadyAdded(book))
            {
                Console.WriteLine("Book is already in the list.");
                return;
            }

            bookList.Add(book);
            Console.WriteLine("Book added successfully!");
        }

        public void DisplayBooks()
        {
            if (bookList.Count == 0)
            {
                Console.WriteLine("No books in the list.");
                return;
            }

            Console.WriteLine("List of Books:");
            foreach (var book in bookList)
            {
                Console.WriteLine(book);
                Console.WriteLine("----------------------");
            }
        }

        public Book SearchBookByName(string name)
        {
            foreach (var book in bookList)
            {
                if (book.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return book;
            }
            return null;
        }

        private bool IsBookAlreadyAdded(Book book)
        {
            foreach (var existingBook in bookList)
            {
                if (existingBook.Name.Equals(book.Name, StringComparison.OrdinalIgnoreCase) &&
                    existingBook.Author.Equals(book.Author, StringComparison.OrdinalIgnoreCase) &&
                    existingBook.ReleaseYear == book.ReleaseYear)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
