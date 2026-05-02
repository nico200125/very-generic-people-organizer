using Organizador.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizador.Interfaces
{
    internal static class Fabrica
    {
        public static IPersona CreateController()
        {
            // Devolvemos el controlador que tiene la lógica
            return new ControladorPersonas();
        }
    }
}
