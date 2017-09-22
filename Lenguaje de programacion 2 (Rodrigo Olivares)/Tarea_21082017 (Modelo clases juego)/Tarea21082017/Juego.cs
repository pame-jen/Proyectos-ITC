using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea21082017
{
    //esta clase no puede ser instanciada
    //es decir no se puede crear un objeto de ella
    public abstract  class Juego
    {
        string nombre;
        string descripcion;
        int duracion;

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

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        /// <summary>
        /// duracion es en horas
        /// </summary>
        public int Duracion
        {
            get
            {
                return duracion;
            }

            set
            {
                duracion = value;
            }
        }


        /// <summary>
        /// cambia horas a minutos
        /// </summary>
        /// <returns>int</returns>
        virtual public int DuracionDeJuego()
        {
            return duracion * 60;
        }
    }
}
