namespace Snake
{
    interface ISnakePartFactory<TCoordinate, TDirection>
    {
        ISnakePart<TCoordinate, TDirection> MakeSnakePart(ICoordinate<TCoordinate, TDirection> startCoordinate);        
    }
}