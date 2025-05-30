using T2;

class Program
{
    static void Main(string[] args)
    {
        ArbolBBP arbolPersonas = new ArbolBBP();
        int opcion;
        do
        {
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("1) Agregar Persona");
            Console.WriteLine("2) Listar Personas");
            Console.WriteLine("3) Mayores de cierta edad");
            Console.WriteLine("4) Antepenúltimo por DNI");
            Console.WriteLine("5) Fin");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("DNI: ");
                    int dni = int.Parse(Console.ReadLine());
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Edad: ");
                    int edad = int.Parse(Console.ReadLine());
                    arbolPersonas.Agrega(new Persona(dni, nombre, edad));
                    break;

                case 2:
                    Console.WriteLine("\nListado de personas (PreOrden):");
                    arbolPersonas.ImprimePre();
                    break;

                case 3:
                    Console.Write("Edad: ");
                    int edadMin = int.Parse(Console.ReadLine());
                    int cant = arbolPersonas.CantidadMayores(edadMin);
                    Console.WriteLine($"Cantidad de personas mayores de {edadMin}: {cant}");
                    break;

                case 4:
                    Console.WriteLine("Antepenúltima persona por DNI: ");
                    Console.WriteLine(arbolPersonas.Antepenultimo());
                    break;
            }

        } while (opcion != 5);

        Console.WriteLine("Programa finalizado.");
    }
}

