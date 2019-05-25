using Domain;

namespace App
{
    public interface IStudentRegistrationRepository
    {
        Student Exists(string registration);
        void Register(Student student);
    }
}