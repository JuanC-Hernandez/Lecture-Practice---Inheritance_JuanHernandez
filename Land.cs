using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Practice___Inheritance_JuanHernandez
{
    internal class Land : Vehicle
    {
        // Fields
        int _wheels;
        
        // Constructor 
        public Land(string color, int wheels) : base(color)
        {
            _wheels = wheels;
        }
        // Overide ToString
        public override string ToString()
        {
            return base.ToString() + $" - Number of Wheels {_wheels}";
        }
    }
}
