using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set ;}
        public string SlackHandle { get; set; }
        public string Cohort { get; set; }
        public List<Exercise> AssignedExercises = new List<Exercise>();
        public Student(string firstName, string lastName, string slackHandle, string cohort)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
            AssignedExercises = new List<Exercise>();
        }
    }
}
