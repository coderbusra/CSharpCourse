using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id=1, 
                FirstName="Büşra", 
                LastName="Dertli", 
                City="Ankara"
            };

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer(2,"Ayşe", "Aslan", "Konya");

            Method(2, "Beyza", "Deniz", "İstanbul");

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine(); 
        }

        static void Method(int id, string firstName, string lastName, string city)
        {

        }
    }

    class Customer
    {
        // defualt constructor
        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }

}
