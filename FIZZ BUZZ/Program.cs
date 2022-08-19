using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIZZ_BUZZ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // DEL 1 AL 100: 
            // SI EL NUMERO ES MULTIPLO DE 3, SE CAMBIA POR LA PALABRA POR "FIZZ"
            // SI ES MULTIPLO DE 5, POR LA PALABRA "BUZZ"
            // SI ES MULTIPLO DE AMBOS, SE CAMBIA POR LA PALBRA "FIZZ BUZZ"

            // DECLARAMOS VARIABLES
            int num = 100;
            string fizz = "Fizz";
            string buzz = "Buzz";
            string fizzBuzz = "Fizz Buzz";

            // UTILIZANDO LA HERRAMIENTA "FOR" ASIGNAMOS CADA VARIABLE
            // ANTERIORMENTE DECLARADA SEGUN CORRESPONDA
            for (int i = 0; i <= 100 ; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(fizzBuzz);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(fizz);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(buzz);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();


        }
    }
}
