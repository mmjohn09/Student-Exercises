using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort 
    {
        public string CohortName { get; set; }
        public List<Student> StudentList = new List<Student>();
        public List<Instructor> InstructorList = new List<Instructor>();
    }
}