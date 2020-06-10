using QuizApp.DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.DomainModels.Models
{
    public class Teacher : User
    {
        public Teacher()
        {

        }

        public Teacher(string firstName, string lastName, string username, string password)
            : base(firstName, lastName, username, password)
        {
            Role = Roles.Teacher;
        }
    }
}
