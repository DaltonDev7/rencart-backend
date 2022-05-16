namespace rencart.Interfaces
{
    public interface IUnityOfWork
    {
        IMarcaRepository Marcas { get; }

        int Complete();
        void Dispose();
    }
}
