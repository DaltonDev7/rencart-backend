namespace rencart.Interfaces
{
    public interface IUnityOfWork
    {
        IMarcaRepository Marcas { get; }
        IModeloRepository Modelos { get; }

        ITipoVehiculoRepository TipoVehiculos { get; }

        ITipoCombustibleRepository TipoCombustible { get; }
        IVehiculoRepository vehiculo { get; }
        ITipoPersonaRepository TipoPersona { get; }

        IClienteRepository Cliente { get; }
        IEmpleadoRepository Empleado { get; }
        IInspeccionRepository Inspeccion { get; }
        IRentaDevolucionRepository RentaDevolucion { get; }

        int Complete();
        void Dispose();
    }
}
