using System;
using System.Collections.Generic;

namespace QuizApi.Domain.Dtos
{
    public class PerguntaDto
    {
        public int Id { get; set; }
        public string Enunciado { get; set; }
        public string Tema { get; set; }
        public List<AlternativaDto> Alternativas { get; set; }

    }
}
