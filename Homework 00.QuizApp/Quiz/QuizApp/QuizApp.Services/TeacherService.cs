using QuizApp.DomainModels.Enums;
using QuizApp.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Services
{
    public class TeacherService
    {
        public List<Teacher> Teachers { get; set; }
        private static HelperServices helperService = new HelperServices();

        public TeacherService()
        {
            Teachers = new List<Teacher>()
            {
                new Teacher
                {
                    FirstName = "Martin",
                    LastName = "Trajanovski",
                    Username = "martin_martin",
                    Password = "martin123",
                    Role = Roles.Teacher

                }
            };
        }
        public void QuizzLogic(Student student)
        {
            int score = 0;
            int choice;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("What is the capital of Tasmania?");
                Console.WriteLine($"1. Dodoma\n2. Hobart\n3. Launceston\n4. Wellington");
                choice = helperService.ValidatePositiveNumber(Console.ReadLine(), 4);
                if (choice < 1 || choice > 4)
                {
                    Console.Clear();
                }
                else if (choice == 2)
                {
                    score += 1;
                    break;
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("What is the tallest building in the Republic of the Congo?");
                Console.WriteLine("1. Kinshasa Democratic Republic Of The Congo Temple\n2. Palais De La Nation\n3. Kongo Trade Centre\n4. Nabemba Tower");
                choice = helperService.ValidatePositiveNumber(Console.ReadLine(), 4);
                if (choice < 1 || choice > 4)
                {
                    Console.Clear();
                }
                else if (choice == 4)
                {
                    score += 1;
                    break;
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Which of these is not one of Pluto's moons?");
                Console.WriteLine("1. Styx\n2. Hydra\n3. Nix\n4. Lugia");
                choice = helperService.ValidatePositiveNumber(Console.ReadLine(), 4);
                if (choice < 1 || choice > 4)
                {
                    Console.Clear();
                }
                else if (choice == 3)
                {
                    score += 1;
                    break;
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("What is the smallest lake in the world?");
                Console.WriteLine("1. Onega Lake\n2. Benxi Lake\n3. Kivu Lake\n4. Wakatipu Lake");
                choice = helperService.ValidatePositiveNumber(Console.ReadLine(), 4);
                if (choice < 1 || choice > 4)
                {
                    Console.Clear();
                }
                else if (choice == 2)
                {
                    score += 1;
                    break;
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("What country has the largest population of alpacas?");
                Console.WriteLine("1. Chad\n2. Peru\n3. Australia\n4. Niger");
                choice = helperService.ValidatePositiveNumber(Console.ReadLine(), 4);
                if (choice < 1 || choice > 4)
                {
                    Console.Clear();
                }
                else if (choice == 2)
                {
                    score += 1;
                    break;
                }
                else
                {
                    break;
                }
            }

            if (score < 1)
            {
                student.Grade = 1;
            }
            else if (score == 1)
            {
                student.Grade = 2;
            }
            else if (score == 2)
            {
                student.Grade = 3;
            }
            else if (score == 3 || score == 4)
            {
                student.Grade = 4;
            }
            else
            {
                student.Grade = 5;
            }
            student.HasTakenExam = true;
            Console.WriteLine($"You managed to get {score} out of 5 answers right. Your grade is {student.Grade}!");
            Console.ReadLine();
        }
        public Teacher LogIn(string username, string password)
        {
            foreach (Teacher teacher in Teachers)
            {
                if (teacher.Username == username && teacher.Password == password)
                    return teacher;
            }
            return null;
        }
    }
}
