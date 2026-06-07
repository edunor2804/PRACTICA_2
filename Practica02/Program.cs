using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando la variable edad como tipo de dato entero
            int edad;

            //Solicita al usuario que ingrese su edad
            Console.Write("Ingrese su edad: ");

            //Convierte la edad ingresada y lo convierte a entero
            edad = int.Parse(Console.ReadLine());

            //Verifica si la edad es mayor a 18 
            if(edad >= 18) 
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else 
            {
                Console.WriteLine("Eres menor de edad");
            }

            Console.ReadKey();
        }
    }
}
  
