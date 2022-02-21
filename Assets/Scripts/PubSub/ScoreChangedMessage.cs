namespace PubSub
{
    public class ScoreChangedMessage : IMessage
    {
        public int Score { get; }

        public ScoreChangedMessage(int score)
        {
            Score = score;
        }
    }
}