using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Precio unitario: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Cantidad de unidades adquiridas: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.Write("Descuento a aplicar: ");
            int descuento = int.Parse(Console.ReadLine());

            double subTotal = precio * cantidad;
            double valorDescuento = subTotal * descuento / 100;
            double total = subTotal - valorDescuento;

            Console.WriteLine($"Producto: {nombre}");
            Console.WriteLine($"Subtotal: {subTotal}");
            Console.WriteLine($"Valor del descuento: {valorDescuento}");
            Console.WriteLine($"Total a pagar: {total}");



            Console.ReadKey();
        }
    }
}
