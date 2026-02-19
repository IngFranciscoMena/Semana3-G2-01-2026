using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializar la Cola // FIFO First In, First Out
            Queue<string> documentos = new Queue<string>();

            // Agregar elementos
            documentos.Enqueue("Tarea de Base Datos.pdf");
            documentos.Enqueue("Tarea de Programacion 1.pdf");
            documentos.Enqueue("Tarea de Redes.pdf");

            // Retirar un elemento de la cola
            Console.WriteLine($"El documento impreso es: {documentos.Dequeue()}");

            // Mostrar el siguiente elmento encolado
            Console.WriteLine($"El siguiente documento a imprimir es: {documentos.Peek()}");
        }
    }
}
