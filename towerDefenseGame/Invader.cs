using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towerDefenseGame
{
    class Invader
    {
        private MapLocation _loaction;

        //Properties
        public MapLocation Location
        {
            get
            {
                return _loaction;
            }
            set
            {
                _loaction = value;
                Console.WriteLine("Lacation changed");
            }
        }
    }
}
