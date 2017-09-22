using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPolimorfismo
{
    public class Alumno: Persona 
    {
        int año = DateTime.Now.Year; 
        public override int AñoNacimiento()
        {
            return año - Edad;
        }
    }
}
