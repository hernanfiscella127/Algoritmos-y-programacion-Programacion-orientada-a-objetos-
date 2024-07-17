using System;

namespace palabras
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void CrearLista()
        {

            Console.WriteLine("Ingrese la cantidad de palabras");

            int respuesta = int.Parse(Console.ReadLine());
            int[] recopilador = new int[respuesta];

            for (int i=0; i < respuesta; i++)
            {
                Console.WriteLine("El lugar que va a llenar corresponde al lugar" + i);
                Console.WriteLine("Escriba la palabra que desea agregar al sistema ");

                string eleccion = Console.ReadLine();
                int traductor = int.Parse(eleccion);
                recopilador[i] = traductor;
                
            }

        }
        static int promedio(int [] lista)
        {
            int ContadorSumador = 0;

            foreach (int i in lista)
            {

                ContadorSumador += i;

            }

            int resultadoFinal = ContadorSumador / lista.Length;

            return resultadoFinal;

            
        }
        static void LetraS(string [] lista)
        {
            int ContadorDeS = 0;

            for (int i = 0; i < lista.Length; i++)
            {
                if(lista[0] == "s")
                {
                    ContadorDeS += 1;
                }

            }

        }

    }
}
