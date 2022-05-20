namespace rencart.Interfaces
{
    public interface IUnityOfWork
    {
        IMarcaRepository Marcas { get; }
        IModeloRepository Modelos { get; }

        int Complete();
        void Dispose();
    }
}
