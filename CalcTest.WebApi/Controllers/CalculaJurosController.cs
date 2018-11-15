﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalcTest.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalcTest.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ApiController
    {
        private readonly ICalculoDeJurosApplicationService _calculoDeJurosService;

        public CalculaJurosController(ICalculoDeJurosApplicationService calculoDeJurosService)
        {
            _calculoDeJurosService = calculoDeJurosService;
        }

        // GET: api/ShowMeTheCode
        [HttpGet]
        public IActionResult Get(decimal valorInicial, int meses)
        {
            return Response(_calculoDeJurosService.Calcular(valorInicial, meses));
        }
    }
}
