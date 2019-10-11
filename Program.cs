using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create list of exercises
            Exercise ChickenMonkey = new Exercise("Chicken Monkey", "Javascript");
            Exercise Kennel = new Exercise("Kennel", "Javascript");
            Exercise DailyJournal = new Exercise("Daily Journal", "Javascript");
            Exercise UrbanPlanner = new Exercise("Urban Planner", "C#");
            Exercise LinqList = new Exercise("Linq List", "C#");
            Exercise Heist = new Exercise("Heist", "C#");
            Exercise Bangazon = new Exercise("Bangazon", "Python");

            //Create Cohorts
            Cohort DayThirtyThree = new Cohort("Day Cohort 33");
            Cohort DayThirtyFour = new Cohort("Day Cohort 34");
            Cohort DayThirtyFive = new Cohort("Day Cohort 35");
            Cohort EveningTen = new Cohort("Evening Cohort 10");

            //Create students
            Student Shane = new Student("Shane", "Wilson", "@ShaneGang", "Day Cohort 33");
            Student Maggie = new Student("Maggie", "Johnson", "@mj", "Day Cohort 34");
            Student Sarah = new Student("Sarah", "Fleming", "@SarahF", "Day Cohort 34");
            Student Bennett = new Student("Bennett", "Foster", "@BennyAndTheJets", "Day Cohort 34");
            Student Leigh = new Student("Leigh", "Rogers", "@LeighRogerThat", "Day Cohort 35");
            Student Caroline = new Student("Caroline", "Brownlee", "@CarolineBee", "Day Cohort 35");
            Student John = new Student("John", "Johnson", "@JohnJohn", "Evening Cohort 10");
            Student Kelly = new Student("Kelly", "Coles", "@KColes", "Evening Cohort 10");
            Student Michael = new Student("Michael", "Stiles", "@MStiles", "Evening Cohort 10");

            //Create instructors
            Instructor Andy = new Instructor("Andy", "Collins", "@AndyManCan", "Day Cohort 34", "Invented C#");
            Instructor Steve = new Instructor("Steve", "Brownlee", "@Coach", "Day Cohort 33", "Python");
            Instructor Bryan = new Instructor("Bryan", "Nilsen", "@BryFive", "Day Cohort 34", "High Fives");
            Instructor Jenna = new Instructor("Jenna", "Solis", "@JennaS", "Day Cohort 35", "Javascript");
            Instructor Adam = new Instructor("Adam", "Sheaffer", "@AShea", "Evening Cohort 10", "SQL");

            //Add student to a cohort
            DayThirtyThree.StudentList.Add(Shane);
            DayThirtyFour.StudentList.Add(Maggie);
            DayThirtyFour.StudentList.Add(Sarah);
            DayThirtyFour.StudentList.Add(Bennett);
            DayThirtyFive.StudentList.Add(Leigh);
            DayThirtyFive.StudentList.Add(Caroline);
            EveningTen.StudentList.Add(John);
            EveningTen.StudentList.Add(Kelly);
            EveningTen.StudentList.Add(Michael);

            //Add instructor to cohort
            DayThirtyThree.InstructorList.Add(Steve);
            DayThirtyFour.InstructorList.Add(Andy);
            DayThirtyFour.InstructorList.Add(Bryan);
            DayThirtyFive.InstructorList.Add(Jenna);
            EveningTen.InstructorList.Add(Adam);

            //Have each instructor assign some exercises to different students
            Andy.AssignExercise(Heist, Maggie);
            Andy.AssignExercise(LinqList, Maggie);
            Steve.AssignExercise(DailyJournal, Maggie);
            Bryan.AssignExercise(UrbanPlanner, Sarah);
            Bryan.AssignExercise(Kennel, Sarah);
            Jenna.AssignExercise(ChickenMonkey, John);
            Jenna.AssignExercise(Kennel, Kelly);
            Steve.AssignExercise(DailyJournal, Kelly);
            Steve.AssignExercise(Bangazon, Shane);
            Steve.AssignExercise(DailyJournal, John);
            Bryan.AssignExercise(UrbanPlanner, Maggie);
            Adam.AssignExercise(ChickenMonkey, Leigh);
            Steve.AssignExercise(DailyJournal, Leigh);

            //Create lists of students, instructors, cohorts, and exercises
            List<Student> allStudents = new List<Student>
            { Maggie, Sarah, Leigh, Kelly, John, Shane };

            List<Instructor> allInstructors = new List<Instructor>
            { Andy, Steve, Bryan, Jenna, Adam };

            List<Cohort> allCohorts = new List<Cohort>
            { DayThirtyThree, DayThirtyFour, DayThirtyFive, EveningTen };

            List<Exercise> allExercises = new List<Exercise>
            { ChickenMonkey, DailyJournal, Kennel, UrbanPlanner, Heist, LinqList, Bangazon };

            //Get all exercises that are javascript
            List<Exercise> javascriptExercises = allExercises
            .Where(exercise => exercise.Language == "Javascript").ToList();

            //Get all students in Cohort 34
            List<Student> cohort34Students = allStudents
            .Where(student => student.Cohort == "Day Cohort 34").ToList();

            //Get all instructors in Cohort 34
            List<Instructor> cohort34Instructors = allInstructors
            .Where(instructor => instructor.Cohort == "Day Cohort 34").ToList();

            //Sort students in alphabetical order by last name
            List<Student> studentLastNameSort = allStudents
            .OrderBy(student => student.LastName).ToList();

            //Get any students not assigned an exercise
            List<Student> studentsNotAssignedExercise = allStudents
            .Where(student => student.AssignedExercises.Count == 0).ToList();

            //Sort students by number of exercises assigned
            List<Student> studentsSortedByNumExercises = allStudents
            .OrderBy(student => student.AssignedExercises.Count()).ToList();

            foreach (Student student in allStudents)
            {
                foreach (Exercise exercise in student.AssignedExercises)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is working on {exercise.ExerciseName}");
                }
            }

        }
    }
}
