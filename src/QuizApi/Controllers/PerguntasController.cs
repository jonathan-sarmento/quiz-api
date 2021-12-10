using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QuizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerguntasController : ApiBaseController
    {
        public IActionResult Index() 
            => ApiOk("Bem vindo ao quiz-api!");
    }
}
