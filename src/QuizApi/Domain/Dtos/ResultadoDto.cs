using System;
using System.Collections.Generic;

namespace QuizApi.Domain.Dtos
{
    public class ResultadoDto<T, V>
    {
        public IDictionary<T, V> Resultados { get; set; }
    }
}
