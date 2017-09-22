using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpHerencia
{
    class Program
    {       

        static void Main(string[] args)
        {
            //instancia de Aereo
            Aereo avion = new Aereo();
            //instancia de Terrestre
            Terrestre camion = new Terrestre("JAX","tara 1200",150);

            avion.descripcion = "es un transporte aereo de pasajeros";
            avion.nombre = "Boing 737";
            avion.Distancia = 300;

            Console.WriteLine("{0}",avion.aTexto());
            Console.WriteLine("{0}",camion.aTexto());
            //Console.WriteLine("nombre: {0}; descripción: {1} Millas: {3}", avion.nombre, avion.descripcion,avion.Distancia);
            Console.ReadKey();

        }
    }
}
