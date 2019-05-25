using Domain;

namespace App
{
    public interface IStudentRepository
    {
        Student Exists(string registration);
        void Register(Student student);
        Student Get(string registration);
        void Update(Student student);
        void CancelRegistration(string registration);
    }
}