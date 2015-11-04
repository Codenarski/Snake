using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    interface ICoordinate<TCoordinate, TDirection>
    {
        void ChangeTo(TCoordinate newCoordinate);
        void NextByDirection(TDirection newDirection);
        ICoordinate<TCoordinate, TDirection> GetPrevious();
        TCoordinate Current();
        TCoordinate Last();
    }
}
