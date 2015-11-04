using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using Snake._2D;

namespace Snake
{
    class Coordinate2D : ICoordinate<Point, Direction2D>
    {
        private Direction2D _direction;
        private Point _point;
        private ICoordinate<Point, Direction2D> _last; 

        public Coordinate2D(Direction2D direction,Point point)
        {
            _direction = direction;
            _point = point;
            _last = new Coordinate2D(_direction,_point);
        }

        public void ChangeTo(ICoordinate<Point, Direction2D> newCoordinate)
        {
            _last = new Coordinate2D(_direction, _point);
            _point = newCoordinate.CurrentCoordinate();
            _direction = newCoordinate.CurrentDirection();            
        }       

        public void ChangeToPreviousByDirection(Direction2D direction)
        {
            _direction = direction;
            switch (_direction)
            {
                case Direction2D.Up:
                    _point.Y++;
                    break;
                case Direction2D.Down:
                    _point.Y--;
                    break;
                case Direction2D.Left:
                    _point.X++;
                    break;
                case Direction2D.Right:
                    _point.X--;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_direction), _direction, null);
            }
        }

        public void ChangeToNextByDirection(Direction2D newDirection)
        {
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
            throw new NotImplementedException();
        }

        public Point CurrentCoordinate()
        {
            return _point;
        }

        public Direction2D CurrentDirection()
        {
            return _direction;
        }

        ICoordinate<Point, Direction2D> ICoordinate<Point, Direction2D>.Last()
        {
            return _last;
        }
    }
}