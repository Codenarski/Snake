using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Snake<TCoordinate> : ISnake
    {
        private TCoordinate _startCoordinate;

        public Snake(TCoordinate startCoordinate)
        {
            _startCoordinate = startCoordinate;
        }


        public void Grow()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
