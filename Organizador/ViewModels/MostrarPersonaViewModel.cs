using Organizador.Interfaces;
using Organizador.Records;
using System;
using System.Collections.Generic;
    using System.Collections.ObjectModel;

namespace Organizador.ViewModels
{
    public class MostrarPersonaViewModel : ViewModelBase
    {
        IPersona conP;
        public PersonaR persona { get; }

        // Colección observable para enlazar en la vista
        public ObservableCollection<string> Notas { get; }

        public MostrarPersonaViewModel(int ci)
        {
            conP = Fabrica.CreateController();
            persona = conP.mostrarPersona(ci) ?? throw new ArgumentException("CI no encontrado", nameof(ci));

            // Inicializar desde la lista existente (si la hay)
            Notas = new ObservableCollection<string>(persona.Notas ?? new List<string>());
        }
    }
}
