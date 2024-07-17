
using System;

namespace segundoconst
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaHora = new int[] { 24, 30, 15 };
            //Hora h = new Hora(23, 30, 15);
            //Console.WriteLine(h.getHora());

            Hora f = new Hora(listaHora);
            Console.WriteLine(f.getHora());

            Console.ReadKey(true);

        }
    }

    class Hora
    {
        int hour;
        int min;
        int sec;

        public Hora(int hour, int min, int sec)
        {
            this.hour = hour;

            this.min = min;

            this.sec = sec;


        }
        public Hora(int [] hour)
        {
            this.hour = hour[0];

            min = hour[1];

            sec = hour[2];


        }
        public string getHora()
        {

            return hour + " HORAS, " + min + " MINUTOS, " + sec + " SEGUNDOS";

        }



    }

}