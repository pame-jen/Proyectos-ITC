using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            Alumno Al1 = new Alumno();
            Al1.Nombre="Andy";
            Al1.Edad=30;
            Al1.ApellidoP="vera";
            Al1.ApellidoM="lizama";

            Docente Do1 = new Docente() { 
            Nombre="prueba docente",
            Edad=45,
            ApellidoP="gomez",
            ApellidoM="salinas"
            };

            Console.WriteLine("--- Datos Alumno ---\n");
            Console.WriteLine("Nombre: {0} \nApellidos: {1} \nEdad: {2} \nAño Nacimiento: {3} ", Al1.Nombre, Al1.ApellidoP + " " + Al1.ApellidoM, Al1.Edad, Al1.AñoNacimiento());

            Console.WriteLine("\n\n--- Datos Docente ---\n");
            Console.WriteLine("Nombre: {0} \nApellidos: {1} \nEdad: {2} \nAño Nacimiento: {3} ", Do1.Nombre, Do1.ApellidoP + " " + Do1.ApellidoM, Do1.Edad, Do1.AñoNacimiento());
            Console.ReadKey();
        }
    }
}
