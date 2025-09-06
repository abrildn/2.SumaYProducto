using System;

namespace SumaYProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            string linea = Console.ReadLine();
            int num1 = int.Parse(linea);
            Console.WriteLine("Ingrese un número");
            linea = Console.ReadLine();
            int num2 = int.Parse(linea);
            Console.WriteLine("Ingrese un número");
            linea = Console.ReadLine();
            int num3 = int.Parse(linea);
            Console.WriteLine("Ingrese un número");
            linea = Console.ReadLine();
            int num4 = int.Parse(linea);

            int suma = num1 + num2;
            int producto = num3 * num4;

            Console.WriteLine("La suma de los 2 primeros números es: ");
            Console.WriteLine(suma);
            Console.WriteLine("EL producto de los 2 últimos números es: ");
            Console.WriteLine(producto);
        }
    }
}
