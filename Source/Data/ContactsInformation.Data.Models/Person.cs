namespace ContactsInformation.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using ContactsInformation.Data.Common.Models;

    public class Person : DeletableEntity, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Sex { get; set; }

        public string PhoneNumber { get; set; }

        public string PhotoPath { get; set; }

        public string Status { get; set; }
    }
}
