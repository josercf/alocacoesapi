using JRCFAlocacao.Data;
using System;

namespace JRCFAlocacao.Domain
{
    public class Disciplina : DocumentItem
    {
        public Disciplina()
        {
            Key = Guid.NewGuid().ToString();
        }

        public string Key { get; set; }
        public string Descricao { get; set; }
    }
}
