using System.ComponentModel.DataAnnotations;

namespace QuizApi.Domain.Entities
{
    public abstract class SimpleId
    {
        [Key]
        public string Id { get; set; }
    }
}
