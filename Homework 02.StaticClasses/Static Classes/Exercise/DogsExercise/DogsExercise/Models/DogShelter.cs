using System;
using System.Collections.Generic;
using System.Text;

namespace DogsExercise.Models
{
    public static class DogShelter
    {
        public static List<Dog> Dogs;
        static DogShelter()
        {
            Dogs = new List<Dog>();
        }
        public static void PrintAll()
        {
            foreach (Dog dog in Dogs)
            {
                Console.WriteLine($"Hello my name is {dog.Name} and I have a {dog.Color} fur!");
            }
        }
    }
}
