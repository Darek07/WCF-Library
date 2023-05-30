using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace wcf_client
{
    using Library;

    internal class Program
    {
        private static LibraryServiceClient proxy;

        static void Main(string[] args)
        {
            using (proxy = new LibraryServiceClient("LibrarySvcHttpEndpoint"))
            {
                do
                {
                    DisplayMenu();
                } while (DetectOptionOrExit());
            }
        }

        private static bool DetectOptionOrExit()
        {
            int option = Int32.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Book book;
                    try
                    {
                        book = proxy.GetBookDetails(AskForBookId());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        break;
                    }
                    DisplayBookDetails(book);
                    break;
                case 2:
                    Book[] books = proxy.GetBooks(AskForWordInTitle());
                    DisplayBooksIds(books);
                    break;
                case 0:
                    return false;
                default:
                    Console.WriteLine("Wrong option.");
                    break;
            }
            return true;
        }

        private static string AskForBookId()
        {
            Console.WriteLine();
            Console.Write("Enter book's id: ");
            return Console.ReadLine();
        }

        private static string AskForWordInTitle()
        {
            Console.WriteLine();
            Console.Write("Enter word in title: ");
            return Console.ReadLine();
        }

        private static void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Choose one of the following options: ");
            Console.WriteLine("1 - get book details by id");
            Console.WriteLine("2 - get book ids by word in title");
            Console.WriteLine("0 - exit");
            Console.WriteLine();
        }

        private static void DisplayBookDetails(Book book)
        {
            Console.WriteLine();
            Console.WriteLine("Title: {0}", book.Title);
            Console.WriteLine("Description: {0}", book.Description);
            Console.WriteLine("Authors:");
            foreach (Author author in book.Authors)
            {
                Console.WriteLine("\t{0}", author.Name);
            }
            Console.WriteLine();
        }

        private static void DisplayBooksIds(Book[] books)
        {
            Console.WriteLine();
            if (books == null || books.Length == 0)
            {
                Console.WriteLine("There are no books with the given word in library.");
                return;
            }

            Console.WriteLine("Books ids for given word:");
            foreach (Book book in books)
            {
                Console.WriteLine("\t{0}. {1}", book.Id, book.Title);
            }
            Console.WriteLine();
        }
    }
}
