namespace QuizApi.Domain.Entities
{
    public class Alternativa : SimpleId
    {
        public string Descricao { get; set; }
        public bool RespostaCerta { get; set; }
        public int PerguntaId { get; set; }
        public Pergunta Pergunta { get; set; }
    }
}
