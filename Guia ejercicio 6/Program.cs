using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Salario base: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Porcentaje de bonificación (%): ");
            int porcentajeBono = int.Parse(Console.ReadLine());

            double bono = salario * porcentajeBono/100;
            double salarioFinal = salario + bono;

            Console.WriteLine($"{nombre} tu bono es de ${bono}");
            Console.WriteLine($"Tu salario final es de ${salarioFinal}");


            Console.ReadKey();
        }
    }
}
