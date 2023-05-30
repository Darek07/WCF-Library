using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryService : ILibraryService
    {

        private List<Book> books;

        public LibraryService()
        {
            // Initialize a list of books
            books = new List<Book>
            {
                new Book { _id = "1", _title = "Book 1", _authors = new List<Author> { new Author { _name = "Author 1" } } },
                new Book { _id = "2", _title = "Book 2", _authors = new List<Author> { new Author { _name = "Author 2" } } },
                new Book { _id = "3", _title = "Book 3", _authors = new List<Author> { new Author { _name = "Author 3" } } }
            };
        }

        public Task<Book> GetBookDetails(string id)
        {
            // Find the book with the specified id
            var book = books.Find(b => b._id == id);

            if (book == null)
            {
                throw new FaultException<NoSuchBookException>(new NoSuchBookException());
            }

            return Task.FromResult(book);
        }

        public Task<List<Book>> GetBooks(string query)
        {
            // Perform a search based on the query
            var result = new List<Book>();

            foreach (var book in books)
            {
                if (book._title.Contains(query))
                {
                    result.Add(book);
                }
            }

            return Task.FromResult(result);
        }
    }
}
