namespace FinalProject3
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int ReleaseYear { get; set; }

        public Book(string name, string author, int releaseYear)
        {
            Name = name;
            Author = author;
            ReleaseYear = releaseYear;
        }

        public override string ToString()
        {
            return $"Book Name: {Name}\nAuthor: {Author}\nRelease Year: {ReleaseYear}";
        }
    }

}
