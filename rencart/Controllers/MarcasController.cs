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
    public class MarcasController : ControllerBase
    {
        private readonly IUnityOfWork _IUnityOfWork;
        public RencarDbContext _context;

        public MarcasController(IUnityOfWork IUnityOfWork, RencarDbContext context)
        {
            _IUnityOfWork = IUnityOfWork;   
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var marcas =  _IUnityOfWork.Marcas.GetAll();
                return StatusCode(200, marcas);
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
        [Route("remove/{idmarca}")]
        public async Task<IActionResult> Remove(int idmarca)
        {
            try
            {
                var marca = await _context.Marca.FirstOrDefaultAsync(i => i.Id == idmarca);
                if (marca  != null) _IUnityOfWork.Marcas.Remove(marca);

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
        [Route("GetById/{idMarca}")]
        public IActionResult GetById(int idMarca)
        {
            try
            {
                var marca = _IUnityOfWork.Marcas.Get(idMarca);
                return StatusCode(200, marca);
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
        public IActionResult Update(Marca Marca)
        {
            try
            {
                _IUnityOfWork.Marcas.Update(Marca);
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
        public IActionResult Add(Marca marca)
        {
            try
            {
                marca.FechaCreacion = DateTime.UtcNow.AddMinutes(-240);
                _IUnityOfWork.Marcas.Add(marca);

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
