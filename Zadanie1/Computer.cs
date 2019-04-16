using System;

namespace Zadanie1
{
    class Computer
    {
        static int ID = 1;
        private String name = "Computer";

        public Computer()
        {
            this.name = name + " " + ID.ToString();
            ID++;
        }

        public override string ToString()
        {
            return name;
        }

    }
}