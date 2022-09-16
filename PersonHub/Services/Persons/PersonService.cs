using PersonHub.Models;
using PersonHub.Repositories.Persons;
using PersonHub.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonHub.Services.Persons
{
    public class PersonService
    {
        private readonly PersonRepository _personRepository;

        public PersonService(PersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public IEnumerable<Persona> PersonaList()
        {
            return _personRepository.Get().Select(s => Map(s));
        }

        public Persona PersonaDetail(int id)
        {
            if (id < 1) throw new ArgumentException(nameof(id));

            return Map(_personRepository.GetById(id));
        }

        public void InsertPersona(Persona persona)
        {
            PersonaValidation.Validate(persona);

            _personRepository.Insert(Map(persona));
        }

        public void UpdatePersona(Persona persona)
        {
            PersonaValidation.Validate(persona);

            _personRepository.Update(Map(persona));
        }

        private Persona Map(Person person)
        {
            return new Persona(person.Id, person.Name, person.Age, person.Gender, person.Email);
        }

        private Person Map(Persona persona)
        {
            return new Person(persona.Id, persona.Nombre, persona.Edad, persona.Sexo, persona.Email);
        }
    }
}