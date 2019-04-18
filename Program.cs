using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.
            Exercise Nutshell = new Exercise("Nutshell"){
                ExerciseLanguage = "Javascript"
            };
            Exercise WelcomeToNashville = new Exercise("Welcome To Nashville"){
                ExerciseLanguage = "HTML/CSS"
            };
            Exercise Capstone = new Exercise("Lawn and Order"){
                ExerciseLanguage = "React"
            };
            Exercise ThisProject = new Exercise("Student Exercises"){
                ExerciseLanguage = "C Sharp"
            };

            // Create 3, or more, cohorts.
            Cohort C30 = new Cohort("Cohort 30");
            Cohort C29 = new Cohort("Cohort 29");
            Cohort C28 = new Cohort("Cohort 28");

            // Create 4, or more, students and assign them to one of the cohorts.
            Student SamCronin = new Student("Sam", "Cronin", "croninsw") {
                cohort = C30
            };

            Student BrianNeal = new Student("Brian", "Neal", "BigDong214") {
                cohort = C29
            };

            Student AbbeyBrown = new Student("Abbey", "Brown", "theOleAB") {
                cohort = C30
            };

            Student ConnorBailey = new Student("Connor", "Bailey", "goldenRod6969420") {
                cohort = C30
            };

            Student DominicKantrude = new Student("Dominic", "Kantrude", "kanDo") {
                cohort = C30
            };

            Student KaterinaFreeman = new Student("Katerina", "Freeman", "katWoman") {
                cohort = C29
            };

            // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor SteveBrownlee = new Instructor("Steve", "Brownlee", "coach") {
                cohort = C30
            };

            Instructor JoeShepard = new Instructor("Joe", "Shepard", "joes") {
                cohort = C29
            };

            Instructor Jissie = new Instructor("Jissie", "LastName", "Jissie") {
                cohort = C28
            };

            // Have each instructor assign 2 exercises to each of the students.
            SteveBrownlee.AddExercise(SamCronin, Nutshell);
            SteveBrownlee.AddExercise(SamCronin, Capstone);
            SteveBrownlee.AddExercise(BrianNeal, WelcomeToNashville);
            SteveBrownlee.AddExercise(BrianNeal, Capstone);
            SteveBrownlee.AddExercise(AbbeyBrown, ThisProject);
            SteveBrownlee.AddExercise(AbbeyBrown, WelcomeToNashville);
            SteveBrownlee.AddExercise(ConnorBailey, ThisProject);
            SteveBrownlee.AddExercise(ConnorBailey, Nutshell);

            JoeShepard.AddExercise(SamCronin, WelcomeToNashville);
            JoeShepard.AddExercise(SamCronin, ThisProject);
            JoeShepard.AddExercise(BrianNeal, WelcomeToNashville);
            JoeShepard.AddExercise(BrianNeal, Capstone);
            JoeShepard.AddExercise(AbbeyBrown, ThisProject);
            JoeShepard.AddExercise(AbbeyBrown, WelcomeToNashville);
            JoeShepard.AddExercise(ConnorBailey, ThisProject);
            JoeShepard.AddExercise(ConnorBailey, Nutshell);

            Jissie.AddExercise(SamCronin, Nutshell);
            Jissie.AddExercise(SamCronin, Capstone);
            Jissie.AddExercise(BrianNeal, WelcomeToNashville);
            Jissie.AddExercise(BrianNeal, Capstone);
            Jissie.AddExercise(AbbeyBrown, ThisProject);
            Jissie.AddExercise(AbbeyBrown, WelcomeToNashville);
            Jissie.AddExercise(ConnorBailey, ThisProject);
            Jissie.AddExercise(ConnorBailey, Nutshell);
            Jissie.AddExercise(ConnorBailey, WelcomeToNashville);
            Jissie.AddExercise(ConnorBailey, Capstone);

            List<Student> students = new List<Student>(){
                SamCronin,
                BrianNeal,
                AbbeyBrown,
                ConnorBailey,
                DominicKantrude
            };

            List<Exercise> exercises = new List<Exercise>(){
                WelcomeToNashville,
                ThisProject,
                Nutshell,
                Capstone
            };

            List<Instructor> instructors = new List<Instructor>(){
                SteveBrownlee,
                JoeShepard,
                Jissie
            };

            List<Cohort> cohorts = new List<Cohort>(){
                C30,
                C29,
                C28
            };

            IEnumerable<Exercise> jsExercises = from ex in exercises
                where ex.ExerciseLanguage == "Javascript"
                select ex;

                // foreach(Exercise ex in jsExercises)
                // {
                //     Console.WriteLine($"{ex}");
                // }

            IEnumerable<Student> studentsInCohort = from s in students
                where s.cohort == C30
                select s;

                // foreach(Student student in studentsInCohort)
                // {
                //     Console.WriteLine($"{student.FullName}");
                // }

            IEnumerable<Instructor> instructorsInCohort = from i in instructors
                where i.cohort == C30
                select i;

                // foreach(Instructor i in instructorsInCohort)
                // {
                //     Console.WriteLine(i.FullName);
                // }

            IEnumerable<Student> studentsByLastName = from s in students
                orderby s.LastName ascending
                select s;

                // foreach(Student s in studentsByLastName)
                // {
                //     Console.WriteLine(s.FullName);
                // }

            IEnumerable<Student> notWorkingOnExercises = students.Where(student => student.Exercises.Count == 0);

                // foreach(Student s in notWorkingOnExercises)
                // {
                //     Console.WriteLine(s.FullName);
                // }

            Student doingTheMostWork = students.OrderByDescending(student => student.Exercises.Count).First();

                // Console.WriteLine($"Student with most exercises: {doingTheMostWork.FullName}");

            foreach(Cohort cohort in cohorts)
            {
                Console.WriteLine($"{cohort.CohortName} has {cohort.Students.Count} students.");
            }








            // foreach(Student student in students)
            // {
            //     foreach(Exercise exercise in exercises)
            //     {
            //         Console.WriteLine($"{student.FullName} is working on {exercise.ExerciseName}");
            //     }
            // }
        }
    }
}






