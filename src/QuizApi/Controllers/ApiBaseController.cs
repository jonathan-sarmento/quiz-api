using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizApi.Api;

namespace QuizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBaseController : ControllerBase
    {
        protected OkObjectResult ApiOk<T>(T Results) 
            => Ok(CustomResponse("", true, Results));
        protected OkObjectResult ApiOk(string Message = "") 
            => Ok(CustomResponse(Message, true));
        protected CreatedResult ApiCreated(string Message = "") 
            => Created("", CustomResponse(Message, true));
        protected NotFoundObjectResult ApiNotFound(string Message = "") 
            => NotFound(CustomResponse(Message, false));
        protected BadRequestObjectResult ApiBadRequest<T>(T results, string Message = "") 
            => BadRequest(CustomResponse(Message, false, results));


        #region Metodos privados
        ApiResponse<T> CustomResponse<T>(string message, bool succeed, T results) =>
            new ApiResponse<T>()
            {
                Message = message,
                Succeed = succeed,
                Results = results
            };

        ApiResponse<string> CustomResponse(string message, bool succeed) =>
            new ApiResponse<string>()
            {
                Message = message,
                Succeed = succeed,
            };

        #endregion
    }
}
