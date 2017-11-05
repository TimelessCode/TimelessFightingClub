using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimatefightingleague
{
    class Fighter
    {
        public int hp = 100;
       public enum State
        {
            walking,
            jumping,
            punching
        }

       public State mystate = new State();
        //change from int to component class
      public  List<Icomponent> Components = new List<Icomponent>();

        //change from int to animation class
        List<int> Anims = new List<int>();

        public Icomponent getcomponent(Type t)
        {


           return Components.Find(i => i.GetType() == t);
        }
    }
}
