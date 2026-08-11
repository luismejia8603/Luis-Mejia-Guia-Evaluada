using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingresar número 1: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("Ingresar número 2: ");
            double numero2 = double.Parse(Console.ReadLine());

            double suma = numero1 + numero2;
            double resta = numero1 - numero2;
            double multiplicacion = numero1 * numero2;
            double division = numero1 / numero2;
            double residuoDivision = numero1 % numero2;

            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta}");
            Console.WriteLine($"Multiplicación: {multiplicacion}");
            Console.WriteLine($"División: {division}");
            Console.WriteLine($"Residuo división: {residuoDivision}");

            Console.ReadKey();
        }
    }
}
