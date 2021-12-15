using QuizApi.Domain.Dtos;
using QuizApi.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApi.Services.Abstractions
{
    public interface IPerguntaService
    {
        Task<List<PerguntaDto>> getAllAsync();

        Task<PerguntaDto> getByIdAsync(int id);

        Task<List<PerguntaDto>> getByTemaAsync(string tema);
    }
}
