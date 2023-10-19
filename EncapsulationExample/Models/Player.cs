using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample.Models
{
    internal class Player
    {
        int _sutGucu;
        public int SutGucu { get { return _sutGucu; } 
            set 
            { 
                if (value > 0 && value<=30)
                    _sutGucu = value;
                else
                {
                    Random rnd = new Random();
                    _sutGucu = rnd.Next(1, 30);
                }
            } 
        }
        public Player(int SutGucu)
        {
            this.SutGucu = SutGucu; 
        }
    }
}
