using System;
using System.Collections.Generic;
using System.Linq;
using App;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class StudentRegistrationTest
    {
        [TestMethod]
        [ExpectedException(typeof(StudentAlreadyExistsException))]
        public void CannotRegisterStudentIfAlreadyExists()
        {
            var studentRegistration = new RegisterStudent(new StudentRepositoryStub());
            
            studentRegistration.Execute(new RegisterStudentRequest
            {
                Registration = "REG001",
                Name = "John Doe",
                BirthDate = new DateTime(1993, 11, 29)
            });
        }

        private class StudentRepositoryStub : IStudentRepository
        {
            private IList<Student> _studentsList;

            public StudentRepositoryStub()
            {
                _studentsList = new List<Student>
                {
                    new Student("REG001", "John Doe", new DateTime(1993, 11, 29))
                };
            }
        
            public Student Exists(string registration)
            {
                return _studentsList.FirstOrDefault(s => s.Registration == registration);
            }

            public void Register(Student student)
            {
                throw new System.NotImplementedException();
            }

            public Student Get(string registration)
            {
                throw new System.NotImplementedException();
            }

            public void Update(Student student)
            {
                throw new System.NotImplementedException();
            }

            public void CancelRegistration(string registration)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}