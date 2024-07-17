
using System;

namespace horaUno
{
    class Program
    {
        static void Main(string[] args)
        {
            Hora h = new Hora(23, 30, 15);
            Console.WriteLine(h.getHora());
            
            Console.ReadKey(true);

        }
    }

    class Hora
    {
        int hour;
        int min;
        int sec;

        public Hora(int hour , int min , int sec)
        {
            this.hour = hour;

            this.min = min;

            this.sec = sec;


        }
        public  string getHora()
        {

            return hour + " HORAS, " + min + " MINUTOS, " + sec + " SEGUNDOS";

        }

        

    }

}
