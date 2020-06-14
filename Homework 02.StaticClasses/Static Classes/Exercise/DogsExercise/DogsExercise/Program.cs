using DogsExercise.Models;
using System;

namespace DogsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog() { Id = 1, Name = "Teodora", Color = "Yellow" };
            Dog dog2 = new Dog() { Id = 2, Name = "Filimena", Color = "Green" };
            Dog dog3 = new Dog() { Id = 3, Name = "Paraskeva", Color = "Red" };
            if (Dog.Validate(dog1) == true)
            {
                DogShelter.Dogs.Add(dog1);
            }
            else
            {
                Console.WriteLine("Smth Went Wrong!");
            }
            if (Dog.Validate(dog2) == true)
            {
                DogShelter.Dogs.Add(dog2);
            }
            else
            {
                Console.WriteLine("Smth Went Wrong!");
            }
            if (Dog.Validate(dog3) == true)
            {
                DogShelter.Dogs.Add(dog3);
            }
            else
            {
                Console.WriteLine("Smth Went Wrong!");
            }

            DogShelter.PrintAll();



            Console.ReadLine();
        }
    }
}
