namespace Snake
{
    class SnakePartFactory<TCoordinate, TDirection> : ISnakePartFactory<TCoordinate, TDirection>
    {
        public ISnakePart<TCoordinate, TDirection> MakeSnakePart(ICoordinate<TCoordinate, TDirection> startCoordinate)
        {
            return new SnakePart<TCoordinate, TDirection>(startCoordinate);
        }
    }
}