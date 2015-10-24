namespace ContactsInformation.Web.ViewModels.Home
{
    using System.ComponentModel.DataAnnotations;

    using ContactsInformation.Data.Models;
    using ContactsInformation.Web.Infrastructure.Mapping;

    public class ShowPeopleViewModel : IMapFrom<Person>
    {
        public int Id { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }
    }
}