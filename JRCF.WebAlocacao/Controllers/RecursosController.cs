using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JRCFAlocacao.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace JRCF.WebAlocacao.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class RecursosController : Controller
    {
        private readonly IMongoCollection<Recurso> recursos;
        public RecursosController(MongoClient client)
        {
            var database = client.GetDatabase("jrcfdb");
            recursos = database.GetCollection<Recurso>(nameof(recursos));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var recursosCursor = await recursos.FindAsync(FilterDefinition<Recurso>.Empty);
            var _recursos = await recursosCursor.ToListAsync();

            return Ok(_recursos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute]string id)
        {
            var recursosCursor = await recursos.FindAsync(x => x.Key == id);
            var _recurso = (await recursosCursor.ToListAsync()).FirstOrDefault();

            return Ok(_recurso);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Recurso model)
        {
            await recursos.InsertOneAsync(model);
            return Ok(model);
        }


        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Recurso model)
        {
            await recursos.ReplaceOneAsync(Builders<Recurso>.Filter.Eq(p => p.Key, model.Key), model);
            return Ok(model);
        }
    }
}