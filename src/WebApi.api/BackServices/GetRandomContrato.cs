using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using WebApi.api.Services;
using WebApi.api.Models;
using WebApi.api.BackServices;

namespace WebApi.api.BackServices
{
    public class GetRandomContrato : IGetRandomContrato
    {
        public async Task<List<Contrato>> ReturnRandomContratoBasedOnTag(Contrato contrato)
        {
           
            using (var client = new HttpClient())
            {
                var url = new Uri("");   //url da prognum
                
                string json;
                var response = await client.GetAsync(url);  //método GetAsync() envia uma requisição HTTP GET e retorna uma variavel respose que contém a resposta HTTP.
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync(); //Chamamos então ReadAsAsycn para desserializar o retorno JSON para uma instância
                }
                
                return JsonConvert.DeserializeObject<List<Contrato>>(json);
            }
        }
    }
}