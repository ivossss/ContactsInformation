namespace ContactsInformation.Data
{
    using System.Data.Entity;

    using ContactsInformation.Data.Models;
    using ContactsInformation.Data.Migrations;

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
