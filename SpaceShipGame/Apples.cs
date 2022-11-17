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
        public int xS { get; set; }
        public int yS { get; set; }


        public void Spawn()
        {
            var rnd = new Random();
            var dis = new Snake();
            var util = new Utils();

            xS = rnd.Next(10,120);
            yS = rnd.Next(5,35);

            util.Display(xS, yS, Apple);


            if (dis.X == xS || dis.Y == yS) 
            {
                dis.Count++;
            }

        }
    }
}
