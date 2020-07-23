using System;
using System.Threading.Tasks;
using Giphy.Libs.Models;
using Giphy.Libs.Giphy;

namespace WebApi.api.Services
{
    public class ContratoService : IContratoService
    {
        private readonly IGetRandomContrato _getRandomContrato;

        public ContratoService(IGetRandomContrato getRandomContrato)
        {
            _getRandomContrato = getRandomContrato;
        }
        public async Task<Contrato> GetRandomContratoBasedOnSearchCritera(string searchCritera)
        {
            return await _getRandomContrato.ReturnRandomContratoBasedOnTag(searchCritera);
        }
    }
}