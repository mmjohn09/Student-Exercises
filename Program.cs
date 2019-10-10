using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise ChickenMonkey = new Exercise();
            ChickenMonkey.ExerciseName = "Chicken Monkey";
            ChickenMonkey.Language = "Javascript";
            
            

            Exercise UrbanPlanner = new Exercise();
            UrbanPlanner.ExerciseName = "Urban Planner";
            UrbanPlanner.Language = "C#";
            

            Exercise Kennel = new Exercise();
            Kennel.ExerciseName = "Kennel";
            Kennel.Language = "React Js";
            

            Exercise DailyJournal = new Exercise();
            DailyJournal.ExerciseName = "Daily Journal";
            DailyJournal.Language = "Javascript";

            
            Cohort DayThirtyFour = new Cohort();
            DayThirtyFour.CohortName = "Day Cohort 34";
            

            Cohort DayThirtyFive = new Cohort();
            DayThirtyFive.CohortName = "Day Cohort 35";

            
            Cohort NightTen = new Cohort();
            NightTen.CohortName = "Night Cohort 10";
            
        
            Student Maggie = new Student();
            Maggie.FirstName = "Maggie";
            Maggie.LastName = "Johnson";
            Maggie.SlackHandle = "@mj";
            Maggie.Cohort = "Day Cohort 34";
            

            Student John = new Student();
            John.FirstName = "John";
            John.LastName = "Johnson";
            John.SlackHandle = "@JohnJohnson";
            John.Cohort = "Night Cohort 10";
        

            Student Sarah = new Student();
            Sarah.FirstName = "Sarah";
            Sarah.LastName = "Fleming";
            Sarah.SlackHandle = "@SarahF";
            Sarah.Cohort = "Day Cohort 34";
            

            Student Leigh = new Student();
            Leigh.FirstName = "Leigh";
            Leigh.LastName = "Rogers";
            Leigh.SlackHandle = "@LeighRogers";
            Leigh.Cohort = "Day Cohort 35";
    

            Instructor Andy = new Instructor();
            Andy.FirstName = "Andy";
            Andy.LastName = "Collins";
            Andy.SlackHandle = "@Andy";
            Andy.Cohort = "Day Cohort 34";
            Andy.Specialty = "Invented C#";

            Instructor Steve = new Instructor();
            Steve.FirstName = "Steve";
            Steve.LastName = "Brownlee";
            Steve.SlackHandle = "@Coach";
            Steve.Cohort = "Day Cohort 35";
            Steve.Specialty = "Python";

            Instructor Bryan = new Instructor();
            Bryan.FirstName = "Bryan";
            Bryan.LastName = "Nilsen";
            Bryan.SlackHandle = "@BryFive";
            Bryan.Cohort = "Night Cohort 10";
            Bryan.Specialty = "High Fives";


            Andy.AssignExercise(ChickenMonkey, Maggie);
            Andy.AssignExercise(Kennel, Sarah);
            Andy.AssignExercise(ChickenMonkey, John);
            Bryan.AssignExercise(Kennel, John);
            Bryan.AssignExercise(UrbanPlanner, Maggie);
            Bryan.AssignExercise(UrbanPlanner, Sarah);
            Steve.AssignExercise(ChickenMonkey, Leigh);
            Steve.AssignExercise(DailyJournal, Leigh);


            List<Student> students = new List<Student>();
            students.Add(Maggie);
            students.Add(John);
            students.Add(Sarah);
            students.Add(Leigh);

            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(ChickenMonkey);
            exercises.Add(Kennel);
            exercises.Add(DailyJournal);
            exercises.Add(UrbanPlanner);

            foreach(Student student in students)
            {
                foreach(Exercise exercise in student.AssignedExercises)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is working on {exercise.ExerciseName}");
                }
            }

        }
    }
}
