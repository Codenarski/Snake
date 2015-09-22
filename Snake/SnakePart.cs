using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class SnakePart<TCoordinate>: ISnakePart
    {
        private TCoordinate _startCoordinate;
        private Queue<ISnakePart> _queue = new Queue<ISnakePart>();
        public SnakePart(TCoordinate startCoordinate)
        {
            _startCoordinate = startCoordinate;
        }
        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
