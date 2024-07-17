using System;
using System.Collections;

namespace alumnos
{
    class Program
    {
        static void Main(string[] args)
        {

            Alumnos pepito = new Alumnos();
            pepito.AgregarDia("Lunes");
            //pepito.AgregarHora("13");
            //pepito.AgregaMateria("Matematica");

            Console.WriteLine(pepito.getDia);
        }
    }
    class Alumnos
    {
        private ArrayList Dias = new ArrayList();
        private ArrayList Horas;
        private ArrayList Materias;



        //public Alumnos()
        //{
           // Dias = new ArrayList();
            //Horas = new ArrayList();
            //Materias = new ArrayList();
        //}

        public void AgregarDia(string dia)
        {
            Dias.Add(dia);
        }
        public void AgregarHora(string hora)
        {
            Horas.Add(hora);
        }
        public void AgregaMateria(string materia)
        {
            Materias.Add(materia);
        }

        public ArrayList getDia
        {
            get { return Dias; }
        }
        public ArrayList gethora
        {
            get { return Horas; }
        }
        public ArrayList getMateria
        {
            get { return Materias; }
        }



    }
}
