using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [ServiceContract]
    public interface ILibraryService
    {
        [OperationContract]
        Task<List<Book>> GetBooks(string query);

        [OperationContract]
        [FaultContract(typeof(NoSuchBookException))]
        Task<Book> GetBookDetails(string id);
    }

    [DataContract]
    public class Author
    {
        [DataMember]
        public string _name;
    }

    [DataContract]
    public class Book
    {
        [DataMember]
        public string _id;
        [DataMember]
        public string _title;
        [DataMember]
        public string _description;
        [DataMember]
        public List<Author> _authors;
    }

    [DataContract]
    public class NoSuchBookException
    {
        public NoSuchBookException() { }
    }
}
