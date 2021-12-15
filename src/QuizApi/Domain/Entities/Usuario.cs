using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApi.Domain.Entities
{
    public class Usuario : SimpleId
    {
        public string Nome { get; set; }
        public string LinkImagem { get; set; }
        public int Pontuacao { get; set; }

    }
}
