using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Alumno PrimerAlumno = new Alumno("Franco", "Salvatierra", 1111);
            Alumno SegundoAlumno = new Alumno("Angel", "Rozas", 2222);
            Alumno TercerAlumno = new Alumno("Juan", "Cruz", 3333);

            PrimerAlumno.Estudiar(9, 8);
            SegundoAlumno.Estudiar(3, 2);
            TercerAlumno.Estudiar(10, 7);

            Alumno.Mostrar(PrimerAlumno);
            Alumno.Mostrar(SegundoAlumno);
            Alumno.Mostrar(TercerAlumno);

            Console.ReadKey();
        }
    }
}
