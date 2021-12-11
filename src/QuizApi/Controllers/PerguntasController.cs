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
    }
}
