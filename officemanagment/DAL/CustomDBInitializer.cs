using officemanagment.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace officemanagment.DAL
{
    internal class CustomDBInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<userContext>
    {
        protected override void Seed(userContext context)
        {
            var users = new List<user>
            {
                new user() {username ="LIKU", password = "Liku@123", email ="Liku@gmail.com" },
                 new user() {username ="Miku", password = "Miku@123", email ="Miku@gmail.com" },
                  new user() {username ="CIKU", password = "Ciku@123", email ="Ciku@gmail.com" }
            };
            users.ForEach(s  => context.SaveChanges());
            context.SaveChanges();

        }
    }
}