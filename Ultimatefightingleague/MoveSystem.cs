using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ultimatefightingleague.components;

namespace Ultimatefightingleague
{
    class MoveSystem
    {
        public List<Fighter> chars = new List<Fighter>();
        public List<Movement> movements = new List<Movement>();


        //this will add a movement to the fighter and stuff it in the right list
        public void add(Fighter c){
            c.Components.Add(new Movement()); chars.Add(c);
            Movement m = (Movement)c.Components.Find(i => i.GetType() == typeof(Movement));
            m.owner = c;
            movements.Add(m);
        }
     

        public void update_mo()
        {

            foreach (Movement item in movements)
            {
                item.Update();
                System.Diagnostics.Debug.WriteLine(item.x + "Is the x");
            }

        }
    }
}
