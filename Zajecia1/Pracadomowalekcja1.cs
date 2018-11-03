using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Poproszenie użytkownika o cyfrę nr 1
            Console.WriteLine("Podaj cyfrę nr 1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            //Poproszenie użytkownika o cyfrę nr 2
            Console.WriteLine("Podaj cyfrę nr 2");
            int number2 = Convert.ToInt32(Console.ReadLine());

            //Operacja mnożenia
            if ((number1 + number2) >= 15)
            {
                Console.WriteLine(number1 * number2);
            }
            else Console.WriteLine("Suma mniejsza od 15");
            Console.ReadLine();
        }
    }
}
