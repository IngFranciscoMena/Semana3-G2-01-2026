using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Program
    {
        // Un arreglo de tipo double donde se almancerán las calificaciones del ciclo en 1 materia.
        static double[] calificaciones = new double[3];

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine(new string('-', 10) + "\nSeleccione una Opción\n" + new string('-', 10));
                Console.WriteLine("1. Ingresar Notas\n2. Mostrar Notas\n3. Editar Notas\n4. Calcular Promedio\n0. Salir");

                // Validación de entrada de usuario
                if (int.TryParse(Console.ReadLine(), out int opcion))
                {

                    // Uso de estructura switch para el manejo de opciones
                    switch (opcion)
                    {
                        case 1:
                            InsertarNotas();
                            break;
                        case 2:
                            MostrarNotas();
                            break;
                        case 3:
                            EditarNotas();
                            break;
                        case 4:
                            CalcularPromedio();
                            break;
                        case 0:
                            Console.WriteLine("Saliendo del programa...");
                            return;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor ingrese un número.");
                }
            } while (true);
        }

        static void InsertarNotas()
        {
            // Lógica para ingresar notas
            for (int i = 0; i < calificaciones.Length; i++) // iterar 3 veces
            {
                while (true)
                {
                    Console.WriteLine($"Ingrese la calificación {i+1} del Laboratorio: "); 

                    // validación de entrada del usuario
                    if (double.TryParse(Console.ReadLine(), out double nota))
                    {
                        // validación de rango 
                        if (nota < 0 || nota > 10)
                        {
                            Console.WriteLine("La calificación debe estar entre 0 y 10. Intente de nuevo.");
                            continue; // volver al inicio del bucle while
                        }

                        calificaciones[i] = nota;
                        break; // salir del bucle while si la entrada es válida
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Por favor ingrese un número.");
                    }
                }
            }
        }

        static void MostrarNotas()
        {
            // Lógica para mostrar notas
            Console.WriteLine("Notas ingresadas: ");

            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.WriteLine($"Calificación {i+1}: {calificaciones[i]}");
            }
        }

        static void EditarNotas()
        {
            // Lógica para editar notas
            MostrarNotas();

            while (true)
            {
                Console.WriteLine("Seleccione la nota a modificar: ");

                // validación de entrada del usuario
                if (int.TryParse(Console.ReadLine(), out int indice))
                {

                    // validación de rango
                    if (indice >= 1 && indice <= calificaciones.Length) // 1 y 3
                    {
                        while (true)
                        {
                            Console.WriteLine("Ingrese la nueva calificación: ");

                            // validación de entrada del usuario
                            if (double.TryParse(Console.ReadLine(), out double nuevaNota))
                            {

                                // validación de rango
                                if (nuevaNota < 0 || nuevaNota > 10)
                                {
                                    Console.WriteLine("La calificación debe estar entre 0 y 10. Intente de nuevo.");
                                    continue; // volver al inicio del bucle while
                                }

                                // modificamos la calificación en el arreglo
                                calificaciones[indice - 1] = nuevaNota;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida. La calificación debe ser un número.");
                            }
                        }

                        break; // salir del bucle principal después de la edición
                    }
                    else
                    {
                        Console.WriteLine("La nota seleccionada no existe. Intente de nuevo.");
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido. Intente de nuevo");
                }
            }            
        }

        static void CalcularPromedio()
        {
            // Lógica para calcular promedio
            double promedio = calificaciones.Average();
            Console.WriteLine($"El promedio del ciclo es: {promedio}");
        }
    }l
}
