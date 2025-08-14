using Game.Interfaces;
using Game.Models;
using Microsoft.AspNetCore.Mvc;

namespace Game.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("choices")]
        public ActionResult<IEnumerable<ChoiceModel>> GetChoices()
        {
            return Ok(_gameService.GetAllChoices());
        }

        [HttpGet("randomChoice")]
        public async Task<IActionResult> GetRandomChoice()
        {
            var choice = await _gameService.GetRandomChoiceFromApiAsync();
            return Ok(choice);
        }

        [HttpPost("play")]
        public async Task<IActionResult> PlayGame([FromBody] PlayRequestModel playRequest)
        {
            var result = await _gameService.PlayGameAsync(playRequest.choice_id);

            if (result == null)
            {
                return NotFound("Game result not found.");
            }

            return Ok(result);
        }
    }
}
