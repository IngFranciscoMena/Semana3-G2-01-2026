using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casos_de_Uso
{
    internal class Program
    {
        // Clase Estudiante
        class Estudiante
        {
            // Propiedades o atributos
            public string nombre;
            public int edad;
            public double calificacion;

            // Acciones
            public override string ToString()
            {
                return $"Nombre: {nombre}.\nEdad: {edad}\nNota: {calificacion}";
            }
        }

        static void Main(string[] args)
        {
            // Ejecutar el Caso 1
            //Caso_1();

            //Caso_2();
        }

        static void Caso_1()
        {

            ArrayList estudiantes = new ArrayList();

            bool continuar = true;

            while (continuar) 
            {
                // Objeto Estudiante
                Estudiante estudiante = new Estudiante();

                Console.WriteLine("Ingrese el nombre del Estudiante: ");
                string nombre = Console.ReadLine();

                if (string.IsNullOrEmpty(nombre) || nombre.Length < 10)
                {
                    Console.WriteLine("El nombre ingresado no cumple con los requisitos necesario para el registro");
                    continue;
                }

                estudiante.nombre = nombre;

                while (true)
                {
                    Console.WriteLine("Ingrese la edad del Estudiante: ");

                    if (!int.TryParse(Console.ReadLine(), out int edad))
                    {
                        Console.WriteLine("Edad incorrecta, favor ingresar la edad en formato numerico");
                        continue;
                    }

                    if (edad < 15)
                    {
                        Console.WriteLine("No tienes la edad requerida para tomar esta clase");
                        continue;
                    } 

                    estudiante.edad = edad;
                    break;
                }

                while (true)
                {
                    Console.WriteLine("Ingrese la nota del Estudiante: ");

                    if (!double.TryParse(Console.ReadLine(), out double nota))
                    {
                        Console.WriteLine("Nota incorrecta, favor ingresar una nota en formato numerico");
                        continue;
                    }

                    if (!(nota >= 0 && nota <= 10))
                    {
                        Console.WriteLine("La nota debe estar en un rango de 0 a 10");
                        continue;
                    }

                    estudiante.calificacion = nota;
                    break;
                }

               // Agregar el estudiante al ArrayList de estudiantes
               estudiantes.Add(estudiante);

                Console.WriteLine("Desea ingresar otro estudiante: (Si/No)");
                string otroEstudiante = Console.ReadLine();

                // Validacion
                if (otroEstudiante.Trim().ToLower().Equals("no") || otroEstudiante.Trim().ToLower().Equals("n"))
                {
                    Console.WriteLine("Registro de Estudiantes finalizado");
                    continuar = false;
                }
            }

            // Registro de estudiantes
            Console.WriteLine("Registro de estudiantes\n" + new string('-',20));

            foreach (Estudiante estudiante in estudiantes)
            {
                Console.WriteLine(estudiante);
            }
        }

        static void Caso_2()
        {
            // Crear un objeto historial

            HistorialNavegacion historial = new HistorialNavegacion();

            historial.Visitar("www.google.com");
            historial.Visitar("www.youtube.com");
            historial.Visitar("www.facebook.com");
            historial.Visitar("www.netflix.com");
            historial.MostrarPaginaActual(); // www.netflix.com

            historial.Atras();
            historial.Atras();
            historial.MostrarPaginaActual(); // www.youtube.com

            historial.Adelante();
            historial.MostrarPaginaActual(); // www.facebook.com
        }

        class HistorialNavegacion
        {
            // atributos de la clase

            // Crear dos estructuras tipo Pila

            Stack<string> navegacionAtras = new Stack<string>();
            Stack<string> navegacionAdelante = new Stack<string>();

            // Variable que nos muestre la pagina actual
            string paginaActual = "";

            // comportamientos de la clase

            public void Visitar(string url)
            {
                // validacion de la url
                if (string.IsNullOrEmpty(url))
                {
                    Console.WriteLine("La url no puede estar vacia");
                }

                // validacion para verificar si existe ya una navegacion
                if (!string.IsNullOrEmpty(paginaActual)) // si la pagina actual no esta vacia
                {
                    // Limpiar en caso no exista una pagina actual
                    navegacionAtras.Push(paginaActual);
                }

                paginaActual = url;
                navegacionAdelante.Clear();
            }

            public void Atras()
            {
                // validacion
                if(navegacionAtras.Count > 0)
                {
                    navegacionAdelante.Push(paginaActual);
                    paginaActual = navegacionAtras.Pop();
                    Console.WriteLine($"Regresando a {paginaActual}");
                }
                else
                {
                    Console.WriteLine("No existen paginas anteriores");
                }

            }

            public void Adelante()
            {
                // validacion
                if (navegacionAdelante.Count > 0)
                {
                    navegacionAtras.Push(paginaActual);
                    paginaActual = navegacionAdelante.Pop();
                    Console.WriteLine($"Avanzando a {paginaActual}");
                }
                else
                {
                    Console.WriteLine("No existen paginas siguientes");
                }
            }

            public void MostrarPaginaActual()
            {
                Console.WriteLine($"Pagina actual: {paginaActual}");
            }
        }
    }
}
