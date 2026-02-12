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
        static ArrayList libros = new ArrayList();

        // clase Libro
        class Libro // Un modelo para crear libros
        {
            // propiedades
            public string titulo; // protected, public, private, internal
            public int año;

            // comportamientos 

            public override string ToString() // aplicando polimorfismo
            {
                return $"Título: {titulo}\nAño de Publicación: {año}";
            }
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
                            InsertarUnLibro();
                            break;
                        case 2:
                            MostrarLibros();
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

        static void InsertarUnLibro()
        {
            //1. Solicitar al usuario que ingrese un titulo
            Console.WriteLine("Ingrese el titulo del libro: ");
            string titulo = Console.ReadLine();


            //2. Solicitar al usuario que ingrese el año de publicación
            int año = 0;

            while (true) 
            {
                Console.WriteLine("Ingrese el año de publicación: ");
                
                // validación de entrada
                if (int.TryParse(Console.ReadLine(), out int entrada))
                {
                    // validación de rango
                    if (entrada < 0)
                    {
                        Console.WriteLine("Debe ingresar un año válido");
                        continue;
                    }

                    año = entrada;
                    break;
                }
                else
                {
                    Console.WriteLine("Debe ingresar el año en formato numerico");
                }
            }

            //3. Crear el objeto de la clase Libro

            Libro libro = new Libro();
            libro.titulo = titulo;
            libro.año = año;

            //4. Insertar el libro en el listado de libros
            libros.Add(libro);
        }

        static void MostrarLibros()
        {
            Console.WriteLine("Listado de libros");

            foreach (var libro in libros)
            {
                // Mostrar el detalle
                Console.WriteLine(libro.ToString());
            }
        }
    }
}
