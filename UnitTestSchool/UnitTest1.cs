using ClassLibrary1st;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestSchool
{
    [TestClass]
    public class UnitTest1
    {
        Student st = new Student();
        Person pr = new Person();
        Teacher te = new Teacher();

        [TestMethod]
        public void TestMethod1()
        {
            st.Name = "Iza";
            Assert.AreEqual("Iza", st.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEx()
        {
            st.Name = "K";
        }

        [TestMethod]
        public void TestMethod2()
        {
            st.Address = "Ro";
            Assert.AreEqual("Ro", st.Address);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEx2()
        {
            st.Address = null;
        }

        [TestMethod]
        public void TestMethod3()
        {
            st.Semester = 1;
            Assert.AreEqual(1, st.Semester);

            st.Semester = 8;
            Assert.AreEqual(8, st.Semester);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEx3()
        {
            st.Semester = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEx3b()
        {
            st.Semester = 9;
        }

        [TestMethod]
        public void TestMethod4()
        {
            st.GenderProperty = Student.Gender.female;
            Assert.AreEqual(Student.Gender.female, st.GenderProperty);

            st.GenderProperty = Student.Gender.male;
            Assert.AreEqual(Student.Gender.male, st.GenderProperty);
        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void TestEx4()
        //{
        //    //st.GenderProperty = "men";      no exception, enum is not flexible
        //}

        [TestMethod]
        public void TestMethod5()
        {
            te.Name = "MArta";
            Assert.AreEqual("MArta", te.Name);

            te.Address = "CPH";
            Assert.AreEqual("CPH", te.Address);

            te.GenderProperty = Person.Gender.female;
            Assert.AreEqual(Person.Gender.female, te.GenderProperty);

            te.Salary = 10000;
            Assert.AreEqual(10000, te.Salary);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Exceptions5()
        {
            te.Address = null;

            //te.Name = "K";

            //te.Salary = 9999;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Exceptions6()
        {
            te.Name = "K";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Exceptions7()
        {
            te.Salary = 9999;
        }

        [TestMethod]
        public void TestHash()
        {
            pr.GetHashCode();
            Assert.AreEqual(1187620530, pr.GetHashCode());
        }

        [TestMethod]
        public void TestBeforeCodeEquals()
        {
            st.GenderProperty = Person.Gender.female;
            st.Equals(st.GenderProperty);
            Assert.AreEqual(true, st.Equals(st.GenderProperty));
        }
    }
}
