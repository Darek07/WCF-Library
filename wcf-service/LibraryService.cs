using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                new Book { Id = "1", Title = "Book 1", Authors = new List<Author> { new Author { Name = "Author 1" } } },
                new Book { Id = "2", Title = "Book 2", Authors = new List<Author> { new Author { Name = "Author 2" } } },
                new Book { Id = "3", Title = "Book 3", Authors = new List<Author> { new Author { Name = "Author 3" } } }
            };
        }

        public Task<Book> GetBookDetails(string id)
        {
            // Find the book with the specified id
            var book = books.Find(b => b.Id == id);

            return book == null
                ? throw new FaultException<NoSuchBookException>(new NoSuchBookException(), "There is no book with the given id in library.")
                : Task.FromResult(book);
        }

        public Task<List<Book>> GetBooks(string query)
        {
            // Perform a search based on the query
            var result = new List<Book>();

            foreach (var book in books)
            {
                if (book.Title.Contains(query))
                {
                    result.Add(book);
                }
            }

            return Task.FromResult(result);
        }
    }
}
