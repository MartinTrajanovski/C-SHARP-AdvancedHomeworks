using QuizApp.DomainModels.Models;
using QuizApp.Services;
using System;

namespace QuizApp
{
    class Program
    {
        private static HelperServices helperService = new HelperServices();
        private static StudentService studentService = new StudentService();
        private static TeacherService teacherService = new TeacherService();
        private static Student loggedStudent = null;
        private static Teacher loggedTeacher = null;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int roleChoice;
                int tries = 0;
                while (true)
                {
                    Console.WriteLine("Welcome to our Quizz App!");
                    Console.WriteLine("Are you a teacher, or a student?");
                    Console.WriteLine("1) Teacher\n2) Student");
                    roleChoice = helperService.ValidatePositiveNumber(Console.ReadLine(), 2);
                    if (roleChoice != 1 && roleChoice != 2)
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome! Press Enter to continue...");
                        Console.ReadLine();
                        break;
                    }
                }
                if (roleChoice == 1)
                {
                    while (tries < 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter username!");
                        string user = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Enter password!");
                        string password = Console.ReadLine();
                        loggedTeacher = teacherService.LogIn(user, password);
                        if (loggedTeacher == null)
                        {
                            helperService.ErrorMessage("Wrong username or password!");
                            tries++;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            studentService.PrintStudents();
                            Console.ReadLine();
                            break;
                        }
                        if (tries == 3)
                        {
                            Console.WriteLine("You have run out of tries! Press Enter to exit!");
                            Console.ReadLine();
                            System.Environment.Exit(0);
                        }
                    }
                }
                else if (roleChoice == 2)
                {
                    while (tries < 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter username!");
                        string user = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Enter password!");
                        string password = Console.ReadLine();
                        loggedStudent = studentService.LogIn(user, password);
                        if (loggedStudent == null)
                        {
                            Console.Clear();
                            helperService.ErrorMessage("Wrong username or password!");
                            tries++;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (loggedStudent.HasTakenExam == true)
                        {
                            Console.Clear();
                            helperService.ErrorMessage("You have already taken the exam!");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {

                            teacherService.QuizzLogic(loggedStudent);
                            break;
                        }
                        if (tries == 3)
                        {
                            Console.WriteLine("You have run out of tries! Press Enter to exit!");
                            Console.ReadLine();
                            System.Environment.Exit(0);
                        }
                    }
                }
                if (helperService.RunAgain() == false) break;
                Console.Clear();
            }
        }
    }
}
