namespace Alocacao
{
    public class Horario
    {
        public int Periodo { get; set; }
        public Turma Turma { get; set; }
        public Recurso Recurso { get; set; }
        public Disciplina Disciplina { get; set; }

        public override string ToString()
        {
            return $"{Periodo}*{Turma.Descricao}*{Disciplina.Descricao}*{Recurso.Nome}";
        }
    }
}
