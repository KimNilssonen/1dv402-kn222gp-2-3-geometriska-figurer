using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{

    // 1. Create class, that is inherits from the class "Shape".
    class Ellipse:Shape
    {

        // 2. Properties that returns the area and perimeter...
            // Area.
        public override double Area
        {
            get { return (Math.PI*(Length/2)*(Width/2)); }
        }

            // Perimeter.
        public override double Perimeter
        {
            get { return (Math.PI * Math.Sqrt(2 * (Length / 2) * (Length / 2) + 2 * (Width / 2) * (Width / 2))); }
        }
        

        // Method that calls the base class, in this case, "Shape".
        public Ellipse(double length, double width):base(length, width)
        {
            
        }

    }
}
