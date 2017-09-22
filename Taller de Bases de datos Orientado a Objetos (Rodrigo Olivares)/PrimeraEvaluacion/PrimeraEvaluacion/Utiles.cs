using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraEvaluacion
{
    static class Utiles
    {
        public static void metodoPrueba(DPS _dpsNuevo) 
        {
            Console.WriteLine("\n INFORMACIÓN DPS Nº: ---> {0} <---", _dpsNuevo.NroDps);
            Console.WriteLine("\n Rut contratante: {0} \n Rut Ejecutivo: {1} \n Fecha Respuesta: {2} \n Observación: {3}",_dpsNuevo.RutContratante,_dpsNuevo.RutEjecutivo,_dpsNuevo.FechaRespuesta,_dpsNuevo.DatosDps());
        }


    }
}
