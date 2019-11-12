using System;

namespace student_exercises_c2
{
    class Instructor{
        public int id {get;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string SlackHandle {get; set;}
        public Cohort Cohort {get; set;}

        public string Specialty {get; set;}

        public void AssignExerciseToStudent(Exercise exerciseToAssign, Student victim){
            victim.assignedExercises.Add(exerciseToAssign);
        }

        public void AssignStudentToCohort(Student studentToAssign, Cohort cohort){
            cohort.StudentList.Add(studentToAssign);
        }

    }
}