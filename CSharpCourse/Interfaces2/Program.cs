using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // interface new'lenemez!

            IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            
            IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.UpDate();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InterManager());

            Console.ReadLine();
        }
    }

    interface IPersonManager
    {
        // unimplemented operation
        void Add();
        void UpDate();
    }

    //inherits-class -------- implements - interface
    class CustomerManager:IPersonManager
    {
        public void Add()
        {
            // müşteri ekleme kodlar yazılır
            Console.WriteLine("Müşteri eklendi");
        }

        public void UpDate()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodlar yazılır
            Console.WriteLine("Personel eklendi");
        }

        public void UpDate()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }

    class InterManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void UpDate()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
