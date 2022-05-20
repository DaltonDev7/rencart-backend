using Microsoft.AspNetCore.Mvc;
using rencart.Entities;
using rencart.Interfaces;
using System;

namespace rencart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IUnityOfWork _IUnityOfWork;

        public EmpleadoController(IUnityOfWork iUnityOfWork)
        {
            _IUnityOfWork=iUnityOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
               
                return StatusCode(200, _IUnityOfWork.Empleado.GetAll());
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
        public IActionResult Add(Empleado empleado)
        {
            try
            {
                empleado.FechaCreacion = DateTime.UtcNow.AddMinutes(-240);
                _IUnityOfWork.Empleado.Add(empleado);

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
        public IActionResult Update(Empleado empleado)
        {
            try
            {
                _IUnityOfWork.Empleado.Update(empleado);
                return StatusCode(204, _IUnityOfWork.Complete());
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
