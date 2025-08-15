using Game.Interfaces;
using Game.Models;

namespace Game.Services
{
    public class GameService : IGameService
    {
        private readonly List<ChoiceModel> _choices = new()
        {
            new ChoiceModel { Id = 1, Name = "rock" },
            new ChoiceModel { Id = 2, Name = "paper" },
            new ChoiceModel { Id = 3, Name = "scissors" },
            new ChoiceModel { Id = 4, Name = "lizard" },
            new ChoiceModel { Id = 5, Name = "spock" }
        };

        private static readonly Dictionary<int, HashSet<int>> WinningMap = new()
        {
            { 1, new HashSet<int> { 3, 4 } }, // rock beats scissors, lizard
            { 2, new HashSet<int> { 1, 5 } }, // paper beats rock, spock
            { 3, new HashSet<int> { 2, 4 } }, // scissors beats paper, lizard
            { 4, new HashSet<int> { 2, 5 } }, // lizard beats paper, spock
            { 5, new HashSet<int> { 1, 3 } }  // spock beats rock, scissors
        };

        private readonly IHelperApisService _helperApisService;
        public GameService(IHelperApisService helperApisService)
        {
            _helperApisService = helperApisService;
        }

        public IEnumerable<ChoiceModel> GetAllChoices()
        {
            return _choices;
        }

        public async Task<ChoiceModel> GetRandomChoiceFromApiAsync()
        {
            int randomNumber = await _helperApisService.GetRandomIndexAsync();
            int index = (randomNumber - 1) % _choices.Count;

            return _choices[index];
        }

        public async Task<ResultModel> PlayGameAsync(int playerChoiceId)
        {
            var comoputerChoice = await GetRandomChoiceFromApiAsync();

            var result = new ResultModel
            {
                PlayerChoiceId = playerChoiceId,
                ComputerChoiceId = comoputerChoice.Id,
                Result = DetermineResult(playerChoiceId, comoputerChoice.Id)
            };

            return result;
        }

        private string DetermineResult(int playerChoiceId, int computerChoiceId)
        {
            if (playerChoiceId == computerChoiceId)
                return "tie";

            if (WinningMap.TryGetValue(playerChoiceId, out var beats) && beats.Contains(computerChoiceId))
                return "win";

            return "lose";
        }
    }
}
