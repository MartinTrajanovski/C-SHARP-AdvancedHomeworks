using Models;
using System;
using System.Collections.Generic;

namespace Exercise
{
    class Program
    {
        public static PetStore<Dog> PetStoreDogs = new PetStore<Dog>();
        public static PetStore<Cat> PetStoreCats = new PetStore<Cat>();
        public static PetStore<Fish> PetStoreFish = new PetStore<Fish>();
        static void Main(string[] args)
        {
            PetStoreDogs.Pets.Add(new Dog() { Name = "Sydney", Age = 4, FavouriteFood = new List<string> { "Moussaka", "Shakshuka" }, GoodBoy = true, Type = "Labrador" });
            PetStoreDogs.Pets.Add(new Dog() { Name = "Hank", Age = 6, FavouriteFood = new List<string> { "Chicken", "Parmesan" }, GoodBoy = false, Type = "Bulldog" });

            PetStoreCats.Pets.Add(new Cat() { Name = "Louisa", Age = 55, Type = "Siamese", IsLazy = true });
            PetStoreCats.Pets.Add(new Cat() { Name = "Maria", Age = 73, Type = "Persian", IsLazy = false });

            PetStoreFish.Pets.Add(new Fish() { Name = "Phil", Age = 87, Color = "Gray", Size = 13, Type = "Neon Tetra" });
            PetStoreFish.Pets.Add(new Fish() { Name = "Harold", Age = 44, Color = "Gold", Size = 9, Type = "Platy" });

            PetStoreDogs.PrintPets();
            PetStoreCats.PrintPets();
            PetStoreFish.PrintPets();

            Console.ReadLine();
        }
    }
}
