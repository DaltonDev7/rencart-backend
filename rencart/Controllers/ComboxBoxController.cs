using Microsoft.AspNetCore.Mvc;
using rencart.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace rencart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComboxBoxController : ControllerBase
    {
        private IComboxService _comboxService;

        public ComboxBoxController(IComboxService comboxService)
        {
            _comboxService=comboxService;
        }

        [HttpGet]
        [Route("Cliente")]
        public async Task<IActionResult> getClienteCombox()
        {
            try
            {
                var clientes = await _comboxService.getClienteCombox();
                return StatusCode(200, clientes);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("TipoPersona")]
        public async Task<IActionResult> getTipoPersonaCombox()
        {
            try
            {
                var tipoPersonas = await _comboxService.getTipoPersonaCombox();
                return StatusCode(200, tipoPersonas);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("Marca")]
        public async Task<IActionResult> getMarcaCombox()
        {
            try
            {
                var marcas = await _comboxService.getMarcaCombox();
                return StatusCode(200, marcas);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("Modelo")]
        public async Task<IActionResult> getModeloCombox()
        {
            try
            {
                var marcas = await _comboxService.getModeloCombox();
                return StatusCode(200, marcas);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("TipoCombustible")]
        public async Task<IActionResult> getTipoCombustibleCombox()
        {
            try
            {
                var marcas = await _comboxService.getTipoCombustibleCombox();
                return StatusCode(200, marcas);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("TipoVehiculo")]
        public async Task<IActionResult> getTipoVehiculoCombox()
        {
            try
            {
                var tipoVehiculo = await _comboxService.getTipoVehiculoCombox();
                return StatusCode(200, tipoVehiculo);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }


        [HttpGet]
        [Route("Empleado")]
        public async Task<IActionResult> getEmpleadoCombox()
        {
            try
            {
                var empleados = await _comboxService.getEmpleadoCombox();
                return StatusCode(200, empleados);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("Vehiculo")]
        public async Task<IActionResult> getVehiculoCombox()
        {
            try
            {
                var vehiculos = await _comboxService.getVehiculoCombox();
                return StatusCode(200, vehiculos);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("GetModelosByMarca/{idMarca}")]
        public async Task<IActionResult> getModelosByIdMarca(int idMarca)
        {
            try
            {
                var vehiculos = await _comboxService.getModelosByIdMarca(idMarca);
                return StatusCode(200, vehiculos);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }



    }
}
