using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Direction<TDirection> : IDirection<TDirection>
    {
        public void Move(TDirection intoDirection)
        {
            throw new NotImplementedException();
        }
    }
}
