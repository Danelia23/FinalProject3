namespace FinalProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager manager = new BookManager();

            while (true)
            {
                Console.WriteLine("1. Add new book");
                Console.WriteLine("2. Display all books");
                Console.WriteLine("3. Search for a book by name");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice:");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter book name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter author:");
                        string author = Console.ReadLine();
                        Console.WriteLine("Enter release year:");
                        if (!int.TryParse(Console.ReadLine(), out int releaseYear))
                        {
                            Console.WriteLine("Invalid release year! Please enter a number.");
                            continue;
                        }
                        manager.AddBook(new Book(name, author, releaseYear));
                        break;
                    case 2:
                        manager.DisplayBooks();
                        break;
                    case 3:
                        Console.WriteLine("Enter the name of the book you want to search:");
                        string searchName = Console.ReadLine();
                        Book foundBook = manager.SearchBookByName(searchName);
                        if (foundBook != null)
                        {
                            Console.WriteLine("Book found:");
                            Console.WriteLine(foundBook);
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
                        break;
                }
            }
        }
    }
}