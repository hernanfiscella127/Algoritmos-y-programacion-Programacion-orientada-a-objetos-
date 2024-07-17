
using System;
using System.Linq;
using System.Collections;



namespace avanza
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numeros = new ArrayList();
            double acomuladorTotal = 0;
            double acumuladorCantidadDeDigitos = 0;






            string salir = "no";

            while (salir != "si")
            {
                Console.WriteLine("Ingrese un numero");
                int numeroGenerico = int.Parse(Console.ReadLine());
                numeros.Add(numeroGenerico);
                acomuladorTotal += numeroGenerico;
                acumuladorCantidadDeDigitos++;
                Console.WriteLine("Desea salir ? ");
                salir = Console.ReadLine();

            }

            
            double promedio = acomuladorTotal / acumuladorCantidadDeDigitos;


            Console.WriteLine("El promedio es: " + promedio);
            
            

            
            
            


        }
        static int resta(int num1,int num2)
        {
            return num1 - num2;

        }
        

    }
        
    class calculadora
    {
        
        public void suma(int num1,int num2)
        {
            Console.WriteLine(num1+num2);
        }





    }
}
