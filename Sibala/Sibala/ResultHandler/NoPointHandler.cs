namespace Sibala.ResultHandler
{
    public class NoPointHandler : ISibalaResultHandler
    {
        private SibalaGame _sibalaGame;

        public NoPointHandler(SibalaGame sibalaGame)
        {
            _sibalaGame = sibalaGame;
        }

        public void SetResult()
        {
            _sibalaGame.Type = SibalaType.NoPoint;
            _sibalaGame.Points = 0;
            _sibalaGame.Output = "No Point";
            _sibalaGame.MaxPoint = _sibalaGame.Points;
        }
    }
}