using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    // 1. Create class, that is inherits from the class "Shape".
    class Rectangle:Shape
    {

        // 2. Properties that returns the area and perimeter.
            // Area.
        public override double Area
        {
            get { return Length * Width; }
        }

            // Perimeter.
        public override double Perimeter
        {
            get { return (2 * Length) + (2 * Width); }
        }


        // Method that calls the base class, in this case, "Shape".
        public Rectangle(double length, double width):base(length, width)
        {

        }
    }
}
