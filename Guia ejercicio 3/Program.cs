using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar nombre empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresar horas trabajadas: ");
            int horasTrabajadas = int.Parse(Console.ReadLine());

            Console.Write("Pago correspondiente por hora: ");
            double pagoXhora = double.Parse(Console.ReadLine());

            double salario = horasTrabajadas * pagoXhora;


            Console.Write($"Salario de {nombre}: {salario} ");





            Console.ReadKey();
        }
    }
}
