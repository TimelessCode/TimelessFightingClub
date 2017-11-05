using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ultimatefightingleague.components;

namespace Ultimatefightingleague
{
    class DamageSystem
    {
        public List<Fighter> fighters = new List<Fighter>();

      public  void update()
        {
            // f is the attacker
            for (int i = 0; i < fighters.Count; i++)
            {

            
            
                //if the fighter is punching
                if (fighters[i].mystate == Fighter.State.punching)
                {

                    //get the combatants
                    Movement att = (Movement)fighters[i].getcomponent(typeof(Movement));
                    Movement def;
                    if (i == 0)
                    {
                        def = (Movement)fighters[1].getcomponent(typeof(Movement));
                    }
                    else
                    {
                         def = (Movement)fighters[0].getcomponent(typeof(Movement));
                    }
                    
                        if(((def.x > att.x) && ((def.x - att.x) < 20 ) )/*add neg condition next*/ )
                    {
                        System.Diagnostics.Debug.WriteLine("punch");
                    }
                    else if ((def.x < att.x) && ((att.x- def.x ) < 20 /*add neg condition next*/ ))
                    {
                        System.Diagnostics.Debug.WriteLine("punch");
                    }

                    fighters[i].mystate = Fighter.State.walking;
                }
            }

        }
    }
}
