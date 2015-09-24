namespace Snake
{
    class SnakePartFactory<TCoordinate> : ISnakePartFactory<TCoordinate>
    {
        public ISnakePart<TCoordinate> MakeHeadPart(ICoordinate<TCoordinate> startCoordinate)
        {
           return new SnakePart<TCoordinate>(startCoordinate);
        }

        public ISnakePart<TCoordinate> MakeTailPart(ISnakePart<TCoordinate> previousSnakePart)
        {
            return new SnakePart<TCoordinate>(previousSnakePart);
        }
    }
}