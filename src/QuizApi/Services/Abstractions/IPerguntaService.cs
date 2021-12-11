using QuizApi.Domain.Dtos;
using QuizApi.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApi.Services.Abstractions
{
    public interface IPerguntaService
    {
        Task<List<ResultadoDto>> getAllAsync();

        Task<ResultadoDto> getByIdAsync(int id);

        Task<List<ResultadoDto>> getByTemaAsync(string tema);
    }
}
