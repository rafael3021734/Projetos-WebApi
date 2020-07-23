using System;
using System.Threading.Tasks;
using Giphy.Libs.Models;

namespace WebApi.Services
{
    public interface IContratoService
    {
        Task<Contrato> GetRandomContratoBasedOnSearchCritera(string searchCritera);
    }
}