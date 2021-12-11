using QuizApi.Domain.Dtos;
using QuizApi.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApi.Services.Abstractions
{
    public interface IPerguntaService
    {
        Task<ResultadoDto<string, dynamic>> getAllAsync();

        Task<ResultadoDto<string, dynamic>> getByIdAsync(int id);

        Task<ResultadoDto<string, dynamic>> getByTemaAsync(string tema);
    }
}
