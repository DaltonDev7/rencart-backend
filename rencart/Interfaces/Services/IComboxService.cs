using System.Threading.Tasks;

namespace rencart.Interfaces.Services
{
    public interface IComboxService
    {
        Task<dynamic> getClienteCombox();
        Task<dynamic> getVehiculoCombox();
        Task<dynamic> getMarcaCombox();
        Task<dynamic> getTipoPersonaCombox();
        Task<dynamic> getModeloCombox();

        Task<dynamic> getEmpleadoCombox();
        Task<dynamic> getTipoCombustibleCombox();

        Task<dynamic> getTipoVehiculoCombox();
        Task<dynamic> getModelosByIdMarca(int idMarca);
    }
}
