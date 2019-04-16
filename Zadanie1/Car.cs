using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Car : ISpeed
    {
        static int ID = 1;
        private int speed;
        private String name = "Car";

        public Car()
        {
            this.name = name + " " + ID.ToString();
            ID++;
            speed = 0;
        }


        public void decreaseSpeed(int val)
        {
            if (speed > 0)
            {
                speed -= val;
            }
        }

        public int getSpeed()
        {
            return speed;
        }

        public void increaseSpeed(int val)
        {
            speed += val;
        }


        public override string ToString()
        {
            return name;
        }


    }
}
