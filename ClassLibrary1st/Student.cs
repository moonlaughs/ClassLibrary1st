using System;

namespace ClassLibrary1st
{
    public class Student : Person
    {
        //private string _name;
        //private string _address;
        private int _semester;

        //public string Name
        //{
        //    get => _name;
        //    set { if (value.Length >= 2)
        //            _name = value;
        //        else throw new ArgumentOutOfRangeException();
        //    }
        //}

        //public string Address
        //{
        //    get => _address;
        //    set
        //    {
        //        if (value != null)
        //            _address = value;
        //        else throw new ArgumentOutOfRangeException();
        //    }
        //}

        public int Semester
        {
            get => _semester;
            set
            {
                if (value >= 1 && value <= 8)
                    _semester = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        //private string _gender;
        //public enum Gender       // "Gender" is a type like string or int
        //{
        //    female,
        //    male
        //}

        //public Gender GenderProperty { get; set; }     // enum is not flexible that is why we do not need to check any conditions
        //{
        //    get => _gender;
        //    set
        //    {
        //        if((value == Gender.female.ToString() || (value == Gender.male.ToString())))
        //        {
        //            _gender = value;
        //        }
        //        else throw new ArgumentOutOfRangeException();
        //    }
        //}

        public Student()
        {
            _semester = Semester;
        }

        public override string ToString()
        {
            return $"{Semester}";
        }

        
    }
}
