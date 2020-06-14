using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Classes
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User(int id, string name, string username, string pass)
        {
            this.Id = id;
            this.Name = name;
            this.Username = username;
            this.Password = pass;
        }

        public virtual void PrintUser()
        {
            Console.WriteLine($"Id:{Id} | Name: {Name} | Username: {Username}");
        }
    }
}
