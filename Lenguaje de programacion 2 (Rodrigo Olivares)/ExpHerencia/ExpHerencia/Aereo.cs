using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpHerencia
{
    public class Aereo: Transporte
    {
        float millas;

        public float Distancia
        {
            get { return millas; }
            set { millas = value; }
        }

        public override string aTexto()
        {
            return "Soy Aereo";
        }
    }
}
