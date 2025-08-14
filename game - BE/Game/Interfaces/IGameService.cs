using Game.Models;

namespace Game.Interfaces
{
    public interface IGameService
    {
        public IEnumerable<ChoiceModel> GetAllChoices();
        public Task<ChoiceModel> GetRandomChoiceFromApiAsync();
        public Task<ResultModel?> PlayGameAsync(int playerChoiceId);
    }
}
