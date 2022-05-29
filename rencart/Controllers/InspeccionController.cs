using Microsoft.AspNetCore.Mvc;
using rencart.Entities;
using rencart.Interfaces;
using rencart.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace rencart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InspeccionController : ControllerBase
    {
        private readonly IUnityOfWork _IUnityOfWork;
        private readonly IInspeccionService _inspeccionService;

        public InspeccionController(IUnityOfWork iUnityOfWork, IInspeccionService inspeccionService)
        {
            _IUnityOfWork=iUnityOfWork;
            _inspeccionService=inspeccionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return StatusCode(200, await _IUnityOfWork.Inspeccion.getAllInspecciones());
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
        [Route("GetById/{idInspeccion}")]
        public IActionResult GetById(int idInspeccion)
        {
            try
            {
                var inspeccion = _IUnityOfWork.Inspeccion.Get(idInspeccion);
                return StatusCode(200, inspeccion);
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
        [Route("remove/{idInspeccion}")]
        public  async Task<IActionResult> Remove(int idInspeccion)
        {
            try
            {

                await _inspeccionService.removeInspeccion(idInspeccion);
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

        [HttpGet]
        [Route("verificarVehiculoInspeccion/{idVehiculo}")]
        public async Task<IActionResult> VerificarInspeccionVehiculo(int idVehiculo)
        {
            try
            {
                var inspeccion = await _IUnityOfWork.Inspeccion.verificarInspeccionVehiculo(idVehiculo);
                return StatusCode(200, inspeccion);
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
        public IActionResult Add(Inspeccion inspeccion)
        {
            try
            {
                inspeccion.FechaCreacion = DateTime.UtcNow.AddMinutes(-240);
                _IUnityOfWork.Inspeccion.Add(inspeccion);

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


        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Inspeccion inspeccion)
        {
            try
            {
                _IUnityOfWork.Inspeccion.Update(inspeccion);
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
