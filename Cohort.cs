using System;
using System.Collections.Generic;
using System.Linq;

namespace student_exercises_c2
{
    class Cohort {
        public Cohort(string name){
            CohortName = name;
        }
        public string CohortName {get; set;}
        public List<Student> StudentList {get; set;} = new List<Student>();
        public List<Instructor> InstructorList {get; set;} = new List<Instructor>();

        public Student FindByStudentByName(string studentName){
            Student foundStudent = StudentList.First(singleStudent => singleStudent.FirstName == studentName);
            return foundStudent;
        }
    }
}