using System;

namespace Practica3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables
            string firstname = "Edvin";
            String lastname = "Guevara";
            int edad = 18;
            // Concatenacion de variables
            var name = firstname + " " + lastname;
            // Imprimir variables dentro del texto
            Console.WriteLine("Su nombre es: {1} y su edad es: {0}", edad, name);
        }
    }
}
