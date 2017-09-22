using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpHerencia
{
    public class Transporte
    {
        //atributos
        public string nombre;
        public string descripcion;

        // metodos 
        //este metodo puede ser sobreescrito
        //es decir se puede cambiar el codigo que 
        // contienen
        //para realizar la misma tarea de otro modo

        //métodos
        virtual public string aTexto()
        {
            return string.Empty;
        }

    }
}
