namespace ContactsInformation.Data
{
    using System.Data.Entity;

    using ContactsInformation.Data.Migrations;
    using ContactsInformation.Data.Models;

    public class ContactsInformationDbContext : DbContext
    {
        public ContactsInformationDbContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ContactsInformationDbContext, Configuration>());
        }

        public DbSet<Person> People { get; set; }
    }
}
