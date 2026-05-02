using System;
using System.Collections.Generic;
using Organizador.Records;

namespace Organizador.Modelo
{
    public class Persona
    {
        //Campos
        public int CI { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Telefono { get; set; }
        public List<String> Notas { get; set; } 


        //Constructor
        public Persona(int ci, string name, DateTime birthDate, string telefono)
        {
            CI = ci;
            Name = name;
            BirthDate = birthDate;
            Telefono = telefono;
            Notas = new List<String>();

            //Calcula la edad
            Age = CalculateAge(birthDate);
        }

        //Calclua la edad a partir de la fecha de nacimiento y la fecha actual
        private int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            // Si todavía no ha cumplido años este año, resta 1 a la edad
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }

        // Method to display person details
        public PersonaR mostrarPersona()
        {
            return new PersonaR(CI, Name, Age, BirthDate, Telefono, Notas);
        }

        public void agregarNota(string nota)
        {
            Notas.Add(nota);
        }
    }
}