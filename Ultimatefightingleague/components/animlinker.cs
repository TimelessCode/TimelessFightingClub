using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimatefightingleague
{
    class animlinker : Icomponent
    {
        
        public void Update()
        {
            
        }

        public Dictionary<Fighter.State, Animation> links = new Dictionary<Fighter.State, Animation>();
    }
}
