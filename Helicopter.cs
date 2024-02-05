using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Practice___Inheritance_JuanHernandez
{
    internal class Helicopter : Air
    {
        // Fields
        int _numberOfPropellers;
        // Constructor
        public Helicopter(string color, int numberofpropellers) : base(color)
        {
            _numberOfPropellers = numberofpropellers;
        }
        // Override ToString
        public override string ToString()
        {
            return base.ToString() + $" - Number of Propellers {_numberOfPropellers}";
        }
    }
}
