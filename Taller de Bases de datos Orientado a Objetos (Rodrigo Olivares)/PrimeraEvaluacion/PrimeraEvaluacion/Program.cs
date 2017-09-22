using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraEvaluacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Desgravamen desgNuevo = new Desgravamen(1, "125638", "125135", Convert.ToDateTime("12/09/2017"),"prueba");
            SeguroVida segNuevo = new SeguroVida(2, "123456789", "123456789", Convert.ToDateTime("04/09/2017"), 3);
            DPS dpsNuevo = new DPS()
            {
                NroDps=2,
                RutContratante="123",
                RutEjecutivo="123",
                FechaRespuesta=Convert.ToDateTime("03/09/2017")
            };

            Utiles.metodoPrueba(desgNuevo);
            Utiles.metodoPrueba(segNuevo);
            Utiles.metodoPrueba(dpsNuevo);
            Console.ReadKey();
        }
    }
}
