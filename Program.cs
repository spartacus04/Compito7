using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compito7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserire un mese: ");
            int mese = int.Parse(Console.ReadLine());
            Console.Write("Inserire un giorno: ");
            int giorno = int.Parse(Console.ReadLine());

            int num = (mese - 1) * 30 + giorno;
            int resto = num % 7;

            if(resto == 1)
            {
                Console.WriteLine("Il giorno è lunedì");
            }
            else if(resto == 2)
            {
                Console.WriteLine("Il giorno è martedì");
            }
            else if(resto == 3)
            {
                Console.WriteLine("Il giorno è mercoledì");
            }
            else if (resto == 4)
            {
                Console.WriteLine("Il giorno è giovedì");
            }
            else if (resto == 5)
            {
                Console.WriteLine("Il giorno è venerdì");
            }
            else if (resto == 6)
            {
                Console.WriteLine("Il giorno è sabato");
            }
            else if (resto == 7)
            {
                Console.WriteLine("Il giorno è domenica");
            }

            Console.ReadKey();
        }
    }
}
