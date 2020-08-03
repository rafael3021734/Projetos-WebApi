using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using WebApi.api.Services;
using WebApi.api.Models;
using System.Collections.Generic;
using WebApi.api.BackServices;

namespace WebApi.api.BackServices
{
    public interface IGetRandomContrato
    {
         Task<List<Contrato>> ReturnRandomContratoBasedOnTag(Contrato contrato);  
        
    }
}