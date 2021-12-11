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
        IPerguntaService _perguntasService;
        public PerguntasController(IPerguntaService perguntaService)
        {
            _perguntasService = perguntaService;
        }
        public async Task<IActionResult> Index() 
            => ApiOk(await _perguntasService.getAllAsync());
    }
}
