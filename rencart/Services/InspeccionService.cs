
using Microsoft.EntityFrameworkCore;
using rencart.Context;
using rencart.Interfaces;
using rencart.Interfaces.Services;
using System.Threading.Tasks;

namespace rencart.Services
{
    public class InspeccionService : IInspeccionService
    {
        public RencarDbContext _context;
        private readonly IUnityOfWork _IUnityOfWork;

        public InspeccionService(RencarDbContext context, IUnityOfWork UnityOfWork)
        {
            _context=context;
            _IUnityOfWork=UnityOfWork;
        }

        public async Task<dynamic> removeInspeccion(int idInspeccion)
        {
            var inspeccion = await _context.Inspeccion.FirstOrDefaultAsync(i => i.Id == idInspeccion);
            if (inspeccion != null)
            {
                _IUnityOfWork.Inspeccion.RemoveInspeccion(inspeccion);
            }
            return null;
        }



    }
}
