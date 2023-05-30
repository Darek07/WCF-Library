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
        private string _name;

        [DataMember]
        public string Name
        {
            get => _name; 
            set => _name = value;
        }
    }

    [DataContract]
    public class Book
    {
        [DataMember]
        private string _id;
        [DataMember]
        private string _title;
        [DataMember]
        private string _description;
        [DataMember]
        private List<Author> _authors;

        [DataMember]
        public string Id
        {
            get => _id; 
            set => _id = value;
        }

        [DataMember]
        public string Title
        {
            get => _title;
            set => _title = value;
        }

        [DataMember]
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        [DataMember]
        public List<Author> Authors
        {
            get => _authors;
            set => _authors = value;
        }
    }

    [DataContract]
    public class NoSuchBookException
    {
        public NoSuchBookException() { }
    }
}
