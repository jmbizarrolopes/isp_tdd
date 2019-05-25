using System;

namespace App
{
    public class RegisterStudentRequest : IRequest
    {
        public string Registration { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}