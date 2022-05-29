using rencart.Entities;
using System.Threading.Tasks;

namespace rencart.Interfaces
{
    public interface IModeloRepository: IBaseRepository<Modelo>
    {
        void Update(Modelo modelo);
        Task<dynamic> getModeloById(int idModelo);

        Task<dynamic> getModelos();

    }
}
