using System;

namespace lenght
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introdusca el valor uno");
            int primerValor=int.Parse(Console.ReadLine());
            Console.WriteLine("Introdusca el valor dos");
            int segundoValor = int.Parse(Console.ReadLine());

            if (primerValor > segundoValor)
            {
                Console.WriteLine("El primer valor"+ primerValor+ "Es el mayor");

            }
            else
            {
                Console.WriteLine("el segundo valor ", segundoValor, " es el mayor");

            }
            int promedi = primerValor/segundoValor;

            Console.WriteLine("El promedio es: "+ promedi);






        }
    }
}
