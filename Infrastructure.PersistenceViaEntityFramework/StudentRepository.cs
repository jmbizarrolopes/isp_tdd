using App;
using Domain;

namespace Infrastructure.PersistenceViaEntityFramework
{
    public class StudentRepository : IStudentRepository
    {
        public StudentRepository()
        {
            
        }
        
        public Student Exists(string registration)
        {
            throw new System.NotImplementedException();
        }

        public Student Get(string registration)
        {
            throw new System.NotImplementedException();
        }

        public void CancelRegistration(string registration)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new System.NotImplementedException();
        }

        public void Register(Student student)
        {
            throw new System.NotImplementedException();
        }
    }
}