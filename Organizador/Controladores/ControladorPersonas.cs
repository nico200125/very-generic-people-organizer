using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organizador.Colecciones;
using Organizador.Modelo;
using Organizador.Records;
using Organizador.Interfaces;

namespace Organizador.Controladores
{
    internal class ControladorPersonas : IPersona
    {
        private readonly ColeccionPersonas coleccionPersonas;
        public ControladorPersonas()
        {
            this.coleccionPersonas = ColeccionPersonas.Instance;

        }
        public bool agregarPersona(PersonaR persona)
        {
            Persona npersona = new Persona(persona.CI, persona.Name, persona.BirthDate, persona.Telefono);
            return coleccionPersonas.AddPerson(npersona);   
        }
        public List<PersonaR> mostrarPersonas()
        {
            List<Persona> personas = coleccionPersonas.GetAllPeople();
            List<PersonaR> personasR = new List<PersonaR>();
            foreach (var persona in personas)
            {
                personasR.Add(persona.mostrarPersona());
            }
            return personasR;
        }
        public PersonaR? mostrarPersona(int ci)
        {
            return coleccionPersonas.GetPersonById(ci).mostrarPersona();
        }
        
    }
}
