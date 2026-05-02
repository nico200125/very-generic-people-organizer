using Organizador.Interfaces;
using Organizador.Modelo;
using Organizador.Records;
using Organizador.Views;
using System;
using System.Collections.Generic;
namespace Organizador.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        IPersona conP;
        public List<PersonaR> personas {  get; }
        private PersonaR _selectedPersona;
        public PersonaR selectedPersona
        {
            get => _selectedPersona;
            set
            {
                if (SetProperty(ref _selectedPersona, value) && value != null)
                {
                    // Create the instance of your existing window
                    var detailsWindow = new MostrarPersonaWindow();

                    // Pass the CI to the new window (either via constructor or ViewModel)
                    detailsWindow.DataContext = new MostrarPersonaViewModel(_selectedPersona.CI);

                    detailsWindow.Show();


                    _selectedPersona = null;
                    OnPropertyChanged(nameof(selectedPersona));
                }
            }
        }

        public MainWindowViewModel() {
            conP = Fabrica.CreateController();
            List<String> notas1 = new List<String>();
            List<String> notas2 = new List<String>();
            List<String> notas3 = new List<String>();
            conP.agregarPersona(new PersonaR(10021212, "abc", 0, new DateTime(2001, 12, 25), "099791290", notas1));
            conP.agregarPersona(new PersonaR(53597406, "cba", 0, new DateTime(2001, 12, 25), "099791290", notas2));
            conP.agregarPersona(new PersonaR(12345678, "xyz", 0, new DateTime(2001, 12, 25), "099791290", notas3));
            personas = conP.mostrarPersonas();
        }
    }
}
