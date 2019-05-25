using System;
using System.Collections.Generic;
using System.Linq;
using App;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class EditStudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(StudentNotFoundException))]
        public void CannotEditStudentIfNotFound()
        {
            var editStudent = new EditStudent(new StudentRepositoryStub());
            
            editStudent.Execute(new EditStudentRequest
            {
                Registration = "REG001",
                Name = "John Doe",
                BirthDate = new DateTime(1993, 11, 29)
            });
        }
        
        private class StudentRepositoryStub : IStudentEditionRepository
        {
            private IList<Student> _studentsList;

            public StudentRepositoryStub()
            {
                _studentsList = new List<Student>
                {
                    new Student("REG002", "John Smith", new DateTime(1993, 10, 15))
                };
            }

            public Student Get(string registration)
            {
                return _studentsList.FirstOrDefault(s => s.Registration.Equals(registration));
            }

            public void Update(Student student)
            {
            }
        }
    }
}