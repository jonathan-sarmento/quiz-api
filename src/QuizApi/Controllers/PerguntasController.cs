using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizApi.Services.Abstractions;
using System.Threading.Tasks;

namespace QuizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerguntasController : ApiBaseController
    {
        private readonly IPerguntaService _perguntasService;
        public PerguntasController(IPerguntaService perguntaService)
        {
            _perguntasService = perguntaService;
        }

        [HttpGet]
        public async Task<IActionResult> Index() 
            => ApiOk(await _perguntasService.getAllAsync());

        [HttpGet]
        [Route("/ById/{id}")]
        public async Task<IActionResult> GetById(int id)
            => ApiOk(await _perguntasService.getByIdAsync(id));

        [HttpGet]
        [Route("/ByTheme/{tema}")]
        public async Task<IActionResult> GetByTheme(string tema)
            => ApiOk(await _perguntasService.getByTemaAsync(tema));
    }
}
