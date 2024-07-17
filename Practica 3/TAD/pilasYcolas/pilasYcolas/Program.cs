using System;
using System.Collections.Generic;
using System.Collections;

namespace pilasYcolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
        
    }
    
    //pila de autoPilot
    public class Pila {
        private List<int> lista;
        public Pila()
        {
            lista = new List<int>();
        }
        public void Push(int valor)
        {
            lista.Add(valor);
        }
        public int Pop()
        {
            int valor = lista[lista.Count - 1];
            lista.RemoveAt(lista.Count - 1);
            return valor;
        }
        public int Peek()
        {
            return lista[lista.Count - 1];
        }
        public bool Vacia()
        {
            return lista.Count == 0;
        }
    }
    //pila de la uni(incompleta la profe no mostro todo)
    public class Pila2
    {
        private ArrayList elementos;
        public Pila2()
        {
            elementos = new ArrayList();
        }
        public void Apilar(int valor)
        {
            elementos.Add(valor);
        }
        public int Desapilar()
        {
            int valor = (int)elementos[elementos.Count - 1];
            elementos.RemoveAt(elementos.Count - 1);
            return valor;
        }

    }
    //cola de autoPilot
    public class Cola
    {
        private List<int> lista;
        public Cola()
        {
            lista = new List<int>();
        }
        public void Encolar(int valor)
        {
            lista.Add(valor);
        }
        public int Desencolar()
        {
            int valor = lista[0];
            lista.RemoveAt(0);
            return valor;
        }
        public int Peek()
        {
            return lista[0];
        }
        public bool Vacia()
        {
            return lista.Count == 0;
        }
    }
}
