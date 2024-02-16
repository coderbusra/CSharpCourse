using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceType
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////Value Types: int, decimal, float, double, enum, boolean - stackde tutulur.
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;
            //sayi2 = 100;

            //Console.WriteLine("Sayi1 : " + sayi1);

            //// Reference Types : arrays, class, interface - heapde tutulur.
            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayilar1[0] = " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCarNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "Veli";


            Person person3 = customer;
            customer.FirstName = "Ahmet";

            //Console.WriteLine(((Customer)person3).CreditCarNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);

            Console.ReadLine();

        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
        
        //base class : Person
        class Customer : Person
        {
            public string CreditCarNumber { get; set; }
        }

        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
