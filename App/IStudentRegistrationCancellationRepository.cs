using Domain;

namespace App
{
    public interface IStudentRegistrationCancellationRepository
    {
        Student Exists(string registration);
        void CancelRegistration(string registration);
    }
}