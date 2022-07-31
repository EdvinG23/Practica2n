using System;

namespace Practica6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Introduzca un numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma de los numeros es: " + (num1 + num2));
            

            Console.WriteLine("Hello World!");
        }
    }
}
