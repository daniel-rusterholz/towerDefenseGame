using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towerDefenseGame
{
    class towerDefenseGameException : System.Exception
    {
        public towerDefenseGameException()
        {
        }

        public towerDefenseGameException(string message) : base(message)
        {
        }
    }

    class OutOfBoundsException : towerDefenseGameException
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {
            
        }
    }
}
