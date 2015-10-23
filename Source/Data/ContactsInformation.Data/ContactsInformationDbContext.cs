namespace ContactsInformation.Data
{
    using System.Data.Entity;

    using ContactsInformation.Data.Models;

    public class ContactsInformationDbContext : DbContext
    {
        public ContactsInformationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
