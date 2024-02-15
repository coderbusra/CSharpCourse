using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Value Types
            //Console.WriteLine("Hello World");

            double number5 = 10.4;
            decimal number6 = 10;
            char character = 'a';
            string city = "Ankara";
            bool condition = false;
            byte number4 = 255;
            short number3 = -32152;
            int number1 = 214848364;
            long number2 = 982145244554115364;
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine("Number1 is {0} ", number1);
            Console.WriteLine("Number2 is {0} ", number2);
            Console.WriteLine("Character is : ",(int)character);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday=10,Tuesday=20,Wednesday=30,Thursday,Friday,Saturday,Sunday
    }
}
