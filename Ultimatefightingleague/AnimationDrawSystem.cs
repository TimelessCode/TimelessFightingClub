using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Ultimatefightingleague.components;

namespace Ultimatefightingleague
{
    class AnimationDrawSystem
    {
        Rectangle findsourcerect(Animation a)
        {
            Rectangle sourcerect = new Rectangle((int)(a.offset + (a.framesize.X * a.currentframe)), (a.tex.Height / a.rowamount) * a.row, (int)a.framesize.X, (int)a.framesize.Y);
            return sourcerect;
        }


        public void drawfighter( SpriteBatch sb ,Fighter f)
        {
            //turn this into a switch soon
            if (f.mystate == Fighter.State.walking) {
                //get the animlinker to find the animation for the current state,
                animlinker al = (animlinker)f.getcomponent(typeof(animlinker));
                //get the movement to get the position of the dudeman
                Movement m = (Movement)f.getcomponent(typeof(Movement));
                //get the animation
                Animation a = al.links[Fighter.State.walking];
                //Draw it baby
                sb.Draw(a.tex,new Rectangle(m.x,m.y,100,100),findsourcerect(a),Color.White);
                    }
        }
    }
}
