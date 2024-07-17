
using System;

namespace NombreEdadDni
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] listaHora = new int[] { 24, 30, 15 };
            //Hora h = new Hora(23, 30, 15);
            //Console.WriteLine(h.getHora());

            //Hora f = new Hora(listaHora);
            //Console.WriteLine(f.getHora());
            //Persona Humano1 = new Persona("Hernan", 22, 41222841);
            //Console.WriteLine(Humano1.getPersona());
            //al usar el set no usar Console.writeline;
            //Humano1.setPersona("Hen",25,2144431);
            //Console.WriteLine(Humano1.getPersona());



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
        public Hora(int[] hour)
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
    class Persona
    {
        string Nombre;
        int Edad;
        int Dni;

        public Persona(string Nombre, int Edad , int Dni)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Dni = Dni;
        }

        public void setPersona(string Nombre,int Edad , int Dni)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Dni = Dni;
        }
        public string getPersona()
        {
            return "El nombre es " + Nombre + " .La edad es: " + Edad + " .El numero de dni es: " + Dni ;
        }
        
        
    }

}