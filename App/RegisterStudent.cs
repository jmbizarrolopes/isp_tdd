using Domain;

namespace App
{
    public class RegisterStudent : IUseCase
    {
        private readonly IStudentRepository _studentRepository;

        public RegisterStudent(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Execute(IRequest request)
        {
            var data = (RegisterStudentRequest)request;

            if (_studentRepository.Exists(data.Registration) != null)
                throw new StudentAlreadyExistsException();

            var student = new Student(data.Registration, data.Name, data.BirthDate);
            
            _studentRepository.Register(student);
        }
    }
}