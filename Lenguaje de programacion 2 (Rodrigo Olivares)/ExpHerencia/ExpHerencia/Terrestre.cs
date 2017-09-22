using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpHerencia
{
    public class Terrestre: Transporte
    {
        float km;

        public float Distancia
        {
            get { return km; }
            set { km = value; }
        }

        //constructor
        public Terrestre(string _nombre, string _descripcion,float _km)
        {
            nombre = _nombre;
            descripcion = _descripcion;
            Distancia = _km;
        }

        // el polimorfismo se puede aplicar solo cuando la 
        // clase base contiene metodos virtuales (Ej.: virtual public string aTexto)
        // y para sobreescribir aquellos metodos se debe 
        // utilizar override (Ej.: public override string aTexto)
        public override string aTexto() 
        {
            return "Soy Terrestre";
        }
    }
}
