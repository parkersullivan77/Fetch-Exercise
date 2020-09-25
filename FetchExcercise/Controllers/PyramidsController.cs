using Microsoft.AspNetCore.Mvc;
using FetchExcercise.Modles;
using FetchExcercise.Data;

namespace FetchExcercise.Controllers
{
    [Route("api/Pyramids")]
    [ApiController]
    public class PyramidsController : ControllerBase
    {
        private readonly  TestRepo _repository = new TestRepo();
        
        [HttpGet("{word}")]
        public ActionResult <Pyramid> determinePyramid(string word)
        {
            
            var pyramidItems = _repository.isPyramidWord(word);
            
            
            return Ok(pyramidItems);
        }

    }
}       