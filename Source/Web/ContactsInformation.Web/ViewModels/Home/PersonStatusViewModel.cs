namespace ContactsInformation.Web.ViewModels.Home
{
    using System.ComponentModel.DataAnnotations;

    using ContactsInformation.Data.Models;
    using ContactsInformation.Web.Infrastructure.Mapping;

    public class PersonStatusViewModel : IMapFrom<Person>
    {
        [Required]
        public int Id { get; set; }

        public string Status { get; set; }
    }
}