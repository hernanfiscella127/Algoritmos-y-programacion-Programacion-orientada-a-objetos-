using System;

namespace calculadora
{
    class calcu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al menu");
            Console.WriteLine("Opcion 0 para salir");
            Console.WriteLine("Opcion 1 para sumar");
            Console.WriteLine("Opcion 2 para restar");
            Console.WriteLine("Opcion 3 para multiplicar");
            Console.WriteLine("Opcion 4 para dividir");
            Console.WriteLine("Por favor elija una opcion");
            int opcion = int.Parse(Console.ReadLine());
            if(opcion == 0)
            {
                Console.WriteLine("Saliste del programa");
            }
            else if (opcion == 1)
            {
                Console.WriteLine("Introdusca el primer numero");
                int numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Introdusca el segundo numero");
                int numero2 = int.Parse(Console.ReadLine());

                Suma(numero1, numero2);

            }
            else if (opcion == 2)
            {
                Console.WriteLine("Introdusca el primer numero");
                int numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Introdusca el segundo numero");
                int numero2 = int.Parse(Console.ReadLine());

                Resta(numero1, numero2);

            }
            else if (opcion == 3)
            {
                Console.WriteLine("Introdusca el primer numero");
                int numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Introdusca el segundo numero");
                int numero2 = int.Parse(Console.ReadLine());

                Multiplicacion(numero1, numero2);

            }
            else if (opcion == 4)
            {
                Console.WriteLine("Introdusca el primer numero");
                int numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Introdusca el segundo numero");
                int numero2 = int.Parse(Console.ReadLine());

                Divicion(numero1, numero2);

            }
            else
            {
                Console.WriteLine("Tecla no permitida");
            }

        }
        static void Suma(int num1 , int num2)
        {
            Console.WriteLine("El resultado es: " +(num1 + num2));
        }
        static void Resta(int num1 , int num2)
        {
            Console.WriteLine("El resultado es: "+ (num1 - num2));
        }
        static void Multiplicacion(int num1 , int num2)
        {
            Console.WriteLine("El resultado es: " + (num1 * num2));
        }
        static void Divicion(int num1 , int num2)
        {
            Console.WriteLine("El resultado es: "+ (num1 / num2));
        }
    }
}
