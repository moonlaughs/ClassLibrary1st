using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1st
{
    public class Teacher : Person
    {
        private int _salary;

        public int Salary
        {
            get => _salary;
            set { if (value >= 10000)
                    _salary = value;
                else throw new ArgumentOutOfRangeException();

            }
        }

        public Teacher()
        {
            _salary = Salary;
        }

        public override string ToString()
        {
            return $"{Salary}";
        }
    }
}
