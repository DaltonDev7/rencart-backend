using Microsoft.AspNetCore.Mvc;
using rencart.Entities;
using rencart.Interfaces;
using System;
using System.Threading.Tasks;

namespace rencart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly IUnityOfWork _IUnityOfWork;

        public VehiculoController(IUnityOfWork iUnityOfWork)
        {
            _IUnityOfWork=iUnityOfWork;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return StatusCode(200, await _IUnityOfWork.vehiculo.getVehiculos());
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
        public IActionResult Update(Vehiculo vehiculo)
        {
            try
            {
                _IUnityOfWork.vehiculo.Update(vehiculo);
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
        [Route("GetById/{idVehiculo}")]
        public IActionResult GetById(int idVehiculo)
        {
            try
            {
                var vehiculo = _IUnityOfWork.vehiculo.Get(idVehiculo);
                return StatusCode(200, vehiculo);
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
        public IActionResult Add(Vehiculo vehiculo)
        {
            try
            {
                vehiculo.FechaCreacion = DateTime.UtcNow.AddMinutes(-240);
                _IUnityOfWork.vehiculo.Add(vehiculo);

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
