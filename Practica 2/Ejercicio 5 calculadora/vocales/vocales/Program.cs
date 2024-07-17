
using System;

namespace vocales
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "aguero";
            NumVocal(word);
        }
        static void NumVocal(string Palabra)
        {
            //string[] conservador = new string [1];




            for (int i = 0; i == Palabra.Length; i++)
            {
                int ContadorVocales = 0;


                if (Palabra[i] == 'a' || Palabra[i] == 'e' || Palabra[i] == 'i' || Palabra[i] == 'o' || Palabra[i] == 'u' || Palabra[i] == 'A' || Palabra[i] == 'E' || Palabra[i] == 'I' || Palabra[i] == 'O' || Palabra[i] == 'U')
                {

                    ContadorVocales += 1;

                }

                int[] vocales = new int[1];
                vocales[0] = ContadorVocales;

                Console.WriteLine("La cantidad de vocales es: " + ContadorVocales);

            }





        }
    }
}
