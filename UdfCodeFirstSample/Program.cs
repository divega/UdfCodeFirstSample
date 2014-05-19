using System;
using System.Data.Entity;
using System.Linq;

namespace UdfCodeFirstSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var db = new TownContext())
            {
                db.People.Add(new Person {Name = "Alfreds Futterkiste", BirthDate = new DateTime(1980, 1, 1)});
                db.SaveChanges();
            }


            using (var db = new TownContext())
            {
                var age = db.People.Select(p => new {p.Name, Age = Fun.GetAge(p.BirthDate)}).FirstOrDefault();
                Console.WriteLine(age);
            }
        }
    }

    public class TownContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(new GetAgeStoreFunctionInjectionConvention());
        }
    }
}