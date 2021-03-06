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
    public class TipoCombustibleController : ControllerBase
    {
        private readonly IUnityOfWork _IUnityOfWork;
        public RencarDbContext _context;

        public TipoCombustibleController(IUnityOfWork iUnityOfWork, RencarDbContext context)
        {
            _IUnityOfWork=iUnityOfWork;
            _context=context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return StatusCode(200, _IUnityOfWork.TipoCombustible.GetAll());
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
        [Route("remove/{idTipoCombustible}")]
        public async Task<IActionResult> Remove(int idTipoCombustible)
        {
            try
            {
                var tipo = await _context.TipoCombustible.FirstOrDefaultAsync(i => i.Id == idTipoCombustible);
                if (tipo  != null) _IUnityOfWork.TipoCombustible.Remove(tipo);

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
        [Route("GetById/{idTipoCombustible}")]
        public IActionResult GetById(int idTipoCombustible)
        {
            try
            {
                var marca = _IUnityOfWork.TipoCombustible.Get(idTipoCombustible);
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
        public IActionResult Update(TipoCombustible tipoCombustible)
        {
            try
            {
                _IUnityOfWork.TipoCombustible.Update(tipoCombustible);
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
        public IActionResult Add(TipoCombustible tipoCombustible)
        {
            try
            {
                tipoCombustible.FechaCreacion = DateTime.UtcNow.AddMinutes(-240);
                _IUnityOfWork.TipoCombustible.Add(tipoCombustible);

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
