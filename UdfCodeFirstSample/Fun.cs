using System;
using System.Data.Entity;

namespace UdfCodeFirstSample
{
    public static class Fun
    {
        [DbFunction("CodeFirstDatabaseSchema", "GetAge")]
        public static int? GetAge(DateTime? birthDate)
        {
            // this in-memory implementation will not be invoked when working on LINQ to Entities
            int? age = null;
            if (birthDate.HasValue)
            {
                DateTime today = DateTime.Today;
                age = today.Year - birthDate.Value.Year;
                if (birthDate > today.AddYears(-age.Value))
                {
                    age--;
                }
            }
            return age;
        }
    }
}