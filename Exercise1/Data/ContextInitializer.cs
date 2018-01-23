using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exercise1.Models;
using System.Data.Entity;

namespace Exercise1.Data
{
    public class ContextInitializer: DropCreateDatabaseIfModelChanges<CoreContext>
    {
        protected override void Seed(CoreContext context)
        {
            var users = new List<User>
            {
                new User() {FirstName="John", MidName="Frank", LastName="Doe", DOB=DateTime.Parse("1980-01-01") },
                new User() {FirstName="Jane", MidName="Frank", LastName="Doe", DOB=DateTime.Parse("1986-01-01") },
                new User() {FirstName="Mary", MidName="Frank", LastName="Doe", DOB=DateTime.Parse("1972-01-01") },
                new User() {FirstName="Mary", MidName="Frank", LastName="Doe", DOB=DateTime.Parse("1975-01-01") }
            };
            users.ForEach(u => context.Users.Add(u));
            base.Seed(context);

        }
    }
}