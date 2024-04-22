using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit7
{
    internal class NonResidentialBuilding : Room
    {
        public double Height { get; set; }

        public NonResidentialBuilding(double area, double price, double height) : base(area, price)
        {
            Height = height;
        }

        public override void Repair()
        {
            Price = 2 * (Price / Area); // Calculate price using the formula
        }
    }
}
