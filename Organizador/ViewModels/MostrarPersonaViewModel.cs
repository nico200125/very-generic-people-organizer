using Organizador.Interfaces;
using Organizador.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizador.ViewModels
{
    internal class MostrarPersonaViewModel : ViewModelBase
    {
        IPersona conP;
        public PersonaR persona { get; }
        public MostrarPersonaViewModel(int ci) { 
            conP = Fabrica.CreateController();
            persona = conP.mostrarPersona(ci);
        }
    }
}
