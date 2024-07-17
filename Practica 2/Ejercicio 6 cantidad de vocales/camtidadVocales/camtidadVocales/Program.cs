using System;

namespace camtidadVocales
{
    class Program
    {
        static void Main(string[] args)
        {

            int nu = NumVocales("Pepae");
            Console.WriteLine(nu);
        }
        static int[] NumVocales(string sentence)
        {
            int total = 0;
            int[] arry = new int[] { total };
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u')
                {
                    total++;
                }
            }
            return arry;
            //return total;
            //Console.WriteLine("El total es: " + total);
        }
    }
}
