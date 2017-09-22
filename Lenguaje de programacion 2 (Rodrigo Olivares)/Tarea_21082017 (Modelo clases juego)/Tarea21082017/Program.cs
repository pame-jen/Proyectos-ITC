using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea21082017
{
    class Program
    {
        static void Main(string[] args)
        {
            Accion oBattleField = new Accion("BattleField", "juego de accion", 80, 4);
            Accion oUncharted4 = new Accion("Uncharted4", "juego de accion", 6, 8);
            Fantasia oFinalFantasy = new Fantasia("oFinalFantasy", "juego de fantasia", 60, true);
            Fantasia oLOL = new Fantasia("LOL", "juego de fantasia", 120, false);
             

            Console.WriteLine("JUEGOS DE ACCION\n\nnombre: {0}\ndescripcion: {1}\nduracion: {2} minutos\nNroJugadores: {3}", oBattleField.Nombre, oBattleField.Descripcion, oBattleField.DuracionDeJuego(), oBattleField.NroJugadores );

            Console.WriteLine("mensaje: {0}\nRUT con formato: {1}", Utiles.enviarMensaje("esto es un mensaje"), Utiles.formatoRut("111111111"));
           
            Console.ReadKey();
        }
    }
}
