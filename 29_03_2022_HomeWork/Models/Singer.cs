using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_03_2022_HomeWork.Models
{
    internal class Singer
    {
        private string _name;
        private string _surname;
        private int _age;
        public Singer(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age; 
        }
        public string Name { get { return _name; } 
            set 
            {
                if (value.Length <= 100) _name = value;
            }
        }
        public string Surname { get { return _surname; } 
            set 
            {
                if (value.Length <= 100) _surname = value; 
            } 
        }
        public int Age { get { return _age; } 
            set 
            {
                if (value>=0 && value <= 170) _age = value; 
            } 
        }

    }
}
