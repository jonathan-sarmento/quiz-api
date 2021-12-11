using System;
using System.Collections.Generic;

namespace QuizApi.Domain.Dtos
{
    public class ResultadoDto
    {
        public int Id { get; set; }

        public string Enunciado { get; set; }

        public string Tema { get; set; }
    }
}
