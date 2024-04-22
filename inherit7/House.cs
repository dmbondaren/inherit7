using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit7
{
    internal class House : Room
    {
        public int NumberOfFloors { get; set; }

        public House(double area, double price, int numberOfFloors) : base(area, price)
        {
            NumberOfFloors = numberOfFloors;
        }

        public override void Repair()
        {
            Price *= 1.4; // Increase price by 40%
        }
    }
}
