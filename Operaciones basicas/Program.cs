using System;

namespace Operaciones_basicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, op, Rps=1;

            do
            {
                Console.WriteLine("Operaciones basicas");
                Console.WriteLine("-------------------");
                Console.WriteLine("1 - Suma");
                Console.WriteLine("2 - Resta");
                Console.WriteLine("3 - Division");
                Console.WriteLine("4 - Multiplicacion");
                Console.WriteLine("------------------");

                Console.WriteLine("¿Que operacion quieres realizar");
                op = Convert.ToInt32(Console.ReadLine());



                switch (op)
                {
                    case 1:
                        Console.WriteLine("1 - Suma");
                        Console.WriteLine("Introduzca el primer numero: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca el segundo numero: ");
                        num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("La suma de los numeros es: " + (num1 + num2));

                        break;
                    case 2:
                        Console.WriteLine("2 - Resta");
                        Console.WriteLine("Introduzca el primer numero: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca el segundo numero: ");
                        num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("La resta de los numeros es: " + (num1 - num2));

                        break;
                    case 3:
                        Console.WriteLine("3 - Division");
                        Console.WriteLine("Introduzca el primer numero: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca el segundo numero: ");
                        num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("La division de los numeros es: " + (num1 / num2));

                        break;
                    case 4:
                        Console.WriteLine("4 - Multiplicacion");
                        Console.WriteLine("Introduzca el primer numero: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca el segundo numero: ");
                        num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("La multiplicacion de los numeros es: " + (num1 * num2));

                        break;

                    default:
                        Console.WriteLine("Intentelo de nuevo");
                        Console.ReadLine();
                        break;
                }

                Console.WriteLine("Precione 1 para finalizar y un numero cualquiera para continuar");
                Rps = Convert.ToInt32(Console.ReadLine());


            } while (Rps !=1);
            Console.WriteLine("A finalizado");

        }
    }
}
