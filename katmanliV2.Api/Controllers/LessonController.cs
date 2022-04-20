using katmanliV2.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace katmanliV2.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LessonController : Controller
    {
        private readonly ILessonService _lessonService;
        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var data = await _lessonService.GetById(id);
            return Ok(data);
        }
    }
}
