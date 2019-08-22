using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Alumno
    {

        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Nacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Alumno()
        {

            Nombre = "Alexia";
            Matricula = "189363";
        }
            public Alumno(string nombre, string matricula)
            {
                Nombre = nombre;
                Matricula = matricula;


            }
        }
    }