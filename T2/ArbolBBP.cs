using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class ArbolBBP
    {
        private NodoP Raiz;

        public void Agrega(Persona persona)
        {
            Raiz = Insertar(Raiz, persona);
        }

        private NodoP Insertar(NodoP nodo, Persona persona)
        {
            if (nodo == null)
                return new NodoP(persona);

            if (persona.Dni < nodo.Dato.Dni)
                nodo.Izq = Insertar(nodo.Izq, persona);
            else if (persona.Dni > nodo.Dato.Dni)
                nodo.Der = Insertar(nodo.Der, persona);

            return nodo;
        }

        public void ImprimePre()
        {
            PreOrden(Raiz);
        }

        private void PreOrden(NodoP nodo)
        {
            if (nodo != null)
            {
                Console.WriteLine(nodo.Dato);
                PreOrden(nodo.Izq);
                PreOrden(nodo.Der);
            }
        }

        public int CantidadMayores(int edad)
        {
            return ContarMayores(Raiz, edad);
        }

        private int ContarMayores(NodoP nodo, int edad)
        {
            if (nodo == null) return 0;

            int conteo = nodo.Dato.Edad > edad ? 1 : 0;
            return conteo + ContarMayores(nodo.Izq, edad) + ContarMayores(nodo.Der, edad);
        }

        public string Antepenultimo()
        {
            List<Persona> lista = new List<Persona>();
            InOrden(Raiz, lista);
            if (lista.Count >= 3)
                return lista[lista.Count - 2].ToString();
            else
                return "No hay suficientes personas para determinar el antepenúltimo.";
        }

        private void InOrden(NodoP nodo, List<Persona> lista)
        {
            if (nodo != null)
            {
                InOrden(nodo.Izq, lista);
                lista.Add(nodo.Dato);
                InOrden(nodo.Der, lista);
            }
        }
    }
}
