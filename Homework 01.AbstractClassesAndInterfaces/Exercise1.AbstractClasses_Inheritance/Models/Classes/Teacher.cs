using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Classes
{
    public class Teacher : User, ITeacher
    {
        public List<string> Subjects { get; set; }
        public Teacher(int id, string name, string usename, string pass, List<string> subjects)
            :base(id, name, usename, pass)
        {
            this.Subjects = subjects;
        }

        public override void PrintUser()
        {
            foreach (string subject in Subjects)
            {
                Console.WriteLine(subject);
            }
        }
    }
}
