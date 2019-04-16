using System;

namespace Zadanie1
{
    internal class Submarine : IDive, ISpeed
    {
        static int ID = 1;
        private String name = "Submarine";
        private int speed;
        private int depth;

        public Submarine()
        {
            this.name = name + " " + ID.ToString();
            ID++;
            speed = 0;
            depth = 0;
        }

        public void decreaseDepth(int val)
        {
            if (depth > 0)
            {
                depth -= val;
            }
        }

        public void decreaseSpeed(int val)
        {
            if (speed > 0)
            {
                speed -= val;
            }
        }

        public int getDepth()
        {
            return depth;
        }

        public int getSpeed()
        {
            return speed;
        }

        public void increaseDepth(int val)
        {
            depth += val;
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