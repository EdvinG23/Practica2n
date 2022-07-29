using System;

namespace Practica5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca su nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Introduzca su edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Su nombre es: {0} y tiene {1} años de edad", name, edad);
        }
    }
}
