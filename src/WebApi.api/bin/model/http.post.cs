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
                
                var response = await client.PostAsJsonAsync(url, Contratos);  //O método PostAsJsonAsync serializa um objeto para JSON e então envia-o na requisição POST. e retorna uma variavel response que contém a resposta HTTP.

                if (response.IsSuccessStatusCode)
                {
                    return response.Headers.Location;
                }
            }    
        }
    }
}