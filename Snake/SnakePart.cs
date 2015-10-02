using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class SnakePart<TCoordinate, TDirection> : ISnakePart<TCoordinate, TDirection>
    {
        private ICoordinate<TCoordinate> _coordinate;        
        public SnakePart(ICoordinate<TCoordinate> startCoordinate)
        {
            _coordinate = startCoordinate;
        }

        public SnakePart(ISnakePart<TCoordinate, TDirection> previousSnakePart)
        {
            _coordinate = previousSnakePart.Coordinate().GetPrevious();
        }

        public void Move(TDirection newDirection)
        {
            throw new NotImplementedException();
        }

        public void Move(ISnakePart<TCoordinate, TDirection> successorPart)
        {
            _coordinate.ChangeTo(successorPart.Coordinate().Last());
        }

        ICoordinate<TCoordinate> ISnakePart<TCoordinate, TDirection>.Coordinate()
        {
            return _coordinate;
        }
    }
}