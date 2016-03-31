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

        public Alumno(string Nombre, string Apellido, int Legajo)
        {
            this.nombre = Nombre;
            this.apellido = Apellido;
            this.legajo = Legajo;
        }

        public static void CalcularFinal()
        { }
        
        public static void Estudiar(byte notaUno, byte notaDos)
        {
            
        }
        
        public static void Mostrar()
        { }
    }
}
