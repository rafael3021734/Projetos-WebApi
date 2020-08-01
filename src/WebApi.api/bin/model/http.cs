using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Giphy.Libs.Models;

namespace http.model
{
    public class GetRandomGif : IGetRandomGif
    {
        public async Task<Contrato> ReturnRandomContratoBasedOnTag(string searchCritera)
        {
            const string giphyKey = "";

            using (var client = new HttpClient())
            {
                var url = new Uri("");   //url da prognum
                
                var response = await client.GetAsync(url);  //método GetAsync() envia uma requisição HTTP GET e retorna uma variavel respose que contém a resposta HTTP.

                string json;
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync(); //Chamamos então ReadAsAsycn para desserializar o retorno JSON para uma instância
                }
                
                return JsonConvert.DeserializeObject<GiphyModel>(json);
            }
        }
    }
}