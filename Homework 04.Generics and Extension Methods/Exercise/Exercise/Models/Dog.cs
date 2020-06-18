using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public List<string> FavouriteFood { get; set; }
        public override string PrintInfo()
        {
            return $"My name is {Name}! I am a {Age} year old {Type}!";
        }
    }
}
