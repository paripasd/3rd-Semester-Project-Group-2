using System;
using System.Security.Principal;
using TestAPIConsumerFirst;

namespace TestAPIConsumerFirst
{
    public class Program
    {

        public static void Main()
        {
            DeveloperAPIConsumer consumer = new DeveloperAPIConsumer("http://localhost:6063/api/v1/developers");

            
            Developer developer2 = new Developer("Akos","akos@gmail.com","this is my description");
            Console.WriteLine(consumer.GetAllDevelopers()); 
            
                    
        }
    }
}
