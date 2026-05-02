using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organizador.Modelo;
using Organizador.Records;

namespace Organizador.Colecciones
{
    internal class ColeccionPersonas
    {
        //instancia singleton de la clase ColeccionPersonas
        private static ColeccionPersonas? _instance;

        // Dicionario para almacenar personas por su ID
        private readonly Dictionary<int, Persona> personas = new Dictionary<int, Persona>();

        // Campo publico para acceder a la instancia singleton de ColeccionPersonas
        public static ColeccionPersonas Instance
        {
            get
            {
                // Si no existe, la crea (Lazy Initialization)
                if (_instance == null)
                {
                    _instance = new ColeccionPersonas();
                }
                return _instance;
            }
        }

        private ColeccionPersonas() { }

        //Añadir una persona al diccionario, asegurando que no se dupliquen IDs
        public bool AddPerson(Persona person)
        {
            if (person == null || personas.ContainsKey(person.CI)) return false; // No se puede añadir una persona nula o con un ID duplicado

            personas.Add(person.CI, person);
            return true;
        }

        //Mostrar una persona por su ID, o null si no se encuentra
        public Persona GetPersonById(int id)
        {
            if (personas.TryGetValue(id, out Persona person))
            {
                return person;
            }

            return null;
        }

        // Lista de todas las personas almacenadas
        public List<Persona> GetAllPeople()
        {
            return personas.Values.ToList();
        }

        // Remover una persona por su ID, devolviendo true si se eliminó correctamente o false si no se encontró
        public bool RemovePerson(int id)
        {
            return personas.Remove(id);
        }
    }
}
