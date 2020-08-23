using System.Threading.Tasks;
using AngularJeopardy.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AngularJeopardy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JeopardyController : ControllerBase
    {
        private readonly IJeopardyService _jeopardyService;
        
        public JeopardyController(IJeopardyService jeopardyService)
        {
            _jeopardyService = jeopardyService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _jeopardyService.GetQuestionsByCategoryAsync();

            return Ok(categories);
        }
    }
}