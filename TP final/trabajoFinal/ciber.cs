using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace trabajoFinal
{
    class Ciber
    {        
        string nombre;
        ArrayList maquinas;
        ArrayList clientes;
        double recaudacion;
        double sumaDescuentos;
        double precioHora;

        public Ciber(string nombre, double recaudacion, double sumaDescuentos, double precioHora)
        {
            this.nombre = nombre;
            this.recaudacion = recaudacion;
            this.sumaDescuentos = sumaDescuentos;
            this.precioHora = precioHora;
            maquinas = new ArrayList();
            clientes = new ArrayList();
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Recaudacion
        {
            get { return recaudacion; }
            set { recaudacion = value; }
        }
        public double SumaDescuentos
        {
            get { return sumaDescuentos; }
            set { sumaDescuentos = value; }
        }
        public double PrecioHora
        {
            get { return precioHora; }
            set { precioHora = value; }
        }
        public ArrayList Maquinas
        {
            get { return maquinas; }
        }
        public ArrayList Clientes
        {
            get { return clientes; }
        }

        public void ocuparMaq(int nroMaq, Usuario x)
        {
            foreach (Maquina i in maquinas)
            {
                if (i.NumeroMaquina == nroMaq)
                {
                    i.User = x;
                }
            }
        }
        public void agregaCliente(Usuario x)
        {
            clientes.Add(x);
        }
        public void eliminaCliente(Usuario x)
        {
            clientes.Remove(x);
        }
        public void liberarMaq(int nroMaq)
        {
            foreach (Maquina i in maquinas)
            {
                if (i.NumeroMaquina == nroMaq)
                {
                    i.User = null;
                }
            }
        }
        public int cantidadMaqLibres()
        {
            return maquinas.Count;
        }

        public void agregaMaquina(Maquina x)
        {
            maquinas.Add(x);
        }
        public Maquina verMaqI(Maquina i)
        {
            return i;
        }
    }
}

