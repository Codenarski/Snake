using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snake._2D;

namespace Snake
{
    interface ICoordinate<TCoordinate, TDirection>
    {

        void ChangeTo(ICoordinate<TCoordinate, TDirection> newCoordinate);
        void ChangeToNextByDirection(TDirection newDirection);
        void ChangeToPreviousByDirection(Direction2D direction);

        ICoordinate<TCoordinate, TDirection> MakeNextByDirection();
        ICoordinate<TCoordinate, TDirection> MakePreviousByDirection();


        TCoordinate CurrentCoordinate();
        TDirection CurrentDirection();

        ICoordinate<TCoordinate, TDirection> Last();

    }
}
