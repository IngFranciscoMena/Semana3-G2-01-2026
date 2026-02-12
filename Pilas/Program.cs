using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una pila de string donde se almacerán frutas

            Stack<string> frutas = new Stack<string>(); // inicializar una Pila - Estructura LIFO - Last In, First Out

            // agregar elementos a la pila
            frutas.Push("Manzana");
            frutas.Push("Pera");
            frutas.Push("Naranja");
            frutas.Push("Sandia");

            // obtener la Manza

            Console.WriteLine(frutas.Peek());
        }
    }
}
