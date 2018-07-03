using System.Collections.Generic;

namespace Alocacao
{
    public class Recurso
    {
        public int Id { get; set; }
        public string  Nome { get; set; }

        public List<Disciplina> Competencias { get; set; }
    }
}
