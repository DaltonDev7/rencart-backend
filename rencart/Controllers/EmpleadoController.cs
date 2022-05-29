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
    public class EmpleadoController : ControllerBase
    {
        private readonly IUnityOfWork _IUnityOfWork;
        public RencarDbContext _context;

        public EmpleadoController(IUnityOfWork iUnityOfWork, RencarDbContext context)
        {
            _IUnityOfWork=iUnityOfWork;
            _context=context;
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
                empleado.FechaIngreso = DateTime.UtcNow.AddMinutes(-240);
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

        [HttpDelete]
        [Route("remove/{idempleado}")]
        public async Task<IActionResult> Remove(int idempleado)
        {
            try
            {
                var empleado = await _context.Empleado.FirstOrDefaultAsync(i => i.Id == idempleado);
                if (empleado  != null) _IUnityOfWork.Empleado.Remove(empleado);

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
        [Route("GetById/{idEmpleado}")]
        public IActionResult GetById(int idEmpleado)
        {
            try
            {
                var empleado = _IUnityOfWork.Empleado.Get(idEmpleado);
                return StatusCode(200, empleado);
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
