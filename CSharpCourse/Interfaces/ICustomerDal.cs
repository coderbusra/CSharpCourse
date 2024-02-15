using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }
    
    class SqlServerCustomerDal : ICustomerDal 
    {
        public void Add()
        {
            Console.WriteLine("Sql add");
        }

        public void Delete()
        {
            Console.WriteLine("Sql delete");
        }
        
        public void Update()
        {
            Console.WriteLine("Sql update"); 
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle add");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle delete");
        }

        public void Update()
        {
            Console.WriteLine("Oracle update");
        }
    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql add");
        }

        public void Delete()
        {
            Console.WriteLine("MySql delete");
        }

        public void Update()
        {
            Console.WriteLine("MySql update");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
