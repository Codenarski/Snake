namespace Snake
{
    class SnakePartFactory<TCoordinate, TDirection> : ISnakePartFactory<TCoordinate, TDirection>
    {
        public ISnakePart<TCoordinate, TDirection> MakeHeadPart(ICoordinate<TCoordinate, TDirection> startCoordinate)
        {
           return new SnakePart<TCoordinate, TDirection>(startCoordinate);
        }

        public ISnakePart<TCoordinate, TDirection> MakeTailPart(ISnakePart<TCoordinate, TDirection> previousSnakePart)
        {
           return new SnakePart<TCoordinate, TDirection>(previousSnakePart);
        }
    }
}