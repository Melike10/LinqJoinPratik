using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoinPratik
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Book(int bId, string title, int authorId)
        {
            BookId = bId;
            Title = title;
            AuthorId = authorId;
        }
    }
}
