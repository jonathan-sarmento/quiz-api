using QuizApi.Domain.Enums;
using System.Collections.Generic;

namespace QuizApi.Domain.Entities
{
    public class Pergunta : SimpleId
    {
        public string Enunciado { get; set; }

        public Tema Tema { get; set; }

        public List<Alternativa> Alternativas { get; set; }
    }
}
