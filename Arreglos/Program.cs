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
        static void Main(string[] args)
        {

            // Llenado del arreglo con las calificaciones del Laboratorio

            Menu();
        }

        static void Menu()
        {
            double[] practicaLaboratorio = new double[3];

            do
            {
                Console.WriteLine(new string('-', 10) + "\nSeleccione una Opción\n" + new string('-', 10));
                Console.WriteLine("1. Ingresar Notas\n2. Editar Notas\n3. Mostrar Notas\n4. Calcular Promedio\n0. Salir");

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            // Lógica para ingresar notas
                            for (int i = 0; i < practicaLaboratorio.Length; i++)
                            {
                                Console.WriteLine("Ingrese la calificación {0} del Laboratorio: ", i + 1);
                                practicaLaboratorio[i] = Convert.ToDouble(Console.ReadLine());
                            }
                            break;
                        case 2:
                            // Lógica para editar notas
                            Console.WriteLine("Notas ingresadas: ");

                            for (int i = 0; i < practicaLaboratorio.Length; i++)
                            {
                                Console.WriteLine("Calificación {0}: {1}", i + 1, practicaLaboratorio[i]);
                            }

                            Console.WriteLine("Seleccione la nota a modificar: ");

                            if (int.TryParse(Console.ReadLine(), out int indice))
                            {
                                if (indice >= 1 && indice <= practicaLaboratorio.Length)
                                {
                                    Console.WriteLine("Ingrese la nueva calificación: ");
                                    if (double.TryParse(Console.ReadLine(), out double nuevaNota))
                                    {
                                        practicaLaboratorio[indice - 1] = nuevaNota;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Entrada no válida. La calificación debe ser un número.");
                                    }
                                }


                            }
                            else
                            {
                                Console.WriteLine("Índice no válido.");
                            }

                            break;
                        case 3:
                            // Lógica para mostrar notas
                            Console.WriteLine("Notas ingresadas: ");

                            for (int i = 0; i < practicaLaboratorio.Length; i++)
                            {
                                Console.WriteLine("Calificación {0}: {1}", i + 1, practicaLaboratorio[i]);
                            }
                            break;
                        case 4:
                            // Lógica para calcular promedio
                            double promedio = practicaLaboratorio.Average();
                            Console.WriteLine($"El promedio de la práctica de laboratorio del primer periodo es: {promedio}");
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
    }
}
