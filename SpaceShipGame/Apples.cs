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

            xS = rnd.Next(5, 80);
            yS = rnd.Next(3, 45);

            dis.Display(xS, yS, Apple);


            if (dis.X == xS || dis.Y == yS) 
            {
                dis.SnakesLegnth.Add(Apple);
            }



                




        }
    }
}
