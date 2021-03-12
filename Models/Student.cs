//tinfo200:[2021-03-10-<aram2020>-dykstra1]- This is the student class. we have a few properties to the student class.
//we have a primary key column of the data table that the student entity holds in the entity framework core. the student id will be stuck to that id and other entities will use that id for navigation
//we also have the enrollment property which is a navigation property. we can hold enrollment properties of a student entity. we also called the icollection to allow
//the navigation property to become a list.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
