namespace App
{
    public interface IUseCase
    {
        void Execute(IRequest request);
    }
}