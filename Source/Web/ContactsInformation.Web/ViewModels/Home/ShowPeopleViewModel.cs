namespace ContactsInformation.Web.ViewModels.Home
{
    using ContactsInformation.Data.Models;
    using ContactsInformation.Web.Infrastructure.Mapping;
    using System.ComponentModel.DataAnnotations;

    public class ShowPeopleViewModel : IMapFrom<Person>
    {
        public int Id { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }
    }
}