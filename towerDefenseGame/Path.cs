using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towerDefenseGame
{
    class Path
    {
        private readonly MapLocation[] _path;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public double GetLocationAt(int pathStep)
        {
            if (pathStep < _path.Length)
            {
                return double.Parse(_path[pathStep].ToString());
            }
            else
            {
                return 0.0;
            }
        }
    }
}
