using System;
using System.Collections.Generic;
using System.Text;

namespace trabajoFinal
{
    class Maquina
    {
        int numeroMaquina;
        Usuario user;
        double sumaImportes;

        public Maquina(int numeroMaquina, Usuario user, double sumaImportes)
        {
            this.numeroMaquina = numeroMaquina;
            this.user = user;
            this.sumaImportes = sumaImportes;
        }
        public int NumeroMaquina
        {
            get { return numeroMaquina; }
            set { numeroMaquina = value; }
        }
        public Usuario User
        {
            get { return user; }
            set { user = value; }
        }
        public double SumaImportes
        {
            get { return sumaImportes; }
            set { sumaImportes = value; }
        }
    }
}

