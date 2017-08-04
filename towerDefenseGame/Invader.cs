using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towerDefenseGame
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        //c# Auto properti - Automatic implements a getter and setter
        public MapLocation Location { get; private set; }

        public Invader(Path path) // Constructor
        {
            _path = path;
            Location = _path.GetLocationAt(_pathStep);
        }

        public void Move() // Method
        {
            _pathStep += 1;
            Location = _path.GetLocationAt(_pathStep);
        }
        
    }
}
