﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/LibraryService")]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private Library.Author[] _authorsField;
        
        private string _descriptionField;
        
        private string _idField;
        
        private string _titleField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Library.Author[] _authors
        {
            get
            {
                return this._authorsField;
            }
            set
            {
                this._authorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _description
        {
            get
            {
                return this._descriptionField;
            }
            set
            {
                this._descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _id
        {
            get
            {
                return this._idField;
            }
            set
            {
                this._idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _title
        {
            get
            {
                return this._titleField;
            }
            set
            {
                this._titleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Author", Namespace="http://schemas.datacontract.org/2004/07/LibraryService")]
    public partial class Author : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string _nameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _name
        {
            get
            {
                return this._nameField;
            }
            set
            {
                this._nameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NoSuchBookException", Namespace="http://schemas.datacontract.org/2004/07/LibraryService")]
    public partial class NoSuchBookException : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ILibraryService")]
public interface ILibraryService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBooks", ReplyAction="http://tempuri.org/ILibraryService/GetBooksResponse")]
    Library.Book[] GetBooks(string query);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBooks", ReplyAction="http://tempuri.org/ILibraryService/GetBooksResponse")]
    System.Threading.Tasks.Task<Library.Book[]> GetBooksAsync(string query);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBookDetails", ReplyAction="http://tempuri.org/ILibraryService/GetBookDetailsResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(Library.NoSuchBookException), Action="http://tempuri.org/ILibraryService/GetBookDetailsNoSuchBookExceptionFault", Name="NoSuchBookException", Namespace="http://schemas.datacontract.org/2004/07/LibraryService")]
    Library.Book GetBookDetails(string id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBookDetails", ReplyAction="http://tempuri.org/ILibraryService/GetBookDetailsResponse")]
    System.Threading.Tasks.Task<Library.Book> GetBookDetailsAsync(string id);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ILibraryServiceChannel : ILibraryService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class LibraryServiceClient : System.ServiceModel.ClientBase<ILibraryService>, ILibraryService
{
    
    public LibraryServiceClient()
    {
    }
    
    public LibraryServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public LibraryServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public LibraryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public LibraryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public Library.Book[] GetBooks(string query)
    {
        return base.Channel.GetBooks(query);
    }
    
    public System.Threading.Tasks.Task<Library.Book[]> GetBooksAsync(string query)
    {
        return base.Channel.GetBooksAsync(query);
    }
    
    public Library.Book GetBookDetails(string id)
    {
        return base.Channel.GetBookDetails(id);
    }
    
    public System.Threading.Tasks.Task<Library.Book> GetBookDetailsAsync(string id)
    {
        return base.Channel.GetBookDetailsAsync(id);
    }
}