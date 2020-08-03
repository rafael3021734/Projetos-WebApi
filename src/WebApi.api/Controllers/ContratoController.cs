using System;
using System.Threading.Tasks;
using WebApi.api.Services;
using WebApi.api.BackServices;
using WebApi.api.Models;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.api.Controllers
{
    public class ContratoController : Controller
    {
        private readonly IContratoService _ContratoServices;

        public ContratoController(IContratoService ContratoService)
        {
            _ContratoServices = ContratoService;
        }

        [HttpGet]
        [Route("api/Contrato")]     // defini o url(v1/giphy/random) variavel(searchcritera)
        public async Task<IActionResult> GetRandomContrato(Contrato contrato)   //parametro chamada metodo (searchCritera)
        {
            var result = await _ContratoServices.GetRandomContratoBasedOnSearchCritera(contrato); // metodo de serviço

            return Ok(result);
        }
    }
    
}