namespace SundayTechTest.Migrations
{
    using SundayTechTest.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SundayTechTest.DAL.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SundayTechTest.DAL.SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Jai",LastName="Francis",Age="34",City="Mumbai",PostalCode="1234",EmailAddress="TestEmailAddress1", EnrollmentDate=DateTime.Parse("2012-02-01")},
            new Student{FirstMidName="Viru",LastName="Fernances",Age="33",City="Mumbai",PostalCode="12345",EmailAddress="TestEmailAddress2",EnrollmentDate=DateTime.Parse("2013-03-01")},
            new Student{FirstMidName="Gabbar",LastName="Dsouza",Age="31",City="Mumbai",PostalCode="12346",EmailAddress="TestEmailAddress3",EnrollmentDate=DateTime.Parse("2014-05-01")},
            new Student{FirstMidName="Kalia",LastName="Martin",Age="30",City="Mumbai",PostalCode="12347",EmailAddress="TestEmailAddress4",EnrollmentDate=DateTime.Parse("2017-07-01")},
            new Student{FirstMidName="Shakaal",LastName="John",Age="35",City="Mumbai",PostalCode="12348",EmailAddress="TestEmailAddress5",EnrollmentDate=DateTime.Parse("2016-06-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
        }
    }
}
