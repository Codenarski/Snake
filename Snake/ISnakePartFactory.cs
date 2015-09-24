namespace Snake
{
    interface ISnakePartFactory<TCoordinate>
    {
        ISnakePart<TCoordinate> MakeHeadPart(ICoordinate<TCoordinate> startCoordinate);
        ISnakePart<TCoordinate> MakeTailPart(ISnakePart<TCoordinate> previousSnakePart);
    }
}