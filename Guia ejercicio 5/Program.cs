using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cantidad de dinero en dolares (USD): ");
            double dolares = double.Parse(Console.ReadLine());

            Console.Write("Valor del cambio de moneda entre USD y Euro (0.86): ");
            double  valorConversion = double.Parse(Console.ReadLine());

            double euros = dolares * valorConversion;

            Console.Write($"${dolares} dolares son: {euros} Euros");

            Console.ReadKey();

        }
    }
}
