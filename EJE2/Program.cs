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
            //variable donde se guardará la opción del usuario
            int opcion;
            
            //Muestra las opciones disponibles
            
            Console.WriteLine("------- MENÚ DE CURSOS ---------");
            Console.WriteLine("1. Programación");
            Console.WriteLine("2. Redes");
            Console.WriteLine("3. Base de Datos");
            Console.WriteLine("4. Diseño Grafico");
            

            //Solicita al usuario seleccionar un curso
            Console.WriteLine("Seleccione un Curso: ");
            opcion = int.Parse(Console.ReadLine());
            

            //Evalua la opción elegida
            switch(opcion)
            {
                case 1:
                    //primera opción de curso
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
                    //Muestra mensaje si la opcion no exite
                    Console.WriteLine("Opcion no valida, elige un numero del 1 al 4.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
