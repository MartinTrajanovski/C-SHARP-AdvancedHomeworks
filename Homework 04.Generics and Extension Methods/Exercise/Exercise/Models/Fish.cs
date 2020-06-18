using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }
        public override string PrintInfo()
        {
            return $"My name is {Name}! I am a {Age} year old {Type} fish!";
        }
    }
}
