using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Snake<TCoordinate, TDirection> : ISnake<TDirection>
    {
        private ICoordinate<TCoordinate> _startCoordinate;
        private TDirection _currentDirection;
        private readonly int _initialSize;
        private readonly ISnakePartFactory<TCoordinate> _snakePartFactory;
        private Queue<ISnakePart<TCoordinate>> _queue = new Queue<ISnakePart<TCoordinate>>();

        public Snake(ICoordinate<TCoordinate> startCoordinate, TDirection currentDirection, int initialSize, ISnakePartFactory<TCoordinate> snakePartFactory)
        {
            _startCoordinate = startCoordinate;
            _currentDirection = currentDirection;
            _initialSize = initialSize;
            _snakePartFactory = snakePartFactory;
            InitSnake();
        }

        private void InitSnake()
        {
            InitSnakeHead();
            InitSnakeTail();
        }

        private void InitSnakeTail()
        {
            for (var i = 0; i <= _initialSize; i++)
                AddNewSnakeTailPart();            
        }

        private void InitSnakeHead()
        {
            var snakeHead = _snakePartFactory.MakeHeadPart(_startCoordinate);
            _queue.Enqueue(snakeHead);
        }


        public void Grow()
        {            
            AddNewSnakeTailPart();
        }

        private void AddNewSnakeTailPart()
        {
            var snakeTailPart = _snakePartFactory.MakeTailPart(_queue.Last());
            _queue.Enqueue(snakeTailPart);
        }

        public void Move(TDirection newDirection)
        {
            throw new NotImplementedException();
        }
    }
}
