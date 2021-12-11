using Microsoft.EntityFrameworkCore;
using QuizApi.Domain.Dtos;
using QuizApi.Domain.Entities;
using QuizApi.Repositories;
using QuizApi.Repositories.Abstractions;
using QuizApi.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApi.Services
{
    public class PerguntaService : IPerguntaService
    {
        private readonly IPerguntaRepository _repository;
        public PerguntaService(IPerguntaRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<ResultadoDto>> getAllAsync()
        {
            try
            {
                List<Pergunta> perguntas = await _repository.SelectAll().ToListAsync();
                List<ResultadoDto> resultados = new List<ResultadoDto>();
                perguntas.ForEach(pergunta => resultados.Add(new ResultadoDto
                {
                    Tema = pergunta.Tema.ToString(),
                    Id = pergunta.Id,
                    Enunciado = pergunta.Enunciado
                }));
                return resultados;
            }
            catch
            {
                return null;
            }
        }

        public async Task<ResultadoDto> getByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<ResultadoDto>> getByTemaAsync(string tema)
        {
            throw new System.NotImplementedException();
        }
    }
}
