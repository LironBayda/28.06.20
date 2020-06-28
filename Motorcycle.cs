using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._6._20
{
    class Motorcycle : Vehice
    {

        const int MAX_NUM_SPEED = 200;
        const int NUM_OF_PASSENGERS = 5;

       public int _numberOfHandBreakes;

        public override int GetMaxNumOfPassengers()
        {
            return NUM_OF_PASSENGERS;
        }

        public override int GetMaxNumspeed()
        {
            return MAX_NUM_SPEED;
        }

        override public string ToString()
        {
            return base.ToString() + $" number Of Hand Breakes= {_numberOfHandBreakes}";


        }
    }
}
