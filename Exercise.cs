namespace StudentExercises
{ 
    public class Exercise
    {
        public string ExerciseName { get; set; }
        public string Language { get; set; }
        public Exercise(string name, string language)
        {
            ExerciseName = name;
            Language = language;
        }
    }
}
