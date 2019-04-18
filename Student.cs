using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Student : NSSPerson
    {
        // private classes to set students cohort
        private Cohort _cohort { get; set; }

        // public class to allow for a student to be moved between cohorts
        public Cohort cohort {
            get {
                return _cohort;
            }
            set {
                if(_cohort != null) {
                    _cohort.Students.Remove(this);
                    _cohort = value;
                    _cohort.Students.Add(this);
                } else {
                    _cohort = value;
                    _cohort.Students.Add(this);
                }
            }
        }

        public Student(string FirstName, string LastName, string SlackName) : base(FirstName, LastName, SlackName){}

        // new List to store the exercises that a student is currently working on
        public List<Exercise> Exercises = new List<Exercise>();

    }
}