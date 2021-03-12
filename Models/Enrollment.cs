//tinfo200:[2021-03-10-<aram2020>-dykstra1]- The enrollment entity also uses a primary key  of EnrollmentID. this holds the classname ID pattern
//which will creats a seperate ID than student ID. we have a grade enum which can also be a null grade, which is declared with the ? after the grade type in the grade property.
//student id will be a foreign key, which means it will call a key from a different property.



namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }

    }

}