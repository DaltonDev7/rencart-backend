using System.Threading.Tasks;

namespace rencart.Interfaces.Services
{
    public interface IInspeccionService
    {
        Task<dynamic> removeInspeccion(int idInspeccion);
    }
}
