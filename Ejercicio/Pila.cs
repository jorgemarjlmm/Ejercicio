using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio
{
    public class Nodo
    {
        private int dato;
        private Nodo siguiente = null;
        private int valorMaximoPila;

        public int Dato { get => dato; set => dato = value; }
        public Nodo Siguiente { get => siguiente; set => siguiente = value; }
        public int ValorMaximoPila { get => valorMaximoPila; set => valorMaximoPila = value; }

    }

    public class Pila
    {
        private Nodo ancla;
        private Nodo auxAncla;

        public Pila()
        {
            ancla = new Nodo();
            ancla.Siguiente = null;
        }

        public void Push(int pDato)
        {
            int valorMaximo;
            Nodo ultimoNodo = new Nodo();

            Nodo tmp = new Nodo();
            tmp.Dato = pDato;

            ultimoNodo = Peek();

            if (ultimoNodo.ValorMaximoPila > pDato)
            {
                valorMaximo = ultimoNodo.ValorMaximoPila;
            }
            else
            {
                valorMaximo = pDato;
            }

            tmp.ValorMaximoPila = valorMaximo;
            tmp.Siguiente = ancla.Siguiente;

            ancla.Siguiente = tmp;
        }

        public Nodo Pop()
        {
            Nodo result = new Nodo();

            if (ancla.Siguiente != null)
            {
                auxAncla = ancla.Siguiente;
                result.Dato = auxAncla.Dato;
                result.ValorMaximoPila = auxAncla.ValorMaximoPila;

                ancla.Siguiente = auxAncla.Siguiente;
                auxAncla.Siguiente = null;
            }

            return result;
        }

        public Nodo Peek()
        {
            Nodo result = new Nodo();

            if (ancla.Siguiente != null)
            {
                auxAncla = ancla.Siguiente;
                result.Dato = auxAncla.Dato;
                result.ValorMaximoPila = auxAncla.ValorMaximoPila;
            }

            return result;
        }

        public void Imprimir()
        {
            auxAncla = ancla;

            while (auxAncla.Siguiente != null)
            {
                auxAncla = auxAncla.Siguiente;

                int datoNodo = auxAncla.Dato;
                int valorMaximoPila = auxAncla.ValorMaximoPila;

                Console.WriteLine("El número del nodo es: [{0}]", datoNodo);
                //Console.WriteLine("[{0}]", valorMaximoPila);
            }
        }
    }
}