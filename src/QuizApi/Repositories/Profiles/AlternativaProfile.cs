using AutoMapper;
using QuizApi.Domain.Dtos;
using QuizApi.Domain.Entities;

namespace QuizApi.Repositories.Profiles
{
    public class AlternativaProfile : Profile
    {
        public AlternativaProfile()
        {
            CreateMap<Alternativa, AlternativaDto>();
        }
    }
}