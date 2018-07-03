using System;
using System.Collections.Generic;

namespace Alocacao
{
    public class Turma
    {
        public Turma()
        {
           
        }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DayOfWeek Dia { get; set; }
        public List<Disciplina> Disciplina { get; set; }
    }
}
