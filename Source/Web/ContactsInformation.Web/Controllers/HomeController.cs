namespace ContactsInformation.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using ContactsInformation.Data.Common.Repositories;
    using ContactsInformation.Data.Models;

    public class HomeController : Controller
    {
        private readonly IDeletableEntityRepository<Person> peopleRepository;

        public HomeController(IDeletableEntityRepository<Person> peopleDeletableRepository)
        {
            this.peopleRepository = peopleDeletableRepository;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}