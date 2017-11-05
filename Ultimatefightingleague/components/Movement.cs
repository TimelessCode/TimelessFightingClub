using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Ultimatefightingleague.components
{
    class Movement : Icomponent
    {


        public  void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right)) {

                owner.mystate = Fighter.State.walking;
                x += 10;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {

                owner.mystate = Fighter.State.walking;
                x -= 10;
            }


            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {

                owner.mystate = Fighter.State.walking;
                y -= 5;
            }



            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {

                owner.mystate = Fighter.State.walking;
                 y += 5;
            }


            if (Keyboard.GetState().IsKeyDown(Keys.Z))
            {

                owner.mystate = Fighter.State.punching;
                
            }
        }

        public Fighter owner;
        public int x = 0;
        public int y = 0;
    }
}
