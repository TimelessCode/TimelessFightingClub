using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Ultimatefightingleague
{
    class Animation
    {
        /*
        It needs a value for the size of one frame , the amount of frames in the anim , and the row
        from there you can go to the row ( defined by the height of the tex/#rows )
        draw the first frame ( a rect -> 0,0 is offset,row height  widht/height defind in frame) 
        and the next one ( same y but this time with offset + frame width 
        */
       public Vector2 framesize;
        public int framenumber;
        public int offset;
        public int row;
        public int rowamount;
        public Texture2D tex;
        public int currentframe;
     
       
    }
}
