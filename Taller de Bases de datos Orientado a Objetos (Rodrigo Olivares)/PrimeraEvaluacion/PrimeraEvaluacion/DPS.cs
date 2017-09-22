using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraEvaluacion
{
    class DPS
    {
        private int nroDps;
        private string rutContratante;
        private string rutEjecutivo;
        private DateTime fechaRespuesta;
        public int NroDps
        {
            get { return nroDps; }
            set { nroDps = value; }
        }
        
        public string RutContratante
        {
            get { return rutContratante; }
            set { rutContratante = value; }
        }     

        public string RutEjecutivo
        {
            get { return rutEjecutivo; }
            set { rutEjecutivo = value; }
        }
        
        public DateTime FechaRespuesta
        {
            get { return fechaRespuesta; }
            set { fechaRespuesta = value; }
        }

        virtual public string DatosDps() 
        {
            return " Nº DPS: " + Convert.ToString(NroDps) + " Rut Contratante: " + RutContratante;
        }
    }
}
