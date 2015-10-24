namespace ContactsInformation.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using ContactsInformation.Data.Common.Repositories;
    using ContactsInformation.Data.Models;
    using ContactsInformation.Web.ViewModels.Home;

    public class HomeController : Controller
    {
        private readonly IDeletableEntityRepository<Person> peopleRepository;

        public HomeController(IDeletableEntityRepository<Person> peopleDeletableRepository)
        {
            this.peopleRepository = peopleDeletableRepository;
        }

        public ActionResult Index()
        {
            var people = this.peopleRepository
                .All()
                .OrderBy(p => p.FirstName)
                .ProjectTo<ShowPeopleViewModel>();

            return this.View(people);
        }
    }
}