namespace Snake
{
    interface ISnakePartFactory<TCoordinate, TDirection>
    {
        ISnakePart<TCoordinate, TDirection> MakeHeadPart(ICoordinate<TCoordinate> startCoordinate);
        ISnakePart<TCoordinate, TDirection> MakeTailPart(ISnakePart<TCoordinate, TDirection> previousSnakePart);
    }
}