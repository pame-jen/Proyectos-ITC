using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraEvaluacion
{
    class SeguroVida:DPS
    {
        private int nroBeneficiarios;

        public int NroBeneficiarios
        {
            get { return nroBeneficiarios; }
            set { nroBeneficiarios = value; }
        }
        public SeguroVida()
        {
            
        }

        public SeguroVida(int _nroDPS, string _rutContratante, string _rutEjecutivo, DateTime _fechaRespuesta, int _nroBeneficiarios)
        {
            NroDps = _nroDPS;
            RutContratante = _rutContratante;
            RutEjecutivo = _rutEjecutivo;
            FechaRespuesta = _fechaRespuesta;
            NroBeneficiarios = _nroBeneficiarios;
        }

        public override string DatosDps()
        {
            return FechaRespuesta.ToLongDateString();
        }
    }
}
