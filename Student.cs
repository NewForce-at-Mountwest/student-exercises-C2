using System;
using System.Collections.Generic;
using System.Linq;

namespace student_exercises_c2
{
    class Student {

        public int id {get;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string SlackHandle {get; set;}
        public Cohort Cohort {get; set;}
        public List<Exercise> assignedExercises {get; set;} = new List<Exercise>();
    }
}