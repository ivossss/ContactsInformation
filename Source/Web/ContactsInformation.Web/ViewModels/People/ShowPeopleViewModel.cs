namespace ContactsInformation.Web.ViewModels.People
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

        public string Status { get; set; }

        public string Sex { get; set; }

        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}