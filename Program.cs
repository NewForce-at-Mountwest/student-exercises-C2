using System;
using System.Collections.Generic;
using System.Linq;

namespace student_exercises_c2
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise studentExercisePartOne = new Exercise()
            {
                ExerciseName = "Student Exercises Part One",
                Language = "C#"
            };

            Exercise chickenMonkey = new Exercise()
            {
                ExerciseName = "Chicken Monkey",
                Language = "JavaScript"
            };

            Exercise banksAndMillionaires = new Exercise()
            {
                ExerciseName = "Banks and Millionaires",
                Language = "C#"
            };

            Exercise kennel = new Exercise()
            {
                ExerciseName = "Kennel",
                Language = "JavaScript"
            };

            Cohort cohortTwo = new Cohort("Cohort Two");

            Student levi = new Student()
            {
                FirstName = "Levi",
                LastName = "Samples",
                Cohort = cohortTwo
            };

            Student ryan = new Student()
            {
                FirstName = "Ryan",
                LastName = "Clay",
                Cohort = cohortTwo
            };

            Student melody = new Student()
            {
                FirstName = "Melody",
                LastName = "Miller",
                Cohort = cohortTwo
            };

            Instructor jordan = new Instructor()
            {
                FirstName = "Jordan",
                LastName = "Castelloe",
                Cohort = cohortTwo
            };

            jordan.AssignExerciseToStudent(banksAndMillionaires, melody);
            jordan.AssignExerciseToStudent(banksAndMillionaires, ryan);
            jordan.AssignExerciseToStudent(studentExercisePartOne, melody);
            jordan.AssignExerciseToStudent(chickenMonkey, levi);

            Console.WriteLine("Melody's exercises:");
            melody.assignedExercises.ForEach(singleExercise => Console.WriteLine(singleExercise.ExerciseName));

            Console.WriteLine("Ryan's exercises:");
            ryan.assignedExercises.ForEach(singleExercise => Console.WriteLine(singleExercise.ExerciseName));

            Console.WriteLine("Levi's exercises:");
            levi.assignedExercises.ForEach(singleExercise => Console.WriteLine(singleExercise.ExerciseName));

            List<Student> allStudents = new List<Student>(){
                ryan, levi, melody
            };

            List<Exercise> allExercises = new List<Exercise>(){
                studentExercisePartOne, chickenMonkey, banksAndMillionaires, kennel
            };

            foreach (Exercise currentExercise in allExercises)
            {
                Console.WriteLine(currentExercise.ExerciseName);
                Console.WriteLine("-------");
                List<Student> assignedStudents = allStudents
                .Where(singleStudent => singleStudent.assignedExercises.Any(singleExercise => singleExercise.ExerciseName == currentExercise.ExerciseName)).ToList();

                assignedStudents.ForEach(singleStudent => Console.WriteLine(singleStudent.FirstName));
                Console.WriteLine();



            }

        }
    }
}
