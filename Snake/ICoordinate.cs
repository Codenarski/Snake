using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    interface ICoordinate<TCoordinate>
    {
        void ChangeTo(TCoordinate newCoordinate);
        ICoordinate<TCoordinate> GetPrevious();
        TCoordinate Current();
        TCoordinate Last();
    }
}
