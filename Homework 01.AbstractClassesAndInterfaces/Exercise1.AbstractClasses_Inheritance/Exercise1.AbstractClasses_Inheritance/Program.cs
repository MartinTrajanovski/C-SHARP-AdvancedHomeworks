using Models.Classes;
using System;
using System.Collections.Generic;

namespace Exercise1.AbstractClasses_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacherMartin = new Teacher(1, "Martin Trajanovski", "martin_tra", "123", new List<string> { "C#", "JS" });
            Teacher teacherMarko = new Teacher(2, "Marko Trajanovski", "marko_tra", "321", new List<string> { "HTML", "CSS" });

            Student studentIvan = new Student(1, "Ivan Petrusevski", "ivan_pet", "543", new List<int> { 5, 5, 5 });
            Student studentJovana = new Student(2, "Jovana Arsoska", "jovana_ars", "876", new List<int> { 4, 4, 5 });

            Console.WriteLine("++++++Teacher++++++++");
            teacherMartin.PrintUser();
            teacherMarko.PrintUser();
            Console.WriteLine("+++++Student+++++++++");
            studentIvan.PrintUser();
            studentJovana.PrintUser();
            
            Console.ReadLine();
        }
    }
}
