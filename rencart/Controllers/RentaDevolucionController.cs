using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rencart.Context;
using rencart.DTO;
using rencart.Entities;
using rencart.Interfaces;
using System;
using System.Threading.Tasks;

namespace rencart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentaDevolucionController : ControllerBase
    {
        private readonly IUnityOfWork _IUnityOfWork;
        public RencarDbContext _context;
        public RentaDevolucionController(IUnityOfWork iUnityOfWork, RencarDbContext context)
        {
            _IUnityOfWork=iUnityOfWork;
            _context=context;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return StatusCode(200, await _IUnityOfWork.RentaDevolucion.getRentas());
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
        [Route("remove/{idRenta}")]
        public async Task<IActionResult> Remove(int idRenta)
        {
            try
            {
                var renta = await _context.RentaDevolucion.FirstOrDefaultAsync(i => i.Id == idRenta);
                if(renta  != null) _IUnityOfWork.RentaDevolucion.Remove(renta);
               
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

        [HttpPost]
        [Route("verificarRentaDisponible")]
        public async Task<IActionResult> verificarRenta(RentaDisponibleDTO payload)
        {
            try
            {
            
                var response = await _IUnityOfWork.RentaDevolucion.verificarRentaDisponible(payload);

                return StatusCode(201, response);
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
        [Route("buscadorRenta")]
        public async Task<IActionResult> buscador(BuscadorDTO payload)
        {
            try
            {

                var response = await _IUnityOfWork.RentaDevolucion.buscador(payload);

                return StatusCode(200, response);
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
        public IActionResult Update(RentaDevolucion data)
        {
            try
            {
                _IUnityOfWork.RentaDevolucion.updateRentaActual(data);
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
