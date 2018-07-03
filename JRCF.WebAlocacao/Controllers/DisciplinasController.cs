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
    public class DisciplinasController : Controller
    {
        private readonly IMongoCollection<Disciplina> disciplinas;
        public DisciplinasController(MongoClient client)
        {
            var database = client.GetDatabase("jrcfdb");
            disciplinas = database.GetCollection<Disciplina>(nameof(disciplinas));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var disciplinasCursor = await disciplinas.FindAsync(FilterDefinition<Disciplina>.Empty);
            var _disciplinas = await disciplinasCursor.ToListAsync();

            return Ok(_disciplinas);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Disciplina model)
        {
            await disciplinas.InsertOneAsync(model);
            return Ok(model);
        }


    }
}