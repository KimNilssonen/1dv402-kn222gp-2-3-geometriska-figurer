using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{

    // 1. Create class.
    abstract class Shape
    {

        // 2. Declare variables.
        private double _length;
        private double _width;

        // 3. Properties.
        public abstract double Area
        {
            // Get, returns a value to the private variable.
            get;
        }

        public double Length
        {
            get { return _length; }

            // Set, sets a value to a variable.
            set {
                    if (value < 0)
                    {
                        throw new ArgumentException(); 
                    }

                    _length = value;
                }
        }

        public abstract double Perimeter
        {
            get;
        } 

        public double Width
        {
            get { return _width; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _width = value;
            }
        }

        // 4. Methods
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString()
        {
            return String.Format("Lenth     : {0, 10:f2}\nWidth     : {1, 10:f2}\nPerimiter : {2, 10:f2}\nArea      : {3, 10:f2}", Length, Width, Perimeter, Area);
        }

    }

    // Used to replace the integer in "switch-cases". Using enums makes the code more self documentary.
    enum ShapeType
    {
        Ellipse,
        Rectangle
    }
}
