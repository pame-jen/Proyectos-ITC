using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea21082017
{
    public class Fantasia: Juego 
    {
        bool online;
        

        public Fantasia(string _nombre, string _descripcion, int _duracion, bool _onLine)
        {
            Nombre = _nombre;
            Descripcion = _descripcion;
            Duracion = _duracion;
            Online = _onLine;
        }

        public bool Online
        {
            get
            {
                return online;
            }

            set
            {
                online = value;
            }
        }


        public override int DuracionDeJuego()
        {
            return Duracion;
        }
    }
}
