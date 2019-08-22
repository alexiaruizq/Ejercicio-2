using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();

            Console.WriteLine("Alumno ");
            Console.WriteLine("Nombre: " + alumno1.Nombre);
            Console.WriteLine("Matricula " + alumno1.Matricula);
            Console.WriteLine("Correo: ");
            Console.WriteLine("Direccion: ");

            Alumno alumno2 = new Alumno("Alexia", "alexiaruiz-@hotmail.com");

            Console.Read();

        }
    }
}
