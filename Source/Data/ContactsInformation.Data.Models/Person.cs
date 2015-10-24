namespace ContactsInformation.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using ContactsInformation.Data.Common.Models;

    public class Person : DeletableEntity, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }

        public string Sex { get; set; }

        public string PhoneNumber { get; set; }

        public string PhotoUrl { get; set; }

        public string Status { get; set; }
    }
}
