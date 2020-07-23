using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using programfirst.Model;

namespace programfirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[] { 
                new Evento() {
                    EventoId = 1,
                    Tema = "Angular e .net Core",
                    Local = "Belo Horizonte",
                    Lote = "1 lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy")
                },
                new Evento() {
                    EventoId = 3,
                    Tema = "Angular e .net Core",
                    Local = "Bahia",
                    Lote = "3 lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy")
                },
                new Evento() {
                    EventoId = 2,
                    Tema = "Angular e .net Core",
                    Local = "São Paulo",
                    Lote = "2 lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy")
                }
                
                };//.FirstOrDefault(x => x.EventoId = Id);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return new Evento[]{
             new Evento() {
                    EventoId = 1,
                    Tema = "Angular e .net Core",
                    Local = "Belo Horizonte",
                    Lote = "1 lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy")
                },
                new Evento() {
                    EventoId = 2,
                    Tema = "Angular e .net Core",
                    Local = "São Paulo",
                    Lote = "2 lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy")
                }
                
                }.FirstOrDefault(x => x.EventoId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
