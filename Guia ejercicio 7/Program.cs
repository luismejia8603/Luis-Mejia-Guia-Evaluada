using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar nombre del cliente: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresar producto 1: ");
            string producto1 = Console.ReadLine();

            Console.Write("Ingresar precio: $");
            double precio1 = double.Parse(Console.ReadLine());

            Console.Write("Ingresar producto 2: ");
            string producto2 = Console.ReadLine();

            Console.Write("Ingresar precio: $");
            double precio2 = double.Parse(Console.ReadLine());

            Console.Write("Ingresar producto 3: ");
            string producto3 = Console.ReadLine();

            Console.Write("Ingresar precio:$");
            double precio3 = double.Parse(Console.ReadLine());


            double subTotal = precio1 + precio2 + precio3;

            double iva = subTotal * 0.13;

            double total = subTotal + iva;

            Console.WriteLine($"{nombre} gracias por comprar");
            Console.WriteLine($"Subtotal: ${subTotal:F2}");
            Console.WriteLine($"IVA: ${iva:F2}");
            Console.WriteLine($"Total a pagar: ${total:F2}");





        }
    }
}
