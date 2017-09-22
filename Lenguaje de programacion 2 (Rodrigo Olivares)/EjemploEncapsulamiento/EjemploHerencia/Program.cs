using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    class Program
    {
        // la herencia esta dividida en clases base y clases derivadas
        // una clase derivada es una especificación de la clase base
        // Todas las clases derivadas heredan todas las propiedades públicas disponibles de sus clases base
        // sin embargo, no son heredables los constructores y los destructores, ya que estos no son públicos

        class Persona
        {
            int id;
            string nombre;
            int edad;
            // 
            static int sumaId;

            // encapsulamiento
            public int Id
            {   get { return id; }
                set { id = value; }}
            public string Nombre
            {   get { return nombre; }
                set { nombre = value; }}
            public int Edad
            {   get { return edad; }
                set { edad = value; }}

            // constructor
            // quiere decir que cuando instanciemos esta clase 
            // se creará por defecto con estos valores
            // el constructor siempre debe llamarse con el nombre de la clase
            public Persona()
            {
                id = 0;
                nombre = "Juan Perez del Canto";
                edad = 30;
            }

            // instancia del constructor que recibe parametros
            // cuando una clase contiene dos constructores se diferencian por su 
            // tipo, el número y el orden de sus parametros y esto se denomina "SobreCarga"
            public Persona(string _nombre, int _edad)
            {
                id = sgteId();
                nombre = _nombre;
                edad = _edad;
            }

            // función, retorna un entero 
            // investigar sobre protected y diferentes ambitos de las propiedades
            // https://msdn.microsoft.com/es-es/library/ms228632(v=vs.90).aspx
            protected int sgteId()
            {
                return ++sumaId;
            }

        }

        class PersonaNatural : Persona
        {
            string nroTelefono;

            public string NroTelefono
            {
                get { return nroTelefono; }
                set { nroTelefono = value; }
            }

            //public PersonaNatural()
            //{
            //    // TODO: Complete member initialization
            //}

            public PersonaNatural(string _nombre, int _edad, string _telefono)
            {
                Nombre = _nombre;
                Edad = _edad;
                NroTelefono = _telefono;
                Id = sgteId();
            }

           
        }

        static void Main(string[] args)
        {

            Persona objPer = new Persona();
            Console.WriteLine("Id: {0} Nombre: {1} Edad: {2} ", objPer.Id, objPer.Nombre, objPer.Edad);

            Persona objPer2 = new Persona("Marta Allende",28);
            Console.WriteLine("Id: {0} Nombre: {1} Edad: {2} ", objPer2.Id, objPer2.Nombre, objPer2.Edad);

            PersonaNatural objPerNat = new PersonaNatural("Prueba Per Natural",25,"9758 25 48");
            Console.WriteLine("Id: {0} Nombre: {1} Edad: {2} Nro Telefono: {3}", objPerNat.Id, objPerNat.Nombre, objPerNat.Edad,objPerNat.NroTelefono);

            PersonaNatural objPerNat2 = new PersonaNatural("persona natural 2", 60, "8458 12 85");
            Console.WriteLine("Id: {0} Nombre: {1} Edad: {2} Nro Telefono: {3}", objPerNat2.Id, objPerNat2.Nombre, objPerNat2.Edad, objPerNat2.NroTelefono);
            Console.ReadKey();
        }
    }
}
