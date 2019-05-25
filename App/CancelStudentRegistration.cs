namespace App
{
    public class CancelStudentRegistration : IUseCase
    {
        private readonly IStudentRepository _studentRepository;

        public CancelStudentRegistration(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        
        public void Execute(IRequest request)
        {
            var data = (CancelStudentRegistrationRequest)request;
            
            if (_studentRepository.Exists(data.Registration) == null)
                throw new StudentNotFoundException();
            
            _studentRepository.CancelRegistration(data.Registration);
        }
    }
}