﻿using AutoMapper;
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
        private readonly IMapper _mapper;
        public PerguntaService(IPerguntaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<PerguntaDto>> getAllAsync()
        {
            try
            {
                // return await _repository.SelectAll().Include(x => x.Alternativas)
                // .Select(x => new Pergunta()
                // {
                //     Id = x.Id,
                //     Enunciado = x.Enunciado,
                //     Tema = x.Tema,
                //     Alternativas = x.Alternativas.Select(c => new Alternativa(){
                //         Id = c.Id,
                //         Descricao = c.Descricao
                //     }).ToList()
                // })
                // .ToListAsync();


                return await _repository.SelectAll()
                                                .Include(x => x.Alternativas)
                                                .Select(x => _mapper.Map<PerguntaDto>(x))
                                                .ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<PerguntaDto> getByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<PerguntaDto>> getByTemaAsync(string tema)
        {
            throw new System.NotImplementedException();
        }
    }
}
