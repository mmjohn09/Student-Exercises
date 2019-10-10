using System;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise ChickenMonkey = new Exercise()
            {
                ExerciseName = "Chicken Monkey",
                Language = "Javascript"
            };

            Exercise UrbanPlanner = new Exercise()
            {
                ExerciseName = "Urban Planner",
                Language = "C#"
            };

            Exercise Kennel = new Exercise()
            {
                ExerciseName = "Kennel",
                Language = "React Js"
            };

            Exercise DailyJournal = new Exercise()
            {
                ExerciseName = "Daily Journal",
                Language = "Javascript"
            };

            Cohort DayThirtyFour = new Cohort()
            {
                CohortName = "Day Cohort 34",
                StudentList 
                InstructorList
            };

            Cohort DayThirtyFive = new Cohort()
            {
                CohortName = "Day Cohort 35",
                StudentList 
                InstructorList
            };

            Cohort NightTen = new Cohort()
            {
                CohortName = "Night Cohort 10",
                StudentList 
                InstructorList
            };

            Student Maggie = new Student()
            {
                FirstName = "Maggie",
                LastName = "Johnson",
                SlackHandle = "@mj",
                Cohort = "Day Cohort 34"
                AssignedExercises 
            };

            Student John = new Student()
            {
                FirstName = "John",
                LastName = "Johnson",
                SlackHandle = "@JohnJohnson",
                Cohort = "Night Cohort 10",
                AssignedExercises
            };

            Student Sarah = new Student()
            {
                FirstName = "Sarah",
                LastName = "Fleming",
                SlackHandle = "@SarahF",
                Cohort = "Day Cohort 34",
                AssignedExercises
            };

            Student Leigh = new Student()
            {
                FirstName = "Leigh",
                LastName = "Rogers",
                SlackHandle = "@LeighRogers",
                Cohort = "Day Cohort 35"
            };

            Instructor Andy = new Instructor()
            {
                FirstName = "Andy",
                LastName = "Collins",
                SlackHandle = "@Andy",
                Cohort = "Day Cohort 34"
            }
        }
    }
}
