using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonHub.ViewModels
{
    public class Persona
    {
        public Persona()
        {

        }
        public Persona(int id, string nombre, int edad, int sexo, string email)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Email = email;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Sexo { get; set; }
        public string Email { get; set; }
    }
}