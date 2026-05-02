using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organizador.Records;

namespace Organizador.Interfaces
{
    internal interface IPersona
    {
        bool agregarPersona(PersonaR persona);
        List<PersonaR> mostrarPersonas();
        PersonaR? mostrarPersona(int ci);
    }
}
