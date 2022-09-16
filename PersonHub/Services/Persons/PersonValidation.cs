using PersonHub.Models;
using PersonHub.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonHub.Services.Persons
{
    public static class PersonaValidation
    {
        public static void Validate(Persona persona)
        {
            if (string.IsNullOrEmpty(persona.Nombre))
                throw new Exception("El nombre es requerido");

            if(persona.Nombre.Length > 20)
                throw new Exception("El limite de caracteres es 20");

            if (persona.Edad < 1)
                throw new Exception("Edad no puede ser menor que 1");

            var genderValues = new[] { 0, 1 };
            if (! genderValues.Contains(persona.Sexo))
                throw new Exception("Valores no aceptados para sexo");

            if(string.IsNullOrEmpty(persona.Email))
                throw new Exception("El email es requerido");
        }
    }
}