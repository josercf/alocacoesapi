using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alocacao
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Horario> horario = new List<Horario>();


            var recursos = GetRecursos();
            foreach (var turma in GetTurmas())
            {
                int periodo = 1;
                foreach (var disciplina in turma.Disciplina)
                {
                    var alocacao = new Horario();

                    //recupera todos que podem aplicar a disciplina
                    var recursosPossiveis = recursos.Where(r => r.Competencias.Any(c => c.Id == disciplina.Id))?.ToList();

                    Recurso melhorRecurso = null;

                    //busca o melhor recurso
                    foreach (var recurso in recursosPossiveis)
                    {
                        //Se o recurso já está alocado no horário, evito uma segunda alocação
                        if (horario.Any(h => h.Recurso == recurso && h.Periodo == periodo))
                            continue;

                        melhorRecurso = recurso;
                    }

                    alocacao.Turma = turma;
                    alocacao.Recurso = melhorRecurso;
                    alocacao.Periodo = periodo;
                    alocacao.Disciplina = disciplina;

                    horario.Add(alocacao);
                    periodo++;
                }
            }

            var builder = new StringBuilder();

            for (int i = 0; i < horario.Count; i++)
            {

                if (i % 2 == 0)
                    Console.Write($"{horario[i].Turma.Descricao}*{horario[i].Disciplina.Descricao}*{horario[i].Recurso.Nome}");
                else
                    Console.Write($"*{horario[i].Disciplina.Descricao}*{horario[i].Recurso.Nome}\n");
            }

           
            Console.ReadKey();




            foreach (var item in GetRecursos())
            {
                Console.WriteLine(item.Nome);

                foreach (var disciplina in item.Competencias)
                {
                    Console.WriteLine("\t" + disciplina.Descricao);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }


        static List<Recurso> GetRecursos()
        {


            var recursos = new List<Recurso>();

            recursos.Add(new Recurso()
            {
                Id = 1,
                Nome = "Mathes Acosta",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 1, Descricao = "Desenvolvimento Web com HTML" },
                            new Disciplina { Id = 2, Descricao = "MS Project" },
                            new Disciplina { Id = 9, Descricao = "Excel - Básico Módulo I" },
                            new Disciplina { Id = 10, Descricao = "Excel Avançado Módulo II" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 2,
                Nome = "Mathias Viana",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 2, Descricao = "MS Project" },
                            new Disciplina { Id = 9, Descricao = "Excel - Básico Módulo I" },
                            new Disciplina { Id = 10, Descricao = "Excel Avançado Módulo II" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 3,
                Nome = "José Jackson",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 2, Descricao = "MS Project" },
                            new Disciplina { Id = 9, Descricao = "Excel - Básico Módulo I" },
                            new Disciplina { Id = 10, Descricao = "Excel Avançado Módulo II" } ,
                            new Disciplina { Id = 3, Descricao = "Word e PowerPoint" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 4,
                Nome = "Ivan Barbosa",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 2, Descricao = "MS Project" },
                            new Disciplina { Id = 9, Descricao = "Excel - Básico Módulo I" },
                            new Disciplina { Id = 10, Descricao = "Excel Avançado Módulo II" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 5,
                Nome = "Matheus Antunes",
                Competencias =
                new List<Disciplina> {
                    new Disciplina { Id = 4, Descricao = "Português: Regras e Uso Módulo I" },
                    new Disciplina { Id = 3, Descricao = "Word e PowerPoint" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 6,
                Nome = "Anderson Ferreira",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 9, Descricao = "Excel - Básico Módulo I" },
                            new Disciplina { Id = 10, Descricao = "Excel Avançado Módulo II" },
                            new Disciplina { Id = 3, Descricao = "Word e PowerPoint" } ,
                            new Disciplina { Id = 4, Descricao = "Português: Regras e Uso Módulo I" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 8,
                Nome = "Jaqueline Jesus",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 3, Descricao = "Word e PowerPoint" } ,
                            new Disciplina { Id = 4, Descricao = "Português: Regras e Uso Módulo I" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 9,
                Nome = "Willby Florencio",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 3, Descricao = "Word e PowerPoint" } ,
                            new Disciplina { Id = 4, Descricao = "Português: Regras e Uso Módulo I" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 10,
                Nome = "Ana Carolina",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 5, Descricao = "Inglês Intermediário 2" },
                            new Disciplina { Id = 6, Descricao = "Inglês - Básico 2" },
                            new Disciplina { Id = 7, Descricao = "Inglês - Básico 1" },
                            new Disciplina { Id = 8, Descricao = "Inglês: Intermediário 1" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 11,
                Nome = "Marcelo Leal",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 5, Descricao = "Inglês Intermediário 2" },
                            new Disciplina { Id = 6, Descricao = "Inglês - Básico 2" },
                            new Disciplina { Id = 7, Descricao = "Inglês - Básico 1" },
                            new Disciplina { Id = 8, Descricao = "Inglês: Intermediário 1" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 12,
                Nome = "Felipe Silvestre",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 5, Descricao = "Inglês Intermediário 2" },
                            new Disciplina { Id = 6, Descricao = "Inglês - Básico 2" },
                            new Disciplina { Id = 7, Descricao = "Inglês - Básico 1" },
                            new Disciplina { Id = 8, Descricao = "Inglês: Intermediário 1" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 13,
                Nome = "Jorge Paulo",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 5, Descricao = "Inglês Intermediário 2" },
                            new Disciplina { Id = 6, Descricao = "Inglês - Básico 2" },
                            new Disciplina { Id = 7, Descricao = "Inglês - Básico 1" },
                            new Disciplina { Id = 8, Descricao = "Inglês: Intermediário 1" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 14,
                Nome = "José Augsto",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 5, Descricao = "Inglês Intermediário 2" },
                            new Disciplina { Id = 6, Descricao = "Inglês - Básico 2" },
                            new Disciplina { Id = 7, Descricao = "Inglês - Básico 1" },
                            new Disciplina { Id = 8, Descricao = "Inglês: Intermediário 1" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 15,
                Nome = "Emerson Cassio",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 5, Descricao = "Inglês Intermediário 2" },
                            new Disciplina { Id = 6, Descricao = "Inglês - Básico 2" },
                            new Disciplina { Id = 7, Descricao = "Inglês - Básico 1" },
                            new Disciplina { Id = 8, Descricao = "Inglês: Intermediário 1" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 16,
                Nome = "Mariana Nolla",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 5, Descricao = "Inglês Intermediário 2" },
                            new Disciplina { Id = 6, Descricao = "Inglês - Básico 2" },
                            new Disciplina { Id = 7, Descricao = "Inglês - Básico 1" },
                            new Disciplina { Id = 8, Descricao = "Inglês: Intermediário 1" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 17,
                Nome = "Luciano Cesar",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 5, Descricao = "Inglês Intermediário 2" },
                            new Disciplina { Id = 6, Descricao = "Inglês - Básico 2" },
                            new Disciplina { Id = 7, Descricao = "Inglês - Básico 1" },
                            new Disciplina { Id = 8, Descricao = "Inglês: Intermediário 1" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 18,
                Nome = "Bruno Eric",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 5, Descricao = "Inglês Intermediário 2" },
                            new Disciplina { Id = 6, Descricao = "Inglês - Básico 2" },
                            new Disciplina { Id = 7, Descricao = "Inglês - Básico 1" },
                            new Disciplina { Id = 8, Descricao = "Inglês: Intermediário 1" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 19,
                Nome = "Renata Muzzy",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 5, Descricao = "Inglês Intermediário 2" },
                            new Disciplina { Id = 6, Descricao = "Inglês - Básico 2" },
                            new Disciplina { Id = 7, Descricao = "Inglês - Básico 1" },
                            new Disciplina { Id = 8, Descricao = "Inglês: Intermediário 1" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 20,
                Nome = "Carolina de Lima",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 5, Descricao = "Inglês Intermediário 2" },
                            new Disciplina { Id = 6, Descricao = "Inglês - Básico 2" },
                            new Disciplina { Id = 7, Descricao = "Inglês - Básico 1" },
                            new Disciplina { Id = 8, Descricao = "Inglês: Intermediário 1" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 21,
                Nome = "Eder Lemos",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 9, Descricao = "Excel - Básico Módulo I" },
                            new Disciplina { Id = 10, Descricao = "Excel Avançado Módulo II" } ,
                            new Disciplina { Id = 3, Descricao = "Word e PowerPoint" }
                }
            });

            recursos.Add(new Recurso()
            {
                Id = 22,
                Nome = "Luccas Nunes",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 9, Descricao = "Excel - Básico Módulo I" },
                            new Disciplina { Id = 10, Descricao = "Excel Avançado Módulo II" } ,
                            new Disciplina { Id = 3, Descricao = "Word e PowerPoint" }
                }
            });
            recursos.Add(new Recurso()
            {
                Id = 23,
                Nome = "Josiel Lemos",
                Competencias =
                new List<Disciplina> {
                            new Disciplina { Id = 2, Descricao = "MS Project" },
                            new Disciplina { Id = 9, Descricao = "Excel - Básico Módulo I" },
                            new Disciplina { Id = 10, Descricao = "Excel Avançado Módulo II" }
                }
            });

            return recursos;
        }

        static List<Turma> GetTurmas()
        {
            return new List<Turma>{
                new Turma { Id = 1, Dia = DayOfWeek.Monday, Descricao = "Sistemas de Informação", Disciplina = new List<Disciplina> { new Disciplina { Id = 1, Descricao = "Desenvolvimento Web com HTML" }, new Disciplina { Id = 8, Descricao = "Inglês: Intermediário 1" } } },
                new Turma { Id = 2, Dia = DayOfWeek.Monday, Descricao = "Tec. Redes de Computadores", Disciplina = new List<Disciplina> { new Disciplina { Id = 2, Descricao = "MS Project" }, new Disciplina { Id = 7, Descricao = "Inglês - Básico 1" } } },
                new Turma { Id = 3, Dia = DayOfWeek.Monday, Descricao = "Tec. Em Comércio Exterior", Disciplina = new List<Disciplina> { new Disciplina { Id = 3, Descricao = "Word e PowerPoint" }, new Disciplina { Id = 5, Descricao = "Inglês Intermediário 2" } } },
                new Turma { Id = 4, Dia = DayOfWeek.Monday, Descricao = "Ciências Contábeis", Disciplina = new List<Disciplina> { new Disciplina { Id = 10, Descricao = "Excel Avançado Módulo II" }, new Disciplina { Id = 5, Descricao = "Inglês Intermediário 2" } } },
                new Turma { Id = 5, Dia = DayOfWeek.Monday, Descricao = "Administração", Disciplina = new List<Disciplina> { new Disciplina { Id = 3, Descricao = "Word e PowerPoint" }, new Disciplina { Id = 6, Descricao = "Inglês - Básico 2" } } },
                new Turma { Id = 6, Dia = DayOfWeek.Monday, Descricao = "Ciências Contábeis", Disciplina = new List<Disciplina> { new Disciplina { Id = 10, Descricao = "Excel Avançado Módulo II" }, new Disciplina { Id = 5, Descricao = "Inglês Intermediário 2" } } },
                new Turma { Id = 7, Dia = DayOfWeek.Monday, Descricao = "Direito", Disciplina = new List<Disciplina> { new Disciplina { Id = 4, Descricao = "Português: Regras e Uso Módulo I" }, new Disciplina { Id = 6, Descricao = "Inglês - Básico 2" } } },
                new Turma { Id = 8, Dia = DayOfWeek.Monday, Descricao = "Psicologia", Disciplina = new List<Disciplina> { new Disciplina { Id = 3, Descricao = "Word e PowerPoint" }, new Disciplina { Id = 7, Descricao = "Inglês - Básico 1" } } },
                new Turma { Id = 9, Dia = DayOfWeek.Monday, Descricao = "Administração", Disciplina = new List<Disciplina> { new Disciplina { Id = 5, Descricao = "Inglês Intermediário 2" }, new Disciplina { Id = 3, Descricao = "Word e PowerPoint" } } },
                new Turma { Id = 10, Dia = DayOfWeek.Monday, Descricao = "Tec. Gestão de Recursos Humanos", Disciplina = new List<Disciplina> { new Disciplina { Id = 6, Descricao = "Inglês - Básico 2" }, new Disciplina { Id = 3, Descricao = "Word e PowerPoint" } } },
                new Turma { Id = 11, Dia = DayOfWeek.Monday, Descricao = "Tec. Em Análise e Desenvolvimento de Sistemas", Disciplina = new List<Disciplina> { new Disciplina { Id = 7, Descricao = "Inglês - Básico 1" }, new Disciplina { Id = 9, Descricao = "Excel - Básico Módulo I" } } },
                new Turma { Id = 12, Dia = DayOfWeek.Monday, Descricao = "Tec. Marketing", Disciplina = new List<Disciplina> { new Disciplina { Id = 8, Descricao = "Inglês: Intermediário 1" }, new Disciplina { Id = 9, Descricao = "Excel - Básico Módulo I" } } },
                new Turma { Id = 13, Dia = DayOfWeek.Monday, Descricao = "Administração", Disciplina = new List<Disciplina> { new Disciplina { Id = 6, Descricao = "Inglês - Básico 2" }, new Disciplina { Id = 3, Descricao = "Word e PowerPoint" } } },
                new Turma { Id = 14, Dia = DayOfWeek.Monday, Descricao = "Ciências Contábeis", Disciplina = new List<Disciplina> { new Disciplina { Id = 6, Descricao = "Inglês - Básico 2" }, new Disciplina { Id = 3, Descricao = "Word e PowerPoint" } } },
                new Turma { Id = 15, Dia = DayOfWeek.Monday, Descricao = "Direito", Disciplina = new List<Disciplina> { new Disciplina { Id = 7, Descricao = "Inglês - Básico 1" }, new Disciplina { Id = 4, Descricao = "Português: Regras e Uso Módulo I" } } },
                new Turma { Id = 16, Dia = DayOfWeek.Monday, Descricao = "Psicologia", Disciplina = new List<Disciplina> { new Disciplina { Id = 6, Descricao = "Inglês - Básico 2" }, new Disciplina { Id = 9, Descricao = "Excel - Básico Módulo I" } } },
                new Turma { Id = 17, Dia = DayOfWeek.Monday, Descricao = "Psicologia", Disciplina = new List<Disciplina> { new Disciplina { Id = 7, Descricao = "Inglês - Básico 1" }, new Disciplina { Id = 3, Descricao = "Word e PowerPoint" } } },
            };
        }
    }
}
