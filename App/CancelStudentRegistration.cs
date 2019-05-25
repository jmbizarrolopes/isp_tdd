namespace App
{
    public class CancelStudentRegistration : IUseCase
    {
        private readonly IStudentRegistrationCancellationRepository _studentRepository;

        public CancelStudentRegistration(IStudentRegistrationCancellationRepository studentRepository)
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