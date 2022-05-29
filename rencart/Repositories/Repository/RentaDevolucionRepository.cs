using Microsoft.EntityFrameworkCore;
using rencart.Context;
using rencart.DTO;
using rencart.Entities;
using rencart.Interfaces;
using rencart.Repositories.Generico;
using System.Linq;
using System.Threading.Tasks;

namespace rencart.Repositories.Repository
{
    public class RentaDevolucionRepository : BaseRepository<RentaDevolucion>, IRentaDevolucionRepository
    {

        public RencarDbContext _context { get { return context; } }
        public RentaDevolucionRepository(RencarDbContext context) : base(context)
        {
        }

        public async Task<dynamic> getRentas()
        {
            return await _context.RentaDevolucion.Select(r => new
            {
                r.Id,
                Vehiculo = r.Vehiculo.Descripcion,
                Cliente =  r.Cliente.Nombres+"  "+r.Cliente.Apellidos,
                r.FechaRenta,
                r.CantidadDias
            }).ToListAsync();
        }

        public async Task<dynamic> verificarRentaDisponible(RentaDisponibleDTO  payload)
        {
            var response  = await _context.RentaDevolucion.Where(
            r => r.IdVehiculo == payload.IdVehiculo && r.confirmarDevolucion == false && 
            (payload.FechaRenta >= r.FechaRenta.Date && payload.FechaRenta <= r.FechaDevolucion || 
             payload.FechaDevolucion >= r.FechaRenta && payload.FechaDevolucion <= payload.FechaDevolucion)).CountAsync();

            if(response == 0)
            {
                //esta disponible
                return true;
            }
            else
            {
                return false;
            }
        }


        public async Task<dynamic> buscador(BuscadorDTO payload)
        {

            switch (payload.TipoColumna)
            {
                case 1:
                    return await _context.RentaDevolucion.Where(r => r.Cliente.Nombres.Contains(payload.Columna)).Select(r  => new
                    {
                        r.Id,
                        Vehiculo = r.Vehiculo.Descripcion,
                        Cliente = r.Cliente.Nombres+"  "+r.Cliente.Apellidos,
                        r.FechaRenta,
                        r.CantidadDias
                    }).ToListAsync();
                    break;

                case 2:
                    return await _context.RentaDevolucion.Where(r => r.Vehiculo.Descripcion.Contains(payload.Columna)).Select(r => new
                    {
                        r.Id,
                        Vehiculo = r.Vehiculo.Descripcion,
                        Cliente = r.Cliente.Nombres+"  "+r.Cliente.Apellidos,
                        r.FechaRenta,
                        r.CantidadDias
                    }).ToListAsync();

                    break;

                case 3:
                    return await _context.RentaDevolucion.Where(r => r.FechaRenta.ToString().Contains(payload.Columna)).Select(r => new
                    {
                        r.Id,
                        Vehiculo = r.Vehiculo.Descripcion,
                        Cliente = r.Cliente.Nombres+"  "+r.Cliente.Apellidos,
                        r.FechaRenta,
                        r.CantidadDias
                    }).ToListAsync();
                    break;
                default:
                    return null;
                    break;
            }

           
        }


        private async Task<dynamic> verificarRentaDisponibleSinConfirmar(RentaDisponibleDTO payload)
        {
            var response = await _context.RentaDevolucion.Where(
            r => r.IdVehiculo != payload.IdVehiculo &&  r.Id != payload.Id  &&
            (payload.FechaRenta >= r.FechaRenta.Date && payload.FechaRenta <= r.FechaDevolucion ||
             payload.FechaDevolucion >= r.FechaRenta && payload.FechaDevolucion <= payload.FechaDevolucion)).CountAsync();

            if (response == 0)
            {
                //esta disponible
                return true;
            }
            else
            {
                return false;
            }
        }

        public  async Task<dynamic> Update(UpdateRentaDTO data)
        {
            //Verificamos si la fehcas no se han actualizado
            if(data.rentaAntesPayload.FechaRenta == data.rentaActualPayload.FechaRenta && data.rentaAntesPayload.FechaDevolucion == data.rentaActualPayload.FechaDevolucion)
            {
                updateRentaActual(data.rentaActualPayload);
                return null;
            }
            else
            {

                var payloadDisponible = new RentaDisponibleDTO
                {
                    Id = data.rentaActualPayload.Id,
                    IdVehiculo = data.rentaActualPayload.IdVehiculo,
                    FechaRenta = data.rentaActualPayload.FechaRenta,
                    FechaDevolucion = data.rentaActualPayload.FechaDevolucion,
                };

                if(data.rentaAntesPayload.confirmarDevolucion  == data.rentaActualPayload.confirmarDevolucion)
                {
                    var res = await verificarRentaDisponibleSinConfirmar(payloadDisponible);
                    if(res == true)
                    {
                        updateRentaActual(data.rentaActualPayload);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    var response = await verificarRentaDisponible(payloadDisponible);
                    if (response  == true)
                    {
                        updateRentaActual(data.rentaActualPayload);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }


            }

        }

        public void updateRentaActual(RentaDevolucion renta)
        {
            var updateRenta = Get(renta.Id);
            updateRenta.IdCliente = renta.IdCliente;
            updateRenta.IdEmpleado = renta.IdEmpleado;
            updateRenta.IdVehiculo = renta.IdVehiculo;
            updateRenta.confirmarDevolucion = renta.confirmarDevolucion;
            updateRenta.CantidadDias = renta.CantidadDias;
            updateRenta.CantidadPorDia = renta.CantidadPorDia;
            updateRenta.Comentario = renta.Comentario;
            updateRenta.FechaRenta = renta.FechaRenta;
            updateRenta.FechaDevolucion = renta.FechaDevolucion;
            updateRenta.MontoPorDia = renta.MontoPorDia;
        }
    }
}
