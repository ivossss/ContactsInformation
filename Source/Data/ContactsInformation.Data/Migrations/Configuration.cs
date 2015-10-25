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
                newPerson.FirstName = this.GenerateRandomString(3, 10, letters);
                newPerson.LastName = this.GenerateRandomString(5, 10, letters);
                newPerson.Sex = this.GetRandomNumber(2) == 1 ? "Male" : "Female";
                newPerson.PhoneNumber = this.GenerateRandomString(5, 9, numbers);
                newPerson.Status = "Active";
                newPerson.PhotoUrl = "http://cdn3.rd.io/user/no-user-image-square.jpg";
                context.People.Add(newPerson);
            }
        }

        private string GenerateRandomString(int minLenght, int maxLenght, char[] allowedChars)
        {
            int lenght = this.GetRandomNumber(minLenght, maxLenght);
            StringBuilder builder = new StringBuilder();
            int randomNumber;

            for (int i = 0; i < lenght; i++)
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

        private int GetRandomNumber(int minValue, int maxValue)
        {
            return this.random.Next(minValue, maxValue);
        }
    }
}
