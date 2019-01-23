using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1st
{
    public class Person : IEquatable<Person>
    {
        private string _name;
        private string _address;

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length >= 2)
                    _name = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                if (value != null)
                    _address = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public enum Gender       // "Gender" is a type like string or int
        {
            female,
            male
        }

        public Gender GenderProperty { get; set; }

        public Person()
        {
            _name = Name;
            _address = Address;
        }

        public override string ToString()
        {
            return $"{Name}, {Address}, {GenderProperty}";
        }
        
        public double Password { get; set; }
        public double ImagineryNumber { get; set; }

        public override int GetHashCode()
        {
            var hashCode = 8999889;
            hashCode = hashCode * 98 + Password.GetHashCode();
            hashCode = hashCode * 89 + ImagineryNumber.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            return other != null &&
                   GenderProperty == other.GenderProperty;
        }
    }
}
