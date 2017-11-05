using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Ultimatefightingleague
{
    class AnimationDrawSystem
    {
        void findsourcerect(Animation a)
        {
            int rowamount = 0;
            int currentframe = 0;
            //x=offset y width height
            Rectangle sourcerect = new Rectangle((int)(a.offset + (a.framesize.X * currentframe)), (a.tex.Height / rowamount) * a.row, (int)a.framesize.X, (int)a.framesize.Y);
        }
    }
}
