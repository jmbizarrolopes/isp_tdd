namespace App
{
    public class EditStudent : IUseCase
    {
        private readonly IStudentEditionRepository _studentRepository;

        public EditStudent(IStudentEditionRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        
        public void Execute(IRequest request)
        {
            var data = (EditStudentRequest)request;

            var student = _studentRepository.Get(data.Registration);

            if (student is null)
                throw new StudentNotFoundException();
            
            student.ChangeName(data.Name);
            student.ChangeBirthDate(data.BirthDate);
            
            _studentRepository.Update(student);
        }
    }
}