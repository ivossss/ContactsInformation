namespace ContactsInformation.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Text;

    using ContactsInformation.Data.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactsInformationDbContext>
    {
        private readonly Random random = new Random();

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ContactsInformationDbContext context)
        {
            if (context.People.Any())
            {
                return;
            }

            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] numbers = "0123456789".ToCharArray();
            for (int i = 0; i < 20; i++)
            {
                var newPerson = new Person();
                newPerson.FirstName = this.GenerateRandomString(5, letters);
                newPerson.LastName = this.GenerateRandomString(7, letters);
                newPerson.Sex = this.GetRandomNumber(2) == 1 ? "Male" : "Female";
                newPerson.PhoneNumber = this.GenerateRandomString(9, numbers);
                context.People.Add(newPerson);
            }
        }

        private string GenerateRandomString(int length, char[] allowedChars)
        {
            StringBuilder builder = new StringBuilder();
            int randomNumber;

            for (int i = 0; i < length; i++)
            {
                randomNumber = this.GetRandomNumber(allowedChars.Length);
                builder.Append(allowedChars[randomNumber]);
            }

            return builder.ToString();
        }

        private int GetRandomNumber(int maxValue)
        {            
            return this.random.Next(maxValue);
        }
    }
}
