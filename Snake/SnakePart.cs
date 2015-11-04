using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class SnakePart<TCoordinate, TDirection> : ISnakePart<TCoordinate, TDirection>
    {
        private ICoordinate<TCoordinate, TDirection> _coordinate;        
        public SnakePart(ICoordinate<TCoordinate, TDirection> startCoordinate)
        {
            _coordinate = startCoordinate;
        }    

        public void Move(TDirection newDirection)
        {
            _coordinate.ChangeToNextByDirection(newDirection);
        }

        public void Move(ISnakePart<TCoordinate, TDirection> successorPart)
        {
            _coordinate.ChangeTo(successorPart.Coordinate().Last());
        }

        ICoordinate<TCoordinate, TDirection> ISnakePart<TCoordinate, TDirection>.Coordinate()
        {
            return _coordinate;
        }
    }
}