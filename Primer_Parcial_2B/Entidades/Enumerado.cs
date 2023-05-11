using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enumerado
    {
        public enum ETiposDeReparaciones
        {
            Ps2,
            Ps3,
            Ps4,
            Ps5,
            Xbox360,
            XboxOne,
            NintendoSwitch,
            JoystickPs4,
            JoystickPs5,
            JoystickXbox360,
            joystickXboxOne,
            JoyconIzquierdo,
            JoyconDerecho
        }

        public enum EEstado
        {
            Abierto,
            EnTaller,
            Presupuestado,
            Retirado
        }

        public enum ECategoria
        {
            Juego,
            Accesorio,
            Merchandising,
            Consola
        }
    }

}
