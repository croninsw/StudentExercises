using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        // private string to make cohort unique
        private string _cohortName { get; set; }

        // public list of students currently enrolled
        public List<Student> Students = new List<Student>();

        // public list of instructors currently working
        public List<Instructor> Instructors = new List<Instructor>();




        // when the cohort is instantiated, set the private class of name to the name you give it
        public Cohort(string name) {
            _cohortName = name;
        }

        public string CohortName
        {
            get
            {
                return _cohortName;
            }
        }
    }
}