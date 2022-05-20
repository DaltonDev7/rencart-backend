using Microsoft.AspNetCore.Mvc;
using rencart.Entities;
using rencart.Interfaces;
using System;

namespace rencart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InspeccionController : ControllerBase
    {
        private readonly IUnityOfWork _IUnityOfWork;

        public InspeccionController(IUnityOfWork iUnityOfWork)
        {
            _IUnityOfWork=iUnityOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return StatusCode(200, _IUnityOfWork.Inspeccion.GetAll());
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
