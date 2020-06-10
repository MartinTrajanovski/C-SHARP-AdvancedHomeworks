using QuizApp.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Services
{
    public class StudentService
    {
        public List<Student> Students { get; set; }
        public StudentService()
        {
            Students = new List<Student>()
            {
                new Student
                {
                    FirstName = "Marko",
                    LastName = "Trajanovski",
                    Username = "marko_marko",
                    Password = "marko123",
                    Role = DomainModels.Enums.Roles.Student
                },
                new Student
                {
                    FirstName = "Ivan",
                    LastName = "Ivanovski",
                    Username = "ivan_ivan",
                    Password = "ivan123",
                    Role = DomainModels.Enums.Roles.Student
                },
                new Student
                {
                    FirstName = "Jovana",
                    LastName = "Jovanovska",
                    Username = "jovana_jovana",
                    Password = "jovana123",
                    Role = DomainModels.Enums.Roles.Student
                },
                new Student
                {
                    FirstName = "Martina",
                    LastName = "Martinovska",
                    Username = "marta_marta",
                    Password = "marta123",
                    Role = DomainModels.Enums.Roles.Student
                }
            };
        }
        public void PrintStudents()
        {
            foreach (Student student in Students)
            {
                if (student.Grade == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{student.FirstName} {student.LastName} | Grade: {student.Grade}");
                }
            }
            Console.ResetColor();
        }
        public Student LogIn(string username, string password)
        {
            foreach (Student student in Students)
            {
                if (student.Username == username && student.Password == password)
                    return student;
            }
            return null;
        }
    }
}
