﻿using Microsoft.AspNetCore.Mvc;
using rencart.Entities;
using rencart.Interfaces;
using System;

namespace rencart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoCombustibleController : ControllerBase
    {
        private readonly IUnityOfWork _IUnityOfWork;

        public TipoCombustibleController(IUnityOfWork iUnityOfWork)
        {
            _IUnityOfWork=iUnityOfWork;
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