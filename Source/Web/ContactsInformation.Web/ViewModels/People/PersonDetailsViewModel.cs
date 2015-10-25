namespace ContactsInformation.Web.ViewModels.People
{
    using ContactsInformation.Data.Models;
    using ContactsInformation.Web.Infrastructure.Mapping;
    using System.ComponentModel.DataAnnotations;

    public class PersonDetailsViewModel : IMapFrom<Person>
    {
        public int Id { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        public string Sex { get; set; }

        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Photo url")]
        public string PhotoUrl { get; set; }

        public string Status { get; set; }
    }
}