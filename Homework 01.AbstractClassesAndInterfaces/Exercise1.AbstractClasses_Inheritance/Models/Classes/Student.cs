using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Classes
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }

        public Student(int id, string name, string usename, string pass, List<int> grades)
            :base(id, name, usename, pass)
        {
            this.Grades = grades;
        }

        public override void PrintUser()
        {
            foreach (int grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
