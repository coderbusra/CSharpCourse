using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }

            //Metod
            HandleException(() =>
            {
                Find();
            });
            

            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<String> students = new List<String> { "Engin", "Derin", "Salih" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException ("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Engin", "Derin", "Salih" };
                students[3] = "Ahmet";
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
