using Microsoft.AspNetCore.Mvc;
using rencart.Entities;
using rencart.Interfaces;
using System;
using System.Threading.Tasks;

namespace rencart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModeloController : ControllerBase
    {

        private readonly IUnityOfWork _IUnityOfWork;

        public ModeloController(IUnityOfWork iUnityOfWork)
        {
            _IUnityOfWork=iUnityOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var modelos = await _IUnityOfWork.Modelos.getModelos();
                return StatusCode(200, modelos);
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
        [Route("GetById/{idModelo}")]
        public async Task<IActionResult> GetById(int idModelo)
        {
            try
            {
                var modelos = await _IUnityOfWork.Modelos.GetAsync(idModelo);
                return StatusCode(200, modelos);
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
        public IActionResult Add(Modelo modelo)
        {
            try
            {
                modelo.FechaCreacion = DateTime.UtcNow.AddMinutes(-240);
                _IUnityOfWork.Modelos.Add(modelo);

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
        public IActionResult Update(Modelo modelo)
        {
            try
            {
              
                _IUnityOfWork.Modelos.Update(modelo);

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
