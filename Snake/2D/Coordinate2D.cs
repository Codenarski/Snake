using System;
using System.Collections.Generic;
using System.Drawing;

namespace Snake._2D
{
                      // ICoordinate<TCoordinate, TDirection>
    class Coordinate2D : ICoordinate<Point, Direction2D>
    {
        private Direction2D _direction;
        private Point _point;
        private KeyValuePair<Point, Direction2D> _last; 

        public Coordinate2D(Direction2D direction,Point point)
        {
            _direction = direction;
            _point = point;
            _last = new KeyValuePair<Point, Direction2D>(_point, _direction);
        }

        public void ChangeTo(KeyValuePair<Point, Direction2D> newCoordinate)
        {
            _last = new KeyValuePair<Point, Direction2D>(_point, _direction);
            _point = newCoordinate.Key;
            _direction = newCoordinate.Value;            
        }       

        public void ChangeToPreviousByDirection(Direction2D direction)
        {
            _last = new KeyValuePair<Point, Direction2D>(_point, _direction);
            _direction = direction;
            _point = MakePreviousPointByDirection();
        }

        private Point MakePreviousPointByDirection()
        {
            var newPoint = new Point(_point.X, _point.Y);
            switch (_direction)
            {
                case Direction2D.Up:
                    newPoint.Y++;
                    break;
                case Direction2D.Down:
                    newPoint.Y--;
                    break;
                case Direction2D.Left:
                    newPoint.X++;
                    break;
                case Direction2D.Right:
                    newPoint.X--;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_direction), _direction, null);
            }
            return newPoint;
        }

        public void ChangeToNextByDirection(Direction2D newDirection)
        {
            _last = new KeyValuePair<Point, Direction2D>(_point, _direction);
            _direction = newDirection;
            _point = MakeNextPointByDirection();
        }

        public ICoordinate<Point, Direction2D> MakeNextByDirection()
        {
            return new Coordinate2D(_direction, MakeNextPointByDirection());    
        }

        private Point MakeNextPointByDirection()
        {
            var newPoint = new Point(_point.X, _point.Y);

            switch (_direction)
            {
                case Direction2D.Up:
                    newPoint.Y--;
                    break;
                case Direction2D.Down:
                    newPoint.Y++;
                    break;
                case Direction2D.Left:
                    newPoint.X--;
                    break;
                case Direction2D.Right:
                    newPoint.X++;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_direction), _direction, null);
            }

            return newPoint;
        }

        public ICoordinate<Point, Direction2D> MakePreviousByDirection()
        {
            return new Coordinate2D(_direction, MakePreviousPointByDirection());
        }

        public Point CurrentCoordinate()
        {
            return _point;
        }

        public Direction2D CurrentDirection()
        {
            return _direction;
        }

        public KeyValuePair<Point, Direction2D> Last()
        {
            return _last;
        }
    }
}