using AutoMapper;
using QuizApi.Domain.Dtos;
using QuizApi.Domain.Entities;

namespace QuizApi.Repositories.Profiles
{
    public class PerguntaProfile : Profile
    {
        public PerguntaProfile()
        {
            CreateMap<Pergunta, PerguntaDto>();
        }
    }
}