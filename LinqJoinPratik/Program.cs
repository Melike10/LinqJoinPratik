using LinqJoinPratik;
namespace LinqJoinPratik
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Book> books = new List<Book> {
                new Book(1, "Refet", 3),
                new Book(2,"Büyük Umutlar",1),
                new Book(3,"1984",2)

                };

            List<Author> authors = new List<Author> {
              new Author(1,"Charles Dickens"),
              new Author(2,"George Orwell"),
              new Author(3,"Fatma Aliye"),
              new Author(4,"Halide Edip Adıvar")

            };

            var bookAuthor = from book in books
                             join author in authors
                             on book.AuthorId equals author.AuthorId
                             select new
                             {
                                Title= book.Title,
                                AuthorName = author.Name
                             };

            foreach (var group in bookAuthor) {
                Console.WriteLine(group.AuthorName + "-"+group.Title);
            }

        }
    }
}