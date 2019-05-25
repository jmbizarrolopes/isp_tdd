using System;

namespace Domain
{
    public class Student
    {
        public Student(string registration, string name, DateTime birthDate)
        {
            Registration = registration;
            Name = name;
            BirthDate = birthDate;
        }

        public string Registration { get; private set; }
        private string Name { get; set; }
        private DateTime BirthDate { get; set; }

        public void ChangeName(string name) =>
            Name = name;

        public void ChangeBirthDate(DateTime birthDate) =>
            BirthDate = birthDate;
    }
}