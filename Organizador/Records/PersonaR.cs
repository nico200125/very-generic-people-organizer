using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizador.Records
{
    // Record para representar una persona
    public record PersonaR(
        int CI,
        string Name,
        int Age,
        DateTime BirthDate,
        string Telefono,
        List<String> Notas
    );
}
