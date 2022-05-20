using Microsoft.AspNetCore.Mvc;
using rencart.Entities;
using rencart.Interfaces;
using System;

namespace rencart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentaDevolucionController : ControllerBase
    {
        private readonly IUnityOfWork _IUnityOfWork;

        public RentaDevolucionController(IUnityOfWork iUnityOfWork)
        {
            _IUnityOfWork=iUnityOfWork;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return StatusCode(200, _IUnityOfWork.RentaDevolucion.GetAll());
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
        public IActionResult Add(RentaDevolucion renta)
        {
            try
            {
                renta.FechaCreacion = DateTime.UtcNow.AddMinutes(-240);
                _IUnityOfWork.RentaDevolucion.Add(renta);

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
        [Route("GetById/{idRentaDevolucion}")]
        public IActionResult GetById(int idRentaDevolucion)
        {
            try
            {
                return StatusCode(200, _IUnityOfWork.RentaDevolucion.Get(idRentaDevolucion));
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
        public IActionResult Update(RentaDevolucion renta)
        {
            try
            {
                _IUnityOfWork.RentaDevolucion.Update(renta);
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
