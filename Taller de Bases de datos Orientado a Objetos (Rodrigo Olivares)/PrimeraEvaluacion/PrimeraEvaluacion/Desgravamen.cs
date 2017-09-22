using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraEvaluacion
{
    class Desgravamen:DPS
    {
        private string nombreDocumento;

        public string NombreDocumento
        {
            get { return nombreDocumento; }
            set { nombreDocumento = value; }
        }

        public Desgravamen() 
        {
            
        }
        public Desgravamen(int _nroDPS, string _rutContratante, string _rutEjecutivo, DateTime _fechaRespuesta, string _nombreDocumento)
        {
            NroDps = _nroDPS;
            RutContratante = _rutContratante;
            RutEjecutivo = _rutEjecutivo;
            FechaRespuesta = _fechaRespuesta;
            NombreDocumento = _nombreDocumento;
        }

        public override string DatosDps()
        {
            return FechaRespuesta.ToShortDateString();
        }
    }
}
