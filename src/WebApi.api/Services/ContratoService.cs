using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using WebApi.api.BackServices;
using WebApi.api.Models;

namespace WebApi.api.Services
{
    public class ContratoService : IContratoService
    {
        private readonly IGetRandomContrato _getRandomContrato;

        public ContratoService(IGetRandomContrato getRandomContrato)
        {
            _getRandomContrato = getRandomContrato;
        }
        public async Task<List<Contrato>> GetRandomContratoBasedOnSearchCritera(Contrato contrato)
        {
            return await _getRandomContrato.ReturnRandomContratoBasedOnTag(contrato);
        }
    }
}