using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableCollege.ViewModel;

namespace TableCollege.Model
{
   public class User
    {
        private string _name;
        private string _password;
        private string _userName;
        private string _role;
        private string _description;
        private string _teacher;
        private string _image;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Password
        {
            get => _password;
            set => _password = HashCode.GetHashCode(value);
        }
        public string UserName
        {
            get => _userName;
            set => _userName = value;
        }
        public string Role
        {
            get => _role;
            set => _role = value;
        }
        public string Image
        {
            get => _image;
            set => _image = value;
        }
      
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public string Teacher
        { 
          get => _teacher;
          set => _teacher = value; 
        }

        public User(string name, string password, string username, string role, string description, string teacher, string image)
        {
            Name = name;
            Password = password;
            UserName = username;
            Role = role;
            Image = image;
            Description = description;
            Teacher = teacher;
            
        }
    }
}
