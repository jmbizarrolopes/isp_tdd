using Domain;

namespace App
{
    public interface IStudentEditionRepository
    {
        Student Get(string registration);
        void Update(Student student);
    }
}