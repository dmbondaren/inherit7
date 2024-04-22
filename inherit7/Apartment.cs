using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit7
{
    internal class Apartment : Room
    {
        public int Floor { get; set; }

        public Apartment(double area, double price, int floor) : base(area, price)
        {
            Floor = floor;
        }

        public override void Repair()
        {
            if (Floor == 5 || Floor == 9)
            {
                Price *= 1.3; // Increase price by 30% if floor is 5 or 9
            }
            else
            {
                Price *= 1.2; // Increase price by 20%
            }
        }
    }
}
