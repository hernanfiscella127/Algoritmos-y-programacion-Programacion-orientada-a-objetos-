
using System;
using System.Collections;

namespace NombreEdadDni
 {
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList PeopleJuntado = new ArrayList();
            ArrayList PeopleAge = new ArrayList();
            ArrayList PeopleDni = new ArrayList();


            string name = "a";
            string age = "b";
            string dni = "c";

            while (name != "" || age!="" || dni != "")
            {
                Console.WriteLine("Ingrese su nombre");
                name = Console.ReadLine();
                Console.WriteLine("Ingrese cuantos años tiene");
                age = Console.ReadLine();
                Console.WriteLine("Ingrese su numero de dni");
                dni = Console.ReadLine();
                Persona datos = new Persona(name, age, dni);
                PeopleJuntado.Add(datos);

            
            }

            foreach(object elementos in PeopleJuntado)
            {
                Console.WriteLine(elementos);
            }

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
        private ArrayList PeopleName;
        private ArrayList PeopleAge;
        private ArrayList PeopleDni;


        string Nombre;
        string Edad;
        string Dni;

        public Persona(string Nombre, string Edad, string Dni)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Dni = Dni;
            //PeopleName.Add(Nombre);
            //PeopleAge.Add(Edad);
            //PeopleDni.Add(Dni);

        }

        public void setPersona(string Nombre, string Edad, string Dni)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Dni = Dni;
        }
        public string getPersona()
        {
            return "El nombre es " + Nombre + " .La edad es: " + Edad + " .El numero de dni es: " + Dni;
        }


    }
}