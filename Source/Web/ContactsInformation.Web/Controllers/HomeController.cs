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
    using System.Net;

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePersonStatus(int personId)
        {
            var personFromDb = this.peopleRepository
                .GetById(personId);

            if (personFromDb == null)
            {
                 return this.HttpNotFound("Post not found");
            }

            if (personFromDb.Status == "Active")
            {
                personFromDb.Status = "Inactive";
            }
            else if (personFromDb.Status == "Inactive")
            {
                personFromDb.Status = "Active";
            }

            this.peopleRepository.Update(personFromDb);
            this.peopleRepository.SaveChanges();

            return this.Content(personFromDb.Status);
        }

        public ActionResult DeletePerson(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var personFromDb = this.peopleRepository
                .GetById(id.Value);

            if (personFromDb == null)
            {
                return this.HttpNotFound("Comment not found");
            }

            this.peopleRepository.Delete(id.Value);
            this.peopleRepository.SaveChanges();

            return this.RedirectToAction("Index");
        }
    }
}