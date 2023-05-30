using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading.Tasks;

namespace Library
{

    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(LibraryService)))
            {
                host.Open();
                Console.WriteLine("Serwis książek został uruchomiony. Naciśnij Enter, aby zakończyć.");
                Console.ReadLine();
            }
        }
    }
}