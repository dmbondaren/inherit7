using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit7
{
    internal class Room
    {
        public double Area { get; set; }
        public double Price { get; set; }

        public Room(double area, double price)
        {
            Area = area;
            Price = price;
        }

        // Make the Repair method virtual
        public virtual void Repair()
        {
            // Default repair method, can be overridden in derived classes
        }

    }
}
