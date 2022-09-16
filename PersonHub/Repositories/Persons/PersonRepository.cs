using PersonHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonHub.Repositories.Persons
{
    public class PersonRepository
    {
        private static List<Person> persons = new List<Person>()
        //SEED
        {
            new Person { Id = 1, Name = "Luis", Age = 27, Gender = 1, Email = "ltolentino" },
            new Person { Id = 2, Name = "Manuela", Age = 20, Gender = 0, Email = "mcaraballo" }
        };

        public Person GetById(int id)
        {
            return persons.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Person> Get()
        {
            return persons;
        }

        public void Insert(Person person)
        {
            var lastId = 0;
            if (persons.Any())
                lastId = persons.Max(p => p.Id);

            person.Id = lastId + 1;

            persons.Add(person);
        }

        public void Update(Person person) 
        {
            var personEntity = GetById(person.Id);

            if (personEntity == null) throw new ArgumentOutOfRangeException(nameof(person.Id));

            personEntity.Name = person.Name;
            personEntity.Age = person.Age;
            personEntity.Gender = person.Gender;
            personEntity.Email = person.Email;
        }
    }
}