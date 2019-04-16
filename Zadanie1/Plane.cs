using System;

namespace Zadanie1
{
    internal class Plane : IRise, ISpeed
    {

        static int ID = 1;
        private String name = "Plane";
        private int speed;
        private int height;

        public Plane()
        {
            speed = 0;
            height = 0;
            this.name = name + " " + ID.ToString();
            ID++;
        }

        public void decreaseHight(int val)
        {
            if (height > 0)
            {
                height -= val;
            }
        }

        public void decreaseSpeed(int val)
        {
            if (speed > 0)
            {
                speed -= val;
            }
        }

        public int getHight()
        {
            return height;
        }

        public int getSpeed()
        {
            return speed;
        }

        public void increaseHight(int val)
        {
            height += val;
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