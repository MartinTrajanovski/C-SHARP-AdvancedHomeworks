using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class PetStore<T> where T : Pet
    {
        public List<T> Pets;

        public PetStore()
        {
            Pets = new List<T>();
        }
        public void PrintPets()
        {
            foreach (T pet in Pets)
            {
                Console.WriteLine(pet.PrintInfo());
            }
        }
        public void BuyPet(string name)
        {
            T pet = Pets.FirstOrDefault(x => x.Name == name);
            if (pet == null)
            {
                Console.WriteLine($"The name of the pet was not found in {pet.GetType().Name} the Pet Store!");
                return;
            }
            Pets.Remove(pet);
            Console.WriteLine($"You have bought a pet from {pet.GetType().Name} the Pet Store!");
        }
    }
}
