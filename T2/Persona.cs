using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Persona
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(int dni, string nombre, int edad)
        {
            Dni = dni;
            Nombre = nombre;
            Edad = edad;
        }

        public override string ToString()
        {
            return $"DNI: {Dni}, Nombre: {Nombre}, Edad: {Edad}";
        }
    }
}
