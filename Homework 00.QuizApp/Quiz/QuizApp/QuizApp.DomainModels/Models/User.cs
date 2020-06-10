using QuizApp.DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.DomainModels.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }
        public User()
        {

        }
        public User(string firstName, string lastName, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = lastName;
            Password = password;
        }
    }
}
