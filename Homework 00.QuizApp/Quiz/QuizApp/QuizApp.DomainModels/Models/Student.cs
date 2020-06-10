using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.DomainModels.Models
{
    public class Student : User
    {
        public int? Grade { get; set; }
        public bool HasTakenExam { get; set; }

        public Student()
        {

        }
    }
}
