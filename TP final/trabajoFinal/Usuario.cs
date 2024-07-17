using System;
using System.Collections.Generic;
using System.Text;

namespace trabajoFinal
{
    class Usuario
    {
        string nombre;
        string aprellido;
        DateTime horaInicio;
        DateTime horaFinal;
        double importeABonar;

        public Usuario(string nombre, string apellido, DateTime horaInicio, DateTime horaFinal, double importeABonar)
        {
            this.nombre = nombre;
            this.aprellido = apellido;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;
            this.importeABonar = importeABonar;
        }
        public Usuario(string nombre, string aprellido)
        {
            this.nombre = nombre;
            this.aprellido = aprellido;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return aprellido; }
            set { Apellido = value; }
        }
        public DateTime HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }
        public DateTime HoraFinal
        {
            get { return horaFinal; }
            set { horaFinal = value; }
        }
        public double ImporteAbonar
        {
            get { return importeABonar; }
            set { importeABonar = value; }
        }
    }
}

