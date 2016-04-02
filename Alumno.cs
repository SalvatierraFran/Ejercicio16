using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio16
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        Random rnd = new Random();

        public Alumno(string Nombre, string Apellido, int Legajo)
        {
            this.nombre = Nombre;
            this.apellido = Apellido;
            this.legajo = Legajo;
        }

        public void CalcularFinal()
        {
            
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                this._notaFinal = rnd.Next(4, 10);
            }
            else
            {
                this._notaFinal = -1;
            }

            if (this._notaFinal != -1)
            {
                Console.Write("\nLa nota del final es: " + this._notaFinal);
            }
            else
            {
                Console.Write("\nDesaprobado");
            }
                
        }
        
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }
        
        public static void Mostrar(Alumno UnAlumno)
        {
            Console.Write("Nombre: " + UnAlumno.nombre);
            Console.Write("\nApellido: " + UnAlumno.apellido);
            Console.Write("\nLegajo: " + UnAlumno.legajo);
            Console.Write("\nNota 1: " + UnAlumno._nota1);
            Console.Write("\nNota 2: " + UnAlumno._nota2);
            UnAlumno.CalcularFinal();
            Console.WriteLine("\n");
        }
    }
}
