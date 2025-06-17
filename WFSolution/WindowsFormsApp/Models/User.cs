using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Models
{
    internal class User
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public User(string name, int age, string email, string password)
        {
            Name = name;
            Age = age;
            Email = email;
            Password = password;
        }
        public override string ToString()
        {
            return $"{Name}({Age}) ({Email})";
        }
    }
}
