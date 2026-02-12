using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListPractica
{
    internal class Program
    {

        // crear nuestro ArrayList
        ArrayList libros = new ArrayList();

        // clase Libro
        class Libro // Un modelo para crear libros
        {
            // propiedades
            string titulo;
            int año;

            // comportamientos
        }

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Seleccione una Opción");
                Console.WriteLine("1. Agregar Libro\n2. Mostrar Libros.\n0. Salir");

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("Hasta la próxima!");
                            return;
                        case 1:
                            break;
                        case 2:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar una opción válida.");
                }
            } while (true);
        }
    }
}
