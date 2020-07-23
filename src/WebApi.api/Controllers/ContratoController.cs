using System;
using System.Threading.Tasks;
using Giphy.Libs.Services;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.api.Controllers
{
    public class ContratoController : Controller
    {
        private readonly IGiphyService _giphyServices;

        public ContratoController(IGiphyService giphyService)
        {
            _giphyServices = giphyService;
        }

        [HttpGet]
        [Route("v1/giphy/random/{searchCritera}")]     // defini o url(v1/giphy/random) variavel(searchcritera)
        public async Task<IActionResult> GetRandomGif(string searchCritera)   //parametro chamada metodo (searchCritera)
        {
            var result = await _giphyServices.GetRandomGifBasedOnSearchCritera(searchCritera); // metodo de serviço

            return Ok(result);
        }
    }
    
}