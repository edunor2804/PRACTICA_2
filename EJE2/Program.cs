using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("------- MENÚ DE CURSOS ---------");
            Console.WriteLine("1. Programación");
            Console.WriteLine("2. Redes");
            Console.WriteLine("3. Base de Datos");
            Console.WriteLine("4. Diseño Grafico");

            Console.WriteLine("Seleccione un Curso: ");
            opcion = int.Parse(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Elegiste el curso de Programación.");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Elegiste el curso de Redes.");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Elegiste el curso de Base de datos.");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("Elegiste el curso de Diseño Grafico.");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Opcion no valida, elige un numero del 1 al 4.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
