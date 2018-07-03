using JRCFAlocacao.Data;
using System;
using System.Collections.Generic;

namespace JRCFAlocacao.Domain
{
    public class Recurso : DocumentItem
    {
        public Recurso()
        {
            Key = Guid.NewGuid().ToString();
        }

        public string Key { get; set; }
        public string Matricula { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<string> Telefones { get; set; }
        public Area Area { get; set; }
        public Campus Campus { get; set; }
        public DateTime Admissao { get; set; }
        public DateTime? Desligamento { get; set; }
        public List<Disciplina> Competencias { get; set; }
        public Dictionary<string, int> Caracteristicas { get; set; }
    }
}
