using System;
using System.Collections.Generic;
using System.Text;

namespace DogsExercise.Models
{
   public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }

        public static bool Validate(Dog dog)
        {
            if(dog.Id>=0 && dog.Name.Length >= 2 && dog.Color != null)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
