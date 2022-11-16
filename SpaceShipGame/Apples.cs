using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShipGame
{


    class Apples
    {
        public string Apple = "+";
        public int xS;
        public int yS;


        public void Spawn()
        {
            var rnd = new Random();
            var dis = new Snake();
            var util = new Utils();

            xS = rnd.Next();
            yS = rnd.Next();

            util.Display(xS, yS, Apple);


            if (dis.X == xS || dis.Y == yS) 
            {
                dis.Count++;
            }

        }
    }
}
