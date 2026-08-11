using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Precio: ");
            double precio = double.Parse(Console.ReadLine());

            double descuento = 0.10;

            Console.Write("Cantidad de producto: ");
            int cantidad = int.Parse(Console.ReadLine());


            double subtotal = cantidad * precio;
            double valorDescuento = descuento * subtotal;
            double total = subtotal - valorDescuento;

            Console.Clear();

            Console.WriteLine($"Producto: {nombre}");
            Console.WriteLine($"Subtotal: {subtotal:F2}");
            Console.WriteLine($"Valor del descuento: {valorDescuento:F2}");
            Console.WriteLine($"Total: {total:F2}");






            Console.ReadKey();

        }
    }
}
