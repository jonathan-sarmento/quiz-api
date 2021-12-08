using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizApi.Domain.Entities;
using QuizApi.Repositories.Abstractions;

namespace QuizApi.Repositories
{
    public class PerguntaRepository : Repository<Pergunta>, IPerguntaRepository
    {
       public PerguntaRepository(DbContext context) : base(context)
       {
           
       }
    }
}