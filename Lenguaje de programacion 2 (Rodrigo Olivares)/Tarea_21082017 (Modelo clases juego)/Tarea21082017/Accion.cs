using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea21082017
{
    public class Accion : Juego
    {
        int nroJugadores;


        public Accion(string _nombre, string _descripcion, int _duracion, int _nroJugadores)
        {
            Nombre = _nombre;
            Descripcion = _descripcion;
            Duracion = _duracion;
            NroJugadores = _nroJugadores; 
        }

        public int NroJugadores
        {
            get
            {
                return nroJugadores;
            }

            set
            {
                nroJugadores = value;
            }
        }


        public string NombreJuego()
        {
            return Nombre;
        }
    }
}
