using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorStudent
{
    public class Student
    {
        public bool IsSenior { get; set; }
        public bool IsAlive { get; set; }
        public Classes CurrentClasses { get; set; }

        public Student()
        {
            IsSenior = true;
            IsAlive = true;
        }

        public void PickCourse(String courseName)
        {
            CurrentClasses = new Classes();
            CurrentClasses.AddClass(courseName);
        }

        public void StudyForExam(TextBook book)
        {
            if (book.HasBeenRead == true)
            {
                IsAlive = true;
            }
            else
            {
                Die();
            }

        }

        public void Procrastinate(TextBook book)
        {
            book.DrinkBeerInstead();
        }

        public void Die()
        {
            IsAlive = false;
            Console.WriteLine("You are dead");
        }
    }
}
