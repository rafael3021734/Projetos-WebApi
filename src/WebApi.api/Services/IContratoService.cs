using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using WebApi.api.BackServices;
using WebApi.api.Models;

namespace WebApi.api.Services
{
    public interface IContratoService
    {
        Task<List<Contrato>> GetRandomContratoBasedOnSearchCritera(Contrato contrato);
    }
}