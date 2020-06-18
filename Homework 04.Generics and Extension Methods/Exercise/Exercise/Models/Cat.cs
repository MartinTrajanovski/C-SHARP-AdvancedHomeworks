using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }
        public int LivesLeft { get; set; }
        public override string PrintInfo()
        {
            return $"My name is {Name}! I am a {Age} year old {Type} cat!";
        }
    }
}
