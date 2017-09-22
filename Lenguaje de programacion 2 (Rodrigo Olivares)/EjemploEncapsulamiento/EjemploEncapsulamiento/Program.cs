using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEncapsulamiento
{
    class Cuadrado 
    {
        //el nombramiento public a una variable o clase corresponde 
        //al ambito de acceso permitido al que pertenece la misma

        // atributo privado, que se encuentra inaccesible
        int ancho;
        int altura;

        // propiedad que por definición es pública
        public int Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public int Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
             // instancia de un objeto de la clase cuadrado
            Cuadrado objCuadrado = new Cuadrado();

            // uso de las propiedades de un objeto instanciado de la clase cuadrado
            objCuadrado.Altura = 150;
            objCuadrado.Ancho = 110;

            Console.WriteLine("altura: {0} ancho: {1}",objCuadrado.Altura,objCuadrado.Ancho);
            Console.ReadKey();
        }
    }
}
