using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JRCFAlocacao.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JRCF.WebAlocacao.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class RecursosController : Controller
    {
        public RecursosController()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            //var dados = GetRecursos();
            return Ok();
        }

        //[NonAction]
        //private List<Recurso> GetRecursos()
        //{


        //    var recursos = new List<Recurso>();

        //    recursos.Add(new Recurso()
        //    {
        //        Nome = "Mathes Acosta",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina { Descricao = "Desenvolvimento Web com HTML" },
        //                    new Disciplina { Descricao = "MS Project" },
        //                    new Disciplina { Descricao = "Excel - Básico Módulo I" },
        //                    new Disciplina { Descricao = "Excel Avançado Módulo II" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Nome = "Mathias Viana",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina {Descricao = "MS Project" },
        //                    new Disciplina {Descricao = "Excel - Básico Módulo I" },
        //                    new Disciplina {Descricao = "Excel Avançado Módulo II" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 3,
        //        Nome = "José Jackson",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina { Descricao = "MS Project" },
        //                    new Disciplina { Descricao = "Excel - Básico Módulo I" },
        //                    new Disciplina { Descricao = "Excel Avançado Módulo II" } ,
        //                    new Disciplina { Descricao = "Word e PowerPoint" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 4,
        //        Nome = "Ivan Barbosa",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina { Descricao = "MS Project" },
        //                    new Disciplina { Descricao = "Excel - Básico Módulo I" },
        //                    new Disciplina { Descricao = "Excel Avançado Módulo II" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 5,
        //        Nome = "Matheus Antunes",
        //        Competencias =
        //        new List<Disciplina> {
        //            new Disciplina {  Descricao = "Português: Regras e Uso Módulo I" },
        //            new Disciplina {  Descricao = "Word e PowerPoint" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 6,
        //        Nome = "Anderson Ferreira",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina { Descricao = "Excel - Básico Módulo I" },
        //                    new Disciplina { Descricao = "Excel Avançado Módulo II" },
        //                    new Disciplina { Descricao = "Word e PowerPoint" } ,
        //                    new Disciplina { Descricao = "Português: Regras e Uso Módulo I" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 8,
        //        Nome = "Jaqueline Jesus",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina { Descricao = "Word e PowerPoint" } ,
        //                    new Disciplina { Descricao = "Português: Regras e Uso Módulo I" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 9,
        //        Nome = "Willby Florencio",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina { Descricao = "Word e PowerPoint" } ,
        //                    new Disciplina { Descricao = "Português: Regras e Uso Módulo I" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 10,
        //        Nome = "Ana Carolina",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina { Descricao = "Inglês Intermediário 2" },
        //                    new Disciplina { Descricao = "Inglês - Básico 2" },
        //                    new Disciplina { Descricao = "Inglês - Básico 1" },
        //                    new Disciplina { Descricao = "Inglês: Intermediário 1" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 11,
        //        Nome = "Marcelo Leal",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina {Descricao = "Inglês Intermediário 2" },
        //                    new Disciplina {Descricao = "Inglês - Básico 2" },
        //                    new Disciplina {Descricao = "Inglês - Básico 1" },
        //                    new Disciplina {Descricao = "Inglês: Intermediário 1" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 12,
        //        Nome = "Felipe Silvestre",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina {Descricao = "Inglês Intermediário 2" },
        //                    new Disciplina {Descricao = "Inglês - Básico 2" },
        //                    new Disciplina {Descricao = "Inglês - Básico 1" },
        //                    new Disciplina {Descricao = "Inglês: Intermediário 1" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 13,
        //        Nome = "Jorge Paulo",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina { Descricao = "Inglês Intermediário 2" },
        //                    new Disciplina { Descricao = "Inglês - Básico 2" },
        //                    new Disciplina { Descricao = "Inglês - Básico 1" },
        //                    new Disciplina { Descricao = "Inglês: Intermediário 1" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 14,
        //        Nome = "José Augsto",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina { Descricao = "Inglês Intermediário 2" },
        //                    new Disciplina { Descricao = "Inglês - Básico 2" },
        //                    new Disciplina { Descricao = "Inglês - Básico 1" },
        //                    new Disciplina { Descricao = "Inglês: Intermediário 1" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 15,
        //        Nome = "Emerson Cassio",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina {  Descricao = "Inglês Intermediário 2" },
        //                    new Disciplina {  Descricao = "Inglês - Básico 2" },
        //                    new Disciplina {  Descricao = "Inglês - Básico 1" },
        //                    new Disciplina {  Descricao = "Inglês: Intermediário 1" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 16,
        //        Nome = "Mariana Nolla",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina { Descricao = "Inglês Intermediário 2" },
        //                    new Disciplina { Descricao = "Inglês - Básico 2" },
        //                    new Disciplina { Descricao = "Inglês - Básico 1" },
        //                    new Disciplina { Descricao = "Inglês: Intermediário 1" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 17,
        //        Nome = "Luciano Cesar",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina {  Descricao = "Inglês Intermediário 2" },
        //                    new Disciplina {  Descricao = "Inglês - Básico 2" },
        //                    new Disciplina {  Descricao = "Inglês - Básico 1" },
        //                    new Disciplina {  Descricao = "Inglês: Intermediário 1" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 18,
        //        Nome = "Bruno Eric",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina { Descricao = "Inglês Intermediário 2" },
        //                    new Disciplina { Descricao = "Inglês - Básico 2" },
        //                    new Disciplina { Descricao = "Inglês - Básico 1" },
        //                    new Disciplina { Descricao = "Inglês: Intermediário 1" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 19,
        //        Nome = "Renata Muzzy",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina {  Descricao = "Inglês Intermediário 2" },
        //                    new Disciplina {  Descricao = "Inglês - Básico 2" },
        //                    new Disciplina {  Descricao = "Inglês - Básico 1" },
        //                    new Disciplina {  Descricao = "Inglês: Intermediário 1" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 20,
        //        Nome = "Carolina de Lima",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina { Descricao = "Inglês Intermediário 2" },
        //                    new Disciplina { Descricao = "Inglês - Básico 2" },
        //                    new Disciplina { Descricao = "Inglês - Básico 1" },
        //                    new Disciplina { Descricao = "Inglês: Intermediário 1" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 21,
        //        Nome = "Eder Lemos",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina { Descricao = "Excel - Básico Módulo I" },
        //                    new Disciplina { Descricao = "Excel Avançado Módulo II" } ,
        //                    new Disciplina { Descricao = "Word e PowerPoint" }
        //        }
        //    });

        //    recursos.Add(new Recurso()
        //    {
        //        Id = 22,
        //        Nome = "Luccas Nunes",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina {Descricao = "Excel - Básico Módulo I" },
        //                    new Disciplina {Descricao = "Excel Avançado Módulo II" } ,
        //                    new Disciplina {Descricao = "Word e PowerPoint" }
        //        }
        //    });
        //    recursos.Add(new Recurso()
        //    {
        //        Id = 23,
        //        Nome = "Josiel Lemos",
        //        Competencias =
        //        new List<Disciplina> {
        //                    new Disciplina { Descricao = "MS Project" },
        //                    new Disciplina { Descricao = "Excel - Básico Módulo I" },
        //                    new Disciplina { Descricao = "Excel Avançado Módulo II" }
        //        }
        //    });

        //    return recursos;
        //}
    }
}