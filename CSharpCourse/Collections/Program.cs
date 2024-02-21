using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();

            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>(); //Key - Value Anahtar kelime vasıtası ile onun değerine ulaşmayı hedeflediğimiz yapılardır.
            dictionary.Add("table", "tablo");
            dictionary.Add("book", "kitap");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));

            Console.ReadLine();
        }

        private static void List()
        {
            List<String> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            Console.WriteLine(cities.Contains("Ankara")); //Doğru ise true döner

            //cities.Clear();//Listeyi temizleme

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer>customers = new List<Customer> 
            //{
            //    new Customer {Id=1, FirstName="Ali"},
            //    new Customer {Id=2,FirstName ="Veli"}
            //};

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Büşra" });
            customers.Add(new Customer { Id = 2, FirstName = "Ayşe" });

            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Hale"
            };

            customers.Add(customer2); //Listenin sonuna Eleman ekleme
            customers.AddRange(new Customer[2] //Array bazlı bir liste ver ben onları customers ekleyeyim
            {
                new Customer { Id = 4 , FirstName = "Hasan"},
                new Customer { Id = 5, FirstName="Hüseyin"}
            });

            var index = customers.IndexOf(customer2); //Listedeki elemanın listede kaçıncı sırada olduğunu verir.

            Console.WriteLine("Index : {0} ", index);

            customers.Add(customer2);

            var index2 = customers.LastIndexOf(customer2); // Aramaya sondan başlar
            Console.WriteLine("Index : {0} ", index2);


            Console.WriteLine(customers.Contains(customer2));

            //customers.Clear();

            customers.Contains(customer2); //Listede aradığımız değer var mı

            customers.Insert(0, customer2); //Kaçıncı sıraya neyi eklemek istiyorsun

            customers.Remove(customer2); //Silme yaparken bulduğu ilk değeri siler diğer kısımlarda da aynsındna varsa onlara dokunmaz

            customers.RemoveAll(c => c.FirstName == "Hale"); //Bütün Hale isimli kişileri sil demek

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count; //Eleman Sayısı
            Console.WriteLine("Count : {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");

            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
