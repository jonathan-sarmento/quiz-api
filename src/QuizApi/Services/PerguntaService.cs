using Microsoft.EntityFrameworkCore;
using QuizApi.Domain.Dtos;
using QuizApi.Domain.Entities;
using QuizApi.Repositories;
using QuizApi.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApi.Services
{
    public class PerguntaService : IPerguntaService
    {
        PerguntaRepository _perguntaRepo;
        public PerguntaService(PerguntaRepository perguntaRepo)
        {
            _perguntaRepo = perguntaRepo;
        }
        public async Task<ResultadoDto<string, dynamic>> getAllAsync()
        {
            try
            {
                List<Pergunta> perguntas = await _perguntaRepo.SelectAll().ToListAsync();
                ResultadoDto<string, dynamic> resultados = new ResultadoDto<string, dynamic>();
                foreach(Pergunta pergunta in perguntas)
                {
                    resultados.Resultados.Add("Id", pergunta.Id);
                    resultados.Resultados.Add("Enunciado", pergunta.Enunciado);
                    resultados.Resultados.Add("Tema", pergunta.Tema.ToString());
                }
                return resultados;
            }
            catch (Exception ex)
            {
                ResultadoDto<string, dynamic> resultado = new ResultadoDto<string, dynamic>();
                resultado.Resultados.Add("Erro", ex.Message);
                resultado.Resultados.Add("Detalhes de erro", ex.InnerException.Message);
                return resultado;
            }
        }

        public async Task<ResultadoDto<string, dynamic>> getByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ResultadoDto<string, dynamic>> getByTemaAsync(string tema)
        {
            throw new System.NotImplementedException();
        }
    }
}
