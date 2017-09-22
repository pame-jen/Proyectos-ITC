using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPolimorfismo
{
    public class Persona
    {
        string nombre;
        string apellidoP;
        string apellidoM;
        int edad;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string ApellidoP
        {
            get
            {
                return apellidoP;
            }

            set
            {
                apellidoP = value;
            }
        }

        public string ApellidoM
        {
            get
            {
                return apellidoM;
            }

            set
            {
                apellidoM = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        //se declara virtual para aplicar
        //polimorfismo
        virtual public int AñoNacimiento()
        {
            return 0;
        }
    }
}
