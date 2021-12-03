using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApi.Domain.Entities
{
    public class Usuario : SimpleId
    {
        public string nome { get; set; }

        public string linkImagem { get; set; }
    }
}
