using Microsoft.AspNetCore.Mvc;
using rencart.Entities;
using rencart.Interfaces;
using System;
using System.Threading.Tasks;

namespace rencart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IUnityOfWork _IUnityOfWork;

        public ClienteController(IUnityOfWork iUnityOfWork)
        {
            _IUnityOfWork=iUnityOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return StatusCode(200, await _IUnityOfWork.Cliente.getClientes());
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
        public IActionResult Add(Cliente cliente)
        {
            try
            {
                cliente.FechaCreacion = DateTime.UtcNow.AddMinutes(-240);
                _IUnityOfWork.Cliente.Add(cliente);

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
        public IActionResult Update(Cliente cliente)
        {
            try
            {
                _IUnityOfWork.Cliente.Update(cliente);
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
        [Route("GetById/{idCliente}")]
        public IActionResult GetById(int idCliente)
        {
            try
            {
                var marca = _IUnityOfWork.Cliente.Get(idCliente);
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
    }
}
