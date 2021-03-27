using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_12
{
    class Program
    {
        //Solicite el ingreso de dos frases y determine si son iguales.
        static void Main(string[] args)
        {
            string Frase_1;
            string Frase_2;

            Console.Write("Por favor, ingrese la primera frase: ");
            Frase_1 = Console.ReadLine();
            Console.Write("Por favor, ingrese la segunda frase: ");
            Frase_2 = Console.ReadLine();
            Console.WriteLine("\r");

            if (Frase_1 == Frase_2)
            {
                Console.WriteLine("Las frases que ingreso son iguales.");
            }
            else
            {
                Console.WriteLine("Las frases que ingreso son diferentes.");
            }
            Console.ReadKey();
        }      
    
    }
}
