using PersonHub.Services.Persons;
using PersonHub.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonHub.Controllers
{
    public class PersonaController : Controller
    {
        private readonly PersonService _personService;
        public PersonaController()
        {
            _personService = new PersonService(new Repositories.Persons.PersonRepository());
        }
        // GET: Persona
        public ActionResult Index()
        {
            return View(_personService.PersonaList());
        }

        public ActionResult Details(int id)
        {
            return View(_personService.PersonaDetail(id));
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.GenderDropDown = GenderDropDown();
            return View(new Persona());
        }

        [HttpPost]
        public ActionResult Create(Persona persona)
        {
            try
            {
                _personService.InsertPersona(persona);
            }
            catch (Exception ex)
            {
                ViewBag.GenderDropDown = GenderDropDown();
                ViewBag.Error = ex.Message;
                return View(persona);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.GenderDropDown = GenderDropDown();
            return View(_personService.PersonaDetail(id));
        }

        [HttpPost]
        public ActionResult Edit(Persona persona)
        {
            try
            {
                _personService.UpdatePersona(persona);
            }
            catch (Exception ex)
            {
                ViewBag.GenderDropDown = GenderDropDown();
                ViewBag.Error = ex.Message;
                return View(persona);
            }

            return RedirectToAction("Index");
        }

        private List<SelectListItem> GenderDropDown()
        {
            var items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "Femenino", Value = "0" });
            items.Add(new SelectListItem { Text = "Masculino", Value = "1" });

            return items;
        }
    }
}