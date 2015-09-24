using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class SnakePart<TCoordinate> : ISnakePart<TCoordinate>
    {
        private readonly ICoordinate<TCoordinate> _startCoordinate;        
        public SnakePart(ICoordinate<TCoordinate> startCoordinate)
        {
            _startCoordinate = startCoordinate;
        }

        public SnakePart(ISnakePart<TCoordinate> previousSnakePart)
        {
            _startCoordinate = previousSnakePart.Coordinate().GetPrevious();
        }

        public void Move()
        {
        }

        ICoordinate<TCoordinate> ISnakePart<TCoordinate>.Coordinate()
        {
            return _startCoordinate;
        }
    }
}