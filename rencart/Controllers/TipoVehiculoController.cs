using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rencart.Context;
using rencart.Entities;
using rencart.Interfaces;
using System;
using System.Threading.Tasks;

namespace rencart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoVehiculoController : ControllerBase
    {
        private readonly IUnityOfWork _IUnityOfWork;
        public RencarDbContext _context;
        public TipoVehiculoController(IUnityOfWork iUnityOfWork, RencarDbContext context)
        {
            _IUnityOfWork=iUnityOfWork;
            _context=context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return StatusCode(200, _IUnityOfWork.TipoVehiculos.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
            finally
            {
                _IUnityOfWork.Dispose();
            }
        }


        [HttpDelete]
        [Route("remove/{idTipoVehiculo}")]
        public async Task<IActionResult> Remove(int idTipoVehiculo)
        {
            try
            {
                var tipo = await _context.TipoVehiculo.FirstOrDefaultAsync(i => i.Id == idTipoVehiculo);
                if (tipo  != null) _IUnityOfWork.TipoVehiculos.Remove(tipo);

                return StatusCode(200, _IUnityOfWork.Complete());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
            finally
            {
                _IUnityOfWork.Dispose();
            }
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update(TipoVehiculo tipoVehiculo)
        {
            try
            {
                _IUnityOfWork.TipoVehiculos.Update(tipoVehiculo);
                return StatusCode(201, _IUnityOfWork.Complete());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
            finally
            {
                _IUnityOfWork.Dispose();
            }
        }

        [HttpGet]
        [Route("GetById/{idTipoVehiculo}")]
        public IActionResult GetById(int idTipoVehiculo)
        {
            try
            {
                return StatusCode(200, _IUnityOfWork.TipoVehiculos.Get(idTipoVehiculo));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
            finally
            {
                _IUnityOfWork.Dispose();
            }
        }

        [HttpPost]
        public IActionResult Add(TipoVehiculo tipoVehiculo)
        {
            try
            {
                tipoVehiculo.FechaCreacion = DateTime.UtcNow.AddMinutes(-240);
                _IUnityOfWork.TipoVehiculos.Add(tipoVehiculo);

                return StatusCode(201, _IUnityOfWork.Complete());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
            finally
            {
                _IUnityOfWork.Dispose();
            }
        }
    }
}
