namespace Game.Models
{
    public class ResultModel
    {
        public int PlayerChoiceId { get; set; }
        public int ComputerChoiceId { get; set; }
        public required string Result { get; set; }
    }
}
