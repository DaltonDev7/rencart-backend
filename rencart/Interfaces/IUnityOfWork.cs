namespace rencart.Interfaces
{
    public interface IUnityOfWork
    {
        int Complete();
        void Dispose();
    }
}
